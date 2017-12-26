using System;
using MyPolinomialLib;

namespace Task2
{
    /*
     * Разработать класс «многочлен» для работы с многочленами от одной переменной и
     * перегрузить для класса операции, допустимые для работы с многочленами (сложение, вычитание, умножение).
     * В классе определить свойства (например, степень многочлена), индексатор на чтение и запись
     * (доступ к коэффициенту по индексустепени), метод, возвращающий строковое представление значения
     * многочлена в удобном для восприятия виде, например, «5х^3 + 2x^2 + 45».  Класс скомпилировать в
     * динамическую библиотеку.  В консольном приложении продемонстрировать работу созданного класса. 
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            Polynomial pol1 = new Polynomial(-1, 2, 3);

            Polynomial pol2 = new Polynomial(-1, 2);

            Console.WriteLine(pol1);
            Console.WriteLine(pol2);
            Console.WriteLine(pol1 + pol2);
            Console.WriteLine(pol1 - pol2);
            Console.WriteLine(pol1 * pol2);
        }
    }
}