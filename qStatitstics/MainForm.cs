using System;
using System.Windows.Forms;
using QStatitstics.Appcode;
using QStatitstics.Properties;
using QStatitstics.Reports;

namespace QStatitstics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataSet1.Teams.Rows.Clear();
            var teamsForm = new EditTeamsForm();
            teamsForm.ShowDialog();
            ReloadData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var playersForm = new EditPlayersForm();
            playersForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadData();
            if (!Settings.Default.CanEditPlayers)
            {
                playersToolStripMenuItem.Enabled =
                    manageToolStripMenuItem.Enabled = teamsToolStripMenuItem.Enabled = false;
            }
        }

        private void ReloadData()
        {
            teamsTableAdapter.FillActiveTeams(dataSet1.Teams);
            int teamsCount = dataSet1.Teams.Rows.Count;
            if (teamsCount > 1)
            {
                VisitorsTeamDropDown.SelectedIndex = 1;
                playersToolStripMenuItem.Enabled =
                    VisitorsTeamDropDown.Enabled = HomeTeamDropDown.Enabled = BeginMatchButton.Enabled = true;
            }
            else
            {
                playersToolStripMenuItem.Enabled = (teamsCount == 0);

                VisitorsTeamDropDown.Enabled = HomeTeamDropDown.Enabled = BeginMatchButton.Enabled = false;
            }
        }

        private void BeginMatchButton_Click(object sender, EventArgs e)
        {
            var Home = (int) (long) HomeTeamDropDown.SelectedValue;
            var Visitors = (int) (long) VisitorsTeamDropDown.SelectedValue;
            if (Home == Visitors)
            {
                MessageBox.Show("Команда не может сыграть матч сама с собой!");
                return;
            }

            Team homeTeam;
            Team visitorsTeam;
            try
            {
                homeTeam = new Team(Home);
                visitorsTeam = new Team(Visitors);
            }
            catch (NotEnoughPlayersException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            if (SetupTeam(homeTeam) && SetupTeam(visitorsTeam))
            {
                var match = new Match(homeTeam, visitorsTeam);
                var matchForm = new MatchForm(match);
                matchForm.ShowDialog();
            }
        }

        private static bool SetupTeam(Team homeTeam)
        {
            var chooseHomePlayers = new SetupRosterForm(homeTeam);
            chooseHomePlayers.ShowDialog();
            return (chooseHomePlayers.DialogResult == DialogResult.OK);
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mlf = new MatchesListForm();
            mlf.ShowDialog();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n')
            {
                BeginMatchButton.PerformClick();
            }
        }

        private void playersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewReportForm.ShowBestSeekers();
        }

        private void охотникиВратариToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewReportForm.ShowBestChasers();
        }
    }
}