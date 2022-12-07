using System.Collections;

namespace ConsoleAppClassPractice;

public class StackExercise
{
    public ArrayList _stackList { get; }

    public StackExercise()
    {
        _stackList = new ArrayList();
    }

    public void Push(object? obj)
    {
        if (obj != null)
        {
            _stackList.Add(obj);
            return;
        }
        throw new InvalidOperationException("Cant add null to list");
    }

    public object Pop()
    {
        if (_stackList.Count <= 0) throw new InvalidOperationException("Cant pop an empty list");
        var poppedObj = _stackList[_stackList.Count - 1];
        _stackList.RemoveAt(_stackList.Count - 1);
        return poppedObj;
    }

    public void Clear()
    {
        _stackList.Clear();
    }
}