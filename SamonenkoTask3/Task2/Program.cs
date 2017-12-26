using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Task2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Console.Write("n: ");
            //int n = Int32.Parse(Console.ReadLine());
            Console.Write("a1: ");
            double a1 = Double.Parse(Console.ReadLine());
            Console.Write("t: ");
            double t = Double.Parse(Console.ReadLine());

            //double[] progression = createArithmeticProgression(n, a1, t);
            //printVector(progression);
            //Console.WriteLine("Production: ");
            //Console.Write(product(progression));

            Console.Write("border: ");
            double alim = Double.Parse(Console.ReadLine());

            double[] progression2 = createGeometricProgression(a1, t, alim);
            Console.WriteLine("Geometric Progression:");
            printVector(progression2);
            //Console.WriteLine("Production: ");
            //Console.Write(product(progression2));
        }

        static double[] createArithmeticProgression(int n, double a1, double t)
        {
            double[] ArithmeticProgression = new double[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    ArithmeticProgression[i] = a1;
                    continue;
                }
                ArithmeticProgression[i] = ArithmeticProgression[i - 1] + t;
            }
            return ArithmeticProgression;
        }

        static double[] createGeometricProgression(double a1, double t, double border)
        {
            double temp = a1;
            int size = 0;
            while (temp > border)
            {
                temp = temp * t;
                size++;
            }

            double[] GeometricProgression = new double[size];
            for (int i = 0; i < GeometricProgression.Length; i++)
            {
                if (i == 0)
                {
                    GeometricProgression[i] = a1;
                }
                else
                {
                    GeometricProgression[i] = GeometricProgression[i - 1] * t;
                }
            }
            return GeometricProgression;
        }


        static double product(double[] vector)
        {
            double result = 1;
            for (int i = 0; i < vector.Length; i++)
            {
                result *= vector[i];
            }
            return result;
        }

        static void printVector(double[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }
    }
}