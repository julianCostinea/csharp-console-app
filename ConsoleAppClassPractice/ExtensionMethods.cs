namespace ConsoleAppClassPractice;

public class ExtensionMethods
{
    static void MainDuplicate(string[] args)
    {
        string post = "This is supposed to be a very long blog post blah blah blah...";
        //although Shorten is static, compiler lets you use it on an instance
        var shortenedPost = post.Shorten(5);

        Console.WriteLine(shortenedPost);

        IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
        var max = numbers.Max();

        Console.WriteLine(max);
    }
}