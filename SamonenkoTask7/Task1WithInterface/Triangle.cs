using System;

namespace Task1WithInterface
{
    public class Triangle : IShape
    {
        private string name;
        private double a;
        private double b;
        private double c;

        public Triangle(string name, double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides of triangle must be more than 0");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Traingle with such sides doesn't exist");
            }

            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string GetName()
        {
            return name;
        }

        public double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }

        public override string ToString()
        {
            return GetName() + " with area: " + GetArea();
        }
    }
}