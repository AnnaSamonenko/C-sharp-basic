using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace Task2
{
    public class ArithmeticSequence
    {
        private readonly int _n;
        private readonly double _a1;
        private readonly double _t;

        public ArithmeticSequence(int n, double a1, double t)
        {
            _n = n;
            _a1 = a1;
            _t = t;
        }

        public double GetByIndex(int N)
        {
            double[] progression = CreateArithmeticSequence();
            if (N > progression.Length)
            {
                throw new Exception();
            }
            return progression[N - 1];
        }

        public double CountSummFirstNElem(int N)
        {
            double sum = 0;
            double[] progression = CreateArithmeticSequence();
            if (N > progression.Length)
            {
                throw new Exception();
            }
            for (int i = 0; i < N; i++)
            {
                sum += progression[i];
            }
            return sum;
        }

        public double AvarageOfFirstNNumbers(int N)
        {
            double sum = CountSummFirstNElem(N);
            return sum / N;
        }

        private double[] CreateArithmeticSequence()
        {
            double[] arithmeticProgression = new double[_n];

            for (int i = 0; i < _n; i++)
            {
                if (i == 0)
                {
                    arithmeticProgression[i] = _a1;
                    continue;
                }
                arithmeticProgression[i] = arithmeticProgression[i - 1] + _t;
            }
            return arithmeticProgression;
        }

        public override string ToString()
        {
            double[] progression = CreateArithmeticSequence();
            string result = System.String.Empty;
            for (int i = 0; i < progression.Length; i++)
            {
                result += progression[i].ToString() + " ";
            }

            return result;
        }
    }
}