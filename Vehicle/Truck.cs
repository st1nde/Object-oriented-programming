using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleExcerise;

namespace VehicleExcercise
{
    internal class Truck: Car
    {
        double load;
        double consumption;

        public Truck()
        {
            this.load = 0;
            this.consumption = 0;
        }

        public Truck(double load, double consumption)
        {
            this.load = load;
            this.consumption = consumption;
        }

        public double CalculateConsmuption()
        {
            return this.load * this.consumption;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
        }

    }
}
