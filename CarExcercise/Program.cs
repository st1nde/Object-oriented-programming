using CarExcercise;
internal class Program
{
    private static void Main(string[] args)
    {
        Car Car1 = new Car();
        Car1.AskData();
        Car1.ShowCarInfo();
        Car1.Accelerate(100);
        Car1.ShowCarInfo();
        Car1.Brake();
        Car1.ShowCarInfo();


        Car Car2 = new Car();
        Car2.AskData();
        Car2.ShowCarInfo();
        Car2.Accelerate(80);
        Car2.ShowCarInfo();
        Car2.Brake();
        Car2.ShowCarInfo();
    }
}