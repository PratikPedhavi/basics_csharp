using System;

namespace operations
{
    public class operations
    {
        public static string Addition(double a, double b)
        {
            double result = a + b;
            return result.ToString();
        }

        public static double Squared(int number)
        {
            double result = Math.Pow(number,2);
            return result;
        }
    }
}