using System.Windows.Forms;
using QStatitstics.Appcode;

namespace QStatitstics
{
    public partial class ViewMatchStatusForm : Form
    {
        private readonly Match match;

        public ViewMatchStatusForm(Match matchData)
        {
            InitializeComponent();
            match = matchData;
        }

        public void UpdateInfo()
        {
            HomeScoreLabel.Text = match.HomeTeam.Score.ToString();
            VisitorsScoreLabel.Text = match.VisitorsTeam.Score.ToString();
            var prow = match.GetLastEvent();
            if (prow == null)
                return;
            var homePlayer = match.HomeTeam.FindPlayerById((int) prow.FirstPlayer);
            var visPlayer = match.VisitorsTeam.FindPlayerById((int) prow.FirstPlayer);
            HomeEventLabel.Visible = homePlayer != null;
            VisitorsEventLabel.Visible = visPlayer != null;
            StatusLabel.Visible = homePlayer != null || visPlayer != null;
            if (homePlayer != null)
            {
                DisplayEvent(homePlayer, prow, HomeEventLabel);
            }
            else if (visPlayer != null)
            {
                DisplayEvent(visPlayer, prow, VisitorsEventLabel);
            }
        }

        private void DisplayEvent(TeamPlayer homePlayer, DataSet1.PerformanceRow prow, Control label)
        {
            var et = (MatchEvent.EventType) prow.EventType;
            switch (et)
            {
                case MatchEvent.EventType.Goal:

                    label.Text = "ÃÎË";
                    break;
                case MatchEvent.EventType.Snitch:
                    label.Text = "Ñíèò÷!!";
                    break;
                case MatchEvent.EventType.Foul:
                case MatchEvent.EventType.TFoul:
                case MatchEvent.EventType.Disqual:
                    label.Text = homePlayer.Fouls;
                    break;
                default:
                    label.Visible = false;
                    break;
            }

            StatusLabel.Text = string.Format("{0} {1}", homePlayer.Number, homePlayer.Name);
        }

        private void HomeEventLabel_Click(object sender, System.EventArgs e)
        {

        }
    }
}