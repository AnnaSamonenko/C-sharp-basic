using System;
using System.Collections.Generic;

namespace Task1WithInterface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                IShape circle = new Circle("circle", 5);
                Console.WriteLine(circle);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}