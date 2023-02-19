using FileManagerExcercise;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        const string path = @"C:\Users\timil\source\repos\Object-oriented-programming\FileManagerExcercise\myBooks.json";

        FileManager fm = new FileManager(path);

        //fm.ReadWords();

        Console.WriteLine(fm.ReadWords());   

        List<Book> books =JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(path));
       


        if (books != null)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
        else Console.WriteLine("404 Lol");

        books.Add(new Book("LOTR", " Tolkien ", 25.99));
        books.Add(new Book("Parry Hotter1", " Rowling", 15.95));
        books.Add(new Book("Parry Hotter2", " Rowling", 15.99));


        File.WriteAllText(path, JsonConvert.SerializeObject(books));

    }
}