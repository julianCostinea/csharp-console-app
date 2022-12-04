// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks;
using ConsoleAppClassPractice;

namespace ConsoleAppClassPractice
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
            var stopWatch = new StopWatchExercise();
            try
            {
                stopWatch.StartStopWatch();
                // stopWatch.StartStopWatch();
                await Task.Delay(3000);
                stopWatch.StopStopWatch();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}