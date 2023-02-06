using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExcercise
{
    abstract class Vehicle
    {
        protected string make, model, modelYear;
        protected double price;

        public Vehicle(string make, string model, string modelYear, double price)
        {
            this.make = make;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        protected Vehicle()
        {
            this.make = string.Empty;
            this.model = string.Empty;
            modelYear = string.Empty;
            price = 0;
        }

        public virtual void PrintInformation()
        {
            if (make != string.Empty)
               Console.WriteLine("Make " + this.make + " Model " + this.model + " Year of production " + this.modelYear + " Price " + this.price);
        }
    }
}
