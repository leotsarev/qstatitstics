using System;
using System.IO;
using System.Windows.Forms;
using QStatitstics.Appcode;
using QStatitstics.Reports;

namespace QStatitstics
{
    public partial class ViewReportForm : Form
    {
        private readonly ReportGenerator generator;
        private string reportText;


        private ViewReportForm(ReportGenerator _generator)
        {
            InitializeComponent();
            generator = _generator;
        }


        private void ViewProtocolForm_Load(object sender, EventArgs e)
        {
            reportText = generator.GetReportText();
            webBrowser1.DocumentText = reportText;
            Text = generator.GetFormHeader();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            using (var sw = new StreamWriter(saveFileDialog.OpenFile()))
            {
                sw.Write(reportText);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

       

        public static void ShowBestSeekers()
        {
            var vrf = new ViewReportForm(new BestSeekersReport());
            vrf.ShowDialog();
        }

        public static void ShowBestChasers()
        {
            var vrf = new ViewReportForm(new BestChasersReport());
            vrf.ShowDialog();
        }

        public static void ShowMatchProtocol(Match match)
        {
            var vpf = new ViewReportForm(new MatchProtocol(match));
            vpf.ShowDialog();
        }
    }
}