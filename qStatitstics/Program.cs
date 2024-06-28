using System;
using System.IO;
using System.Windows.Forms;

[assembly: CLSCompliant(true)]

namespace QStatitstics;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        if (!File.Exists(global::QStatitstics.Properties.Settings.Default.DefaultConnectionString))
        {
            CreateSchema.Generate();
        }
        Application.EnableVisualStyles();
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}
