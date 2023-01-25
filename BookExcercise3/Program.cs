using BookExcercise3;
internal class Program
{
    private static void Main(string[] args)
    {
        Book book1 = new Book("Hobbit", "Tolkien", "WSOY", "9784ldjr9475d", 25.50);
        Book book2 = new Book("Kamasutra", "Indian guy", "WSOY", "jf94hgkd84hf9", 45.95);
        Book book3 = new Book("Science for dummies", "Smart Man", "Book company", "jg84klf9385jfh", 19.90);
        Book book4 = new Book("Holy bible", "God", "God", "978fnh4878634", 1.05);

        book1.GetBookDetails("9784ldjr9475d");
        book2.GetBookDetails("jf94hgkd84hf9");
        book3.GetBookDetails("jg84klf9385jfh");
        book4.GetBookDetails("978fnh4878634");

        Book.ChangeTheme("HORROR");
        book1.GetBookDetails("9784ldjr9475d");
        book2.GetBookDetails("jf94hgkd84hf9");
        book3.GetBookDetails("jg84klf9385jfh");
        book4.GetBookDetails("978fnh4878634");


    }
}