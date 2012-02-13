using System.Data;
using System.Data.SQLite;
using QStatitstics.Appcode;

namespace QStatitstics.Reports
{
    class BestChasersReport : ReportGenerator
    {
        private const string Blockshots = "Blockshots";
        private const string Goals = "Goals";
        private const string Parried = "Parried";
        private const string Zone = "Zone";


        protected override void WriteReport()
        {
            WriteHtmlHeader("Охотники/Вратари");
            WriteChasersTable();
            WriteHtmlFooter();
        }

        private void WriteChasersTable()
        {
            BeginTable();
            BeginRow();
            WriteHeaderCell("№");
            WriteHeaderCell("Игрок");
            WriteHeaderCell("Команда");
            WriteHeaderCell("Голы");
            EndRow();
            foreach (DataRow row in GetDataTable().Rows)
            {
                BeginRow();
                WriteCellInt((int)row[Number]);
                WriteCell((string)row[Nickname]);
                WriteCell((string)row[TeamName]);
                WriteCellInt((int)row[Goals]);
            }
            EndTable();
        }

        private DataTable GetDataTable()
        {
            var table = new DataTable();
            table.Columns.Add(Nickname, typeof(string));
            table.Columns.Add(Number, typeof(int));
            table.Columns.Add(TeamName, typeof(string));
            table.Columns.Add(Goals, typeof(int));
            table.Columns.Add(Parried, typeof(int));
            table.Columns.Add(Zone, typeof(int));
            table.Columns.Add(Blockshots, typeof(int));
            using (SQLiteCommand cmd = CreateCommand(
                string.Format(
                    "SELECT Nickname, Number, Teams.Name as TeamName, " +
                    "(SELECT COUNT (*) FROM Performance WHERE FirstPlayer = PlayerId AND EventType = " +
                    (int)MatchEvent.EventType.Goal + ") AS Goals " +
                    "FROM Players " +
                    "INNER JOIN Teams ON Players.Team = Teams.TeamId " +
                    "WHERE Goals <> 0 ORDER BY Goals DESC")))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = table.NewRow();
                        row[Nickname] = reader[0];
                        row[Number] = reader[1];
                        row[TeamName] = reader[2];
                        row[Goals] = reader[3];
                        table.Rows.Add(row);
                    }
                }
            }
            return table;
        }

        public override string GetFormHeader()
        {
            return "Охотники/Вратари";
        }
    }
}
