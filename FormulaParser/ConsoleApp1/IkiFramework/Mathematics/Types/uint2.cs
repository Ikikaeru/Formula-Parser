using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct uint2 : IEquatable<uint2>
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public uint x;
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public uint y;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        [XmlIgnore]
        public uint u
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
        public uint v
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
        public uint2 xx
        {
            get
            {
                uint2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint2 uu
        {
            get
            {
                uint2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint2 xy
        {
            get
            {
                uint2 vec;
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
        public uint2 uv
        {
            get
            {
                uint2 vec;
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
        public uint2 yx
        {
            get
            {
                uint2 vec;
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
        public uint2 vu
        {
            get
            {
                uint2 vec;
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
        public uint2 yy
        {
            get
            {
                uint2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint2 vv
        {
            get
            {
                uint2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xxx
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 uuu
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xxy
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 uuv
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xyx
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 uvu
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 xyy
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 uvv
        {
            get
            {
                uint3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yxx
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 vuu
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yxy
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 vuv
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yyx
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 vvu
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 yyy
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint3 vvv
        {
            get
            {
                uint3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxxx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 uuuu
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxxy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 uuuv
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxyx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 uuvu
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xxyy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 uuvv
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyxx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 uvuu
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyxy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 uvuv
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyyx
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 uvvu
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 xyyy
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 uvvv
        {
            get
            {
                uint4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxxx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 vuuu
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxxy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 vuuv
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxyx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 vuvu
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yxyy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 vuvv
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyxx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 vvuu
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyxy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 vvuv
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyyx
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 vvvu
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 yyyy
        {
            get
            {
                uint4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public uint4 vvvv
        {
            get
            {
                uint4 vec;
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
        public uint this[uint index]
        {
            get
            {
                switch (index)
                {
                    case 0u: return x;
                    case 1u: return y;
                    default:
                        throw new IndexOutOfRangeException("Invalid uint2 index!");
                }
            }

            set
            {
                switch (index)
                {
                    case 0u: x = value; break;
                    case 1u: y = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid uint2 index!");
                }
            }
        }
        /// <summary>
        /// Representation of 2D vectors and pouints.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public uint2(uint x = 0u, uint y = 0u)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Set x and y components of an existing Vector2.
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        public void Set(uint newX, uint newY)
        {
            x = newX;
            y = newY;
        }
        /// <summary>
        /// Multiplies two vectors component-wise.
        /// </summary>
        /// <param name="scale"></param>
        public void Scale(uint2 scale)
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
            if (!(other is uint2))
            {
                return false;
            }
            return Equals((uint2)other);
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(uint2 other)
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
        public uint SqrMagnitude
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
        public static float Distance(uint2 a, uint2 b)
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
        public static uint2 Min(uint2 a, uint2 b)
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
        public static uint2 Max(uint2 a, uint2 b)
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
        public uint2 Min(uint2 b)
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
        public uint2 Max(uint2 b)
        {
            b.x = x > b.x ? x : b.x;
            b.y = y > b.y ? y : b.y;
            return b;
        }
        /// <summary>
        /// Return the indexed position of a 2D Vector in a grid depending a certain width.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="width">Width of the grid.</param>
        /// <returns></returns>
        public uint GridToPouint(uint width)
        {
            return x + (width * y);
        }
        /// <summary>
        /// Clamp the vector between a min and a max value, then, return it.
        /// </summary>
        /// <param name="vec"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public uint2 Clamp(uint min, uint max)
        {
            uint2 vec;
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
        public uint2 Clamp(uint2 min, uint2 max)
        {
            uint2 vec;
            vec.x = x > max.x ? max.x : x < min.x ? min.x : x;
            vec.y = y > max.y ? max.y : y < min.y ? min.y : y;
            return vec;
        }
        public static uint2 operator ~(uint2 a)
        {
            a.x = ~a.x;
            a.y = ~a.y;
            return a;
        }
        public static uint2 operator +(uint2 a, uint2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static float2 operator +(float2 a, uint2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static float2 operator +(uint2 a, float2 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return b;
        }
        public static uint2 operator +(uint a, uint2 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            return b;
        }
        public static uint2 operator +(uint2 a, uint b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            return a;
        }
        public static float2 operator +(float a, uint2 b)
        {
            float2 vec;
            vec.x = a + b.x;
            vec.y = a + b.y;
            return vec;
        }
        public static float2 operator +(uint2 a, float b)
        {
            float2 vec;
            vec.x = a.x + b;
            vec.y = a.y + b;
            return vec;
        }
        public static uint2 operator -(uint2 a, uint2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static float2 operator -(float2 a, uint2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static float2 operator -(uint2 a, float2 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static uint2 operator -(uint a, uint2 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            return b;
        }
        public static uint2 operator -(uint2 a, uint b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            return a;
        }
        public static float2 operator -(float a, uint2 b)
        {
            float2 vec;
            vec.x = a - b.x;
            vec.y = a - b.y;
            return vec;
        }
        public static float2 operator -(uint2 a, float b)
        {
            float2 vec;
            vec.x = a.x - b;
            vec.y = a.y - b;
            return vec;
        }
        public static uint2 operator *(uint2 a, uint2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static float2 operator *(float2 a, uint2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static float2 operator *(uint2 a, float2 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return b;
        }
        public static uint2 operator *(uint a, uint2 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            return b;
        }
        public static uint2 operator *(uint2 a, uint b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            return a;
        }
        public static float2 operator *(float a, uint2 b)
        {
            float2 vec;
            vec.x = a * b.x;
            vec.y = a * b.y;
            return vec;
        }
        public static float2 operator *(uint2 a, float b)
        {
            float2 vec;
            vec.x = a.x * b;
            vec.y = a.y * b;
            return vec;
        }
        public static uint2 operator /(uint2 a, uint2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static float2 operator /(float2 a, uint2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static float2 operator /(uint2 a, float2 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return b;
        }
        public static uint2 operator /(uint a, uint2 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            return b;
        }
        public static uint2 operator /(uint2 a, uint b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            return a;
        }
        public static float2 operator /(float a, uint2 b)
        {
            float2 vec;
            vec.x = a / b.x;
            vec.y = a / b.y;
            return vec;
        }
        public static float2 operator /(uint2 a, float b)
        {
            float2 vec;
            vec.x = a.x / b;
            vec.y = a.y / b;
            return vec;
        }
        public static uint2 operator %(uint2 a, uint2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static float2 operator %(float2 a, uint2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static float2 operator %(uint2 a, float2 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static uint2 operator %(uint a, uint2 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            return b;
        }
        public static uint2 operator %(uint2 a, uint b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            return a;
        }
        public static float2 operator %(float a, uint2 b)
        {
            float2 vec;
            vec.x = a % b.x;
            vec.y = a % b.y;
            return vec;
        }
        public static float2 operator %(uint2 a, float b)
        {
            float2 vec;
            vec.x = a.x % b;
            vec.y = a.y % b;
            return vec;
        }
        public static uint2 operator &(uint2 a, uint2 b)
        {
            a.x = a.x & b.x;
            a.y = a.y & b.y;
            return a;
        }
        public static uint2 operator &(uint a, uint2 b)
        {
            b.x = a & b.x;
            b.y = a & b.y;
            return b;
        }
        public static uint2 operator &(uint2 a, uint b)
        {
            a.x = a.x & b;
            a.y = a.y & b;
            return a;
        }
        public static uint2 operator ^(uint2 a, uint2 b)
        {
            a.x = a.x ^ b.x;
            a.y = a.y ^ b.y;
            return a;
        }
        public static uint2 operator ^(uint a, uint2 b)
        {
            b.x = a ^ b.x;
            b.y = a ^ b.y;
            return b;
        }
        public static uint2 operator ^(uint2 a, uint b)
        {
            a.x = a.x ^ b;
            a.y = a.y ^ b;
            return a;
        }
        public static uint2 operator >>(uint2 a, int b)
        {
            a.x = a.x >> b;
            a.y = a.y >> b;
            return a;
        }
        public static uint2 operator <<(uint2 a, int b)
        {
            a.x = a.x << b;
            a.y = a.y << b;
            return a;
        }
        public static bool operator ==(uint2 a, uint2 b)
        {
            return a.x == b.x && a.y == b.y;
        }
        public static bool operator !=(uint2 a, uint2 b)
        {
            return a.x != b.x || a.y != b.y;
        }
        public static implicit operator int2(uint2 v)
        {
            int2 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            return vec;
        }
        public static implicit operator int3(uint2 v)
        {
            int3 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = 0;
            return vec;
        }
        public static implicit operator int4(uint2 v)
        {
            int4 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = 0;
            vec.w = 0;
            return vec;
        }
        public static implicit operator uint3(uint2 v)
        {
            uint3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0u;
            return vec;
        }
        public static implicit operator uint4(uint2 v)
        {
            uint4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0u;
            vec.w = 0u;
            return vec;
        }
        public static implicit operator float2(uint2 v)
        {
            float2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator float3(uint2 v)
        {
            float3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0f;
            return vec;
        }
        public static implicit operator float4(uint2 v)
        {
            float4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0f;
            vec.w = 0f;
            return vec;
        }
        public static implicit operator double2(uint2 v)
        {
            double2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        public static implicit operator double3(uint2 v)
        {
            double3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0d;
            return vec;
        }
        public static implicit operator double4(uint2 v)
        {
            double4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0d;
            vec.w = 0d;
            return vec;
        }
        public static explicit operator bool2(uint2 v)
        {
            bool2 vec;
            vec.x = v.x != 0u;
            vec.y = v.y != 0u;
            return vec;
        }
        public static explicit operator bool3(uint2 v)
        {
            bool3 vec;
            vec.x = v.x != 0u;
            vec.y = v.y != 0u;
            vec.z = false;
            return vec;
        }
        public static explicit operator bool4(uint2 v)
        {
            bool4 vec;
            vec.x = v.x != 0u;
            vec.y = v.y != 0u;
            vec.z = false;
            vec.w = false;
            return vec;
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, 0).
        /// </summary>
        [XmlIgnore]
        public static uint2 Zero
        {
            get
            {
                uint2 vec;
                vec.x = 0u;
                vec.y = 0u;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(1, 1).
        /// </summary>
        [XmlIgnore]
        public static uint2 One
        {
            get
            {
                uint2 vec;
                vec.x = 1u;
                vec.y = 1u;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, 1).
        /// </summary>
        [XmlIgnore]
        public static uint2 Up
        {
            get
            {
                uint2 vec;
                vec.x = 0u;
                vec.y = 1u;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(1, 0).
        /// </summary>
        [XmlIgnore]
        public static uint2 Right
        {
            get
            {
                uint2 vec;
                vec.x = 1u;
                vec.y = 0u;
                return vec;
            }
        }
    }
}
