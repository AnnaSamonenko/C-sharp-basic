using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            //Console.WriteLine("Avarage number: ");Console.Write(Avarage());
            //Console.WriteLine("Sum of even numbers: "); Console.Write(SumEvenNumbers());
            Console.WriteLine("Sum of even numbers in range: "); Console.Write(SumEvenNumbersInRange());
        }

        //Вычислить среднее арифметическое значений в диапазоне n – m включительно.
        public static double Avarage()
        {
            double result = 0;
            int amount = 0;
            Console.WriteLine("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i <= m; i++)
            {
                result += i;
                amount++;
            }
            result = result / amount;
            return result;
        }

        //Написать код определения суммы четных чисел в диапазоне целых значений 0 – n1, 
        //используя только операторы повторения (использование if запрещено).
        public static int SumEvenNumbers()
        {
            int sum = 0;
            Console.WriteLine("Input n1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n1; i += 2)
            {
                sum += i;
            }
            return sum;
        }

        // Написать код определения суммы четных чисел в диапазоне целых значений n1 – n2, 
        //используя условные операторы if и операторы повторения.

        static int SumEvenNumbersInRange()
        {
            int sum = 0;
            Console.WriteLine("Input n: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input m: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                sum += i;
            }
            return sum;
        }
    }
}