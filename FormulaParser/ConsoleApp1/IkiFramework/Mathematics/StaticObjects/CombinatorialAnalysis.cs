using System.Numerics;

namespace IkiCore.Mathematics
{
	public static class CombinatorialAnalysis
    {
        static internal long[] factorials = new long[]
        {
            1L,
            1L,
            2L,
            6L,
            24L,
            120L,
            720L,
            5040L,
            40320L,
            362880L,
            3628800L,
            39916800L,
            479001600L,
            6227020800L,
            87178291200L,
            1307674368000L,
            20922789888000L,
            355687428096000L,
            6402373705728000L,
            121645100408832000L,
            2432902008176640000L
        };
        static internal long[] doubleFactorials = new long[]
        {
            1L,
            1L,
            2L,
            3L,
            8L,
            15L,
            48L,
            105L,
            384L,
            945L,
            3840L,
            10395L,
            46080L,
            135135L,
            645120L,
            2027025L,
            10321920L,
            34459425L,
            185794560L,
            654729075L,
            3715891200L,
            13749310575L,
            81749606400L,
            316234143225L,
            1961990553600L,
            7905853580625L,
            51011754393600L,
            213458046676875L,
            1428329123020800L,
            6190283353629375L,
            42849873690624000L,
            191898783962510625L,
            1371195958099968000L,
            6332659870762850625L
        };
        static internal long[] subFactorial = new long[]
        {
            1L,
            0L,
            1L,
            2L,
            9L,
            44L,
            265L,
            1854L,
            14833L,
            133496L,
            1334961L,
            14684570L,
            176214841L,
            2290792932L,
            32071101049L,
            481066515734L,
            7697064251745L,
            130850092279674L,
            2355301661033976L,
            44750731559644712L,
            895014631192890880L
        };
        public static BigInteger BigFactorial(int x)
        {
            if (x <= 0)
            {
                return 1;
            }
            BigInteger a = new BigInteger(1);
            for (int i = 1; i <= x; i++)
            {
                a *= i;
            }
            return a;
        }
        public static BigInteger KFactorial(BigInteger x, int k)
        {
            if (x <= 0)
            {
                return 1;
            }
            return x * KFactorial(x - k, k);
        }
        public static BigInteger BinomialCoefficient(long n, long k)
        {
            long mid = n / 2;
            if (k > n)
            {
                throw new System.Exception("k can't be greater than n.");
            }
            if(k == n)
            {
                return 1;
            }
            if(k > mid)
            {
                BigInteger num = 1;
                BigInteger den = 1;
                for (long i = k + 1, j = 1; i <= n; i++, j++)
                {
                    num *= i;
                    den *= j;
                }
                return num / den;
            }
            else if(n % 2 == 0 && mid == k)
            {
                BigInteger num = 1;
                BigInteger den = 1;
                long i;
                for (i = 1; i <= mid; i++)
                {
                    den *= i;
                }
                for (; i <= n; i++)
                {
                    num *= i;
                }
                return num / den;
            }
            else
            {
                long nk = n - k;
                BigInteger num = 1;
                BigInteger den = 1;
                for (long i = nk + 1, j = 1; i <= n; i++, j++)
                {
                    num *= i;
                    den *= j;
                }
                return num / den;
            }
        }
        public static BigInteger StirlingSecondKind(int n, int k)
        {
            BigInteger result = new BigInteger(0);
            for (int i = 0; i <= k; i++)
            {
                result += Math.MinusOnePowi(k - i) * BinomialCoefficient(k, i) * Math.Pow(i, n);
            }
            return result / BigFactorial(k);
        }
        public static long DoubleFactorial(long a) => a < doubleFactorials.Length && a >= 0L ? doubleFactorials[a] : -1L;
        public static long SubFactorial(long a) => a < subFactorial.Length && a >= 0L ? subFactorial[a] : -1L;
        public static int Factorial(int x)
        {
            if (x >= 0 && x <= 12)
            {
                return (int)factorials[x];
            }
            return 0;
        }
        public static uint Factorial(uint x)
        {
            if (x <= 12u)
            {
                return (uint)factorials[x];
            }
            return 0u;
        }
        public static long Factorial(this long a)
        {
            if (a >= 0L && a <= 20L)
            {
                return factorials[a];
            }
            return 0L;
        }
        public static ulong Factorial(this ulong a)
        {
            if (a <= 20ul)
            {
                return (ulong)factorials[a];
            }
            return 0ul;
        }
        public static float Factorial(float a)
        {
            a += 1f;
            float s = 2.48574089138753565546e-5f;
            if (a < 0.5)
            {
                s += 1.05142378581721974210f / (1.0f - a);
                s += -3.45687097222016235469f / (2.0f - a);
                s += 4.51227709466894823700f / (3.0f - a);
                s += -2.98285225323576655721f / (4.0f - a);
                s += 1.05639711577126713077f / (5.0f - a);
                s += -1.95428773191645869583e-1f / (6.0f - a);
                s += 1.70970543404441224307e-2f / (7.0f - a);
                s += -5.71926117404305781283e-4f / (8.0f - a);
                s += 4.63399473359905636708e-6f / (9.0f - a);
                s += -2.71994908488607703910e-9f / (10.0f - a);
                return (float)(3.14159265358979323846264338327950288419716939937510582f / (System.Math.Sin(3.14159265358979323846264338327950288419716939937510582f * a) * s * 1.8603827342052657173362492472666631120594218414085755f * System.Math.Pow((a - 10.400511f) / 2.71828182845904523536028747135266249f, 0.5f - a)));
            }
            else
            {
                s += 1.05142378581721974210f / a;
                s += -3.45687097222016235469f / (a + 1.0f);
                s += 4.51227709466894823700f / (a + 2.0f);
                s += -2.98285225323576655721f / (a + 3.0f);
                s += 1.05639711577126713077f / (a + 4.0f);
                s += -1.95428773191645869583e-1f / (a + 5.0f);
                s += 1.70970543404441224307e-2f / (a + 6.0f);
                s += -5.71926117404305781283e-4f / (a + 7.0f);
                s += 4.63399473359905636708e-6f / (a + 8.0f);
                s += -2.71994908488607703910e-9f / (a + 9.0f);
                return (float)(s * 1.8603827342052657173362492472666631120594218414085755f * System.Math.Pow((a + 10.400511f) / 2.71828182845904523536028747135266249f, a - 0.5f));
            }
        }
        public static double Factorial(double a)
        {
            a += 1d;
            double s = 2.48574089138753565546e-5;
            if (a < 0.5)
            {
                s += 1.05142378581721974210 / (1.0 - a);
                s += -3.45687097222016235469 / (2.0 - a);
                s += 4.51227709466894823700 / (3.0 - a);
                s += -2.98285225323576655721 / (4.0 - a);
                s += 1.05639711577126713077 / (5.0 - a);
                s += -1.95428773191645869583e-1 / (6.0 - a);
                s += 1.70970543404441224307e-2 / (7.0 - a);
                s += -5.71926117404305781283e-4 / (8.0 - a);
                s += 4.63399473359905636708e-6 / (9.0 - a);
                s += -2.71994908488607703910e-9 / (10.0 - a);
                return 3.14159265358979323846264338327950288419716939937510582d / (System.Math.Sin(3.14159265358979323846264338327950288419716939937510582d * a) * s * 1.8603827342052657173362492472666631120594218414085755 * System.Math.Pow((a - 10.400511) / 2.71828182845904523536028747135266249, 0.5 - a));
            }
            else
            {
                s += 1.05142378581721974210 / a;
                s += -3.45687097222016235469 / (a + 1.0);
                s += 4.51227709466894823700 / (a + 2.0);
                s += -2.98285225323576655721 / (a + 3.0);
                s += 1.05639711577126713077 / (a + 4.0);
                s += -1.95428773191645869583e-1 / (a + 5.0);
                s += 1.70970543404441224307e-2 / (a + 6.0);
                s += -5.71926117404305781283e-4 / (a + 7.0);
                s += 4.63399473359905636708e-6 / (a + 8.0);
                s += -2.71994908488607703910e-9 / (a + 9.0);
                return s * 1.8603827342052657173362492472666631120594218414085755 * System.Math.Pow((a + 10.400511) / 2.71828182845904523536028747135266249, a - 0.5);
            }
        }
        public static int FallingFactorial(int a, int raised)
        {
            if (raised <= 0)
            {
                return 1;
            }
            if (raised == 1)
            {
                return a;
            }
            return (a - raised) * FallingFactorial(a, raised - 1);
        }
        public static uint FallingFactorial(uint a, uint raised)
        {
            if (raised == 0u)
            {
                return 1u;
            }
            if (raised == 1u)
            {
                return a;
            }
            return (a - raised) * FallingFactorial(a, raised - 1u);
        }
        public static long FallingFactorial(long a, long raised)
        {
            if (raised <= 0L)
            {
                return 1L;
            }
            if (raised == 1L)
            {
                return a;
            }
            return (a - raised) * FallingFactorial(a, raised - 1L);
        }
        public static ulong FallingFactorial(ulong a, ulong raised)
        {
            if (raised == 0ul)
            {
                return 1ul;
            }
            if (raised == 1ul)
            {
                return a;
            }
            return (a - raised) * FallingFactorial(a, raised - 1ul);
        }
        public static float FallingFactorial(float a, int raised)
        {
            if (raised <= 0)
            {
                return 1f;
            }
            if (raised == 1)
            {
                return a;
            }
            return (a - raised) * FallingFactorial(a, raised - 1);
        }
        public static double FallingFactorial(double a, long raised)
        {
            if (raised <= 0L)
            {
                return 1d;
            }
            if (raised == 1L)
            {
                return a;
            }
            return (a - raised) * FallingFactorial(a, raised - 1L);
        }
        public static int RisingFactorial(int a, int raised)
        {
            if (raised <= 0)
            {
                return 1;
            }
            if (raised == 1)
            {
                return a;
            }
            return (a + raised) * RisingFactorial(a, raised - 1);
        }
        public static uint RisingFactorial(uint a, uint raised)
        {
            if (raised == 0u)
            {
                return 1u;
            }
            if (raised == 1u)
            {
                return a;
            }
            return (a + raised) * RisingFactorial(a, raised - 1u);
        }
        public static long RisingFactorial(long a, long raised)
        {
            if (raised <= 0L)
            {
                return 1L;
            }
            if (raised == 1L)
            {
                return a;
            }
            return (a + raised) * RisingFactorial(a, raised - 1L);
        }
        public static ulong RisingFactorial(ulong a, ulong raised)
        {
            if(raised == 0ul)
            {
                return 1ul;
            }
            if(raised == 1ul)
            {
                return a;
            }
            return (a + raised) * RisingFactorial(a, raised - 1ul);
        }
        public static float RisingFactorial(float a, int raised)
        {
            if (raised <= 0)
            {
                return 1f;
            }
            if (raised == 1)
            {
                return a;
            }
            return (a + raised) * RisingFactorial(a, raised - 1);
        }
        public static double RisingFactorial(double a, long raised)
        {
            if (raised <= 0L)
            {
                return 1d;
            }
            if (raised == 1L)
            {
                return a;
            }
            return (a + raised) * RisingFactorial(a, raised - 1L);
        }

