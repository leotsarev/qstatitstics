using System.Data;
using System.Data.SQLite;
using QStatitstics.Appcode;

namespace QStatitstics.Reports;

class BestSeekersReport : ReportGenerator
{
    private const string Snitches = "Snitches";

    protected override void WriteReport()
    {
        WriteHtmlHeader("Лучшие ловцы");
        WriteSeekersTable();
        WriteHtmlFooter();
    }

    private void WriteSeekersTable()
    {
        BeginTable();
        BeginRow();
        WriteHeaderCell("№");
        WriteHeaderCell("Игрок");
        WriteHeaderCell("Команда");
        WriteHeaderCell("Снитчи");
        EndRow();
        foreach (DataRow row in GetBestSeekersTable().Rows)
        {
            BeginRow();
            WriteCellInt((int)row[Number]);
            WriteCell((string)row[Nickname]);
            WriteCell((string)row[TeamName]);
            WriteCellInt((int)row[Snitches]);
        }
        EndTable();
    }


    private DataTable GetBestSeekersTable()
    {
        var table = new DataTable();
        table.Columns.Add(Nickname, typeof(string));
        table.Columns.Add(Number, typeof(int));
        table.Columns.Add(TeamName, typeof(string));
        table.Columns.Add(Snitches, typeof(int));
        using (
            SQLiteCommand cmd =
                CreateCommand(
                    "SELECT Nickname, Number, Teams.Name as TeamName, COUNT(EventId) AS Snitches FROM Players INNER JOIN Teams ON Players.Team = Teams.TeamId LEFT JOIN Performance ON Performance.FirstPlayer = Players.PlayerId WHERE Performance.EventType = " +
                    (int)MatchEvent.EventType.Snitch + " GROUP BY PlayerId "))
        {
            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row[Nickname] = reader[0];
                row[Number] = reader[1];
                row[TeamName] = reader[2];
                row[Snitches] = reader[3];
                table.Rows.Add(row);
            }
        }
        return table;
    }

    public override string GetFormHeader()
    {
        return "Лучшие ловцы";
    }
}
