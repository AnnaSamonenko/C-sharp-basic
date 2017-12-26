using System;

namespace Task1
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides of triangle must be more than 0");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Traingle with such sides doesn't exist");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        }
    }
}