        // TO CHECK LATER
        public static double SimpleArrangement(long elements, long arrangement)
        {
            return Factorial((double)arrangement) / Factorial((double)(arrangement - elements));
        }
        public static double RepeatedArrangement(long elements, long arrangement)
        {
            return ((double)elements).Pow(arrangement);
        }
        public static double SimpleDisturbance(long elements)
        {
            double summation = 0d;
            for (long i = 0; i < elements; i++)
            {
                summation += i % 2 * -1d / Factorial((double)i);
            }
            return Factorial((double)elements) * summation;
        }
        public static double SimpleCombinations(long combinations, long totalCombinations)
        {
            return Factorial((double)totalCombinations) / (combinations * Factorial(totalCombinations - (double)combinations));
        }
        public static double RepeatedCombinations(long combinations, long totalCombinations)
        {
            return Factorial((double)(totalCombinations + combinations - 1)) / (Factorial((double)combinations) * Factorial((double)(totalCombinations - 1)));
        }
        public static double SimplePermutation(long elements)
        {
            return Factorial((double)elements);
        }
        public static double RepeatedPermutation(long totalElements, long[] sameArrangement)
        {
            double value = 0d;
            for (int i = 0; i < sameArrangement.Length; i++)
            {
                value += Factorial((double)(sameArrangement[i]));
            }
            return Factorial((double)totalElements) / value;
        }
    }
}
