using System.Data;
using System.Data.SQLite;

namespace QStatitstics;
public static class CreateSchema
{
	public static void Generate()
    {
		using var conn = new SQLiteConnection();
		conn.ConnectionString = global::QStatitstics.Properties.Settings.Default.DefaultConnectionString;
		conn.Open();

		using var cmd = conn.CreateCommand();
		cmd.CommandText = CreateScript;
		cmd.CommandType = CommandType.Text;

		cmd.ExecuteNonQuery();
	}

	public const string CreateScript = @"
BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS ""Teams"" (
	""TeamId""	INTEGER NOT NULL,
	""Name""	TEXT,
	""City""	TEXT,
	""Status""	INTEGER,
	PRIMARY KEY(""TeamId"" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS ""Players"" (
	""PlayerId""	INTEGER NOT NULL,
	""Name""	TEXT NOT NULL,
	""Nickname""	TEXT NOT NULL,
	""Team""	INTEGER NOT NULL,
	""Number""	INTEGER NOT NULL,
	""Sex""	INTEGER NOT NULL,
	""Seeker""	INTEGER NOT NULL,
	PRIMARY KEY(""PlayerId""),
	FOREIGN KEY(""Team"") REFERENCES ""Teams""(""TeamId"")
);
CREATE TABLE IF NOT EXISTS ""Roster"" (
	""Match""	INTEGER NOT NULL,
	""Position""	INTEGER NOT NULL,
	""Player""	INTEGER NOT NULL,
	FOREIGN KEY(""Player"") REFERENCES ""Players""(""PlayerId"")
);
CREATE TABLE IF NOT EXISTS ""Matches"" (
	""MatchId""	INTEGER NOT NULL,
	""HomeTeam""	INTEGER NOT NULL,
	""VisitorsTeam""	INTEGER NOT NULL,
	""HomeScore""	INTEGER NOT NULL,
	""VisitorsScore""	INTEGER NOT NULL,
	PRIMARY KEY(""MatchId"" AUTOINCREMENT),
	FOREIGN KEY(""HomeTeam"") REFERENCES ""Teams""(""TeamId""),
	FOREIGN KEY(""VisitorsTeam"") REFERENCES ""Teams""(""TeamId"")
);
CREATE TABLE IF NOT EXISTS ""Performance"" (
	""EventId""	INTEGER NOT NULL,
	""Match""	INTEGER NOT NULL,
	""Time""	INTEGER NOT NULL,
	""EventType""	INTEGER NOT NULL,
	""FirstPlayer""	INTEGER NOT NULL,
	PRIMARY KEY(""EventId"" AUTOINCREMENT),
	FOREIGN KEY(""FirstPlayer"") REFERENCES ""Players""(""PlayerId"")
);
COMMIT;
";
}
