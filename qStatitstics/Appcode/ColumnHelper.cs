namespace QStatitstics.Appcode;

public static class ColumnHelper
{
    public static void HideColumn(this DataGridView grid, string columnName)
    {
        var column = grid.Columns[columnName];
        if (column != null)
        {
            column.Visible = false;
        }
    }

    public static void SetupColumn(this DataGridView grid, string columnName, int displayIdx, string name, int width)
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
}