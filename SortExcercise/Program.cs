using SortExcercicse;

internal class Program
{
    private static void Main(string[] args)
    {
       List<book> books = new List<book>();

        books.Add(new book("12345", "book1", "author1", 12.00));
        books.Add(new book("123456", "book2", "author2", 13.00));
        books.Add(new book("1234567", "book3", "author3", 14.00));
        books.Add(new book("12345678", "book4", "author4", 15.00));

        foreach (book book in books)
        {
            Console.WriteLine(book);
        }
        //Console.WriteLine(books);

        books.Sort();
        
        foreach (book book in books)
        {
            Console.WriteLine(book);
        }

        
    }
}