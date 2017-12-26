using System;
using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Square square = new Square(2);

            //area
            square.Area();
            //perimeter
            square.Perimeter();
        }
    }
}