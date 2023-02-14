using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    internal class Circle: Shape
    {
        private double radius;

        public Circle(string type, string color, double radius) : base(type,color)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.Round(Math.PI * radius * radius);
        }

        public override string GetInfo()
        {
            return this.type + "\n" + this.color + "\n" + this.radius + "\n" + this.GetArea() + "\n\n";
        }
    }
}
