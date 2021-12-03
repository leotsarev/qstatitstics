using System.Drawing;
using System.Windows.Forms;
using QStatitstics.Appcode;

namespace QStatitstics
{
    public partial class ViewMatchStatusForm : Form
    {
        private readonly Match match;
        private readonly bool reverse;

        public ViewMatchStatusForm(Match matchData, bool reverse)
        {
            InitializeComponent();
            match = matchData;
            this.reverse = reverse;
        }

        public void UpdateInfo()
        {
            HomeScoreLabel.Text = match.HomeTeam.Score.ToString();
            VisitorsScoreLabel.Text = match.VisitorsTeam.Score.ToString();
            var prow = match.GetLastEvent();
            if (prow == null)
                return;

            var et = (MatchEvent.EventType)prow.EventType;

            var homePlayer = match.HomeTeam.FindPlayerById((int) prow.FirstPlayer);
            var visPlayer = match.VisitorsTeam.FindPlayerById((int) prow.FirstPlayer);
            var player = homePlayer ?? visPlayer;
            var eventName = GetEventName(et, player);

            StatusLabel.TextAlign = ContentAlignment.BottomCenter;
            if (player is not null)
            {
                StatusLabel.Text = $"{player.Number} {eventName}";
                StatusLabel.Visible = true;
            }
            else if (eventName is not null)
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
                MatchEvent.EventType.Goal => "ÃÎË",
                MatchEvent.EventType.Snitch => "Ñíèò÷ ïîéìàí",
                MatchEvent.EventType.Foul or MatchEvent.EventType.TFoul or MatchEvent.EventType.Disqual => "Ôîëû: " + player.Fouls,
                MatchEvent.EventType.Timeout => "ÒÀÉÌÀÓÒ",
                _ => null,
            };
        }

        private void ViewMatchStatusForm_Resize(object sender, System.EventArgs e)
        {
            var height = (int)(this.Size.Height * 0.7);
            var width = (int)(this.Size.Width * 0.4);

            HomeScoreLabel.Size=  VisitorsScoreLabel.Size = new Size(width, height);
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
    }
}