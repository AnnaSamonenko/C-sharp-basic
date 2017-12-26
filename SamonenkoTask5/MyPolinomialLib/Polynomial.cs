using System;

namespace MyPolinomialLib
{
    public class Polynomial
    {
        private double[] _coefficients;

        private int _degree;

        public Polynomial(params double[] coefficients)
        {
            _coefficients = new double[coefficients.Length];
            for (int i = 0; i < coefficients.Length; i++)
                _coefficients[i] = coefficients[i];
        }

        public double this[int i]
        {
            get { return _coefficients[i]; }
            set { _coefficients[i] = value; }
        }

        public double Degree()
        {
            int i = _coefficients.Length - 1;
            if (_coefficients[i] != 0)
            {
                _degree = i;
            }
            else
            {
                while (_coefficients[i] == 0)
                {
                    _degree = i - 1;
                    i--;
                    if (i == 0)
                    {
                        return Double.NegativeInfinity;
                    }
                }
            }
            return _degree;
        }

        public static Polynomial operator +(Polynomial pol1, Polynomial pol2)
        {
            int size = Math.Max(pol1._coefficients.Length, pol2._coefficients.Length);

            double[] newCoef = new double[size];
            double[] coef1 = new double[size];
            double[] coef2 = new double[size];

            for (int i = 0; i < size; i++)
            {
                newCoef[i] = 0;
                coef1[i] = 0;
                coef2[i] = 0;
            }

            for (int i = 0; i < pol1._coefficients.Length; i++)
            {
                coef1[coef1.Length - i - 1] = pol1._coefficients[i];
            }

            for (int i = 0; i < pol2._coefficients.Length; i++)
            {
                coef2[coef2.Length - i - 1] = pol2._coefficients[i];
            }

            for (int i = 0; i < size; i++)
            {
                newCoef[i] = coef1[size - i - 1] + coef2[size - i - 1];
            }

            Polynomial result = new Polynomial(newCoef);
            return result;
        }

        public static Polynomial operator -(Polynomial pol1, Polynomial pol2)
        {
            int size = Math.Max(pol1._coefficients.Length, pol2._coefficients.Length);

            double[] newCoef = new double[size];
            double[] coef1 = new double[size];
            double[] coef2 = new double[size];

            for (int i = 0; i < size; i++)
            {
                newCoef[i] = 0;
                coef1[i] = 0;
                coef2[i] = 0;
            }

            for (int i = 0; i < pol1._coefficients.Length; i++)
            {
                coef1[coef1.Length - i - 1] = pol1._coefficients[i];
            }

            for (int i = 0; i < pol2._coefficients.Length; i++)
            {
                coef2[coef2.Length - i - 1] = pol2._coefficients[i];
            }

            for (int i = 0; i < size; i++)
            {
                newCoef[i] = coef1[size - i - 1] - coef2[size - i - 1];
            }

            Polynomial result = new Polynomial(newCoef);
            return result;
        }

        public static Polynomial operator *(Polynomial pol1, Polynomial pol2)
        {
            double[] newCoef = new double[pol1._coefficients.Length + pol2._coefficients.Length - 1];

            for (int i = 0; i < newCoef.Length; i++)
            {
                newCoef[i] = 0;
            }

            for (int i = 0; i < pol1._coefficients.Length; ++i)
            {
                for (int j = 0; j < pol2._coefficients.Length; ++j)
                {
                    newCoef[i + j] += pol1._coefficients[i] * pol2._coefficients[j];
                }
            }

            Polynomial result = new Polynomial(newCoef);
            return result;
        }

        public override string ToString()
        {
            string polynomialString = "";
            for (int i = _coefficients.Length - 1; i >= 0; i--)
            {
                if (_coefficients[i] == 0)
                {
                    continue;
                }

                if (i > 1)
                {
                    if (_coefficients[i] > 0 && i != _coefficients.Length - 1)
                        polynomialString += "+";
                    polynomialString += _coefficients[i] + "*x^" + i;
                }
                else if (i == 1)
                {
                    if (_coefficients[i] > 0 && i != _coefficients.Length - 1)
                        polynomialString += "+";
                    polynomialString += _coefficients[i] + "*x";
                }
                else
                {
                    if (_coefficients[i] > 0)
                        polynomialString += "+";
                    polynomialString += _coefficients[i] + " ";
                }
            }
            return polynomialString;
        }
    }
}