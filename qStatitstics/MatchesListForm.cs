using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using QStatitstics.Appcode;
using QStatitstics.Appcode.DataSet1TableAdapters;
using QStatitstics.Reports;

namespace QStatitstics;

public partial class MatchesListForm : Form
{
    private DataSet1.MatchesDataTable dt;

    public MatchesListForm()
    {
        InitializeComponent();
    }

    private void MatchesListForm_Load(object sender, EventArgs e)
    {
        // TODO: This line of code loads data into the 'dataSet1.Teams' table. You can move, or remove it, as needed.
        teamsTableAdapter.Fill(dataSet1.Teams);

        var mAdapter = new MatchesTableAdapter();

        dt = mAdapter.GetMatchesList();

        MatchesGrid.DataSource = new DataView(dt, "", "", DataViewRowState.OriginalRows);
        MatchesGrid.HideColumn("MatchId");
        MatchesGrid.HideColumn("HomeTeam");
        MatchesGrid.HideColumn("VisitorsTeam");
        MatchesGrid.SetupColumn("HomeTeamName", 0, "Хозяева", 150);
        MatchesGrid.SetupColumn("HomeScore", 1, "Счет", 50);
        MatchesGrid.SetupColumn("VisitorsTeamName", 2, "Гости", 150);
        MatchesGrid.SetupColumn("VisitorsScore", 3, "Счет", 50);
        DeleteButton.Enabled = ViewButton.Enabled = MatchesGrid.Rows.Count > 0;
    }

    private void ByTeamsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        FilterDropDown.Enabled = ByTeamsCheckBox.Checked;
        ApplyFilter();
    }

    private void ApplyFilter()
    {
        if (FilterDropDown.Enabled)
        {
            var filter =
                String.Format("HomeTeam = {0} OR VisitorsTeam = {0}", (long) FilterDropDown.SelectedValue);
            MatchesGrid.DataSource = new DataView(dt, filter, "", DataViewRowState.OriginalRows);
        }
        else
        {
            MatchesGrid.DataSource = new DataView(dt, "", "", DataViewRowState.OriginalRows);
        }
    }

    private void FilterDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilter();
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        if (MatchesGrid.CurrentRow != null &&
            MessageBox.Show("Вы действительно хотите удалить запись о матче?", "Удаление",
                            MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
            var row =
                ((DataRowView) MatchesGrid.CurrentRow.DataBoundItem).Row as DataSet1.MatchesRow;
            if (row != null)
            {
                var mAdapter = new MatchesTableAdapter();
                mAdapter.DeleteMatch(row.MatchId);
                var pAdapter = new PerformanceTableAdapter();
                pAdapter.DeleteMatchData(row.MatchId);
                dt.Rows.Remove(row);
            }
        }
        DeleteButton.Enabled = ViewButton.Enabled = MatchesGrid.Rows.Count > 0;
    }

    private void ViewButton_Click(object sender, EventArgs e)
    {
        if (MatchesGrid.CurrentRow == null) return;

        var row = ((DataRowView) MatchesGrid.CurrentRow.DataBoundItem).Row as DataSet1.MatchesRow;
        if (row == null) return;
        var _match = new Match(row);
        ViewReportForm.ShowMatchProtocol(_match);
    }

    private void btnSaveAll_Click(object sender, EventArgs e)
    {
        chooseFolder.ShowDialog();
        var folder = chooseFolder.SelectedPath;
        foreach (DataGridViewRow gridRow in MatchesGrid.Rows)
        {
            var row = ((DataRowView)gridRow.DataBoundItem).Row as DataSet1.MatchesRow;
            if (row == null) continue;
            var reportGenerator = new MatchProtocol(new Match(row));
            using var sw = new StreamWriter(folder + "\\" + reportGenerator.GetFormHeader() + ".html");
            sw.Write(reportGenerator.GetReportText());
        }
    }
}