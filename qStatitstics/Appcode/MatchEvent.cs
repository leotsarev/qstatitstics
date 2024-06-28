namespace QStatitstics.Appcode;

public class MatchEvent
{
    #region EventType enum

    public enum EventType
    {
        Min = 1,
        Goal = 1,
        Disqual = 2,
        Foul = 3,
        TFoul = 4,
        Snitch = 5,
        Timeout = 6,
        Max = 7
    }

    #endregion

    public readonly EventType etype;
    private readonly Match MatchData;

    private readonly TeamPlayer Player1;
    public readonly TimeSpan time;

    public MatchEvent(Match match, TimeSpan time, EventType et, TeamPlayer player1)
    {
        if (match == null)
        {
            throw new NullReferenceException();
        }
        MatchData = match;
        etype = et;
        this.time = time;
        if (player1 == null)
            throw new EventMalformedException("������ ����� �� ������");

        Player1 = player1;

        MatchData.WriteEvent(this.time, etype, player1);
    }

    public string EventTime
    {
        get { return Utility.FormatTimeSpan(time); }
    }

    public string Name
    {
        get { return GetEventTypeName(etype); }
    }

    public string Player1Name
    {
        get
        {
            if (etype == EventType.Timeout)
                return Player1.m_Team.Name;
            return Player1.Name;
        }
    }

    public static string GetEventTypeName(EventType et)
    {
        switch (et)
        {
            case EventType.Goal:
                return "G � ���";
            case EventType.Disqual:
                return "D � ��������";
            case EventType.Foul:
                return "F � ���";
            case EventType.TFoul:
                return "T � ��. ���";
            case EventType.Snitch:
                return "Q � �����";
            case EventType.Timeout:
                return "A � �������";
        }
        throw new ArgumentOutOfRangeException("etype", et, "����������� ��� �������");
    }

    public static void FillListBox(ListBox lb)
    {
        if (lb != null)
        {
            for (EventType et = EventType.Min; et < EventType.Max; et++)
            {
                lb.Items.Add(new EventTypeItem(et));
            }
        }
    }
}