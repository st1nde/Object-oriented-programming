using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExcercise
{
    internal class Car
    {
        string brand; double speed;

        public Car()
        {
            brand = "";
            this.speed = 0;
        }

        public Car(string brand, double speed)
        {
            this.brand = brand;
            this.speed = speed;
        }

        public void AskData()
        {
            Console.WriteLine("Car brand?");
            this.brand = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Speed?");
            this.speed = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.Write(brand + "\n" + this.speed + "\n");
            

        }

        public double Accelerate(int acceleration)
        {
            if (acceleration > 0)
            {
                Console.WriteLine("Accelerating");
                this.speed += acceleration;
            }
            else Console.WriteLine("Negative acceleration is not permitted!");
            return this.speed;
        }

        public double Brake()
        {
            Console.WriteLine("Using brakes");
            this.speed *= 0.9;
            return this.speed;
        }
    }
}
