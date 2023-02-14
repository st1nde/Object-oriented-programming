using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    internal class Rectangle: Shape
    {
        private double lenght;
        private double width;

        public Rectangle(string type, string color, double lenght, double width):base(type, color)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public override double GetArea()
        {
            return this.lenght * this.width;
        }

        public override string GetInfo()
        {
            return this.type + "\n" + this.color + "\n" + this.lenght + "\n" + this.width + "\n" + GetArea() + "\n\n";
        }
    }
}
