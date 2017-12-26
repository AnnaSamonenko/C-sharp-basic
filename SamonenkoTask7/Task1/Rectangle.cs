using System;

namespace Task1
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(string name, double width, double height) : base(name)
        {
            if (height <= 0 || width <= 0)
            {
                throw new ArgumentException("Sides of rectangle must be more than 0");
            }
            this.height = height;
            this.width = width;
        }

        public override double GetArea()
        {
            return height * width;
        }
    }
}