using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    internal class Triangle: Shape
    {
        private double lenght;
        private double width;

        public Triangle (string type, string color, double lenght, double width): base (type, color)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public override double GetArea()
        {
            return Math.Round(this.lenght * this.width / 2,2);
        }

        public override string GetInfo()
        {
            return this.type + "\n" + this.color + "\n" + this.lenght + "\n" + this.width + "\n\n" + GetArea();
        }
    }
}
