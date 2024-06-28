namespace QStatitstics.Appcode;

internal class Utility
{
    private Utility()
    {
    }

    public static string FormatTimeSpan(long ticks)
    {
        return FormatTimeSpan(new TimeSpan(ticks));
    }

    public static string FormatTimeSpan(TimeSpan time)
    {
        return time.Hours == 0 ? String.Format("{0:D2}:{1:D2}", time.Minutes, time.Seconds) : String.Format("{0:D1}:{1:D2}:{2:D2}", time.Hours, time.Minutes, time.Seconds);
    }

    public static string FormatTimeSpanForTextBox(TimeSpan span)
    {
        return String.Format("{0:D1}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
    }
}