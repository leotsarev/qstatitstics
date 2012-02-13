using System;
using System.Windows.Forms;

namespace QStatitstics.Appcode
{
    internal class Utility
    {
        private Utility()
        {
        }

        public static void HideColumn(DataGridView grid, string columnName)
        {
            var column = grid.Columns[columnName];
            if (column != null)
            {
                column.Visible = false;
            }
        }

        public static void SetupColumn(DataGridView grid, string columnName, int displayIdx, string name, int width)
        {
            var column = grid.Columns[columnName];
            if (column == null)
            {
                return;
            }
            column.DisplayIndex = displayIdx;
            column.HeaderText = name;
            column.Width = width;
        }

        public static string FormatTimeSpan(long ticks)
        {
            return FormatTimeSpan(new TimeSpan(ticks));
        }

        public static string FormatTimeSpan(TimeSpan time)
        {
            return time.Hours == 0 ? String.Format("{0:D2}:{1:D2}", time.Minutes, time.Seconds) : String.Format("{0:D1}:{1:D2}:{2:D2}", time.Hours, time.Minutes, time.Seconds);
        }

        public static string FormatTimeSpanForTextBox(TimeSpan span)
        {
            return String.Format("{0:D1}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
        }
    }
}