using System.Data;
using System.Data.SQLite;
using QStatitstics.Appcode;

namespace QStatitstics;

public partial class EditPlayersForm : Form
{
    public EditPlayersForm()
    {
        InitializeComponent();
    }

    private void EditPlayersForm_Load(object sender, EventArgs e)
    {
        teamsTableAdapter.Fill(dataSet1.Teams);
        playersTableAdapter.Fill(dataSet1.Players);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        try
        {
            playersTableAdapter.Update(dataSet1.Players);
        }
        catch (SQLiteException)
        {
            MessageBox.Show("Сохранение не удалось. Возможно, у некоторых игроков не уникальные номера.");
            DialogResult = DialogResult.None;
        }
    }

    private void ByTeamsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        FilterDropDown.Enabled = ByTeamsCheckBox.Checked;
        LoadPlayers.Enabled = ByTeamsCheckBox.Checked;
        ApplyFilter();
    }

    private void ApplyFilter()
    {
        if (FilterDropDown.Enabled)
        {
            playersBindingSource.Filter = "Team = " + FilterDropDown.SelectedValue;
        }
        else
        {
            playersBindingSource.Filter = "";
        }
    }

    private void FilterDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilter();
    }

    private void LoadPlayers_Click(object sender, EventArgs e)
    {
        if (CsvFileDialog.ShowDialog() == DialogResult.OK)
        {
            var load = new ProcessCSV();
            load.FileName = CsvFileDialog.FileName;
            load.Players = dataSet1.Players;
            load.DeleteBefore = MessageBox.Show(
                                    "Удалить всех игроков, которых нет в новой заявке?",
                                    "Загрузка заявки",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes;
            load.TeamId = (long) FilterDropDown.SelectedValue;
            load.Apply();
        }
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void PlayersGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
    {
        var rowView = (DataRowView) PlayersGrid.Rows[e.RowIndex].DataBoundItem;
        if (rowView != null)
        {
            var row = (DataSet1.PlayersRow) rowView.Row;
            if (row != null)
            {
                if (string.IsNullOrEmpty(row.Name))
                {
                    MessageBox.Show("Введите имя!");
                    e.Cancel = true;
                }
                else if (string.IsNullOrEmpty(row.Nickname))
                {
                    MessageBox.Show("Введите ник!");
                    e.Cancel = true;
                }
                else if (row.Team == 0)
                {
                    MessageBox.Show("Выберите команду!");
                    e.Cancel = true;
                }
                else if (row.Number < 1 || row.Number > 99)
                {
                    MessageBox.Show("Введите номер от 1 до 99");
                }
            }
        }
    }

    private void PlayersGrid_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
    {
        e.Row.Cells["Team"].Value = (FilterDropDown.Enabled)
                                        ? (long) FilterDropDown.SelectedValue
                                        : dataSet1.Teams.Rows[0]["TeamId"];
        e.Row.Cells["Sex"].Value = false;
        e.Row.Cells["Seeker"].Value = false;
    }
}