using System;
using System.Windows.Forms;
using QStatitstics.Appcode;

namespace QStatitstics;

public partial class CorrectTime : Form
{
    private TimeSpan _Span;

    public CorrectTime(TimeSpan span)
    {
        _Span = span;
        InitializeComponent();
    }

    public TimeSpan Span
    {
        get { return _Span; }
    }


    private void CorrectTime_Load(object sender, EventArgs e)
    {
        NewTimeTextBox.Text = OldTimeTextBox.Text = Utility.FormatTimeSpanForTextBox(Span);
    }

    private void OKButton_Click(object sender, EventArgs e)
    {
        TimeSpan.TryParse(NewTimeTextBox.Text, out _Span);
    }
}