namespace ConsoleAppClassPractice;

public abstract class DbConnection
{
    private string _connectionString;
    private TimeSpan _timeout;

    protected DbConnection(TimeSpan timeout, string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException("Connection cannot be null");
        }

        _timeout = timeout;
        _connectionString = connectionString;
    }

    public abstract void OpenConnection();
    public abstract void CloseConnection();
}