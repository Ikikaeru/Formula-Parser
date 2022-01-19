using IkiCore.Core;
using System;
using System.Text;
namespace IkiCore.Mathematics
{
    /// <summary>
    /// Represent a pseudo-random number generator based on the Random from System but use some shortcut.
    /// </summary>
    public class PseudoRandom
    {
        readonly Random rnd;
        /// <summary>
        /// Initialize a new instance of the Random class using a time-dependant default seed.
        /// </summary>
        public PseudoRandom()
        {
            rnd = new Random();
        }
        /// <summary>
        /// Initialize a new instance of the Random class using a specified seed.
        /// </summary>
        public PseudoRandom(int seed)
        {
            rnd = new Random(seed);
        }
        /// <summary>
        /// Return a non negative random integer.
        /// </summary>
        /// <returns></returns>
        public int Int() => rnd.Next();
        /// <summary>
        /// Return a non-negative random integer that is less than the specified maximum.
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public int Int(int max) => rnd.Next(max);
        /// <summary>
        /// Return a non-negative random integer that is less or equal the specified maximum.
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public int IntInclusive(int max) => rnd.Next(max + 1);
        /// <summary>
        /// Return a specified random integer that greater or equal to the minimal value and less than the specified max value.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int Int(int min, int max) => rnd.Next(min, max);
        /// <summary>
        /// Return a specified random integer that greater or equal to the minimal value and less or equal than the specified max value.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int IntInclusive(int min, int max) => rnd.Next(min, max + 1);
        /// <summary>
        /// Return a floating point number that is greater than or equal to 0.0 and less than 1.0.
        /// </summary>
        /// <returns></returns>
        public float Float() => (float)rnd.NextDouble();
        /// <summary>
        /// Return a floating point number that is is between the specified maximal value and 0.0 but will never be the maximal value.
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public float Float(float max) => (float)rnd.NextDouble() * max;
        /// <summary>
        /// Return a floating point number that is is between the specified minimal and maximal value, but will never be equal to the maximal value.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public float Float(float min, float max) => min + (float)rnd.NextDouble() * (max - min);
        public float FloatInclusive() => (float)DoubleInclusive();
        public float FloatInclusive(float max) => (float)DoubleInclusive() * max;
        public float FloatInclusive(float min, float max) => min + (float)DoubleInclusive() * (max - min);
        /// <summary>
        /// Return a floating point number that is greater than or equal to 0.0 and less than 1.0.
        /// </summary>
        /// <returns></returns>
        public double Double() => rnd.NextDouble();
        /// <summary>
        /// Return a floating point number that is is between the specified maximal value and 0.0 but will never be the maximal value.
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public double Double(double max) => rnd.NextDouble() * max;
        /// <summary>
        /// Return a floating point number that is is between the specified minimal and maximal value, but will never be equal to the maximal value.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public double Double(double min, double max) => min + rnd.NextDouble() * (max - min);
        public double DoubleInclusive() => Math.Abs(rnd.NextDouble() * 2f - 1.0);
        public double DoubleInclusive(double max) => DoubleInclusive() * max;
        public double DoubleInclusive(double min, double max) => min + DoubleInclusive() * (max - min);
        public bool Bool(float percent = 0.5f)
        {
            if (percent <= 0f) return false;
            if (percent >= 1f) return true;
            return Float() < percent;
        }
        public bool Bool(double percent)
        {
            if (percent <= 0.0) return false;
            if (percent >= 1.0) return true;
            return Double() < percent;
        }
        public float3 Color()
        {
            float3 c;
            c.x = FloatInclusive();
            c.y = FloatInclusive();
            c.z = FloatInclusive();
            return c;
        }
        public char Character(string chars)
        {
            if (string.IsNullOrEmpty(chars))
            {
                throw new ArgumentException("Empty string");
            }
            return chars[Int(chars.Length)];
        }
        public string Characters(string chars, int length)
        {
            if (string.IsNullOrEmpty(chars))
            {
                throw new ArgumentException("Empty string");
            }
            var randomString = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                randomString.Append(chars[Int(chars.Length)]);
            }
            return randomString.ToString();
        }
        public float2 PointInUnitCircle() => PointOnUnitCircle() * FloatInclusive();
        public float2 PointInUnitSquare()
        {
            float2 v;
            v.x = FloatInclusive() * 2f - 1f;
            v.y = FloatInclusive() * 2f - 1f;
            return v;
        }
        public float3 PointInUnitCube()
        {
            float3 v;
            v.x = FloatInclusive() * 2f - 1f;
            v.y = FloatInclusive() * 2f - 1f;
            v.z = FloatInclusive() * 2f - 1f;
            return v;
        }
        public float3 PointInUnitSphere() => PointOnUnitSphere() * FloatInclusive();
        public float2 PointOnUnitCircle()
        {
            float2 v;
            v.x = 0f;
            v.y = 0f;
            while (v.x == 0f && v.y == 0f)
            {
                v.x = FloatInclusive() * 2f - 1f;
                v.y = FloatInclusive() * 2f - 1f;
            }
            return v.Normalized;
        }
        public float3 PointOnUnitSphere()
        {
            float3 v;
            v.x = 0f;
            v.y = 0f;
            v.z = 0f;
            while (v.x == 0f && v.y == 0f && v.z == 0f)
            {
                v.x = FloatInclusive() * 2f - 1f;
                v.y = FloatInclusive() * 2f - 1f;
                v.z = FloatInclusive() * 2f - 1f;
            }
            return v.Normalized;
        }
        public float2 PointOnUnitSquare()
        {
            float2 v;
            if (Bool()) // Horizontal
            {
                v.x = Bool() ? 1f : -1f;
                v.y = FloatInclusive() * 2f - 1f;
            }
            else // Vertical
            {
                v.x = FloatInclusive() * 2f - 1f;
                v.y = Bool() ? 1f : -1f;
            }
            return v;
        }
        public float3 PointOnUnitCube()
        {
            float3 v;
            if (Bool(0.3333333333333333f))
            {
                v.x = Bool() ? 1f : -1f;
                v.y = FloatInclusive() * 2f - 1f;
                v.z = FloatInclusive() * 2f - 1f;
            }
            else if (Bool(0.3333333333333333f))
            {
                v.x = FloatInclusive() * 2f - 1f;
                v.y = Bool() ? 1f : -1f;
                v.z = FloatInclusive() * 2f - 1f;
            }
            else
            {
                v.x = FloatInclusive() * 2f - 1f;
                v.y = FloatInclusive() * 2f - 1f;
                v.z = Bool() ? 1f : -1f;
            }
            return v;
        }
    }
}
