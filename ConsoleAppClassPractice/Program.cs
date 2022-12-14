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

            //STACK EXERCISE
            
            // var stack = new StackExercise();
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push("3");

            // try
            // {
            //     Console.WriteLine(stack.Pop());
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            // }
            // Console.WriteLine(stack.Pop());
            // Console.WriteLine(stack.Pop());
            // Console.WriteLine(stack.Pop());
            // stack.Clear();

            // Console.WriteLine(stack._stackList.Count);

            //DBCONNECTION EXERCISE
            // var oracleCon = new OracleConnection(new TimeSpan(), "Oracle");
            // var sqlCon = new SQLConnection(new TimeSpan(), "SQL");
            // oracleCon.OpenConnection();
            // sqlCon.OpenConnection();
            // oracleCon.CloseConnection();
            
            //DBCOMMAND EXERCISE
            // var dbCommand = new DBCommand(sqlCon, "oracle instruction");
            // dbCommand.Execute();
            var runningAct = new RunningActivity();
            var workAct = new WorkActivity();
            var workFlow = new WorkFlowEngine.WorkFlow();
            workFlow.AddActivity(runningAct);
            workFlow.AddActivity(workAct);
            var workflowEngine = new WorkFlowEngine();
            workflowEngine.Run(workFlow);

            //delegates with PhotoFilter
            var photoProcessor = new Delegates.PhotoProcessor();
            var filters = new PhotoFilters();
            //custom delegate
            // Delegates.PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            
            //Action delegate
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;
            photoProcessor.Process("photo.jpg", filterHandler);
            
            //adding a new filter without changing PhotoFilters
            static void RemoveRedEye(Photo photo)
            {
                Console.WriteLine("Red eye filter");
            }
        }
    }
}