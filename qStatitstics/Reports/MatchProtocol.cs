using QStatitstics.Appcode;

namespace QStatitstics.Reports
{
    class MatchProtocol : ReportGenerator
    {
        public MatchProtocol(Match _match)
        {
            match = _match;
        }

        private const int COL_SPAN = 1;
        private readonly Match match;

        protected override void WriteReport()
        {
            WriteHtmlHeader(match.MatchTitle);
            WriteHeader2(string.Format("{0} — {1}", match.HomeTeam.Score,
                                       match.VisitorsTeam.Score));
            WriteHeader2("Статистика по игрокам");
            BeginTable();
            WriteCommandStats(match.HomeTeam);
            WriteHeaderRow(EmptyCell);
            WriteCommandStats(match.VisitorsTeam);
            EndTable();
            WriteHeader2("Поминутный протокол");

            WriteMinuteProtocol();

            WriteHtmlFooter();
        }

        public override string GetFormHeader()
        {
            return "Отчет о матче " + match.MatchTitle;
        }


        private void WriteMinuteProtocol()
        {
            BeginTable();
            BeginRow();
            WriteHeaderCell("Время");
            WriteHeaderCell("Событие");
            WriteHeaderCell("Игрок");
            EndRow();
            foreach (DataSet1.PerformanceRow row in match.data.Performance.Rows)
            {
                BeginRow();
                WriteCell(Utility.FormatTimeSpan(row.Time));
                WriteCell(MatchEvent.GetEventTypeName((MatchEvent.EventType)row.EventType));
                WriteCell(match.GetPlayerNameById((int)row.FirstPlayer));
                EndRow();
            }
            EndTable();
        }


        private void WriteCommandStats(Team team)
        {
            WriteHeaderRow(team.Name);
            WriteChaserStats(team);
            WriteBeaterStats(team);
            WriteSeekerStats(team);
        }


        private void WriteStdHeaderCells()
        {
            WriteHeaderCell("№");
            WriteHeaderCell("Имя");
        }

        private void WriteStdCells(TeamPlayer player)
        {
            WriteCellInt(player.Number);
            WriteCell(player.Name);
        }

        private void WriteSeekerStats(Team team)
        {
            WriteHeaderRow("Ловцы");
            BeginRow();
            WriteStdHeaderCells();
            WriteHeaderCell("", COL_SPAN);
            WriteHeaderCell("Фолы");
            EndRow();
            foreach (var player in team.Roster)
            {
                if (player.PlayerPosition != TeamPlayer.Position.Seeker) continue;
                BeginRow();
                WriteStdCells(player);
                if (match.GetPlayersSnitchesCount(player.ID) == 0)
                {
                    WriteCell("", COL_SPAN);
                }
                else
                {
                    WriteCell("СНИТЧ!", COL_SPAN);
                }
                WriteCell(player.Fouls);
                EndRow();
            }
        }

        private void WriteBeaterStats(Team team)
        {
            WriteHeaderRow("Загонщики");
            BeginRow();
            WriteStdHeaderCells();
            WriteHeaderCell("", COL_SPAN);
            WriteHeaderCell("Фолы");
            EndRow();
            foreach (var player in team.Roster)
            {
                if (player.IsPositionType(TeamPlayer.Position.Beater))
                {
                    WriteBeaterData(player);
                }
            }
        }


        private void WriteBeaterData(TeamPlayer player)
        {
            BeginRow();
            WriteStdCells(player);
            WriteCell("", COL_SPAN);
            WriteCell(player.Fouls);
            EndRow();
        }

        private void WriteChaserStats(Team team)
        {
            WriteHeaderRow("Охотники");
            BeginRow();
            WriteStdHeaderCells();
            WriteHeaderCell("Голы");
            WriteHeaderCell("Фолы");
            EndRow();
            foreach (var player in team.Roster)
            {
                if (player.IsPositionType(TeamPlayer.Position.Chaser))
                {
                    WriteChaserData(player);
                }
            }
        }

        private void WriteHeaderRow(string header)
        {
            BeginRow();
            WriteHeaderCell(header, 3 + COL_SPAN);
            EndRow();
        }

        private void WriteChaserData(TeamPlayer player)
        {
            BeginRow();
            WriteStdCells(player);
            WriteCell(player.Goals);
            WriteCell(player.Fouls);
            EndRow();
        }
    }
}
