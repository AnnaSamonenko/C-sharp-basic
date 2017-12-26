using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Task2
{
    internal class Program
    {
        /**
         *
         * Найти расстояние между первым и последним вхождением максимального значения в массиве.
         */
        public static void Main(string[] args)
        {
            int[] vector = {1, 5, 3, 4};
            Console.Write("Distance: ");
            Console.Write(Count(vector));
        }

        static int MaxValue(int[] vector)
        {
            int maxValue = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > maxValue)
                {
                    maxValue = vector[i];
                }
            }
            return maxValue;
        }

        static int Count(int[] vector)
        {
            int maxValue = MaxValue(vector);
            int indexFirst = 0;
            int indexLast = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == maxValue)
                {
                    indexFirst = i;
                    break;
                }
            }

            for (int i = vector.Length - 1; i != 0; i--)
            {
                if (vector[i] == maxValue)
                {
                    indexLast = i;
                    break;
                }
            }
            return indexLast - indexFirst;
        }
    }
}