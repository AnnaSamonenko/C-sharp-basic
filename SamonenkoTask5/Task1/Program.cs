using System;
using MyVectorLib;

namespace Task1
{
    internal class Program
    {
        /**
         * Создать класс, представляющий пользовательский массив с произвольной нижней границей нумерации
         * элементов (как в Паскале), например, состоящий из 5 элементов с индексами 11, 12, 13, 14, 15.
         * 
         * Определить свойства длины массива, нижней и верхней границы индекса, индексатор для чтения
         * и записи элемента по заданному индексу. Класс скомпилировать в динамическую библиотеку.
         * В консольном приложении продемонстрировать работу созданного класса.
         */
        public static void Main(string[] args)
        {
            MyVector arr = new MyVector(11, 5);

            for (int i = arr.StartIndex; i < arr.EndIndex; i++)
            {
                arr[i] = i;
            }
            //Console.Write(arr[0]);
    
            Console.WriteLine(arr[11]);
            
            for (int i = arr.StartIndex; i < arr.EndIndex; i++)
                Console.Write(arr[i] + " ");

            Console.ReadLine();
        }
    }
}