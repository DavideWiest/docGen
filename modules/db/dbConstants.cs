
public class dbSecrets {
    public const string hostServer = "";
    public const string username = "";
    public const string password = "";
    public const string database = "";
    public const string conStr = $"Host={hostServer};Username={username};Password={password};Database={database}";

}

public class dbTable
{
    public static readonly dbTable t1 = new dbTable("t1");
    public static readonly dbTable t2 = new dbTable("t2");
    public static readonly dbTable t3 = new dbTable("t3");

    private readonly string name;

    private dbTable(string name) { this.name = name; }
    public override string ToString() { return name; }
}