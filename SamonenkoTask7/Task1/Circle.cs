using System.ComponentModel;
using System;

namespace Task1
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(string name, double radius) : base(name)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be more than 0");
            }
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.Round((Math.Pow(radius, 2) * Math.PI), 2);
        }
    }
}