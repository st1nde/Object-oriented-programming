using BookExcercise;
internal class Program
{
    private static void Main(string[] args)
    {
        book myFirstBook = new book();
        book mySecondBook = new book("00001", "Holy Bible", "God", 1.00);
        book myThirdBook = new book("00002", "Hemulin Hame", "kirjailija", 20.00);
        mySecondBook.CompareBook(myThirdBook);

    }
}