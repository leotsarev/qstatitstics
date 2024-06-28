using System;
using System.Drawing;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace QStatitstics;

[SupportedOSPlatform("Windows")]
public partial class LabelWithFontScaling : Label
{
    public LabelWithFontScaling()
    {
        InitializeComponent();
    }

    private Size prevSize = Size.Empty;
    private string prevText = string.Empty;

    protected override void OnPaint(PaintEventArgs e)
    {
        if (Bounds.Size != prevSize || Text != prevText)
        {
            prevSize = Bounds.Size;
            prevText = Text;   
            if (string.IsNullOrEmpty(Text))
            {
                return;
            }

            float fontSize = NewFontSize(e.Graphics, this.Bounds.Size, Font, Text);
            Font = new Font("Verdana", fontSize, FontStyle.Bold);
        }

        base.OnPaint(e);
    }

    public static float NewFontSize(Graphics graphics, Size size, Font font, string str)
    {
        SizeF stringSize = graphics.MeasureString(str, font);
        var wRatio = size.Width / stringSize.Width;
        var hRatio = size.Height / stringSize.Height;
        var ratio = Math.Min(hRatio, wRatio) * 0.9f;
        return font.Size * ratio;
    }

}
