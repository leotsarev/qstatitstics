using System;
using System.Data;
using System.Data.SQLite;
using QStatitstics.Appcode.DataSet1TableAdapters;
using QStatitstics.Properties;

namespace QStatitstics.Appcode
{
    public sealed class Match : IDisposable
    {
        private static readonly TimeSpan SnitchStart = new TimeSpan(0, 25, 0);
        private static readonly TimeSpan TimeOutLength = new TimeSpan(0, 1, 0);
        private readonly bool ReadOnly;

        public DataSet1 data;
        private DateTime EndTime = DateTime.MaxValue;
        public Team HomeTeam;
        private DateTime PauseBegin = DateTime.MinValue;
        private DateTime StartTime = DateTime.MinValue;
        private TimeSpan TotalPauseTime = new TimeSpan(0);
        public Team VisitorsTeam;

        public Match(Team homeTeam, Team visitorsTeam)
        {
            HomeTeam = homeTeam;
            VisitorsTeam = visitorsTeam;
            HomeTeam.match = VisitorsTeam.match = this;
            data = new DataSet1();
            HomeTeam.WriteRoster();
            VisitorsTeam.WriteRoster();
            ReadOnly = false;
        }


        public Match(DataSet1.MatchesRow row)
        {
            ReadOnly = true;
            var matchID = (int) row.MatchId;
            data = new DataSet1();
            using (var conn = new SQLiteConnection(Settings.Default.DefaultConnectionString))
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Performance WHERE Match = " + row.MatchId;
                cmd.CommandType = CommandType.Text;
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var perRow = data.Performance.NewPerformanceRow();
                    perRow.EventId = (long)reader["EventId"];
                    perRow.EventType = (long)reader["EventType"];
                    perRow.Time = (long)reader["Time"];
                    perRow.FirstPlayer = (long)reader["FirstPlayer"];
                    perRow.Match = row.MatchId;
                    data.Performance.Rows.Add(perRow);
                }
            }
            //adapter.FillMatchData(data.Performance, row.MatchId);
            var rAdapter = new RosterTableAdapter();
            rAdapter.FillRosterData(data.Roster, matchID);
            HomeTeam = new Team((int) row.HomeTeam);
            VisitorsTeam = new Team((int) row.VisitorsTeam);
            HomeTeam.match = VisitorsTeam.match = this;
            foreach (DataSet1.RosterRow rosterRow in data.Roster.Rows)
            {
                HomeTeam.TrySetPosition(rosterRow.Player, (TeamPlayer.Position) rosterRow.Position);
                VisitorsTeam.TrySetPosition(rosterRow.Player, (TeamPlayer.Position) rosterRow.Position);
            }
            var snitchrows =
                data.Performance.Select(string.Format("EventType = {0}", (int) MatchEvent.EventType.Snitch));
            BeginMatch();
            EndMatch();
            if (snitchrows.Length > 0)
            {
                CorrectTime(new TimeSpan((long) snitchrows[0]["Time"]));
            }
        }


        public TimeSpan MatchTime
        {
            get
            {
                if (StartTime == DateTime.MinValue)
                {
                    return TimeSpan.Zero;
                }
                var now = DateTime.Now;
                if (EndTime != DateTime.MaxValue)
                {
                    now = EndTime;
                }
                else if (PauseBegin != DateTime.MinValue)
                {
                    now = PauseBegin;
                }
                return now - StartTime - TotalPauseTime;
            }
        }

        public TimeSpan TimeOutLeftTime
        {
            get
            {
                if (Paused)
                {
                    var leftTime = TimeOutLength - (DateTime.Now - PauseBegin);
                    if (leftTime > TimeSpan.Zero)
                    {
                        return leftTime;
                    }
                }
                return TimeSpan.Zero;
            }
        }

        public bool Paused
        {
            get { return PauseBegin != DateTime.MinValue; }
        }

        public bool Finished
        {
            get { return EndTime != DateTime.MaxValue; }
        }

        public bool SnitchFlying
        {
            get { return MatchTime > SnitchStart; }
        }

        public string MatchTitle
        {
            get { return HomeTeam.Name + " — " + VisitorsTeam.Name; }
        }

        #region IDisposable Members

        public void Dispose()
        {
            data.Dispose();
        }

        #endregion

        public TeamPlayer FindPlayerById(int playerId)
        {
            return HomeTeam.FindPlayerById(playerId) ?? VisitorsTeam.FindPlayerById(playerId);
        }

        public string GetPlayerNameById(int player)
        {
            return FindPlayerById(player).Name;
        }

        public void SaveData()
        {
            if (ReadOnly)
            {
                throw new ReadOnlyMatchException();
            }

            var MAdapter = new MatchesTableAdapter();
            var mid =
                (int)
                (long) MAdapter.CreateMatch(HomeTeam.TeamID, VisitorsTeam.TeamID, HomeTeam.Score, VisitorsTeam.Score);


            var adapter = new PerformanceTableAdapter();
            foreach (DataSet1.PerformanceRow row in data.Performance.Rows)
            {
                adapter.InsertEvent(mid, row.Time, row.EventType, row.FirstPlayer);
            }

            var rAdapter = new RosterTableAdapter();
            foreach (DataSet1.RosterRow row in data.Roster.Rows)
            {
                rAdapter.Insert(mid, row.Player, row.Position);
            }
        }

        public void WriteEvent(TimeSpan time, MatchEvent.EventType et, TeamPlayer player1)
        {
            data.Performance.AddPerformanceRow(0, time.Ticks, (int) et, player1.ID);
        }

        public void RemoveLastEvent()
        {
            int idx = data.Performance.Rows.Count - 1;
            if (idx < 0)
                return;
            data.Performance.Rows.RemoveAt(idx);
        }

        public DataSet1.PerformanceRow GetLastEvent()
        {
            int idx = data.Performance.Rows.Count - 1;
            return idx < 0 ? null : (DataSet1.PerformanceRow) data.Performance.Rows[idx];
        }

        public void BeginMatch()
        {
            StartTime = DateTime.Now;
        }

        public void BeginPause()
        {
            PauseBegin = DateTime.Now;
        }

        public void EndPause()
        {
            TimeSpan pauseTime = DateTime.Now - PauseBegin;
            PauseBegin = DateTime.MinValue;
            TotalPauseTime += pauseTime;
        }

        public void EndMatch()
        {
            EndTime = DateTime.Now;
        }

        public int GetPlayerGoalsCount(int id)
        {
            return GetPlayerEventsCount(id, MatchEvent.EventType.Goal);
        }

        public int GetPlayerEventsCount(int id, MatchEvent.EventType et)
        {
            string filter = String.Format("FirstPlayer = {0} AND EventType = {1}", id, (int) et);
            return data.Performance.Select(filter).Length;
        }

        public int GetEventsCount(MatchEvent.EventType et)
        {
            string filter = String.Format("EventType = {0}", (int) et);
            return data.Performance.Select(filter).Length;
        }

        public int GetPlayer2EventsCount(int id, MatchEvent.EventType et)
        {
            string filter = String.Format("SecondPlayer = {0} AND EventType = {1}", id, (int) et);
            return data.Performance.Select(filter).Length;
        }

        public bool IsPlayerDisqualed(int id)
        {
            return GetPlayerEventsCount(id, MatchEvent.EventType.Disqual) != 0;
        }

        public int GetPlayerTFoalsCount(int id)
        {
            return GetPlayerEventsCount(id, MatchEvent.EventType.TFoul);
        }

        public int GetPlayerFoalsCount(int id)
        {
            return GetPlayerEventsCount(id, MatchEvent.EventType.Foul);
        }

        public void CorrectTime(TimeSpan timeSpan)
        {
            StartTime += MatchTime;
            StartTime -= timeSpan;
        }

        public int GetPlayersSnitchesCount(int id)
        {
            return GetPlayerEventsCount(id, MatchEvent.EventType.Snitch);
        }

        public void WritePlayerPosition(TeamPlayer player)
        {
            data.Roster.AddRosterRow(0, player.ID, (int) player.PlayerPosition);
        }

        public int GetSkippedGoals(TeamPlayer player)
        {
            return GetPlayer2EventsCount(player.ID, MatchEvent.EventType.Goal);
        }
    }
}