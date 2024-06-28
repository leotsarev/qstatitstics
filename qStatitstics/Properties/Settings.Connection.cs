namespace QStatitstics.Properties;

internal partial class Settings
{
    [global::System.Configuration.ApplicationScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
    [global::System.Configuration.DefaultSettingValueAttribute("data source=\"~\\qstat.db\"")]
    public string DefaultConnectionString
    {
        get
        {
            var str =  ((string)(this["DefaultConnectionString"]));
            return str.Replace("~", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }
    }
}
