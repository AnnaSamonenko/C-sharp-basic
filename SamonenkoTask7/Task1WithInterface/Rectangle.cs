using System;

namespace Task1WithInterface
{
    public class Rectangle : IShape
    {
        private string name;
        private double width;
        private double height;

        public Rectangle(string name, double width, double height)
        {
            if (height <= 0 || width <= 0)
            {
                throw new ArgumentException("Sides of rectangle must be more than 0");
            }
            this.name = name;
            this.width = width;
            this.height = height;
        }

        public string GetName()
        {
            return name;
        }

        public double GetArea()
        {
            return height * width;
        }

        public override string ToString()
        {
            return GetName() + " with area: " + GetArea();
        }
    }
}