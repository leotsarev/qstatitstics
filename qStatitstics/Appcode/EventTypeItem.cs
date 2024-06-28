namespace QStatitstics.Appcode;

public class EventTypeItem
{
    public readonly MatchEvent.EventType ET;

    public EventTypeItem(MatchEvent.EventType et)
    {
        ET = et;
    }

    public string Name
    {
        get { return MatchEvent.GetEventTypeName(ET); }
    }

    public override string ToString()
    {
        return Name;
    }
}