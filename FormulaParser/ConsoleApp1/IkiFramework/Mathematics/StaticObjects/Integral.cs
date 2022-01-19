using System;
namespace IkiCore.Mathematics
{
    public static class Integral
    {
        public static double AntiDerivativeApproximation(double x, Func<double, double> f, int subdivision = 10)
        {
            if (subdivision <= 0)
            {
                subdivision = 1;
            }
            double result = 0.0;
            double offset = x / subdivision;
            for (int i = 0; i < subdivision; i++)
            {
                result += f(offset * i) * offset;
            }
            return result;
        }
        public static double GeneralApproximation(double a, double b, Func<double, double> f, int subdivision = 10)
        {
            if (subdivision <= 0)
            {
                subdivision = 1;
            }
            double result = 0.0;
            double offset = (b - a) / subdivision;
            for (int i = 0; i < subdivision; i++)
            {
                result += f(a + offset * i) * offset;
            }
            return result;
        }
    }
}
