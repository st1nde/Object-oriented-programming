using BookExcercise2;

internal class Program
{
    private static void Main(string[] args) 
    {
        Person person = new Person();
        person.Name = "Pekka";
        Console.WriteLine(person.Name);
    }
}