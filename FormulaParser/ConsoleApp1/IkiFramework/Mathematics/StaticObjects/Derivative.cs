using System;
namespace IkiCore.Mathematics
{
    public static class Derivative
    {
        public static float GeneralApproximation(float x, Func<float, float> f, float dx = float.Epsilon) => (f(x + dx) - f(x - dx)) / (2.0f * dx);
        public static double GeneralApproximation(double x, Func<double, double> f, double dx = double.Epsilon) => (f(x + dx) - f(x - dx)) / (2.0d * dx);
    }
}
