using System;

namespace Task3
{
    class Program
    {
        /***
         * Написать функцию (метод), записывающий в массив-матрицу произвольного размера значение нуль в
            элементы по левую сторону главной диагонали, единицу – по правую. Пример:
            ((2, 4, 3, 3)
            (5, 7, 8, 5)
            (2, 4, 3, 3)
            (5, 7, 8, 5))
            =>
            ((2, 1, 1, 1)
            (0, 7, 1, 1)
            (0, 0, 3, 1)
            (0, 0, 0, 5))
         */

        static void Main(string[] args)
        {
            int[,] matrix = {{2, 4, 3, 3}, {5, 7, 8, 5}, {2, 4, 3, 3}, {5, 7, 8, 5}};

            // impl
            Run(matrix);

            // output
            Output(matrix);

            Console.Read();
        }

        static void Run(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        matrix[i, j] = 1;
                    }
                    if (i > j)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        static void Output(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Read()
        {
        }
    }
}