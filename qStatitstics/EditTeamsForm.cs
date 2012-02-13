using System;
using System.Data;
using System.Windows.Forms;
using QStatitstics.Appcode;
using QStatitstics.Appcode.DataSet1TableAdapters;

namespace QStatitstics
{
    public partial class EditTeamsForm : Form
    {
        public EditTeamsForm()
        {
            InitializeComponent();
        }

        private void EditTeamsForm_Load(object sender, EventArgs e)
        {
            teamsTableAdapter.Fill(Data.Teams);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            teamsTableAdapter.Update(Data.Teams);
        }

        private void TeamsGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var rowView = (DataRowView) TeamsGrid.Rows[e.RowIndex].DataBoundItem;
            if (rowView != null)
            {
                var row = (DataSet1.TeamsRow) rowView.Row;
                if (row != null)
                {
                    if (string.IsNullOrEmpty(row.City))
                    {
                        MessageBox.Show("Введите город!");
                        e.Cancel = true;
                    }
                    else if (string.IsNullOrEmpty(row.Name))
                    {
                        MessageBox.Show("Введите название команды!");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void TeamsGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var rowView = (DataRowView) e.Row.DataBoundItem;
            var row = (DataSet1.TeamsRow) rowView.Row;
            var playersTableAdapter = new PlayersTableAdapter();
            if (CheckDependItems(playersTableAdapter.GetDataByTeam(row.TeamId),
                                 "У команды есть игроки. Удалить всех игроков из базы?", row.Name))
            {
                e.Cancel = true;
                return;
            }
            var matchesTableAdapter = new MatchesTableAdapter();
            DataSet1.MatchesDataTable teamMatches = matchesTableAdapter.GetDataByTeam(row.TeamId);
            if (CheckDependItems(teamMatches, "Есть записи о матчах. Удалить все записи?", row.Name))
            {
                e.Cancel = true;
                return;
            }
            playersTableAdapter.DeletePlayersForTeam(row.TeamId);
            var performanceTableAdapter = new PerformanceTableAdapter();
            foreach (DataSet1.MatchesRow matchRow in teamMatches.Rows)
            {
                matchesTableAdapter.DeleteMatch(matchRow.MatchId);
                performanceTableAdapter.DeleteMatchData(matchRow.MatchId);
            }
        }

        private static bool CheckDependItems(DataTable table, string askMessage, string askCaption)
        {
            return table.Rows.Count > 0 &&
                   MessageBox.Show(askMessage, askCaption, MessageBoxButtons.OKCancel) == DialogResult.Cancel;
        }
    }
}