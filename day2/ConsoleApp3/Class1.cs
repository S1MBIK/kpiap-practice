using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public class Fraction
        {
            private int numerator;   // числитель
            private int denominator; // знаменатель


            public Fraction(int numerator, int denominator)
            {
                if (denominator == 0)
                    throw new ArgumentException("Знаменатель не может быть равен нулю.");

                this.numerator = numerator;
                this.denominator = denominator;
                Simplify();
            }


            private void Simplify()
            {
                int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
                numerator /= gcd;
                denominator /= gcd;
            }

            // НОД
            private int GCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            // Сложение дробей
            public static Fraction operator +(Fraction a, Fraction b)
            {
                return new Fraction(a.numerator * b.denominator + b.numerator * a.denominator,
                                    a.denominator * b.denominator);
            }

            // Вычитание дробей
            public static Fraction operator -(Fraction a, Fraction b)
            {
                return new Fraction(a.numerator * b.denominator - b.numerator * a.denominator,
                                    a.denominator * b.denominator);
            }

            // Умножение дробей
            public static Fraction operator *(Fraction a, Fraction b)
            {
                return new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
            }

            // Деление дробей
            public static Fraction operator /(Fraction a, Fraction b)
            {
                if (b.numerator == 0)
                    throw new DivideByZeroException("Деление на ноль.");

                return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
            }

            public override string ToString()
            {
                return $"{numerator}/{denominator}";
            }
        }

    }
}
