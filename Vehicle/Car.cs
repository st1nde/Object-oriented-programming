using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleExcercise;

namespace VehicleExcerise
{
    internal class Car: Vehicle
    {
         protected string engine, type;
         protected int doors;


        public Car(string engine, string type, int doors)
                    
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        public Car(string engine, string type, int doors, string make, string model, string modelYear, double price) : base(make, model, modelYear, price)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
            this.make = make;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        public Car()
        {
            this.engine = String.Empty;
            this.type = String.Empty;
            this.doors = 0;
        }

        public override void PrintInformation()
        {
            Console.WriteLine("Engine " + this.engine + " Type " + this.type + " Number of doors " + this.doors);
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return this.engine + "\n" + this.type + "\n" + this.doors + "\n";
        }
    }
}
