namespace ConsoleAppClassPractice;

public class DBCommand
{
    private DbConnection _connection;
    private string _instruction;
    
    public DBCommand(DbConnection connection, string instruction)
    {
        if (string.IsNullOrWhiteSpace(instruction))
        {
            throw new InvalidOperationException("Instruction cannot be null");
        }
        _connection = connection;
        _instruction = instruction;
    }

    public void Execute()
    {
        _connection.OpenConnection();
        Console.WriteLine(_instruction);
        _connection.CloseConnection();
    }
}