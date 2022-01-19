using System;
using System.Collections.Generic;
using IkiCore.Core;
namespace IkiCore.Mathematics
{
	public static partial class Math
    {
        public static bool Bool(this int a) => a > 0;
        public static bool Integer(this int a) => a > -1;
        public static bool IsEven(this int a) => (a & 0x1) == 0;
        public static bool IsPowerOfTwo(this int a) => a > 0x0 && (a & (a - 0x1)) == 0x0;
        public static int NaturalNumber(this int a) => a < 0 ? 0 : a;
        public static uint Average(this uint a, uint b) => (a & b) + ((a ^ b) >> 1);
        public static ulong Average(this ulong a, ulong b) => (a & b) + ((a ^ b) >> 1);
        public static bool Approximately(this float value, float value2, float precision = 0.000001f) => (value2 - value).Abs() <= precision;
        public static bool Approximately(this double value, double value2, double precision = 0.000001d) => (value2 - value).Abs() <= precision;
        public static float Repeat(this float t, float a) => (t - (float)System.Math.Floor(t / a) * a).Clamp(0f, a);
        public static double Repeat(this double t, double a) => (t - System.Math.Floor(t / a) * a).Clamp(0d, a);
        public static float OneMinus(this float a) => 1f - a;
        public static double OneMinus(this double a) => 1d - a;
        public static float MinusOnePowf(int pow) => (pow & 0x1) == 0 ? 1f : -1f;
        public static double MinusOnePow(int pow) => (pow & 0x1) == 0 ? 1d : -1d;
        public static int MinusOnePowi(this int power) => ((-1) & (((power & 0x1) << 31) >> 31)) | (1 & ~(((power & 0x1) << 31) >> 31));
        public static int MinusOnePowi(this long power) => (int)(((-1L) & (((power & 0x1) << 63) >> 63)) | (1L & ~(((power & 0x1L) << 63) >> 63)));
        public static int Negate(int x) => ~x + 1;
        public static int Clamp(this int a, int min, int max) => a < min ? min : a > max ? max : a;
        public static float Clamp(this float a, float min, float max) => a < min ? min : a > max ? max : a;
        public static double Clamp(this double a, double min, double max) => a < min ? min : a > max ? max : a;
        public static float ClampTheta(this float a, float min, float max) => (a.Sign() * (a.Abs() % MathConstf.Tau) - MathConstf.Pi).Clamp(min, max);
        public static double ClampTheta(this double a, double min, double max) => (a.Sign() * (a.Abs() % MathConst.Tau) - MathConst.Pi).Clamp(min, max);
        public static float ClampAngle_180(this float a, float min, float max) => (a.Sign() * (a.Abs() % 360f) - 180f).Clamp(min, max);
        public static double ClampAngle_180(this double a, double min, double max) => (a.Sign() * (a.Abs() % 360d) - 180d).Clamp(min, max);
        public static float Saturate(this float a) => a > 1f ? 1f : a < 0f ? 0f : a;
        public static double Saturate(this double a) => a > 1d ? 1d : a < 0d ? 0d : a;
        public static float Step(this float a, float x) => x >= a ? 1f : 0f;
        public static double Step(this double a, double x) => x >= a ? 1d : 0d;
        public static float RealPositive(this float a) => a < 0f ? 0f : a;
        public static double RealPositive(this double a) => a < 0d ? 0d : a;
        public static float GammaToLinearSpace(this float a) => (float)System.Math.Pow(a, 2.2f);
        public static double GammaToLinearSpace(this double a) => System.Math.Pow(a, 2.2d);
        public static float LinearSpaceToGamma(this float a) => (float)System.Math.Pow(a, 0.4545f);
        public static double LinearSpaceToGamma(this double a) => System.Math.Pow(a, 0.4545d);
        public static float Sign(this float a) => a < 0f ? -1f : a > 0f ? 1f : 0f;
        public static double Sign(this double a) => a < 0d ? -1d : a > 0d ? 1d : 0d;
        public static float Difference(this float a, float b) => (a - b).Abs();
        public static double Difference(this double a, double b) => (a - b).Abs();
        public static int Abs(this int number) => (number ^ (number >> 31)) - (number >> 31);
        public static long Abs(this long number) => (number ^ (number >> 63)) - (number >> 63);
        public static float Abs(this float a) => a < 0f ? -a : a;
        public static double Abs(this double a) => a < 0d ? -a : a;
        public static decimal Abs(this decimal a) => a < 0m ? -a : a;
        public static float Fract(this float a) => a - (float)System.Math.Floor(a);
        public static double Fract(this double a) => a - System.Math.Floor(a);
        public static float Floor(this float a) => (float)System.Math.Floor(a);
        public static double Floor(this double a) => System.Math.Floor(a);
        public static float Round(this float a) => (float)System.Math.Round(a);
        public static double Round(this double a) => System.Math.Round(a);
        public static float Ceil(this float a) => (float)System.Math.Ceiling(a);
        public static double Ceil(this double a) => System.Math.Ceiling(a);
        public static float Truncate(this float a) => (float)System.Math.Truncate(a);
        public static double Truncate(this double a) => System.Math.Truncate(a);
        public static float RoundToPointFive(this float a) => (float)System.Math.Floor(a * 2f) * 0.5f;
        public static double RoundToPointFive(this double a) => System.Math.Floor(a * 2f) * 0.5d;
        public static float Exp(this float a) => (float)System.Math.Exp(a);
        public static double Exp(this double a) => System.Math.Exp(a);
        public static float Ln(float a) => (float)System.Math.Log(a);
        public static float Lb(float a) => (float)System.Math.Log(a, 2.0);
        public static float Log(float a) => (float)System.Math.Log10(a);
        public static float Log(float a, float b) => (float)System.Math.Log(a, b);
        public static double Ln(double a) => System.Math.Log(a);
        public static double Lb(double a) => System.Math.Log(a, 2.0);
        public static double Log(double a) => System.Math.Log10(a);
        public static double Log(double a, double b) => System.Math.Log(a, b);
        public static double Pow(double a, long b)
        {
            if (b == 0L)
            {
                return 1.0;
            }
            bool negative = b < 0L;
            b = (b ^ (b >> 63)) - (b >> 63);
            double r = 1.0;
            while (b > 0L)
            {
                if ((b & 0x1L) == 0x1L)
                {
                    r *= a;
                }
                b >>= 1;
                a *= a;
            }
            return negative ? 1.0 / r : r;
        }
        public static long Pow(long a, long b)
        {
            if (b < 0L)
            {
                return 0L;
            }
            else if (b == 0L)
            {
                return 1L;
            }
            long r = 1L;
            while (b > 0L)
            {
                r *= (a & (((b & 0x1L) << 63) >> 63)) + (~b & 0x1L);
                b >>= 1;
                a *= a;
            }
            return r;
        }
        public static float Pow(this float a, float power) => (float)System.Math.Pow(a, power);
        public static double Pow(this double a, double power) => System.Math.Pow(a, power);
        public static int ATimesNegativeOnePowN(this int a, int power) => ((~a + 1) & (((power & 0x1) << 31) >> 31)) | (a & ~(((power & 0x1) << 31) >> 31));
        public static float Sqrt(this float a) => (float)System.Math.Sqrt(a);
        public static double Sqrt(this double a) => System.Math.Sqrt(a);
        public static float CRoot(this float value) => (float)System.Math.Pow(value, 0.33333333333333333333f);
        public static double CRoot(this double value) => System.Math.Pow(value, 0.33333333333333333333f);
        public static float Rsqrt(this float a) => (float)System.Math.Pow(a, -0.5);
        public static double Rsqrt(this double a) => System.Math.Pow(a, -0.5);
        public static float Root(this float a, float root) => (float)System.Math.Pow(a, 1f / root);
        public static double Root(this double a, double root) => System.Math.Pow(a, 1f / root);
        public static float Rroot(this float a, float root) => (float)System.Math.Pow(a, -1f / root);
        public static double Rroot(this double a, double root) => System.Math.Pow(a, -1f / root);
        public static int Remap(this int value, int minOldValue = 0, int maxOldValue = 1, int minNewValue = 0, int maxNewValue = 1) => minNewValue + (value - minOldValue) * (maxNewValue - minNewValue) / (maxOldValue - minOldValue);
        public static float Remap(this float value, float oldMinValue = 0f, float oldMaxValue = 1f, float newMinValue = 0f, float newMaxValue = 1f) => newMinValue + (value - oldMinValue) * (newMaxValue - newMinValue) / (oldMaxValue - oldMinValue);
        public static double Remap(this double value, double oldMinValue = 0d, double oldMaxValue = 1d, double newMinValue = 0d, double newMaxValue = 1d) => newMinValue + (value - oldMinValue) * (newMaxValue - newMinValue) / (oldMaxValue - oldMinValue);
        public static int Min(this int a, int b) => a > b ? b : a;
        public static float Min(this float a, float b) => a > b ? b : a;
        public static double Min(this double a, double b) => a > b ? b : a;
        public static int Max(this int a, int b) => a > b ? a : b;
        public static float Max(this float a, float b) => a > b ? a : b;
        public static double Max(this double a, double b) => a > b ? a : b;
        public static float Lerp(this float value, float end, float time) => value + (end - value) * time;
        public static double Lerp(this double value, double end, double time) => value + (end - value) * time;
        public static float Unlerp(this float a, float b, float t) => (t - a) / (b - a);
        public static double Unlerp(this double a, double b, double t) => (t - a) / (b - a);
        public static float LerpAngle(this float value, float end, float time)
        {
            float delta = (end - value).Repeat(360f);
            if (delta > 180f)
            {
                delta -= 360f;
            }
            return value + delta * time.Saturate();
        }
        public static double LerpAngle(this double value, double end, double time)
        {
            double delta = (end - value).Repeat(360d);
            if (delta > 180d)
            {
                delta -= 360d;
            }
            return value + delta * time.Saturate();
        }
        public static float SmoothStep(this float a, float from, float to)
        {
            a = (a - from) / (to - from);
            a = a < 0f ? 0f : a > 1f ? 1f : a;
            return a * a * (3f - 2f * a);
        }
        public static double SmoothStep(this double a, double from, double to)
        {
            a = (a - from) / (to - from);
            a = a < 0d ? 0d : a > 1d ? 1d : a;
            return a * a * (3d - 2d * a);
        }
        public static float SmootherStep(this float a, float from, float to)
        {
            a = (a - from) / (to - from);
            a = a < 0f ? 0f : a > 1f ? 1f : a;
            return a * a * a * (a * (a * 6f - 15f) + 10f);
        }
        public static double SmootherStep(this double a, double from, double to)
        {
            a = (a - from) / (to - from);
            a = a < 0d ? 0d : a > 1d ? 1d : a;
            return a * a * a * (a * (a * 6d - 15d) + 10d);
        }
        public static float Summation(int from, int to, Func<int, float> function)
        {
            if (from > to)
            {
                return 0f;
            }
            float result = 0f;
            while (from <= to)
            {
                result += function(from++);
            }
            return result;
        }
        public static float Summation_PlusMinus(int from, int to, Func<int, float, float> function)
        {
            if (from > to)
            {
                return 0f;
            }
            float result = 0f;
            float sign = 1f;
            while (from <= to)
            {
                result += function(from++, sign);
                sign *= -1f;
            }
            return result;
        }
        public static float Summation_MinusPlus(int from, int to, Func<int, float, float> function)
        {
            if (from > to)
            {
                return 0f;
            }
            float result = 0f;
            float sign = -1f;
            while (from <= to)
            {
                result += function(from++, sign);
                sign *= -1f;
            }
            return result;
        }
        public static double Summation(int from, int to, Func<int, double> function)
        {
            if (from > to)
            {
                return 0d;
            }
            double result = 0d;
            while (from <= to)
            {
                result += function(from++);
            }
            return result;
        }
        public static double Summation_PlusMinus(int from, int to, Func<int, double, double> function)
        {
            if (from > to)
            {
                return 0d;
            }
            double result = 0d;
            double sign = 1d;
            while (from <= to)
            {
                result += function(from++, sign);
                sign *= -1d;
            }
            return result;
        }
        public static double Summation_MinusPlus(int from, int to, Func<int, double, double> function)
        {
            if (from > to)
            {
                return 0d;
            }
            double result = 0d;
            double sign = -1d;
            while (from <= to)
            {
                result += function(from++, sign);
                sign *= -1d;
            }
            return result;
        }
        public static float Product(int from, int to, Func<int, float> function)
        {
            if(from > to)
            {
                return 0f;
            }
            float result = function(from++);
            while (from <= to)
            {
                result *= function(from++);
            }
            return result;
        }
        public static float Product_PlusMinus(int from, int to, Func<int, float, float> function)
        {
            if (from > to)
            {
                return 0f;
            }
            float sign = 1f;
            float result = function(from++, sign);
            while (from <= to)
            {
                sign *= -1f;
                result *= function(from++, sign);
            }
            return result;
        }
        public static float Product_MinusPlus(int from, int to, Func<int, float, float> function)
        {
            if (from > to)
            {
                return 0f;
            }
            float sign = -1f;
            float result = function(from++, sign);
            while (from <= to)
            {
                sign *= -1f;
                result *= function(from++, sign);
            }
            return result;
        }
        public static double LambertW(double x)
        {
            if (x < -Exp(-1))
            {
                throw new Exception("The Lambert W function is not defined for " + x + ".");
            }
            int amountOfIterations = Max(4, (int)Ceil(Log(x) / 3));
            double w = 3 * Log(x + 1) / 4;
            for (int i = 0; i < amountOfIterations; i++)
            {
                w -= (w * Exp(w) - x) / (Exp(w) * (w + 1) - (w + 2) * (w * Exp(w) - x) / (2 * w + 2));
            }
            return w;
        }
        public static double IteratedLogarithm(double n, double b)
        {
            double x = 0.0;
            while (n > 1.0)
            {
                x += 1.0;
                n = (int)(Log(n) / Log(b));
            }
            return x;
        }
        public static int Min(this int a, params int[] values)
        {
            int m = a;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < m)
                {
                    m = values[i];
                }
            }
            return m;
        }
        public static float Min(this float a, params float[] values)
        {
            float m = a;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < m)
                {
                    m = values[i];
                }
            }
            return m;
        }
        public static double Min(this double a, params double[] values)
        {
            double m = a;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < m)
                {
                    m = values[i];
                }
            }
            return m;
        }
        public static int Max(this int a, params int[] values)
        {
            int m = a;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > m)
                {
                    m = values[i];
                }
            }
            return m;
        }
        public static float Max(this float a, params float[] values)
        {
            float m = a;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > m)
                {
                    m = values[i];
                }
            }
            return m;
        }
        public static double Max(this double a, params double[] values)
        {
            double m = a;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > m)
                {
                    m = values[i];
                }
            }
            return m;
        }
        public static float MoveTowards(this float value, float target, float maxDelta)
        {
            if ((target - value).Abs() <= maxDelta)
            {
                return target;
            }
            return value + (target - value).Sign() * maxDelta;
        }
        public static double MoveTowards(this double value, double target, double maxDelta)
        {
            if ((target - value).Abs() <= maxDelta)
            {
                return target;
            }
            return value + (target - value).Sign() * maxDelta;
        }
        public static float MoveTowardsAngle(this float value, float target, float maxDelta)
        {
            float deltaAngle = value.DeltaAngle(target);
            if (-maxDelta < deltaAngle && deltaAngle < maxDelta)
            {
                return target;
            }
            target = value + deltaAngle;
            return value.MoveTowards(target, maxDelta);
        }
        public static double MoveTowardsAngle(this double value, double target, double maxDelta)
        {
            double deltaAngle = value.DeltaAngle(target);
            if (-maxDelta < deltaAngle && deltaAngle < maxDelta)
            {
                return target;
            }
            return value.MoveTowards(value + deltaAngle, maxDelta);
        }
        public static float Clerp_180(this float a, float b, float t)
        {
            if (b - a < -180.0f)
            {
                return a + ((360f - a + b) * t);
            }
            else if (b - a > 180.0f)
            {
                return a + (-(360f - b + a) * t);
            }
            return a + (b - a) * t;
        }
        public static double Clerp_180(this double a, double b, double t)
        {
            if (b - a < -180.0d)
            {
                return a + ((360d - a + b) * t);
            }
            else if (b - a > 180.0d)
            {
                return a + (-(360d - b + a) * t);
            }
            return a + (b - a) * t;
        }
        public static float DeltaAngle(this float current, float target)
        {
            current = target - current;
            current -= (float)System.Math.Floor(current / 360f) * 360f;
            current = current > 360f ? 360f : current < 0f ? 0f : current;
            return current > 180f ? current - 360f : current;
        }
        public static double DeltaAngle(this double current, double target)
        {
            current = target - current;
            current -= (float)System.Math.Floor(current / 360d) * 360d;
            current = current > 360d ? 360d : current < 0d ? 0d : current;
            return current > 180d ? current - 360d : current;
        }
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            target = current + DeltaAngle(current, target);
            smoothTime = 0.0001f > smoothTime ? 0.0001f : smoothTime;
            float omega = 2f / smoothTime;
            float x = omega * deltaTime;
            x = 1f / (1f + x + 0.48f * x * x + 0.235f * x * x * x);
            float change = current - target;
            float originalTo = target;
            float maxChange = maxSpeed * smoothTime;
            change = change < -maxChange ? -maxChange : change > maxChange ? maxChange : change;
            target = current - change;
            float temp = (currentVelocity + omega * change) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * x;
            float output = target + (change + temp) * x;
            if (originalTo - current > 0.0f == output > originalTo)
            {
                output = originalTo;
                currentVelocity = (output - originalTo) / deltaTime;
            }
            return output;
        }
        public static double SmoothDampAngle(double current, double target, ref double currentVelocity, double smoothTime, double maxSpeed, double deltaTime)
        {
            target = current + DeltaAngle(current, target);
            smoothTime = 0.0001d > smoothTime ? 0.0001d : smoothTime;
            double omega = 2d / smoothTime;
            double x = omega * deltaTime;
            x = 1d / (1d + x + 0.48d * x * x + 0.235d * x * x * x);
            double change = current - target;
            double originalTo = target;
            double maxChange = maxSpeed * smoothTime;
            change = change < -maxChange ? -maxChange : change > maxChange ? maxChange : change;
            target = current - change;
            double temp = (currentVelocity + omega * change) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * x;
            double output = target + (change + temp) * x;
            if (originalTo - current > 0.0d == output > originalTo)
            {
                output = originalTo;
                currentVelocity = (output - originalTo) / deltaTime;
            }
            return output;
        }
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            smoothTime = 0.0001f > smoothTime ? 0.0001f : smoothTime;
            float omega = 2f / smoothTime;
            float x = omega * deltaTime;
            x = 1f / (1f + x + 0.48f * x * x + 0.235f * x * x * x);
            float change = current - target;
            float originalTo = target;
            float maxChange = maxSpeed * smoothTime;
            change = change < -maxChange ? -maxChange : change > maxChange ? maxChange : change;
            target = current - change;
            float temp = (currentVelocity + omega * change) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * x;
            float output = target + (change + temp) * x;
            if (originalTo - current > 0.0f == output > originalTo)
            {
                output = originalTo;
                currentVelocity = (output - originalTo) / deltaTime;
            }
            return output;
        }
        public static double SmoothDamp(double current, double target, ref double currentVelocity, double smoothTime, double maxSpeed, double deltaTime)
        {
            smoothTime = 0.0001d > smoothTime ? 0.0001d : smoothTime;
            double omega = 2d / smoothTime;
            double x = omega * deltaTime;
            x = 1d / (1d + x + 0.48d * x * x + 0.235d * x * x * x);
            double change = current - target;
            double originalTo = target;
            double maxChange = maxSpeed * smoothTime;
            change = change < -maxChange ? -maxChange : change > maxChange ? maxChange : change;
            target = current - change;
            double temp = (currentVelocity + omega * change) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * x;
            double output = target + (change + temp) * x;
            if (originalTo - current > 0.0d == output > originalTo)
            {
                output = originalTo;
                currentVelocity = (output - originalTo) / deltaTime;
            }
            return output;
        }
        public static long[] GetPrimes(long min, long max)
        {
            if (min < 0L || max < 0L)
            {
                throw new Exception("Min or max can't be negative integers.");
            }
            min = min < 2L ? 2L : min;
            max = max < min ? min : max;
            List<long> allPrimes = new List<long>();
            if (min == 2L) // start at 2
            {
                min++;
                allPrimes.Add(2L);
            }
            else if ((min & 0x1L) != 0x1L) // is even
            {
                min++;
            }
            for (; min <= max; min += 2L)
            {
                if (IsPrime(min))
                {
                    allPrimes.Add(min);
                }
            }
            return allPrimes.ToArray();
        }
        public static (long, int)[] PrimeFactorisation(long number)
        {
            if(number == 0 || number == 1)
            {
                return new (long, int)[0];
            }
            number = Abs(number);
            long[] primes = GetPrimes(number);
            int i = primes.Length - 1;
            List<(long, int)> primeFactors = new List<(long, int)>();
            while (number != 1 && i >= 0)
            {
                if(number % primes[i] == 0)
                {
                    (long, int) n;
                    n.Item1 = primes[i];
                    n.Item2 = 0;
                    while (number % primes[i] == 0)
                    {
                        number /= primes[i];
                        n.Item2 += 1;
                    }
                    primeFactors.Add(n);
                }
                i--;
            }
            return primeFactors.ToArray();
        }
        public static long[] GetPrimes(long max)
        {
            if (max <= 0L)
            {
                max = -max;
            }
            if (max < 2L)
            {
                return new long[0];
            }
            List<long> allPrimes = new List<long>
            {
                2L
            };
            int i;
            bool hasFactor;
            for (long min = 3L; min <= max; min += 2L)
            {
                hasFactor = false;
                for (i = 1; i < allPrimes.Count; i++)
                {
                    if (min % allPrimes[i] == 0L)
                    {
                        hasFactor = true;
                        break;
                    }
                    if (allPrimes[i] * allPrimes[i] > min)
                    {
                        break;
                    }
                }
                if (!hasFactor)
                {
                    allPrimes.Add(min);
                }
            }
            return allPrimes.ToArray();
        }
        public static long GreatestCommonDivisor(long a, long b)
        {
            long remainder;
            while (b != 0L)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            return a < 0L ? -a : a;
        }
        public static long LeastCommonMultiple(long a, long b)
        {
            if ((a == 0L) || (b == 0L))
            {
                return 0L;
            }
            long val = (a / GreatestCommonDivisor(a, b)) * b;
            return val < 0L ? -val : val;
        }
        public static int PascalTriangle(this int a, int iterations)
        {
            int result = 1;
            for (int i = 0; i < iterations; ++i)
            {
                result *= (a - i) / (i + 1);
            }
            return result;
        }
        public static int[] DigitOfNumber(this int a)
        {
            a = a < 0 ? -a : a;
            if (a == 0)
            {
                return new int[] { 0 };
            }
            List<int> listOfInts = new List<int>();
            while (a > 0)
            {
                listOfInts.Add(a % 10);
                a = a / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
        public static bool IsPrime(this long a)
        {
            if (a <= 3L)
            {
                if (a < 0L)
                {
                    a = -a;
                }
                if (a <= 3L)
                {
                    return !(a <= 1L);
                }
            }
            if ((a & 0x1L) == 0L || a % 3L == 0L)
            {
                return false;
            }
            for (long i = 5L; i * i <= a; i += 6L)
            {
                if (a % i == 0L || a % (i + 2L) == 0L)
                {
                    return false;
                }
            }
            return true;
        }
        public static float2 QuadraticFormula(this float a, float b, float c)
        {
            a = (b * b - (4f * a * c)).Sqrt();
            float2 v;
            v.x = -b + a;
            v.y = -b - a;
            return v / (2f * a);
        }
        public static float Modulo(this float x, float y) => x - (float)System.Math.Floor(x / y) * y;
        public static double Modulo(this double x, double y) => x - System.Math.Floor(x / y) * y;
        public static float AbsSinFromCos(this float cos) => (float)System.Math.Sqrt(1.0f - cos * cos);
        public static float AbsCosFromSin(this float sin) => (float)System.Math.Sqrt(1.0f - sin * sin);
        public static double AbsSinFromCos(this double cos) => System.Math.Sqrt(1.0 - cos * cos);
        public static double AbsCosFromSin(this double sin) => System.Math.Sqrt(1.0 - sin * sin);
        public static float SinFromCosTheta(this float cos, float theta) => Sign(MathConstf.Pi - theta + (float)System.Math.Floor(theta / MathConstf.Tau) * MathConstf.Tau) * (float)System.Math.Sqrt(1.0f - cos * cos);
        public static float CosFromSinTheta(this float sin, float theta) => Sign(MathConstf.HalfPi - theta + (float)System.Math.Floor(theta / MathConstf.Tau + 0.25f) * MathConstf.Tau) * (float)System.Math.Sqrt(1.0f - sin * sin);
        public static double SinFromCosTheta(this double cos, double theta) => Sign(MathConst.Pi - theta + System.Math.Floor(theta / MathConst.Tau) * MathConst.Tau) * System.Math.Sqrt(1.0 - cos * cos);
        public static double CosFromSinTheta(this double sin, double theta) => Sign(MathConst.HalfPi - theta + System.Math.Floor(theta / MathConst.Tau + 0.25) * MathConst.Tau) * System.Math.Sqrt(1.0 - sin * sin);
    }
}
