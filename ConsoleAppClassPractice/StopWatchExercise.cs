namespace ConsoleAppClassPractice;

public class StopWatchExercise
{
    private DateTime _timeStamp;
    public void StartStopWatch()
    {
        if (_timeStamp != new DateTime())
        {
            throw new ArgumentException("Cannot start stopWatch twice. Must stop first");
        }
        _timeStamp = DateTime.Now;
    }

    public void StopStopWatch()
    {
        var timePassed = DateTime.Now - _timeStamp;
        Console.WriteLine(timePassed);
        _timeStamp = new DateTime();
    }
}