using QStatitstics.Appcode;

namespace QStatitstics;

public partial class ViewMatchStatusForm : Form
{
    private readonly Match match;
    private readonly bool reverse;
    private readonly System.Windows.Forms.Timer timer;

    public ViewMatchStatusForm(Match matchData, bool reverse, bool showTimer)
    {
        InitializeComponent();
        match = matchData;
        this.reverse = reverse;

        if (showTimer)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
    }

    private void Timer_Tick(object sender, System.EventArgs e)
    {
        TimerLabel.Text = Utility.FormatTimeSpan(match.MatchTime);
    }

    public void UpdateInfo()
    {
        HomeScoreLabel.Text = match.HomeTeam.Score.ToString("000");
        VisitorsScoreLabel.Text = match.VisitorsTeam.Score.ToString("000");
        if (!match.Started)
        {
            StatusLabel.Text = "Ìàò÷ íå íà÷àëñÿ";
            return;
        }
        var prow = match.GetLastEvent();
        if (prow == null)
        {
            StatusLabel.Text = "";
            return;
        }

        var et = (MatchEvent.EventType)prow.EventType;

        var homePlayer = match.HomeTeam.FindPlayerById((int)prow.FirstPlayer);
        var visPlayer = match.VisitorsTeam.FindPlayerById((int)prow.FirstPlayer);
        var player = homePlayer ?? visPlayer;
        var eventName = GetEventName(et, player);

        StatusLabel.TextAlign = ContentAlignment.BottomCenter;
        if (eventName is not null)
        {
            StatusLabel.Text = eventName;
            StatusLabel.Visible = true;
        }
        else
        {
            StatusLabel.Visible = false;
        }
    }

    private static string GetEventName(MatchEvent.EventType et, TeamPlayer player)
    {
        return et switch
        {
            MatchEvent.EventType.Goal => $"ÃÎË {player.Number} {player.Name} ({player.GetGoals()})",
            MatchEvent.EventType.Snitch => $"Ñíèò÷ ïîéìàí — {player.Number} {player.Name}",
            MatchEvent.EventType.Foul or MatchEvent.EventType.TFoul or MatchEvent.EventType.Disqual => "Ôîëû: " + player.Fouls,
            MatchEvent.EventType.Timeout => "ÒÀÉÌÀÓÒ",
            _ => null,
        };
    }

    private void ViewMatchStatusForm_Resize(object sender, System.EventArgs e)
    {
        var height = (int)(this.Size.Height * 0.7);
        var width = (int)(this.Size.Width * 0.5);

        HomeScoreLabel.Size = VisitorsScoreLabel.Size = new Size(width, height);
        if (reverse)
        {
            HomeScoreLabel.Location = new Point(ClientSize.Width - width - 20, 0);
            VisitorsScoreLabel.Location = new Point(0, 0);
        }
        else
        {
            VisitorsScoreLabel.Location = new Point(ClientSize.Width - width - 20, 0);
            HomeScoreLabel.Location = new Point(0, 0);
        }

        StatusLabel.Size = new Size(this.Size.Width - 20, (int)(this.Size.Height * 0.2));

    }

    private void ViewMatchStatusForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        timer.Dispose();
    }
}