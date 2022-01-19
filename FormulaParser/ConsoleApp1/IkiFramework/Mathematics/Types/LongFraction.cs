using System.Collections.Generic;

namespace IkiCore.Mathematics
{
    public struct LongFraction
    {
        long numerator;
        long denominator;
        public LongFraction(long numerator, long denominator)
        {
            if (denominator == 0L)
            {
                throw new System.DivideByZeroException();
            }
            if(numerator == 0L)
            {
                this.numerator = 0L;
                this.denominator = 1L;
            }
            else
            {
                if(denominator < 0)
                {
                    numerator = -numerator;
                    denominator = -denominator;
                }
                if(denominator == 1L)
                {
                    this.numerator = numerator;
                    this.denominator = 1L;
                }
                else if(numerator % denominator == 0L)
                {
                    this.numerator = numerator / denominator;
                    this.denominator = 1L;
                }
                else
                {
                    long div = Math.GreatestCommonDivisor(numerator, denominator);
                    this.numerator = numerator / div;
                    this.denominator = denominator / div;
                }
            }
        }
        public bool IsInteger => numerator % denominator == 0L;
        public double DoubleValue => numerator / (double)denominator;
        public long IntegerValue => numerator / denominator;
        public int Sign
        {
            get
            {
                if (numerator == 0)
                {
                    return 0;
                }
                else if ((numerator < 0 && denominator < 0) || (numerator > 0 && denominator > 0))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        public LongFraction Inverse => new LongFraction() { numerator = denominator, denominator = numerator };
        public long Floor
        {
            get
            {
                if (IsInteger)
                {
                    return numerator / denominator;
                }
                else
                {
                    switch(Sign)
                    {
                        case 1:
                            return IntegerValue;
                        case -1:
                            return IntegerValue - 1L;
                        default:
                            return 0L;
                    }
                }
            }
        }
        public long Ceil
        {
            get
            {
                if(IsInteger)
                {
                    return numerator / denominator;
                }
                else
                {
                    switch (Sign)
                    {
                        case 1:
                            return IntegerValue + 1L;
                        case -1:
                            return IntegerValue;
                        default:
                            return 0L;
                    }
                }
            }
        }
        public LongFraction AbsoluteValue => new LongFraction(numerator < 0L ? -numerator : numerator, denominator);
        public LongFraction Power(long power)
        {
            if(power == 0)
            {
                return new LongFraction() { numerator = 1L, denominator = 1L };
            }
            long num = 1L;
            long den = 1L;
            if(power > 0L)
            {
                while (power > 0L)
                {
                    num *= numerator;
                    den *= denominator;
                    power--;
                }
            }
            else
            {
                while (power < 0L)
                {
                    num *= denominator;
                    den *= numerator;
                    power++;
                }
            }
            return new LongFraction(num, den);
        }
        public LongFraction Power(LongFraction power) => Power(power.numerator).Root(power.denominator);
        public LongFraction Root(long root)
        {
            if (numerator < 0L)
            {
                throw new System.Exception("Unexpected power");
            }
            (long, long) top = Rooting(numerator, root);
            (long, long) bottom = Rooting(denominator, root);
            return new LongFraction(top.Item1, bottom.Item1) * new LongFraction((long)System.Math.Round(System.Math.Pow(top.Item2 / (double)bottom.Item2, 1.0 / root) * 100000000000.0), 100000000000);
        }
        public LongFraction Root(LongFraction power) => Root(power.numerator).Power(power.denominator);
        static (long, long) Rooting(long numerator, long root)
        {
            if(numerator < 0L)
            {
                throw new System.Exception("Unexpected complex root");
            }
            if(numerator == 1L || numerator == 0L)
            {
                return (numerator, 1L);
            }
            Dictionary<long, int> factors = new Dictionary<long, int>();
            while ((numerator & 1L) == 0L)
            {
                if (!factors.ContainsKey(2L))
                {
                    factors.Add(2L, 1);
                }
                else
                {
                    factors[2L] += 1;
                }
                numerator >>= 1;
            }
            long counter = 3L;
            while (numerator != 1L)
            {
                if (numerator % counter == 0L)
                {
                    if (!factors.ContainsKey(counter))
                    {
                        factors.Add(counter, 1);
                    }
                    else
                    {
                        factors[counter] += 1;
                    }
                    numerator /= counter;
                }
                else
                {
                    counter += 2L;
                }
            }
            long separated = 1L;
            long rooted = 1L;
            (long, long) kvp;
            foreach (var factor in factors)
            {
                kvp = (factor.Key, factor.Value);
                while(kvp.Item2 >= root)
                {
                    separated *= kvp.Item1;
                    kvp.Item2 -= root;
                }
                if(kvp.Item2 > 0L)
                {
                    rooted *= kvp.Item1 * kvp.Item2;
                }
            }
            return (separated, rooted);
        }
        public static LongFraction E => new LongFraction() { numerator = 7437374403113, denominator = 2736057139200 };
        public static LongFraction Pi => new LongFraction() { numerator = 1285290289249, denominator = 409120605684 };
        public string FractionString() => $"({numerator} / {denominator})";
        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
        public override string ToString() => IsInteger ? IntegerValue.ToString() : DoubleValue.ToString();
        public static bool operator ==(LongFraction x, LongFraction y) => x.numerator == y.numerator && x.denominator == y.denominator;
        public static bool operator !=(LongFraction x, LongFraction y) => !(x == y);
        public static bool operator <(LongFraction x, LongFraction y)
        {
            if (x.denominator == y.denominator)
            {
                return x.numerator < y.numerator;
            }
            else if (x.denominator == 1L)
            {
                return x.numerator * y.denominator < y.numerator;
            }
            else if (y.denominator == 1L)
            {
                return x.numerator < y.numerator * x.denominator;
            }
            else
            {
                long lcm = Math.LeastCommonMultiple(x.denominator, y.denominator);
                return x.numerator * (x.denominator > lcm ? x.denominator / lcm : lcm / x.denominator) < y.numerator * (y.denominator > lcm ? y.denominator / lcm : lcm / y.denominator);
            }
        }
        public static bool operator >(LongFraction x, LongFraction y)
        {
            if (x.denominator == y.denominator)
            {
                return x.numerator > y.numerator;
            }
            else if (x.denominator == 1L)
            {
                return x.numerator * y.denominator > y.numerator;
            }
            else if (y.denominator == 1L)
            {
                return x.numerator > y.numerator * x.denominator;
            }
            else
            {
                long lcm = Math.LeastCommonMultiple(x.denominator, y.denominator);
                return x.numerator * (x.denominator > lcm ? x.denominator / lcm : lcm / x.denominator) > y.numerator * (y.denominator > lcm ? y.denominator / lcm : lcm / y.denominator);
            }
        }
        public static bool operator <=(LongFraction x, LongFraction y)
        {
            if (x.denominator == y.denominator)
            {
                return x.numerator <= y.numerator;
            }
            else if (x.denominator == 1L)
            {
                return x.numerator * y.denominator <= y.numerator;
            }
            else if (y.denominator == 1L)
            {
                return x.numerator <= y.numerator * x.denominator;
            }
            else
            {
                long lcm = Math.LeastCommonMultiple(x.denominator, y.denominator);
                return x.numerator * (x.denominator > lcm ? x.denominator / lcm : lcm / x.denominator) <= y.numerator * (y.denominator > lcm ? y.denominator / lcm : lcm / y.denominator);
            }
        }
        public static bool operator >=(LongFraction x, LongFraction y)
        {
            if (x.denominator == y.denominator)
            {
                return x.numerator >= y.numerator;
            }
            else if (x.denominator == 1L)
            {
                return x.numerator * y.denominator >= y.numerator;
            }
            else if (y.denominator == 1L)
            {
                return x.numerator >= y.numerator * x.denominator;
            }
            else
            {
                long lcm = Math.LeastCommonMultiple(x.denominator, y.denominator);
                return x.numerator * (x.denominator > lcm ? x.denominator / lcm : lcm / x.denominator) >= y.numerator * (y.denominator > lcm ? y.denominator / lcm : lcm / y.denominator);
            }
        }
        public static LongFraction operator -(LongFraction x)
        {
            x.numerator = -x.numerator;
            x.denominator = -x.denominator;
            return x;
        }
        public static LongFraction operator +(LongFraction x, LongFraction y)
        {
            if(x.denominator == y.denominator)
            {
                return new LongFraction(x.numerator + y.numerator, x.denominator);
            }
            else if(x.denominator == 1L)
            {
                return new LongFraction(x.numerator * y.denominator + y.numerator, y.denominator);
            }
            else if(y.denominator == 1L)
            {
                return new LongFraction(x.numerator + y.numerator * x.denominator, x.denominator);
            }
            else
            {
                long lcm = Math.LeastCommonMultiple(x.denominator, y.denominator);
                return new LongFraction(x.numerator * (x.denominator > lcm ? x.denominator / lcm : lcm / x.denominator) + y.numerator * (y.denominator > lcm ? y.denominator / lcm : lcm / y.denominator), lcm);
            }
        }
        public static LongFraction operator +(int x, LongFraction y) => new LongFraction(x * y.denominator + y.numerator, y.denominator);
        public static LongFraction operator +(long x, LongFraction y) => new LongFraction(x * y.denominator + y.numerator, y.denominator);
        public static LongFraction operator +(LongFraction x, int y) => new LongFraction(x.numerator + y * x.denominator, x.denominator);
        public static LongFraction operator +(LongFraction x, long y) => new LongFraction(x.numerator + y * x.denominator, x.denominator);
        public static LongFraction operator -(LongFraction x, LongFraction y)
        {
            if (x.denominator == y.denominator)
            {
                return new LongFraction(x.numerator - y.numerator, x.denominator);
            }
            else if (x.denominator == 1L)
            {
                return new LongFraction(x.numerator * y.denominator - y.numerator, y.denominator);
            }
            else if (y.denominator == 1L)
            {
                return new LongFraction(x.numerator - y.numerator * x.denominator, x.denominator);
            }
            else
            {
                long lcm = Math.LeastCommonMultiple(x.denominator, y.denominator);
                return new LongFraction(x.numerator * (x.denominator > lcm ? x.denominator / lcm : lcm / x.denominator) - y.numerator * (y.denominator > lcm ? y.denominator / lcm : lcm / y.denominator), lcm);
            }
        }
        public static LongFraction operator -(int x, LongFraction y) => new LongFraction(x * y.denominator - y.numerator, y.denominator);
        public static LongFraction operator -(long x, LongFraction y) => new LongFraction(x * y.denominator - y.numerator, y.denominator);
        public static LongFraction operator -(LongFraction x, int y) => new LongFraction(x.numerator - y * x.denominator, x.denominator);
        public static LongFraction operator -(LongFraction x, long y) => new LongFraction(x.numerator - y * x.denominator, x.denominator);
        public static LongFraction operator *(LongFraction x, LongFraction y) => new LongFraction(x.numerator * y.numerator, x.denominator * y.denominator);
        public static LongFraction operator *(int x, LongFraction y) => new LongFraction(x * y.numerator, y.denominator);
        public static LongFraction operator *(long x, LongFraction y) => new LongFraction(x * y.numerator, y.denominator);
        public static LongFraction operator *(LongFraction x, int y) => new LongFraction(x.numerator * y, x.denominator);
        public static LongFraction operator *(LongFraction x, long y) => new LongFraction(x.numerator * y, x.denominator);
        public static LongFraction operator /(LongFraction x, LongFraction y) => x * y.Inverse;
        public static LongFraction operator /(int x, LongFraction y) => x * y.Inverse;
        public static LongFraction operator /(long x, LongFraction y) => x * y.Inverse;
        public static LongFraction operator /(LongFraction x, int y) => new LongFraction(x.numerator, x.denominator * y);
        public static LongFraction operator /(LongFraction x, long y) => new LongFraction(x.numerator, x.denominator * y);
        public static LongFraction operator %(LongFraction x, LongFraction y) => new LongFraction(x.numerator * y.denominator % (y.numerator * x.denominator), x.denominator * y.denominator);
        public static LongFraction operator %(int x, LongFraction y) => new LongFraction(x * y.denominator % y.denominator, y.denominator);
        public static LongFraction operator %(long x, LongFraction y) => new LongFraction(x * y.denominator % y.denominator, y.denominator);
        public static LongFraction operator %(LongFraction x, int y) => new LongFraction(x.numerator % (y * x.denominator), x.denominator);
        public static LongFraction operator %(LongFraction x, long y) => new LongFraction(x.numerator % (y * x.denominator), x.denominator);
    }
}
