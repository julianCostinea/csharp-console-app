// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Threading.Tasks;
using ConsoleAppClassPractice;

namespace ConsoleAppClassPractice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //STOPWATCH EXERCISE

            // var stopWatch = new StopWatchExercise();
            // try
            // {
            //     stopWatch.StartStopWatch();
            //     // stopWatch.StartStopWatch();
            //     await Task.Delay(3000);
            //     stopWatch.StopStopWatch();
            // }
            // catch (ArgumentException ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }

            //STACKPOST EXERCISE

            // var stackPost = new StackPostExercise("myPost", "postDesc", DateTime.Now);
            // stackPost.VoteUp().VoteUp().VoteUp().VoteDown();
            // var voteCount = stackPost.GetVoteCount();
            // Console.WriteLine(voteCount);

            var stack = new StackExercise();
            stack.Push(1);
            stack.Push(2);
            stack.Push("3");

            // try
            // {
            //     Console.WriteLine(stack.Pop());
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            // }
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            // stack.Clear();

            Console.WriteLine(stack._stackList.Count);
        }
    }
}