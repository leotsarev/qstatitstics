using System.Data;
using System.Data.SQLite;
using System.Text;
using QStatitstics.Properties;

namespace QStatitstics.Reports
{
    public abstract class ReportGenerator
    {
        private SQLiteConnection conn;

        protected const string EmptyCell = "&nbsp;";
        protected const string Nickname = "Nickname";
        protected const string Number = "Number";
        protected const string TeamName = "TeamName";


        public string GetReportText()
        {
            builder = new StringBuilder();
            OpenConnection();
            WriteReport();
            conn.Close();
            return builder.ToString();
        }

        protected abstract void WriteReport();

        private void OpenConnection()
        {
            conn = new SQLiteConnection
            {
                ConnectionString = Settings.Default.DefaultConnectionString
            };
            conn.Open();
        }

        protected SQLiteCommand CreateCommand(string sql)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            return cmd;
        }

        private StringBuilder builder;

        protected void AppendLine(string line)
        {
            builder.AppendLine(line);
        }

        protected void Append(string s)
        {
            builder.Append(s);
        }

        protected void WriteHeaderCell(string p, int colSpan)
        {
            if (colSpan < 2)
                builder.AppendLine("<td><strong>");
            else
            {
                builder.AppendFormat("<td colspan='{0}'><strong>", colSpan);
            }
            builder.AppendLine(CheckEmpty(p));
            builder.AppendLine("</strong></td>");
        }

        protected void WriteHeaderCell(string p)
        {
            WriteHeaderCell(p, 1);
        }

        protected void BeginTable()
        {
            builder.AppendLine(
                "<table style=\"border-width: 2px;border-style: solid; border-color: black;\" cellspacing='0' cellpadding='1'>");
        }

        protected void EndTable()
        {
            AppendLine("</table>");
        }

        protected void EndRow()
        {
            AppendLine("</tr>");
        }

        protected void BeginRow()
        {
            AppendLine("<tr>");
        }

        private static string CheckEmpty(string p)
        {
            p = p.Trim();
            return string.IsNullOrEmpty(p) ? EmptyCell : p;
        }

        protected void WriteCellInt(int p)
        {
            WriteCell(p == 0 ? "" : p.ToString());
        }

        protected void WriteCell(string p)
        {
            builder.AppendFormat("<td>{0}</td>", CheckEmpty(p));
        }

        protected void WriteCell(string p, int colSpan)
        {
            builder.AppendFormat("<td colspan='{0}'>{1}</td>", colSpan, CheckEmpty(p));
        }

        protected void WriteAttributeWithValue(string attr, string val)
        {
            builder.Append("<");
            builder.Append(attr);
            builder.Append(">");
            builder.Append(val);
            builder.Append("</");
            builder.Append(attr);
            builder.Append(">");
        }

        protected void WriteHtmlFooter()
        {
            builder.AppendLine("</body>");
            builder.AppendLine("</html>");
        }

        protected void WriteHeader2(string headerText)
        {
            WriteAttributeWithValue("h2",
                                    headerText);
        }

        protected virtual string StyleInfo
        {
            get { return "TD, TH { border-width: 1px; border-style:solid; border-color: black; }"; }
        }

        protected void WriteHtmlHeader(string title)
        {
            builder.AppendLine(
                "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\">");
            builder.AppendLine("<html>");
            builder.AppendLine("<header>");
            builder.AppendLine("<title>");
            builder.AppendLine(title);
            builder.AppendLine("</title>");
            builder.AppendLine("<META http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">");
            builder.AppendLine("<style>");
            builder.AppendLine(StyleInfo);
            builder.AppendLine("</style>");
            builder.AppendLine("</header>");
            builder.AppendLine("<body>");
            WriteAttributeWithValue("h1", title);
        }


        public abstract string GetFormHeader();
    }
}
