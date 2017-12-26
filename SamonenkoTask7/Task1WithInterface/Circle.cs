using System;

namespace Task1WithInterface
{
    public class Circle : IShape
    {
        private String name;
        private double radius;


        public Circle(string name, double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be more than 0");
            }
            this.name = name;
            this.radius = radius;
        }

        public string GetName()
        {
            return name;
        }

        public double GetArea()
        {
            return Math.Round((Math.Pow(radius, 2) * Math.PI), 2);
        }

        public override string ToString()
        {
            return GetName() + " with area: " + GetArea();
        }
    }
}