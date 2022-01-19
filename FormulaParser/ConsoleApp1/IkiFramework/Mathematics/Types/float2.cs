using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct float2 : IEquatable<float2>
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public float x;
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public float y;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        [XmlIgnore]
        public float u
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
        public float v
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
        public float2 xx
        {
            get
            {
                float2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float2 uu
        {
            get
            {
                float2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float2 xy
        {
            get
            {
                float2 vec;
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
        public float2 uv
        {
            get
            {
                float2 vec;
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
        public float2 yx
        {
            get
            {
                float2 vec;
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
        public float2 vu
        {
            get
            {
                float2 vec;
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
        public float2 yy
        {
            get
            {
                float2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float2 vv
        {
            get
            {
                float2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xxx
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 uuu
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xxy
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 uuv
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xyx
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 uvu
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 xyy
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 uvv
        {
            get
            {
                float3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yxx
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 vuu
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yxy
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 vuv
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yyx
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 vvu
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 yyy
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float3 vvv
        {
            get
            {
                float3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxxx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 uuuu
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxxy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 uuuv
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxyx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 uuvu
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xxyy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 uuvv
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyxx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 uvuu
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyxy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 uvuv
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyyx
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 uvvu
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 xyyy
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 uvvv
        {
            get
            {
                float4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxxx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 vuuu
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxxy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 vuuv
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxyx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 vuvu
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yxyy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 vuvv
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyxx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 vvuu
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyxy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 vvuv
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyyx
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 vvvu
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 yyyy
        {
            get
            {
                float4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public float4 vvvv
        {
            get
            {
                float4 vec;
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
        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default:
                        throw new IndexOutOfRangeException("Invalid Float2 index!");
                }
            }

            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid Float2 index!");
                }
            }
        }
        /// <summary>
        /// Representation of 2D vectors and points.
        /// </summary>
        /// <param name="xy"></param>
        public float2(float xy)
        {
            x = xy;
            y = xy;
        }
        /// <summary>
        /// Representation of 2D vectors and points.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public float2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Set x and y components of an existing Vector2.
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        public void Set(float newX, float newY)
        {
            x = newX;
            y = newY;
        }
        /// <summary>
        /// Returns the direction of b from a.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float2 Direction(float2 a, float2 b)
        {
            float2 dir;
            dir.x = b.x - a.x;
            dir.y = b.y - a.y;
            float mag = Mathematics.Math.Sqrt(dir.x * dir.x + dir.y * dir.y);
            if (mag > 0.00001f)
            {
                dir.x = dir.x / mag;
                dir.y = dir.y / mag;
                return dir;
            }
            dir.x = 0f;
            dir.y = 0f;
            return dir;
        }
        /// <summary>
        /// Linearly interpolates between vectors a and b by t.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float2 Lerp(float2 a, float2 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            return a;
        }
        /// <summary>
        /// Linearly interpolates between vectors a and b by t.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float2 Lerp(float2 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            return b;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float2 Nlerp(float2 a, float2 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            float mag = Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y);
            if (mag > 0.00001f)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
            }
            else
            {
                a.x = 0f;
                a.y = 0f;
            }
            return a;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float2 Nlerp(float2 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            float mag = Mathematics.Math.Sqrt(b.x * b.x + b.y * b.y);
            if (mag > 0.00001f)
            {
                b.x = b.x / mag;
                b.y = b.y / mag;
            }
            else
            {
                b.x = 0f;
                b.y = 0f;
            }
            return b;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float2 Unlerp(float2 a, float2 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            a.x = (t - a.x) / (b.x - a.x);
            a.y = (t - a.y) / (b.y - a.y);
            return a;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float2 Unlerp(float2 b, float t)
        {
            t = t < 0f ? 0f : t > 1f ? 1f : t;
            b.x = (t - x) / (b.x - x);
            b.y = (t - y) / (b.y - y);
            return b;
        }
        /// <summary>
        /// Lerp a value between a and c, using b as the bezier between a and c.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float2 QuadraticBezier(float2 a, float2 b, float2 c, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float oneMinusT = 1f - t;
            a.x = oneMinusT * oneMinusT * a.x + 2f * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2f * oneMinusT * t * b.y + t * t * c.y;
            return a;
        }
        /// <summary>
        /// Return the tangent of the quadratic bezier curve.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float2 QuadraticBezierTangent(float2 a, float2 b, float2 c, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            a.x = 2f * (1f - t) * (b.x - a.x) + 2f * t * (c.x - b.x);
            a.y = 2f * (1f - t) * (b.y - a.y) + 2f * t * (c.y - b.y);
            return a;
        }
        /// <summary>
        /// Lerp a value between a and d, using b as the bezier of a and c as the bezier of c.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static float2 CubicBezier(float2 a, float2 b, float2 c, float2 d, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float oneMinusT = 1f - t;
            float oneMinusTPow2 = oneMinusT * oneMinusT;
            float t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3f * oneMinusTPow2 * t * b.x + 3f * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3f * oneMinusTPow2 * t * b.y + 3f * oneMinusT * t2 * c.y + t2 * t * d.y;
            return a;
        }
        /// <summary>
        /// Return the tangent of the cubic bezier curve.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static float2 CubicBezierTrangent(float2 a, float2 b, float2 c, float2 d, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
            float oneMinusT = 1f - t;
            a.x = 3f * oneMinusT * oneMinusT * (b.x - a.x) + 6f * oneMinusT * t * (c.x - b.x) + 3f * t * t * (d.x - c.x);
            a.y = 3f * oneMinusT * oneMinusT * (b.y - a.y) + 6f * oneMinusT * t * (c.y - b.y) + 3f * t * t * (d.y - c.y);
            return a;
        }
        /// <summary>
        /// Linearly interpolates between vectors a and b by t.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float2 LerpUnclamped(float2 a, float2 b, float t)
        {
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            return a;
        }
        /// <summary>
        /// Normalize a value t to a range a - b. The opposite of lerp.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float2 UnlerpUnclamped(float2 b, float t)
        {
            b.x = (t - x) / (b.x - x);
            b.y = (t - y) / (b.y - y);
            return b;
        }
        /// <summary>
        /// Lerp a value between a and c, using b as the bezier between a and c.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float2 QuadraticBezierUnclamped(float2 a, float2 b, float2 c, float t)
        {
            float oneMinusT = 1f - t;
            a.x = oneMinusT * oneMinusT * a.x + 2f * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2f * oneMinusT * t * b.y + t * t * c.y;
            return a;
        }
        /// <summary>
        /// Return the tangent of the quadratic bezier curve.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static float2 QuadraticBezierTangentUnclamped(float2 a, float2 b, float2 c, float t)
        {
            a.x = 2f * (1f - t) * (b.x - a.x) + 2f * t * (c.x - b.x);
            a.y = 2f * (1f - t) * (b.y - a.y) + 2f * t * (c.y - b.y);
            return a;
        }
        /// <summary>
        /// Lerp a value between a and d, using b as the bezier of a and c as the bezier of c.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static float2 CubicBezierUnclamped(float2 a, float2 b, float2 c, float2 d, float t)
        {
            float oneMinusT = 1f - t;
            float oneMinusTPow2 = oneMinusT * oneMinusT;
            float t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3f * oneMinusTPow2 * t * b.x + 3f * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3f * oneMinusTPow2 * t * b.y + 3f * oneMinusT * t2 * c.y + t2 * t * d.y;
            return a;
        }
        /// <summary>
        /// Return the tangent of the cubic bezier curve.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static float2 CubicBezierTrangentUnclamped(float2 a, float2 b, float2 c, float2 d, float t)
        {
            float oneMinusT = 1f - t;
            a.x = 3f * oneMinusT * oneMinusT * (b.x - a.x) + 6f * oneMinusT * t * (c.x - b.x) + 3f * t * t * (d.x - c.x);
            a.y = 3f * oneMinusT * oneMinusT * (b.y - a.y) + 6f * oneMinusT * t * (c.y - b.y) + 3f * t * t * (d.y - c.y);
            return a;
        }
        /// <summary>
        /// Linearly interpolates between vectors a and b by t.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float2 LerpUnclamped(float2 b, float t)
        {
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            return b;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float2 NlerpUnclamped(float2 a, float2 b, float t)
        {
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            float mag = Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y);
            if (mag > 0.00001f)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
            }
            else
            {
                a.x = 0f;
                a.y = 0f;
            }
            return a;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public float2 NlerpUnclamped(float2 b, float t)
        {
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            float mag = Mathematics.Math.Sqrt(b.x * b.x + b.y * b.y);
            if (mag > 0.00001f)
            {
                b.x = b.x / mag;
                b.y = b.y / mag;
            }
            else
            {
                b.x = 0f;
                b.y = 0f;
            }
            return b;
        }
        /// <summary>
        /// Return the sinus of each component of the vector.
        /// </summary>
        [XmlIgnore]
        public float2 Sin
        {
            get
            {
                float2 vec;
                vec.x = (float)System.Math.Sin(x);
                vec.y = (float)System.Math.Sin(y);
                return vec;
            }
        }
        /// <summary>
        /// Return the cosinus of each component of the vector.
        /// </summary>
        [XmlIgnore]
        public float2 Cos
        {
            get
            {
                float2 vec;
                vec.x = (float)System.Math.Cos(x);
                vec.y = (float)System.Math.Cos(y);
                return vec;
            }
        }
        /// <summary>
        /// Moves a point current towards target.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <param name="maxDistanceDelta"></param>
        /// <returns></returns>
        public static float2 MoveTowards(float2 current, float2 target, float maxDistanceDelta)
        {
            float2 toVector;
            toVector.x = target.x - current.x;
            toVector.y = target.y - current.y;
            float dist = Mathematics.Math.Sqrt(toVector.x * toVector.x + toVector.y * toVector.y);
            if (dist <= maxDistanceDelta || dist == 0)
            {
                return target;
            } 
            return current + toVector / dist * maxDistanceDelta;
        }
        /// <summary>
        /// Makes this vector have a magnitude of 1.
        /// </summary>
        public void Normalize()
        {
            float mag = Magnitude;
            if (mag > 0.00001f)
            {
                this = this / mag;
            }
            else
            {
                this = Zero;
            }
        }
        /// <summary>
        /// Return the float raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public float2 Pow(float power)
        {
            float2 vec;
            vec.x = Mathematics.Math.Pow(x, power);
            vec.y = Mathematics.Math.Pow(y, power);
            return vec;
        }
        /// <summary>
        /// Return the float raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public float2 Pow(float2 power)
        {
            float2 vec;
            vec.x = Mathematics.Math.Pow(x, power.x);
            vec.y = Mathematics.Math.Pow(y, power.y);
            return vec;
        }
        /// <summary>
        /// Squareroot of the vector.
        /// </summary>
        [XmlIgnore]
        public float2 Sqrt
        {
            get
            {
                float2 vec;
                vec.x = Mathematics.Math.Sqrt(x);
                vec.y = Mathematics.Math.Sqrt(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns this vector with absolute value of each component.
        /// </summary>
        [XmlIgnore]
        public float2 Abs
        {
            get
            {
                float2 vec;
                vec.x = x > 0f ? x : -x;
                vec.y = y > 0f ? y : -y;
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the largest integer smaller to or equal to f.
        /// </summary>
        [XmlIgnore]
        public float2 Floor
        {
            get
            {
                float2 vec;
                vec.x = Mathematics.Math.Floor(x);
                vec.y = Mathematics.Math.Floor(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns the natural logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public float2 Ln
        {
            get
            {
                float2 vec;
                vec.x = Mathematics.Math.Ln(x);
                vec.y = Mathematics.Math.Ln(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-2 logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public float2 Log2
        {
            get
            {
                float2 vec;
                vec.x = Mathematics.Math.Log(x, 2f);
                vec.y = Mathematics.Math.Log(y, 2f);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public float2 Log10
        {
            get
            {
                float2 vec;
                vec.x = Mathematics.Math.Log(x);
                vec.y = Mathematics.Math.Log(y);
                return vec;
            }
        }
        /// <summary>
        /// Return 1 if the vector is greater or equal to b, otherwise it return 0.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float2 Step(float2 b)
        {
            b.x = x >= b.x ? 1f : 0f;
            b.y = y >= b.y ? 1f : 0f;
            return b;
        }
        /// <summary>
        /// Return the sign of each component.
        /// </summary>
        [XmlIgnore]
        public float2 Sign
        {
            get
            {
                float2 vec;
                vec.x = x.Sign();
                vec.y = y.Sign();
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-e exponential of each component.
        /// </summary>
        [XmlIgnore]
        public float2 Exp
        {
            get
            {
                float2 vec;
                vec.x = Mathematics.Math.Exp(x);
                vec.y = Mathematics.Math.Exp(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-2 exponential of each component.
        /// </summary>
        [XmlIgnore]
        public float2 Exp2
        {
            get
            {
                float2 vec;
                vec.x = Mathematics.Math.Exp(x * 0.69314718f);
                vec.y = Mathematics.Math.Exp(y * 0.69314718f);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 exponential of each component.
        /// </summary>
        [XmlIgnore]
        public float2 Exp10
        {
            get
            {
                float2 vec;
                vec.x = Mathematics.Math.Exp(x * 2.30258509f);
                vec.y = Mathematics.Math.Exp(y * 2.30258509f);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the tangent of x and y.
        /// </summary>
        [XmlIgnore]
        public float2 Tan
        {
            get
            {
                float2 vec;
                vec.x = (float)System.Math.Tan(x);
                vec.y = (float)System.Math.Tan(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the hyperbolic tangent of x and y.
        /// </summary>
        [XmlIgnore]
        public float2 Tanh
        {
            get
            {
                float2 vec;
                vec.x = (float)System.Math.Tanh(x);
                vec.y = (float)System.Math.Tanh(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the hyperbolic cosine of x and y.
        /// </summary>
        [XmlIgnore]
        public float2 Cosh
        {
            get
            {
                float2 vec;
                vec.x = (float)System.Math.Cosh(x);
                vec.y = (float)System.Math.Cosh(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the hyperbolic sinus of x and y.
        /// </summary>
        [XmlIgnore]
        public float2 Sinh
        {
            get
            {
                float2 vec;
                vec.x = (float)System.Math.Sinh(x);
                vec.y = (float)System.Math.Sinh(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the arc tangent of x and y.
        /// </summary>
        [XmlIgnore]
        public float2 Atan
        {
            get
            {
                float2 vec;
                vec.x = (float)System.Math.Atan(x);
                vec.y = (float)System.Math.Atan(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the arc cosine of x and y.
        /// </summary>
        [XmlIgnore]
        public float2 Acos
        {
            get
            {
                float2 vec;
                vec.x = (float)System.Math.Acos(x);
                vec.y = (float)System.Math.Acos(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the arc sinus of x and y.
        /// </summary>
        [XmlIgnore]
        public float2 Asin
        {
            get
            {
                float2 vec;
                vec.x = (float)System.Math.Asin(x);
                vec.y = (float)System.Math.Asin(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns this vector with a magnitude of 1
        /// </summary>
        [XmlIgnore]
        public float2 Normalized
        {
            get
            {
                float mag = Mathematics.Math.Sqrt(x * x + y * y);
                return mag > 0.00001f ? this / mag : Zero;
            }
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
            if (!(other is float2))
            {
                return false;
            }
            return Equals((float2)other);
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float2 Min(float2 b)
        {
            b.x = x < b.x ? x : b.x;
            b.y = y < b.y ? y : b.y;
            return b;
        }
        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float2 Max(float2 b)
        {
            b.x = x > b.x ? x : b.x;
            b.y = y > b.y ? y : b.y;
            return b;
        }
        /// <summary>
        /// Return true if the vector are in opposite direction.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsOppositeDirection(float2 b)
        {
            return x * b.x + y * b.y < 0f;
        }
        /// <summary>
        /// Return true if the vectors are perpendicular
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsPerpendicular(float2 b)
        {
            return x * b.x + y * b.y == 0f;
        }
        /// <summary>
        /// Return true if both vectors are in a similar direction.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsSimilarDirection(float2 b)
        {
            return x * b.x + b.y * y > 0f;
        }
        /// <summary>
        /// Returns the fractional portion of each vector component.
        /// </summary>
        [XmlIgnore]
        public float2 Fract
        {
            get
            {
                float2 vec;
                vec.x = x - Mathematics.Math.Floor(x);
                vec.y = y - Mathematics.Math.Floor(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains f rounded to the nearest integer.
        /// </summary>
        [XmlIgnore]
        public float2 Round
        {
            get
            {
                float2 vec;
                vec.x = (int)Mathematics.Math.Round(x);
                vec.y = (int)Mathematics.Math.Round(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns true if the given vector is exactly equal to this vector.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(float2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }
        /// <summary>
        /// Reflects a vector off the vector defined by a normal.
        /// </summary>
        /// <param name="inDirection"></param>
        /// <param name="inNormal"></param>
        /// <returns></returns>
        public static float2 Reflect(float2 inDirection, float2 inNormal)
        {
            float2 refl;
            float cal = -2f * (inNormal.x * inDirection.x + inNormal.y * inDirection.y);
            refl.x = cal * inNormal.x + inDirection.x;
            refl.y = cal * inNormal.y + inDirection.y;
            return refl;
        }
        /// <summary>
        /// Return the direction from this point to the chosen target.
        /// </summary>
        /// <param name="targetPosition">Target direction</param>
        /// <returns></returns>
        public float2 Direction(float2 targetPosition)
        {
            targetPosition.x = targetPosition.x - x;
            targetPosition.y = targetPosition.y - y;
            float mag = Mathematics.Math.Sqrt(targetPosition.x * targetPosition.x + targetPosition.y * targetPosition.y);
            if(mag > 0.00001f)
            {
                targetPosition.x = targetPosition.x / mag;
                targetPosition.y = targetPosition.y / mag;
                return targetPosition;
            }
            targetPosition.x = 0f;
            targetPosition.y = 0f;
            return targetPosition;
        }
        /// <summary>
        /// Return the refraction vector from the incident vector i, the normal vector n and the refraction index.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <param name="refractionIndex"></param>
        /// <returns></returns>
        public static float2 Refract(float2 i, float2 n, float refractionIndex)
        {
            float dt = n.x * i.x + n.y * i.y;
            float k = 1f - refractionIndex * refractionIndex * (1f - dt * dt);
            if (k >= 0f)
            {
                k = Mathematics.Math.Sqrt(k);
                n.x = refractionIndex * i.x - (refractionIndex * dt + k) * n.x;
                n.y = refractionIndex * i.y - (refractionIndex * dt + k) * n.y;
                return n;
            }
            n.x = 0f;
            n.y = 0f;
            return n;
        }
        /// <summary>
        /// Return the refraction vector from the incident vector, the normal vector n and the refraction index.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="indexRegraction"></param>
        /// <returns></returns>
        public float2 Refract(float2 n, float refractionIndex)
        {
            float dt = n.x * x + n.y * y;
            float k = 1f - refractionIndex * refractionIndex * (1f - dt * dt);
            if(k >= 0f)
            {
                k = Mathematics.Math.Sqrt(k);
                n.x = refractionIndex * x - (refractionIndex * dt + k) * n.x;
                n.y = refractionIndex * y - (refractionIndex * dt + k) * n.y;
                return n;
            }
            n.x = 0f;
            n.y = 0f;
            return n;
        }
        /// <summary>
        /// Remap the value of the vector from the old value to the new one.
        /// </summary>
        /// <param name="minOldValue"></param>
        /// <param name="maxOldValue"></param>
        /// <param name="minNewValue"></param>
        /// <param name="maxNewValue"></param>
        /// <returns></returns>
        public float2 Remap(float minOldValue, float maxOldValue, float minNewValue, float maxNewValue)
        {
            maxOldValue = maxOldValue - minOldValue;
            maxNewValue = maxNewValue - minNewValue;
            float2 vec;
            vec.x = minNewValue + (x - minOldValue) * maxNewValue / maxOldValue;
            vec.y = minNewValue + (y - minOldValue) * maxNewValue / maxOldValue;
            return vec;
        }
        /// <summary>
        /// Remap the value of the vector from the old value to the new one.
        /// </summary>
        /// <param name="minOldValue"></param>
        /// <param name="maxOldValue"></param>
        /// <param name="minNewValue"></param>
        /// <param name="maxNewValue"></param>
        /// <returns></returns>
        public float2 Remap(float2 minOldValue, float2 maxOldValue, float2 minNewValue, float2 maxNewValue)
        {
            float2 vec;
            vec.x = minNewValue.x + (x - minOldValue.x) * (maxNewValue.x - minNewValue.x) / (maxOldValue.x - minOldValue.x);
            vec.y = minNewValue.y + (y - minOldValue.y) * (maxNewValue.y - minNewValue.y) / (maxOldValue.y - minOldValue.y);
            return vec;
        }
        /// <summary>
        /// Clamp the vector between 0 and 1, then, return it.
        /// </summary>
        [XmlIgnore]
        public float2 Saturate
        {
            get
            {
                float2 vec;
                vec.x = x > 1f ? 1f : (x < 0f ? 0f : x);
                vec.y = y > 1f ? 1f : (y < 0f ? 0f : y);
                return vec;
            }
        }
        /// <summary>
        /// Clamp the vector between a min and a max value, then, return it.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public float2 Clamp(float min, float max)
        {
            float2 vec;
            vec.x = x > max ? max : (x < min ? min : x);
            vec.y = y > max ? max : (y < min ? min : y);
            return vec;
        }
        /// <summary>
        /// Return this vector clamp between two vectors.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public float2 Clamp(float2 min, float2 max)
        {
            min.x = x > max.x ? max.x : (x < min.x ? min.x : x);
            min.y = y > max.y ? max.y : (y < min.y ? min.y : y);
            return min;
        }
        /// <summary>
        /// Dot Product of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Dot(float2 a, float2 b)
        {
            return a.x * b.x + a.y * b.y;
        }
        /// <summary>
        /// Return the dot product of vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public float Dot(float2 b)
        {
            return x * b.x + y * b.y;
        }

        /// <summary>
        /// Dot product clamped in the range [-1;1] corresponding to the cosine of the angle of directions.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float DotClamped(float2 a, float2 b)
        {
            float dot_ab = a.x * b.x + a.y * b.y;
            if (dot_ab < 1e-15f && dot_ab > -1e-15f)
            {
                return dot_ab;
            }
            return dot_ab / Mathematics.Math.Sqrt((a.x * a.x + a.y * a.y) * (b.x * b.x + b.y * b.y));
        }
        /// <summary>
        /// Dot product clamped in the range [-1;1] corresponding to the cosine of the angle of directions.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float DotClamped(float2 b)
        {
            float dot_ab = x * b.x + y * b.y;
            if (dot_ab < 1e-15f && dot_ab > -1e-15f)
            {
                return dot_ab;
            }
            return dot_ab / Mathematics.Math.Sqrt((x * x + y * y) * (b.x * b.x + b.y * b.y));
        }
        /// <summary>
        /// Return the distance between two vectors.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public float Distance(float2 target)
        {
            float vecx, vecy;
            vecx = x - target.x;
            vecy = y - target.y;
            return Mathematics.Math.Sqrt(vecx * vecx + vecy * vecy);
        }
        /// <summary>
        /// Returns the length of this vector.
        /// </summary>
        [XmlIgnore]
        public float Magnitude
        {
            get
            {
                return Mathematics.Math.Sqrt(x * x + y * y);
            }
        }
        /// <summary>
        /// Return true of the position of a targeted position is in the range of this vector.
        /// </summary>
        /// <param name="targetPosition">Position of the target</param>
        /// <param name="rangeDistance">Distance detection</param>
        /// <returns></returns>
        public bool IsInRange(float2 targetPosition, float rangeDistance)
        {
            float dirx = targetPosition.x - x;
            float diry = targetPosition.y - y;
            return dirx * dirx + diry * diry < rangeDistance * rangeDistance;
        }
        /// <summary>
        /// Do a smoothstep from vectors value.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public float2 SmoothStep(float2 b, float2 x)
        {
            float2 vec;
            vec.x = (x.x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1f ? 1f : (vec.x < 0f ? 0f : vec.x);
            vec.x = vec.x * vec.x * (3f - 2f * vec.x);
            vec.y = (x.y - y) / (b.y - y);
            vec.y = vec.y > 1f ? 1f : (vec.y < 0f ? 0f : vec.y);
            vec.y = vec.y * vec.y * (3f - 2f * vec.y);
            return vec;
        }
        /// <summary>
        /// Do a smoothstep from vectors value.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public float2 SmoothStep(float2 b, float x)
        {
            float2 vec;
            vec.x = (x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1f ? 1f : (vec.x < 0f ? 0f : vec.x);
            vec.x = vec.x * vec.x * (3f - 2f * vec.x);
            vec.y = (x - y) / (b.y - y);
            vec.y = vec.y > 1f ? 1f : (vec.y < 0f ? 0f : vec.y);
            vec.y = vec.y * vec.y * (3f - 2f * vec.y);
            return vec;
        }
        /// <summary>
        /// Returns the squared length of this vector.
        /// </summary>
        [XmlIgnore]
        public float SqrMagnitude
        {
            get
            {
                return x * x + y * y;
            }
        }
        /// <summary>
        /// Returns the unsigned angle in degrees between from and to.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static float Angle(float2 from, float2 to)
        {
            float denominator = Mathematics.Math.Sqrt(from.SqrMagnitude * to.SqrMagnitude);
            if (denominator < 1e-15f)
            {
                return 0f;
            }
            float val = (from.x * to.x + from.y * to.y) / denominator;
            val = val < -1f ? -1f : val > 1f ? 1f : val;
            return (float)System.Math.Acos(val) * 57.2957795131f;
        }
        /// <summary>
        /// Returns the signed angle in degrees between from and to.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static float SignedAngle(float2 from, float2 to)
        {
            float angle;
            float denominator = Mathematics.Math.Sqrt(from.SqrMagnitude * to.SqrMagnitude);
            if (denominator < 1e-15f)
            {
                angle = 0f;
            }
            else
            {
                angle = (from.x * to.x + from.y * to.y) / denominator;
                angle = angle < -1f ? -1f : angle > 1f ? 1f : angle;
                angle = (float)System.Math.Acos(angle) * 57.2957795131f;
            }
            float sign = (from.x * to.y - from.y * to.x) < 0f ? -1f : 1f;
            return angle * sign;
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Distance(float2 a, float2 b)
        {
            float x = a.x - b.x;
            float y = a.y - b.y;
            return Mathematics.Math.Sqrt(x * x + y * y);
        }
        /// <summary>
        /// Reflects a vector off the vector defined by a normal.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="normal"></param>
        /// <returns></returns>
        public float2 Reflect(float2 normal)
        {
            float2 refl;
            refl.x = -2f * (normal.x * x + normal.y * y) * normal.x + x;
            refl.y = -2f * (normal.x * x + normal.y * y) * normal.y + y;
            return refl;
        }
        /// <summary>
        /// Returns a copy of vector with its magnitude clamped to maxLength.
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static float2 ClampMagnitude(float2 vector, float maxLength)
        {
            if (vector.x * vector.x + vector.y + vector.y > maxLength * maxLength)
            {
                return vector.Normalized * maxLength;
            }
            return vector;
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float2 Min(float2 a, float2 b)
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
        public static float2 Max(float2 a, float2 b)
        {
            a.x = a.x > b.x ? a.x : b.x;
            a.y = a.y > b.y ? a.y : b.y;
            return a;
        }
        /// <summary>
        /// Returns a vector that contains the smallest integer greater to or equal to f.
        /// </summary>
        [XmlIgnore]
        public float2 Ceil
        {
            get
            {
                float2 vec;
                vec.x = Mathematics.Math.Ceil(x);
                vec.y = Mathematics.Math.Ceil(y);
                return vec;
            }
        }
        /// <summary>
        /// Freeze the position of desired component of the vector to 0.
        /// </summary>
        /// <param name="freezeAxis"></param>
        /// <returns></returns>
        public float2 FreezeVector(bool2 freezeAxis)
        {
            float2 vec;
            vec.x = freezeAxis.x ? 0f : x;
            vec.y = freezeAxis.y ? 0f : y;
            return vec;
        }
        /// <summary>
        /// Gradually changes a vector towards a desired goal over time.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <param name="currentVelocity"></param>
        /// <param name="smoothTime"></param>
        /// <param name="maxSpeed"></param>
        /// <param name="deltaTime"></param>
        /// <returns></returns>
        public static float2 SmoothDamp(float2 current, float2 target, ref float2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            smoothTime = 0.0001f > smoothTime ? 0.0001f : smoothTime;
            float omega = 2f / smoothTime;
            float x = omega * deltaTime;
            float exp = 1f / (1f + x + 0.48f * x * x + 0.235f * x * x * x);
            float2 change;
            change.x = current.x - target.x;
            change.y = current.y - target.y;
            float2 originalTo;
            originalTo.x = target.x;
            originalTo.y = target.y;
            float maxChange = maxSpeed * smoothTime;
            change = ClampMagnitude(change, maxChange);
            target = current - change;
            float2 temp;
            temp.x = (currentVelocity.x + omega * change.x) * deltaTime;
            temp.y = (currentVelocity.y + omega * change.y) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * exp;
            float2 output;
            output.x = target.x + (change.x + temp.x) * exp;
            output.y = target.y + (change.y + temp.y) * exp;
            if (((originalTo.x - current.x) * (output.x - originalTo.x) + (originalTo.x - current.x) * (output.y - originalTo.y)) > 0)
            {
                output = originalTo;
                currentVelocity = (output - originalTo) / deltaTime;
            }
            return output;
        }
        /// <summary>
        /// Return true if the distance between 2 points in less than the desired distance
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static bool CompareDistance(float2 a, float2 b, float distance)
        {
            return a.x * b.x + a.y * b.y < distance * distance;
        }
        /// <summary>
        /// Return true if the distance between 2 points in less than the desired distance
        /// </summary>
        /// <param name="b"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public bool CompareDistance(float2 b, float distance)
        {
            return x * b.x + y * b.y < distance * distance;
        }
        public static float2 operator -(float2 a)
        {
            a.x = -a.x;
            a.y = -a.y;
            return a;
        }
        public static float2 operator +(float2 a, float2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static float2 operator +(float a, float2 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            return b;
        }
        public static float2 operator +(float2 a, float b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            return a;
        }
        public static float2 operator -(float2 a, float2 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static float2 operator -(float a, float2 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            return b;
        }
        public static float2 operator -(float2 a, float b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            return a;
        }
        public static float2 operator *(float2 a, float2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static float2 operator *(float a, float2 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            return b;
        }
        public static float2 operator *(float2 b, float a)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            return b;
        }
        public static float2 operator %(float2 a, float2 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static float2 operator %(float a, float2 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            return b;
        }
        public static float2 operator %(float2 b, float a)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            return b;
        }
        public static float2 operator /(float2 a, float2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static float2 operator /(float a, float2 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            return b;
        }
        public static float2 operator /(float2 a, float b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            return a;
        }
        public static bool operator ==(float2 a, float2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a.x * a.x + a.y * a.y < 0.0000000001f;
        }
        public static bool operator !=(float2 a, float2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a.x * a.x + a.y * a.y >= 0.0000000001f;
        }
        public static explicit operator int2(float2 v)
        {
            int2 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            return vec;
        }
        public static explicit operator int3(float2 v)
        {
            int3 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = 0;
            return vec;
        }
        public static explicit operator int4(float2 v)
        {
            int4 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = 0;
            vec.w = 0;
            return vec;
        }
        public static implicit operator float3(float2 v)
        {
            float3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0f;
            return vec;
        }
        public static implicit operator float4(float2 v)
        {
            float4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0f;
            vec.w = 0f;
            return vec;
        }
        public static explicit operator bool2(float2 v)
        {
            bool2 vec;
            vec.x = v.x != 0f;
            vec.y = v.y != 0f;
            return vec;
        }
        public static explicit operator bool3(float2 v)
        {
            bool3 vec;
            vec.x = v.x != 0f;
            vec.y = v.y != 0f;
            vec.z = false;
            return vec;
        }
        public static implicit operator bool4(float2 v)
        {
            bool4 vec;
            vec.x = v.x != 0f;
            vec.y = v.y != 0f;
            vec.z = false;
            vec.w = false;
            return vec;
        }
        public static implicit operator double4(float2 v)
        {
            double4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0d;
            vec.w = 0d;
            return vec;
        }
        public static implicit operator double3(float2 v)
        {
            double3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0d;
            return vec;
        }
        public static implicit operator double2(float2 v)
        {
            double2 vec;
            vec.x = v.x;
            vec.y = v.y;
            return vec;
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, 0).
        /// </summary>
        [XmlIgnore]
        public static float2 Zero
        {
            get
            {
                float2 vec;
                vec.x = 0f;
                vec.y = 0f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(0.5, 0.5).
        /// </summary>
        [XmlIgnore]
        public static float2 Half
        {
            get
            {
                float2 vec;
                vec.x = 0.5f;
                vec.y = 0.5f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(1, 1).
        /// </summary>
        [XmlIgnore]
        public static float2 One
        {
            get
            {
                float2 vec;
                vec.x = 1f;
                vec.y = 1f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, 1).
        /// </summary>
        [XmlIgnore]
        public static float2 Up
        {
            get
            {
                float2 vec;
                vec.x = 0f;
                vec.y = 1f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, -1).
        /// </summary>
        [XmlIgnore]
        public static float2 Down
        {
            get
            {
                float2 vec;
                vec.x = 0f;
                vec.y = -1f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(-1, 0).
        /// </summary>
        [XmlIgnore]
        public static float2 Left
        {
            get
            {
                float2 vec;
                vec.x = -1f;
                vec.y = 0f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(1, 0).
        /// </summary>
        [XmlIgnore]
        public static float2 Right
        {
            get
            {
                float2 vec;
                vec.x = 1f;
                vec.y = 0f;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(float.PositiveInfinity, float.PositiveInfinity).
        /// </summary>
        [XmlIgnore]
        public static float2 PositiveInfinity
        {
            get
            {
                float2 vec;
                vec.x = float.PositiveInfinity;
                vec.y = float.PositiveInfinity;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(float.NegativeInfinity, float.NegativeInfinity).
        /// </summary>
        [XmlIgnore]
        public static float2 NegativeInfinity
        {
            get
            {
                float2 vec;
                vec.x = float.NegativeInfinity;
                vec.y = float.NegativeInfinity;
                return vec;
            }
        }
        /// <summary>
        /// Return the angle between the direction of both vectors.
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public float AngleBetweenDirections(float2 to)
        {
            float denominator = Mathematics.Math.Sqrt((x * x + y * y) * (to.x * to.x + to.y * to.y));
            if(denominator < 1e-15f)
            {
                return 0f;
            }
            float valu = (x * to.x + y * to.y) / denominator;
            return (float)System.Math.Acos(valu < -1f ? -1f : (valu > 1f ? 1f : valu)) * 57.2957795131f;
        }
        /// <summary>
        /// Moves a point current towards target.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="maxDistanceDelta"></param>
        /// <returns></returns>
        public float2 MoveTowards(float2 target, float maxDistanceDelta)
        {
            float2 toVector;
            toVector.x = target.x - x;
            toVector.y = target.y - y;
            float dist = Mathematics.Math.Sqrt(toVector.x * toVector.x + toVector.y * toVector.y);
            return (dist <= maxDistanceDelta || dist == 0) ? target : this + toVector / dist * maxDistanceDelta;
        }
        /// <summary>
        /// Return the dot product angle of both vectors.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public float DotProductAngle(float2 target)
        {
            float2 normThis = Normalized;
            target.Normalize();
            normThis.x = normThis.x * target.x + normThis.y * target.y;
            normThis.x = normThis.x > 1f ? 1f : normThis.x < -1f ? -1f : normThis.x;
            return (float)System.Math.Acos(normThis.x);
        }
        /// <summary>
        /// Returns the signed angle in degrees between from and to.
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public float SignedAngle(float2 to)
        {
            float denominator = Mathematics.Math.Sqrt((x * x + y * y) * (to.x * to.x + to.y * to.y));
            if (denominator < 1e-15f)
            {
                return 0f;
            }
            float a = x * to.y - x * to.x;
            a = a.Sign();
            float valu = (x * to.x + y * to.y) / denominator;
            return ((float)System.Math.Acos(valu < -1f ? -1f : (valu > 1f ? 1f : valu)) * 57.2957795131f) * a;
        }
    }
}
