namespace ConsoleAppClassPractice;

public class Lambdas
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
    }

    static List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book() { Title = "Title 1", Price = 5 },
            new Book() { Title = "Title 2", Price = 7 },
            new Book() { Title = "Title 3", Price = 17 }
        };
    }

    static void Lambda()
    {
        //args=>expression
        Func<int, int> square = number => number * number;
        Console.WriteLine(square(5));

        var books = GetBooks();
        //with Delegate
        var cheapBooksDelegate = books.FindAll(IsCheaperThan10);
        //with Lambda
        var cheapBooks = books.FindAll(b => b.Price <= 10);

        static bool IsCheaperThan10(Book book)
        {
            return book.Price < 10;
        }
    }
}