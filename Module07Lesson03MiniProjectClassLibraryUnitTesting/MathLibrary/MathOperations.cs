using System;
using System.Collections.Generic;
using System.Text;

/*
 * My own answer
 */
namespace MathLibrary
{
    public class MathOperations
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return Math.Round(minuend - subtrahend, 2);
        }

        public double Multiply(double multiplicand, double multiplier)
        {
            return Math.Round(multiplicand * multiplier, 2);
        }

        public double Divide(double dividend, double divisor)
        {
            double output = 0;

            if (divisor != 0)
            {
                output = dividend / divisor;
            }

            return Math.Round(output, 2);
        }
    }
}
