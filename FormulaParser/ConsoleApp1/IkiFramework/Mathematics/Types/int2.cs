using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct int2 : IEquatable<int2>
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public int x;
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public int y;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        [XmlIgnore]
        public int u
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        [XmlIgnore]
        public int v
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        [XmlIgnore]
        public int2 xx
        {
            get
            {
                int2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int2 uu
        {
            get
            {
                int2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int2 xy
        {
            get
            {
                int2 vec;
                vec.x = x;
                vec.y = y;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        [XmlIgnore]
        public int2 uv
        {
            get
            {
                int2 vec;
                vec.x = x;
                vec.y = y;
                return vec;
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        [XmlIgnore]
        public int2 yx
        {
            get
            {
                int2 vec;
                vec.x = y;
                vec.y = x;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
        [XmlIgnore]
        public int2 vu
        {
            get
            {
                int2 vec;
                vec.x = y;
                vec.y = x;
                return vec;
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
        [XmlIgnore]
        public int2 yy
        {
            get
            {
                int2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int2 vv
        {
            get
            {
                int2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xxx
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 uuu
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xxy
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 uuv
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xyx
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 uvu
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 xyy
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 uvv
        {
            get
            {
                int3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yxx
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 vuu
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yxy
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 vuv
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yyx
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 vvu
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 yyy
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int3 vvv
        {
            get
            {
                int3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxxx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 uuuu
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxxy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 uuuv
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxyx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 uuvu
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xxyy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 uuvv
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyxx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 uvuu
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyxy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 uvuv
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyyx
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 uvvu
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 xyyy
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 uvvv
        {
            get
            {
                int4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxxx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 vuuu
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxxy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 vuuv
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxyx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 vuvu
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yxyy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 vuvv
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyxx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 vvuu
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyxy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 vvuv
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyyx
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 vvvu
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 yyyy
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public int4 vvvv
        {
            get
            {
                int4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        /// <summary>
        /// Access the x or y component using [0] or [1] respectively.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [XmlIgnore]
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default:
                        throw new IndexOutOfRangeException("Invalid int2 index!");
                }
            }

            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid int2 index!");
                }
            }
        }
        /// <summary>
        /// Representation of 2D vectors and points.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public int2(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Set x and y components of an existing Vector2.
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        public void Set(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
        /// <summary>
        /// Multiplies two vectors component-wise.
        /// </summary>
        /// <param name="scale"></param>
        public void Scale(int2 scale)
        {
            x *= scale.x;
            y *= scale.y;
        }
        /// <summary>
        /// Returns a nicely formatted string for this vector.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("({0:F1}, {1:F1})", x, y);
        }
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ (y.GetHashCode() << 2);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (!(other is int2))
            {
                return false;
            }
            return Equals((int2)other);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(int2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }
        /// <summary>
        /// Returns the length of this vector.
        /// </summary>
        [XmlIgnore]
        public float Magnitude
        {
            get
            {
                return (float)System.Math.Sqrt(x * x + y * y);
            }
        }
        /// <summary>
        /// Returns the squared length of this vector.
        /// </summary>
        [XmlIgnore]
        public int SqrMagnitude
        {
            get
            {
                return x * x + y * y;
            }
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Distance(int2 a, int2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return (float)System.Math.Sqrt(a.x * a.x + a.y * a.y);
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int2 Min(int2 a, int2 b)
        {
            a.x = a.x > b.x ? b.x : a.x;
            a.y = a.y > b.y ? b.y : a.y;
            return a;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int2 Max(int2 a, int2 b)
        {
            a.x = a.x > b.x ? a.x : b.x;
            a.y = a.y > b.y ? a.y : b.y;
            return a;
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int2 Min(int2 b)
        {
            b.x = x > b.x ? b.x : x;
            b.y = y > b.y ? b.y : y;
            return b;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int2 Max(int2 b)
        {
            b.x = x > b.x ? x : b.x;
            b.y = y > b.y ? y : b.y;
            return b;
        }
        /// <summary>
        /// Clamp the vector between a min and a max value, then, return it.
        /// </summary>
        /// <param name="vec"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int2 Clamp(int min, int max)
        {
            int2 vec;
            vec.x = x > max ? max : x < min ? min : x;
            vec.y = y > max ? max : y < min ? min : y;
            return vec;
        }
        /// <summary>
        /// Clamp the vector between a min and a max value, then, return it.
        /// </summary>
        /// <param name="vec"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int2 Clamp(int2 min, int2 max)
        {
            int2 vec;
            vec.x = x > max.x ? max.x : x < min.x ? min.x : x;
            vec.y = y > max.y ? max.y : y < min.y ? min.y : y;
            return vec;
        }
        /// <summary>
        /// Convert a 2D position into a 1D
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static int Convert2DTo1DPosition(int2 pos, int width)
        {
            return pos.x + pos.y * width;
        }
        /// <summary>
        /// Convert a 2D position into a 1D
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public int Convert2DTo1DPosition(int width)
        {
            return x + y * width;
        }
        public static int2 operator -(int2 a)
        {
            a.x = -a.x;
            a.y = -a.y;
            return a;
        }
        public static int2 operator ~(int2 a)
        {
            a.x = ~a.x;
            a.y = ~a.y;
            return a;
        }
        public static int2 operator +(int2 a, int2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static float2 operator +(float2 a, int2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static float2 operator +(int2 a, float2 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static int2 operator +(int a, int2 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            return b;
        }
        public static int2 operator +(int2 a, int b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            return a;
        }
        public static float2 operator +(float a, int2 b)
        {
            float2 vec;
            vec.x = a + b.x;
            vec.y = a + b.y;
            return vec;
        }
        public static float2 operator +(int2 a, float b)
        {
            float2 vec;
            vec.x = a.x + b;
            vec.y = a.y + b;
            return vec;
        }
        public static int2 operator -(int2 a, int2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static float2 operator -(float2 a, int2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static float2 operator -(int2 a, float2 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static int2 operator -(int a, int2 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            return b;
        }
        public static int2 operator -(int2 a, int b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            return a;
        }
        public static float2 operator -(float a, int2 b)
        {
            float2 vec;
            vec.x = a - b.x;
            vec.y = a - b.y;
            return vec;
        }
        public static float2 operator -(int2 a, float b)
        {
            float2 vec;
            vec.x = a.x - b;
            vec.y = a.y - b;
            return vec;
        }
        public static int2 operator *(int2 a, int2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static float2 operator *(float2 a, int2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static float2 operator *(int2 a, float2 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static int2 operator *(int a, int2 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            return b;
        }
        public static int2 operator *(int2 a, int b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            return a;
        }
        public static float2 operator *(float a, int2 b)
        {
            float2 vec;
            vec.x = a * b.x;
            vec.y = a * b.y;
            return vec;
        }
        public static float2 operator *(int2 a, float b)
        {
            float2 vec;
            vec.x = a.x * b;
            vec.y = a.y * b;
            return vec;
        }
        public static int2 operator /(int2 a, int2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static float2 operator /(float2 a, int2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static float2 operator /(int2 a, float2 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static int2 operator /(int a, int2 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            return b;
        }
        public static int2 operator /(int2 a, int b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            return a;
        }
        public static float2 operator /(float a, int2 b)
        {
            float2 vec;
            vec.x = a / b.x;
            vec.y = a / b.y;
            return vec;
        }
        public static float2 operator /(int2 a, float b)
        {
            float2 vec;
            vec.x = a.x / b;
            vec.y = a.y / b;
            return vec;
        }
        public static int2 operator %(int2 a, int2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static float2 operator %(float2 a, int2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static float2 operator %(int2 a, float2 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static int2 operator %(int a, int2 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            return b;
        }
        public static int2 operator %(int2 a, int b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            return a;
        }
        public static float2 operator %(float a, int2 b)
        {
            float2 vec;
            vec.x = a % b.x;
            vec.y = a % b.y;
            return vec;
        }
        public static float2 operator %(int2 a, float b)
        {
            float2 vec;
            vec.x = a.x % b;
            vec.y = a.y % b;
            return vec;
        }
        public static int2 operator &(int2 a, int2 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            return a;
        }
        public static int2 operator &(int a, int2 b)
        {
            b.x = a & b.x;
            b.y = a & b.y;
            return b;
        }
        public static int2 operator &(int2 a, int b)
        {
            a.x = a.x & b;
            a.y = a.y & b;
            return a;
        }
        public static int2 operator ^(int2 a, int2 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            return a;
        }
        public static int2 operator ^(int a, int2 b)
        {
            b.x = a ^ b.x;
            b.y = a ^ b.y;
            return b;
        }
        public static int2 operator ^(int2 a, int b)
        {
            a.x = a.x ^ b;
            a.y = a.y ^ b;
            return a;
        }
        public static int2 operator >>(int2 a, int b)
        {
            a.x = a.x >> b;
            a.y = a.y >> b;
            return a;
        }
        public static int2 operator <<(int2 a, int b)
        {
            a.x = a.x << b;
            a.y = a.y << b;
            return a;
        }
        public static bool operator ==(int2 a, int2 b)
        {
            return a.x == b.x && a.y == b.y;
        }
        public static bool operator !=(int2 a, int2 b)
        {
            return a.x != b.x || a.y != b.y;
        }
        public static implicit operator int3(int2 v)
        {
            int3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0;
            return new int3(v.x, v.y);
        }
        public static implicit operator float2(int2 v)
        {
            float2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator float3(int2 v)
        {
            float3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0f;
            return vec;
        }
        public static implicit operator float4(int2 v)
        {
            float4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0f;
            vec.w = 0f;
            return vec;
        }
        public static explicit operator bool2(int2 v)
        {
            bool2 vec;
            vec.x = v.x != 0;
            vec.y = v.y != 0;
            return vec;
        }
        public static explicit operator bool3(int2 v)
        {
            bool3 vec;
            vec.x = v.x != 0;
            vec.y = v.y != 0;
            vec.z = false;
            return vec;
        }
        public static explicit operator bool4(int2 v)
        {
            bool4 vec;
            vec.x = v.x != 0;
            vec.y = v.y != 0;
            vec.z = false;
            vec.w = false;
            return vec;
        }
        public static implicit operator int4(int2 v)
        {
            int4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0;
            vec.w = 0;
            return vec;
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, 0).
        /// </summary>
        [XmlIgnore]
        public static int2 Zero
        {
            get
            {
                int2 vec;
                vec.x = 0;
                vec.y = 0;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(1, 1).
        /// </summary>
        [XmlIgnore]
        public static int2 One
        {
            get
            {
                int2 vec;
                vec.x = 1;
                vec.y = 1;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, 1).
        /// </summary>
        [XmlIgnore]
        public static int2 Up
        {
            get
            {
                int2 vec;
                vec.x = 0;
                vec.y = 1;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, -1).
        /// </summary>
        [XmlIgnore]
        public static int2 Down
        {
            get
            {
                int2 vec;
                vec.x = 0;
                vec.y = -1;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(-1, 0).
        /// </summary>
        [XmlIgnore]
        public static int2 Left
        {
            get
            {
                int2 vec;
                vec.x = -1;
                vec.y = 0;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(1, 0).
        /// </summary>
        [XmlIgnore]
        public static int2 Right
        {
            get
            {
                int2 vec;
                vec.x = 1;
                vec.y = 0;
                return vec;
            }
        }
    }
}
