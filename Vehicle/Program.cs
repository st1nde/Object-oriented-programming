
using VehicleExcercise;
using VehicleExcerise;

internal class Program
{
    private static void Main(string[] args)
    {
        Car c4 = new Car("1.6L Diesel", "Van", 5, "VW", "Small van", "2015", 15000);

        Car c1 = new Car("2L Diesel", "SUV", 5);
        Car c2 = new Car("1.6L Gasoline", "Offroad", 2);
        Car c3 = new Car("2L Gasoline", "Coupe", 5);



        c1.PrintInformation();
        c2.PrintInformation();
        

        c2.ToString();
        Console.WriteLine(c3.Equals(c1));

        Truck truck1 = new Truck(5000, 20);
        Truck truck2 = new Truck(12000, 25);

        Truck x = c1 as Truck; //Does not work.
        Car y = truck1 as Car; //Does work

    }
}