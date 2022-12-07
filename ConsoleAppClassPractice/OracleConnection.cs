namespace ConsoleAppClassPractice;

public class OracleConnection : DbConnection
{
    public OracleConnection(TimeSpan timeSpan, string connectionString) : base(timeSpan, connectionString)
    {
    }

    public override void OpenConnection()
    {
        Console.WriteLine("Open Oracle Connection");
    }
    public override void CloseConnection()
    {
        Console.WriteLine("Close Oracle Connection");
    }
}