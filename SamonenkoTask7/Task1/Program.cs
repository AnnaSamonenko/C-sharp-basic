using System;
using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Shape isoscelesTriangle = new IsoscelesTriangle("isoscelesTriangle", 4, 2);
                Console.WriteLine(isoscelesTriangle);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}