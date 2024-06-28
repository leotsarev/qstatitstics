using System.Collections.Generic;
using System.Windows.Forms;
using QStatitstics.Appcode.DataSet1TableAdapters;

namespace QStatitstics.Appcode;

public class Team
{
    public const int GoalValue = 10;
    public const int PlayersCount = 7;
    public const int SnitchValue = 50;
    private readonly int _TeamID;
    private readonly DataSet1 data = new DataSet1();
    public Match match;
    public List<TeamPlayer> Roster = new List<TeamPlayer>();

    public Team(int teamID)
    {
        _TeamID = teamID;
        var teamsAdapter = new TeamsTableAdapter();
        teamsAdapter.Fill(data.Teams);
        var playersAdapter = new PlayersTableAdapter();
        playersAdapter.FillByTeam(data.Players, teamID);
        if (data.Players.Rows.Count < PlayersCount)
        {
            throw new NotEnoughPlayersException(Name);
        }
        foreach (DataSet1.PlayersRow row in data.Players)
        {
            var player = new TeamPlayer(this, (int) row.PlayerId);
            Roster.Add(player);
        }
    }

    public int TeamID
    {
        get { return _TeamID; }
    }

    public string Name
    {
        get { return data.Teams.FindByTeamId(TeamID).Name; }
    }

    public int Score
    {
        get
        {
            var score = 0;
            foreach (var player in Roster)
            {
                score += match.GetPlayerGoalsCount(player.ID)*GoalValue;
                score += match.GetPlayersSnitchesCount(player.ID)*SnitchValue;
            }

            return score;
        }
    }

    public void FillListBox(ListBox lb)
    {
        foreach (var player in Roster)
        {
            lb.Items.Add(player);
        }
    }

    public DataSet1.PlayersRow GetPlayer(int ID)
    {
        return data.Players.FindByPlayerId(ID);
    }

    public TeamPlayer FindPlayerByNum(int num)
    {
        foreach (var player in Roster)
        {
            if (player.Number == num)
                return player;
        }
        return null;
    }

    public TeamPlayer? FindPlayerById(int id)
    {
        foreach (var player in Roster)
        {
            if (player.ID == id)
                return player;
        }
        return null;
    }

    public void WriteRoster()
    {
        foreach (var player in Roster)
        {
            match.WritePlayerPosition(player);
        }
    }

    public void TrySetPosition(int playerId, TeamPlayer.Position position)
    {
        var homePlayer = FindPlayerById(playerId);
        if (homePlayer != null)
        {
            homePlayer.PlayerPosition = position;
        }
    }
}