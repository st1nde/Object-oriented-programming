using ShapeExercise;
using System.Collections.Concurrent;

internal class Program
{
    private static void Main(string[] args)
    {
        Shape cl = new Circle("Circle", "red", 2.5);
        //Console.Write(cl.GetInfo());
        //Console.Write(cl.GetArea());

        Shape rc = new Rectangle("Rectangle", "blue", 7, 8);
        //Console.Write(rc.GetInfo());

        Shape tr = new Triangle("Triangle", "green", 12, 25);
        //Console.Write(tr.GetInfo());

        List<Shape> list = new List<Shape>();
        list.Add(cl);
        list.Add(tr);
        list.Add(tr);

        foreach (Shape s in list)
        {
            Console.WriteLine(s.GetInfo());
        }

        foreach(Shape s in list)
        {
            Console.WriteLine(s.GetInfo());
        }
        list.Sort();
        foreach(Shape s in list)
        {
            Console.WriteLine(s.GetInfo());
        }
    }
}