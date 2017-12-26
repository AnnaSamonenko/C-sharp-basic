using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Task2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // TODO check input datas
            int n = 10;
            double a1 = 4;
            double t = 2;

            ArithmeticSequence arithmeticSequence = new ArithmeticSequence(n, a1, t);

            int N = 4;

            // check on negative values
            try
            {
                arithmeticSequence.GetByIndex(N);
                arithmeticSequence.CountSummFirstNElem(N);
                arithmeticSequence.AvarageOfFirstNNumbers(N);
            }
            catch (Exception e)
            {
                // Todo some log need to be here
            }
        }
    }
}