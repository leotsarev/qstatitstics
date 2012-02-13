using System;
using System.IO;
using System.Text;

namespace QStatitstics.Appcode
{
    internal class ProcessCSV
    {
        private static readonly char[] separators = {',', '\t'};
        public bool DeleteBefore;
        public string FileName;
        public DataSet1.PlayersDataTable Players;
        public long TeamId;

        public void Apply()
        {
            if (DeleteBefore)
            {
                Players.Clear();
            }
            byte[] file = File.ReadAllBytes(FileName);
            Decoder decoder = Encoding.Default.GetDecoder();
            var chars = new char[file.Length];
            decoder.GetChars(file, 0, file.Length, chars, 0);
            var text = new string(chars);
            string[] lines = text.Split('\n');
            foreach (string line in lines)
            {
                InsertPlayer(line.Trim());
            }
        }

        private void InsertPlayer(string line)
        {
            if (line.Length == 0)
            {
                return;
            }
            string[] values = line.Split(separators);
            var row = (DataSet1.PlayersRow) Players.NewRow();
            row.Name = values[0];
            row.Nickname = (values.Length > 0) ? values[1] : "";
            if (values.Length > 1)
            {
                int num;
                Int32.TryParse(values[2], out num);
                row.Number = num;
            }
            row.Team = TeamId;
            Players.Rows.Add(row);
        }
    }
}