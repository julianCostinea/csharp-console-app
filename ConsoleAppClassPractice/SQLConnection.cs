namespace ConsoleAppClassPractice;

public class SQLConnection : DbConnection
{
    public SQLConnection(TimeSpan timeSpan, string connectionString) : base(timeSpan, connectionString)
    {
    }

    public override void OpenConnection()
    {
        Console.WriteLine("Open SQL Connection");
    }
    public override void CloseConnection()
    {
        Console.WriteLine("Close SQL Connection");
    }
}