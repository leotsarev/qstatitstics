namespace QStatitstics.Appcode;

public class TeamPlayer : IComparable<TeamPlayer>
{
    #region Position enum

    public enum Position
    {
        None = 0,
        Chaser = 1,
        Beater = 2,
        Keeper = 3,
        Seeker = 4
    }

    #endregion

    public readonly int ID;
    public Team m_Team;
    public Position PlayerPosition = Position.None;

    public TeamPlayer(Team team, int playerId)
    {
        m_Team = team;
        ID = playerId;
    }

    public int Number
    {
        get { return m_Team.GetPlayer(ID).Number; }
    }

    public string Name
    {
        get { return m_Team.GetPlayer(ID).Nickname; }
    }

    public string DispPosition
    {
        get { return GetPositionTypeShortName(PlayerPosition); }
    }

    public string Goals
    {
        get { return GetGoals().ToString(); }
    }


    public string Fouls
    {
        get
        {
            int fouls = m_Team.match.GetPlayerFoalsCount(ID);
            int tfouls = m_Team.match.GetPlayerTFoalsCount(ID);
            if (m_Team.match.IsPlayerDisqualed(ID) || tfouls > 1 || tfouls + fouls > 4)
            {
                return "��������";
            }
            string result = "";
            if (tfouls != 0)
            {
                result = "��";
            }
            if (tfouls != 0 && fouls != 0)
            {
                result += " + ";
            }
            if (fouls != 0)
            {
                result += fouls.ToString();
            }
            return result;
        }
    }

    #region IComparable<TeamPlayer> Members

    public int CompareTo(TeamPlayer other)
    {
        if (other == null)
        {
            return 1;
        }

        if (PlayerPosition > other.PlayerPosition)
        {
            return 1;
        }
        if (PlayerPosition < other.PlayerPosition)
        {
            return -1;
        }

        if (Number > other.Number)
        {
            return 1;
        }
        if (Number < other.Number)
        {
            return -1;
        }
        return 0;
    }

    #endregion

    public override int GetHashCode()
    {
        return ID;
    }

    public override bool Equals(object obj)
    {
        var other = obj as TeamPlayer;
        if (other == null)
            return false;
        return ID == other.ID;
    }

    public static string GetPositionTypeShortName(Position positionType)
    {
        switch (positionType)
        {
            case Position.Chaser:
                return "�";
            case Position.Beater:
                return "�";
            case Position.Keeper:
                return "�";
            case Position.Seeker:
                return "�";
            case Position.None:
                return "";
        }
        throw new ArgumentOutOfRangeException("positionType", positionType, "����������� ������� �� ����");
    }

    public static string GetPositionTypeName(Position positionType)
    {
        switch (positionType)
        {
            case Position.Chaser:
                return "�������";
            case Position.Beater:
                return "��������";
            case Position.Keeper:
                return "�������";
            case Position.Seeker:
                return "�����";
            case Position.None:
                return "";
        }
        throw new ArgumentOutOfRangeException("positionType", positionType, "����������� ������� �� ����");
    }

    public bool IsPositionType(Position positionType)
    {
        return PlayerPosition == positionType;
    }

    public int GetGoals()
    {
        return m_Team.match.GetPlayerGoalsCount(ID);
    }

    public override string ToString()
    {
        return Name;
    }

    public bool IsChaser()
    {
        return PlayerPosition == Position.Chaser;
    }

    public bool IsBeater()
    {
        return PlayerPosition == Position.Beater;
    }

    public bool CanPlaySeeker()
    {
        return m_Team.GetPlayer(ID).Seeker != 0;
    }


    public int GetMissedGoals()
    {
        return m_Team.match.GetPlayer2EventsCount(ID, MatchEvent.EventType.Goal);
    }
}