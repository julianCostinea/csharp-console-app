namespace ConsoleAppClassPractice;

public class StackPostExercise
{
    private int _voteCount;
    private string _title, _description;
    private DateTime _createdAt;
    public StackPostExercise(string title, string description, DateTime createdAt)
    {
        _title = title;
        _description = description;
        _createdAt = createdAt;
    }
    
    public StackPostExercise VoteUp()
    {
        _voteCount++;
        return this;
    }
    public void VoteDown()
    {
        _voteCount--;
    }

    public int GetVoteCount()
    {
        return _voteCount;
    }
}