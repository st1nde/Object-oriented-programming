using BookExcercise3;
using System.Net;
using Literature;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book1 = new Book("Hobbit", "Tolkien", "WSOY", "9784ldjr9475d", 25.50);
        Book book2 = new Book("Kamasutra", "Indian guy", "WSOY", "jf94hgkd84hf9", 45.95);
        Book book3 = new Book("Science for dummies", "Smart Man", "Book company", "jg84klf9385jfh", 19.90);
        Book book4 = new Book("Holy bible", "God", "God", "978fnh4878634", 1.05);
        Book book5 = new Book("Tst book", "Test Person", "Publisher", "978fhf3593hr3", 25.50);

        book1.GetBookDetails("9784ldjr9475d");
        book2.GetBookDetails("jf94hgkd84hf9");
        book3.GetBookDetails("jg84klf9385jfh");
        book4.GetBookDetails("978fnh4878634");

        Book.ChangeTheme("HORROR");
        book1.GetBookDetails("9784ldjr9475d");
        book2.GetBookDetails("jf94hgkd84hf9");
        book3.GetBookDetails("jg84klf9385jfh");
        book4.GetBookDetails("978fnh4878634");

        Console.WriteLine(book5.Author + "\n");

        Author author1 = new Author("Tolkien", "12.12.1890", book1);
        Author author2 = new Author("Joslyn James", "27.10.1978");
        Author author3 = new Author("Kenzie Reeves", "10.10.1991", book2);


        author1.PrintInformation();
        author3.PrintInformation();
    }
}