using System;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct double2 : IEquatable<double2>
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public double x;
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public double y;
        /// <summary>
        /// X component of the vector.
        /// </summary>
        [XmlIgnore]
        public double u
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
        public double v
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
        public double2 xx
        {
            get
            {
                double2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double2 uu
        {
            get
            {
                double2 vec;
                vec.x = x;
                vec.y = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double2 xy
        {
            get
            {
                double2 vec;
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
        public double2 uv
        {
            get
            {
                double2 vec;
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
        public double2 yx
        {
            get
            {
                double2 vec;
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
        public double2 vu
        {
            get
            {
                double2 vec;
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
        public double2 yy
        {
            get
            {
                double2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double2 vv
        {
            get
            {
                double2 vec;
                vec.x = y;
                vec.y = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xxx
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 uuu
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xxy
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 uuv
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xyx
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 uvu
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 xyy
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 uvv
        {
            get
            {
                double3 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yxx
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 vuu
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yxy
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 vuv
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yyx
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 vvu
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 yyy
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double3 vvv
        {
            get
            {
                double3 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxxx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 uuuu
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxxy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 uuuv
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxyx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 uuvu
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xxyy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 uuvv
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyxx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 uvuu
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyxy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 uvuv
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyyx
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 uvvu
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 xyyy
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 uvvv
        {
            get
            {
                double4 vec;
                vec.x = x;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxxx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 vuuu
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxxy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 vuuv
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxyx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 vuvu
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yxyy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 vuvv
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = x;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyxx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 vvuu
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyxy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 vvuv
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = x;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyyx
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 vvvu
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = x;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 yyyy
        {
            get
            {
                double4 vec;
                vec.x = y;
                vec.y = y;
                vec.z = y;
                vec.w = y;
                return vec;
            }
        }
        [XmlIgnore]
        public double4 vvvv
        {
            get
            {
                double4 vec;
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
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default:
                        throw new IndexOutOfRangeException("Invalid double2 index!");
                }
            }

            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid double2 index!");
                }
            }
        }
        /// <summary>
        /// Representation of 2D vectors and points.
        /// </summary>
        /// <param name="xy"></param>
        public double2(double xy)
        {
            x = xy;
            y = xy;
        }
        /// <summary>
        /// Representation of 2D vectors and points.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public double2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Set x and y components of an existing Vector2.
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        public void Set(double newX, double newY)
        {
            x = newX;
            y = newY;
        }
        /// <summary>
        /// Linearly interpolates between vectors a and b by t.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double2 Lerp(double2 a, double2 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
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
        public double2 Lerp(double2 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
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
        public static double2 Nlerp(double2 a, double2 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            double mag = Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y);
            if (mag > 0.000000000001d)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
            }
            else
            {
                a.x = 0d;
                a.y = 0d;
            }
            return a;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public double2 Nlerp(double2 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            double mag = Mathematics.Math.Sqrt(b.x * b.x + b.y * b.y);
            if (mag > 0.000000000001d)
            {
                b.x = b.x / mag;
                b.y = b.y / mag;
            }
            else
            {
                b.x = 0d;
                b.y = 0d;
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
        public static double2 Unlerp(double2 a, double2 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
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
        public double2 Unlerp(double2 b, double t)
        {
            t = t < 0d ? 0d : t > 1d ? 1d : t;
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
        public static double2 QuadraticBezier(double2 a, double2 b, double2 c, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double oneMinusT = 1d - t;
            a.x = oneMinusT * oneMinusT * a.x + 2d * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2d * oneMinusT * t * b.y + t * t * c.y;
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
        public static double2 QuadraticBezierTangent(double2 a, double2 b, double2 c, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            a.x = 2d * (1d - t) * (b.x - a.x) + 2d * t * (c.x - b.x);
            a.y = 2d * (1d - t) * (b.y - a.y) + 2d * t * (c.y - b.y);
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
        public static double2 CubicBezier(double2 a, double2 b, double2 c, double2 d, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double oneMinusT = 1d - t;
            double oneMinusTPow2 = oneMinusT * oneMinusT;
            double t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3d * oneMinusTPow2 * t * b.x + 3d * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3d * oneMinusTPow2 * t * b.y + 3d * oneMinusT * t2 * c.y + t2 * t * d.y;
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
        public static double2 CubicBezierTrangent(double2 a, double2 b, double2 c, double2 d, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            double oneMinusT = 1d - t;
            a.x = 3d * oneMinusT * oneMinusT * (b.x - a.x) + 6d * oneMinusT * t * (c.x - b.x) + 3d * t * t * (d.x - c.x);
            a.y = 3d * oneMinusT * oneMinusT * (b.y - a.y) + 6d * oneMinusT * t * (c.y - b.y) + 3d * t * t * (d.y - c.y);
            return a;
        }
        /// <summary>
        /// Linearly interpolates between vectors a and b by t.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double2 LerpUnclamped(double2 a, double2 b, double t)
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
        public double2 UnlerpUnclamped(double2 b, double t)
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
        public static double2 QuadraticBezierUnclamped(double2 a, double2 b, double2 c, double t)
        {
            double oneMinusT = 1d - t;
            a.x = oneMinusT * oneMinusT * a.x + 2d * oneMinusT * t * b.x + t * t * c.x;
            a.y = oneMinusT * oneMinusT * a.y + 2d * oneMinusT * t * b.y + t * t * c.y;
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
        public static double2 QuadraticBezierTangentUnclamped(double2 a, double2 b, double2 c, double t)
        {
            a.x = 2d * (1d - t) * (b.x - a.x) + 2d * t * (c.x - b.x);
            a.y = 2d * (1d - t) * (b.y - a.y) + 2d * t * (c.y - b.y);
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
        public static double2 CubicBezierUnclamped(double2 a, double2 b, double2 c, double2 d, double t)
        {
            double oneMinusT = 1d - t;
            double oneMinusTPow2 = oneMinusT * oneMinusT;
            double t2 = t * t;
            a.x = oneMinusTPow2 * oneMinusT * a.x + 3d * oneMinusTPow2 * t * b.x + 3d * oneMinusT * t2 * c.x + t2 * t * d.x;
            a.y = oneMinusTPow2 * oneMinusT * a.y + 3d * oneMinusTPow2 * t * b.y + 3d * oneMinusT * t2 * c.y + t2 * t * d.y;
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
        public static double2 CubicBezierTrangentUnclamped(double2 a, double2 b, double2 c, double2 d, double t)
        {
            double oneMinusT = 1d - t;
            a.x = 3d * oneMinusT * oneMinusT * (b.x - a.x) + 6d * oneMinusT * t * (c.x - b.x) + 3d * t * t * (d.x - c.x);
            a.y = 3d * oneMinusT * oneMinusT * (b.y - a.y) + 6d * oneMinusT * t * (c.y - b.y) + 3d * t * t * (d.y - c.y);
            return a;
        }
        /// <summary>
        /// Linearly interpolates between vectors a and b by t.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public double2 LerpUnclamped(double2 b, double t)
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
        public static double2 NlerpUnclamped(double2 a, double2 b, double t)
        {
            a.x = a.x + (b.x - a.x) * t;
            a.y = a.y + (b.y - a.y) * t;
            double mag = Mathematics.Math.Sqrt(a.x * a.x + a.y * a.y);
            if (mag > 0.000000000001d)
            {
                a.x = a.x / mag;
                a.y = a.y / mag;
            }
            else
            {
                a.x = 0d;
                a.y = 0d;
            }
            return a;
        }
        /// <summary>
        /// Returns the direction of b from a.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double2 Direction(double2 a, double2 b)
        {
            double2 dir;
            dir.x = b.x - a.x;
            dir.y = b.y - a.y;
            double mag = Mathematics.Math.Sqrt(dir.x * dir.x + dir.y * dir.y);
            if (mag > 0.000000000001d)
            {
                dir.x = dir.x / mag;
                dir.y = dir.y / mag;
                return dir;
            }
            dir.x = 0d;
            dir.y = 0d;
            return dir;
        }
        /// <summary>
        /// Lineary interpolates between two vectors and normalize the result.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public double2 NlerpUnclamped(double2 b, double t)
        {
            b.x = x + (b.x - x) * t;
            b.y = y + (b.y - y) * t;
            double mag = Mathematics.Math.Sqrt(b.x * b.x + b.y * b.y);
            if (mag > 0.000000000001d)
            {
                b.x = b.x / mag;
                b.y = b.y / mag;
            }
            else
            {
                b.x = 0d;
                b.y = 0d;
            }
            return b;
        }
        /// <summary>
        /// Return the sinus of each component of the vector.
        /// </summary>
        [XmlIgnore]
        public double2 Sin
        {
            get
            {
                double2 vec;
                vec.x = System.Math.Sin(x);
                vec.y = System.Math.Sin(y);
                return vec;
            }
        }
        /// <summary>
        /// Return the perpendicular of this vector.
        /// </summary>
        [XmlIgnore]
        public double2 Perpendicular
        {
            get
            {
                double2 vec;
                vec.x = -y;
                vec.y = x;
                return vec;
            }
        }
        /// <summary>
        /// Return the perpendicular of this vector.
        /// </summary>
        [XmlIgnore]
        public double2 Perpendicular2
        {
            get
            {
                double2 vec;
                vec.x = y;
                vec.y = -x;
                return vec;
            }
        }
        /// <summary>
        /// Return the cosinus of each component of the vector.
        /// </summary>
        [XmlIgnore]
        public double2 Cos
        {
            get
            {
                double2 vec;
                vec.x = System.Math.Cos(x);
                vec.y = System.Math.Cos(y);
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
        public static double2 MoveTowards(double2 current, double2 target, double maxDistanceDelta)
        {
            double2 toVector;
            toVector.x = target.x - current.x;
            toVector.y = target.y - current.y;
            double dist = Mathematics.Math.Sqrt(toVector.x * toVector.x + toVector.y * toVector.y);
            if (dist <= maxDistanceDelta || dist == 0d)
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
            double mag = Magnitude;
            if (mag > 0.000000000001d)
            {
                this = this / mag;
            }
            else
            {
                this = Zero;
            }
        }
        /// <summary>
        /// Return the double raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public double2 Pow(double power)
        {
            double2 vec;
            vec.x = Mathematics.Math.Pow(x, power);
            vec.y = Mathematics.Math.Pow(y, power);
            return vec;
        }
        /// <summary>
        /// Return the double raised to the power.
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public double2 Pow(double2 power)
        {
            double2 vec;
            vec.x = Mathematics.Math.Pow(x, power.x);
            vec.y = Mathematics.Math.Pow(y, power.y);
            return vec;
        }
        /// <summary>
        /// Squareroot of the vector.
        /// </summary>
        [XmlIgnore]
        public double2 Sqrt
        {
            get
            {
                double2 vec;
                vec.x = Mathematics.Math.Sqrt(x);
                vec.y = Mathematics.Math.Sqrt(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns this vector with absolute value of each component.
        /// </summary>
        [XmlIgnore]
        public double2 Abs
        {
            get
            {
                double2 vec;
                vec.x = x > 0d ? x : -x;
                vec.y = y > 0d ? y : -y;
                return vec;
            }
        }
        /// <summary>
        /// Returns a int2 that contains the largest integer smaller to or equal to f.
        /// </summary>
        [XmlIgnore]
        public int2 FloorToInt
        {
            get
            {
                int2 vec;
                vec.x = (int)x;
                vec.y = (int)y;
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the largest integer smaller to or equal to f.
        /// </summary>
        [XmlIgnore]
        public double2 Floor
        {
            get
            {
                double2 vec;
                vec.x = Mathematics.Math.Floor(x);
                vec.y = Mathematics.Math.Floor(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns the natural logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public double2 Ln
        {
            get
            {
                double2 vec;
                vec.x = Mathematics.Math.Ln(x);
                vec.y = Mathematics.Math.Ln(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-2 logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public double2 Log2
        {
            get
            {
                double2 vec;
                vec.x = Mathematics.Math.Lb(x);
                vec.y = Mathematics.Math.Lb(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 logarithm of each component.
        /// </summary>
        [XmlIgnore]
        public double2 Log10
        {
            get
            {
                double2 vec;
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
        public double2 Step(double2 b)
        {
            b.x = x >= b.x ? 1d : 0d;
            b.y = y >= b.y ? 1d : 0d;
            return b;
        }
        /// <summary>
        /// Return the sign of each component.
        /// </summary>
        [XmlIgnore]
        public double2 Sign
        {
            get
            {
                double2 vec;
                vec.x = x < 0d ? -1d : 1d;
                vec.y = y < 0d ? -1d : 1d;
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-e exponential of each component.
        /// </summary>
        [XmlIgnore]
        public double2 Exp
        {
            get
            {
                double2 vec;
                vec.x = Mathematics.Math.Exp(x);
                vec.y = Mathematics.Math.Exp(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-2 exponential of each component.
        /// </summary>
        [XmlIgnore]
        public double2 Exp2
        {
            get
            {
                double2 vec;
                vec.x = Mathematics.Math.Exp(x * 0.69314718d);
                vec.y = Mathematics.Math.Exp(y * 0.69314718d);
                return vec;
            }
        }
        /// <summary>
        /// Returns the base-10 exponential of each component.
        /// </summary>
        [XmlIgnore]
        public double2 Exp10
        {
            get
            {
                double2 vec;
                vec.x = Mathematics.Math.Exp(x * 2.30258509d);
                vec.y = Mathematics.Math.Exp(y * 2.30258509d);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the tangent of x and y.
        /// </summary>
        [XmlIgnore]
        public double2 Tan
        {
            get
            {
                double2 vec;
                vec.x = System.Math.Tan(x);
                vec.y = System.Math.Tan(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the hyperbolic tangent of x and y.
        /// </summary>
        [XmlIgnore]
        public double2 Tanh
        {
            get
            {
                double2 vec;
                vec.x = System.Math.Tanh(x);
                vec.y = System.Math.Tanh(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the hyperbolic cosine of x and y.
        /// </summary>
        [XmlIgnore]
        public double2 Cosh
        {
            get
            {
                double2 vec;
                vec.x = System.Math.Cosh(x);
                vec.y = System.Math.Cosh(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the hyperbolic sinus of x and y.
        /// </summary>
        [XmlIgnore]
        public double2 Sinh
        {
            get
            {
                double2 vec;
                vec.x = System.Math.Sinh(x);
                vec.y = System.Math.Sinh(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the arc tangent of x and y.
        /// </summary>
        [XmlIgnore]
        public double2 Atan
        {
            get
            {
                double2 vec;
                vec.x = System.Math.Atan(x);
                vec.y = System.Math.Atan(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the arc cosine of x and y.
        /// </summary>
        [XmlIgnore]
        public double2 Acos
        {
            get
            {
                double2 vec;
                vec.x = System.Math.Acos(x);
                vec.y = System.Math.Acos(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the arc sinus of x and y.
        /// </summary>
        [XmlIgnore]
        public double2 Asin
        {
            get
            {
                double2 vec;
                vec.x = System.Math.Asin(x);
                vec.y = System.Math.Asin(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns this vector with a magnitude of 1
        /// </summary>
        [XmlIgnore]
        public double2 Normalized
        {
            get
            {
                double mag = Mathematics.Math.Sqrt(x * x + y * y);
                return mag > 0.000000000001d ? this / mag : Zero;
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
            if (!(other is double2))
            {
                return false;
            }
            return Equals((double2)other);
        }
        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double2 Min(double2 b)
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
        public double2 Max(double2 b)
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
        public bool IsOppositeDirection(double2 b)
        {
            return x * b.x + y * b.y < 0d;
        }
        /// <summary>
        /// Return true if the vectors are perpendicular
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsPerpendicular(double2 b)
        {
            return x * b.x + y * b.y == 0d;
        }
        /// <summary>
        /// Return true if both vectors are in a similar direction.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsSimilarDirection(double2 b)
        {
            return x * b.x + b.y * y > 0d;
        }
        /// <summary>
        /// Returns the fractional portion of each vector component.
        /// </summary>
        [XmlIgnore]
        public double2 Fract
        {
            get
            {
                double2 vec;
                vec.x = x - Mathematics.Math.Floor(x);
                vec.y = y - Mathematics.Math.Floor(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a int2 that contains f rounded to the nearest integer.
        /// </summary>
        [XmlIgnore]
        public int2 RoundToInt
        {
            get
            {
                int2 vec;
                vec.x = (int)Mathematics.Math.Round(x);
                vec.y = (int)Mathematics.Math.Round(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains f rounded to the nearest integer.
        /// </summary>
        [XmlIgnore]
        public double2 Round
        {
            get
            {
                double2 vec;
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
        public bool Equals(double2 other)
        {
            return x.Equals(other.x) && y.Equals(other.y);
        }
        /// <summary>
        /// Reflects a vector off the vector defined by a normal.
        /// </summary>
        /// <param name="inDirection"></param>
        /// <param name="inNormal"></param>
        /// <returns></returns>
        public static double2 Reflect(double2 inDirection, double2 inNormal)
        {
            double2 refl;
            double cal = -2d * (inNormal.x * inDirection.x + inNormal.y * inDirection.y);
            refl.x = cal * inNormal.x + inDirection.x;
            refl.y = cal * inNormal.y + inDirection.y;
            return refl;
        }
        /// <summary>
        /// Return the direction from this point to the chosen target.
        /// </summary>
        /// <param name="targetPosition">Target direction</param>
        /// <returns></returns>
        public double2 Direction(double2 targetPosition)
        {
            targetPosition.x = targetPosition.x - x;
            targetPosition.y = targetPosition.y - y;
            double mag = Mathematics.Math.Sqrt(targetPosition.x * targetPosition.x + targetPosition.y * targetPosition.y);
            if (mag > 0.000000000001d)
            {
                targetPosition.x = targetPosition.x / mag;
                targetPosition.y = targetPosition.y / mag;
                return targetPosition;
            }
            targetPosition.x = 0d;
            targetPosition.y = 0d;
            return targetPosition;
        }
        /// <summary>
        /// Return the refraction vector from the incident vector i, the normal vector n and the refraction index.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <param name="refractionIndex"></param>
        /// <returns></returns>
        public static double2 Refract(double2 i, double2 n, double refractionIndex)
        {
            double dt = n.x * i.x + n.y * i.y;
            double k = 1d - refractionIndex * refractionIndex * (1d - dt * dt);
            if (k >= 0d)
            {
                k = Mathematics.Math.Sqrt(k);
                n.x = refractionIndex * i.x - (refractionIndex * dt + k) * n.x;
                n.y = refractionIndex * i.y - (refractionIndex * dt + k) * n.y;
                return n;
            }
            n.x = 0d;
            n.y = 0d;
            return n;
        }
        /// <summary>
        /// Return the refraction vector from the incident vector, the normal vector n and the refraction index.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="indexRegraction"></param>
        /// <returns></returns>
        public double2 Refract(double2 n, double refractionIndex)
        {
            double dt = n.x * x + n.y * y;
            double k = 1d - refractionIndex * refractionIndex * (1d - dt * dt);
            if (k >= 0d)
            {
                k = Mathematics.Math.Sqrt(k);
                n.x = refractionIndex * x - (refractionIndex * dt + k) * n.x;
                n.y = refractionIndex * y - (refractionIndex * dt + k) * n.y;
                return n;
            }
            n.x = 0d;
            n.y = 0d;
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
        public double2 Remap(double minOldValue, double maxOldValue, double minNewValue, double maxNewValue)
        {
            maxOldValue = maxOldValue - minOldValue;
            maxNewValue = maxNewValue - minNewValue;
            double2 vec;
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
        public double2 Remap(double2 minOldValue, double2 maxOldValue, double2 minNewValue, double2 maxNewValue)
        {
            double2 vec;
            vec.x = minNewValue.x + (x - minOldValue.x) * (maxNewValue.x - minNewValue.x) / (maxOldValue.x - minOldValue.x);
            vec.y = minNewValue.y + (y - minOldValue.y) * (maxNewValue.y - minNewValue.y) / (maxOldValue.y - minOldValue.y);
            return vec;
        }
        /// <summary>
        /// Clamp the vector between 0 and 1, then, return it.
        /// </summary>
        [XmlIgnore]
        public double2 Saturate
        {
            get
            {
                double2 vec;
                vec.x = x > 1d ? 1d : (x < 0d ? 0d : x);
                vec.y = y > 1d ? 1d : (y < 0d ? 0d : y);
                return vec;
            }
        }
        /// <summary>
        /// Clamp the vector between a min and a max value, then, return it.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public double2 Clamp(double min, double max)
        {
            double2 vec;
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
        public double2 Clamp(double2 min, double2 max)
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
        public static double Dot(double2 a, double2 b)
        {
            return a.x * b.x + a.y * b.y;
        }
        /// <summary>
        /// Return the dot product of vectors.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Dot(double2 b)
        {
            return x * b.x + y * b.y;
        }
        /// <summary>
        /// Return the distance between two vectors.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public double Distance(double2 target)
        {
            double vecx, vecy;
            vecx = x - target.x;
            vecy = y - target.y;
            return Mathematics.Math.Sqrt(vecx * vecx + vecy * vecy);
        }
        /// <summary>
        /// Returns the length of this vector.
        /// </summary>
        [XmlIgnore]
        public double Magnitude
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
        public bool IsInRange(double2 targetPosition, double rangeDistance)
        {
            double dirx = targetPosition.x - x;
            double diry = targetPosition.y - y;
            return dirx * dirx + diry * diry < rangeDistance * rangeDistance;
        }
        /// <summary>
        /// Do a smoothstep from vectors value.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public double2 SmoothStep(double2 b, double2 x)
        {
            double2 vec;
            vec.x = (x.x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1d ? 1d : (vec.x < 0d ? 0d : vec.x);
            vec.x = vec.x * vec.x * (3d - 2d * vec.x);
            vec.y = (x.y - y) / (b.y - y);
            vec.y = vec.y > 1d ? 1d : (vec.y < 0d ? 0d : vec.y);
            vec.y = vec.y * vec.y * (3d - 2d * vec.y);
            return vec;
        }
        /// <summary>
        /// Do a smoothstep from vectors value.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public double2 SmoothStep(double2 b, double x)
        {
            double2 vec;
            vec.x = (x - this.x) / (b.x - this.x);
            vec.x = vec.x > 1d ? 1d : (vec.x < 0d ? 0d : vec.x);
            vec.x = vec.x * vec.x * (3d - 2d * vec.x);
            vec.y = (x - y) / (b.y - y);
            vec.y = vec.y > 1d ? 1d : (vec.y < 0d ? 0d : vec.y);
            vec.y = vec.y * vec.y * (3d - 2d * vec.y);
            return vec;
        }
        /// <summary>
        /// Returns the squared length of this vector.
        /// </summary>
        [XmlIgnore]
        public double SqrMagnitude
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
        public static double Angle(double2 from, double2 to)
        {
            double denominator = Mathematics.Math.Sqrt(from.SqrMagnitude * to.SqrMagnitude);
            if (denominator < 1e-15d)
            {
                return 0f;
            }
            double val = (from.x * to.x + from.y * to.y) / denominator;
            val = val < -1d ? -1d : val > 1d ? 1d : val;
            return System.Math.Acos(val) * 57.2957795131d;
        }
        /// <summary>
        /// Returns the signed angle in degrees between from and to.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static double SignedAngle(double2 from, double2 to)
        {
            double angle;
            double denominator = Mathematics.Math.Sqrt(from.SqrMagnitude * to.SqrMagnitude);
            if (denominator < 1e-15d)
            {
                angle = 0d;
            }
            else
            {
                angle = (from.x * to.x + from.y * to.y) / denominator;
                angle = angle < -1d ? -1d : angle > 1d ? 1d : angle;
                angle = System.Math.Acos(angle) * 57.2957795131d;
            }
            double sign = (from.x * to.y - from.y * to.x) < 0d ? -1d : 1d;
            return angle * sign;
        }
        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Distance(double2 a, double2 b)
        {
            double x = a.x - b.x;
            double y = a.y - b.y;
            return Mathematics.Math.Sqrt(x * x + y * y);
        }
        /// <summary>
        /// Reflects a vector off the vector defined by a normal.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="normal"></param>
        /// <returns></returns>
        public double2 Reflect(double2 normal)
        {
            double2 refl;
            refl.x = -2d * (normal.x * x + normal.y * y) * normal.x + x;
            refl.y = -2d * (normal.x * x + normal.y * y) * normal.y + y;
            return refl;
        }
        /// <summary>
        /// Returns a copy of vector with its magnitude clamped to maxLength.
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static double2 ClampMagnitude(double2 vector, double maxLength)
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
        public static double2 Min(double2 a, double2 b)
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
        public static double2 Max(double2 a, double2 b)
        {
            a.x = a.x > b.x ? a.x : b.x;
            a.y = a.y > b.y ? a.y : b.y;
            return a;
        }
        /// <summary>
        /// Returns a int2 that contains the smallest integer greater to or equal to f.
        /// </summary>
        [XmlIgnore]
        public int2 CeilToInt
        {
            get
            {
                int2 vec;
                vec.x = (int)Mathematics.Math.Ceil(x);
                vec.y = (int)Mathematics.Math.Ceil(y);
                return vec;
            }
        }
        /// <summary>
        /// Returns a vector that contains the smallest integer greater to or equal to f.
        /// </summary>
        [XmlIgnore]
        public double2 Ceil
        {
            get
            {
                double2 vec;
                vec.x = (int)Mathematics.Math.Ceil(x);
                vec.y = (int)Mathematics.Math.Ceil(y);
                return vec;
            }
        }
        /// <summary>
        /// Freeze the position of desired component of the vector to 0.
        /// </summary>
        /// <param name="freezeAxis"></param>
        /// <returns></returns>
        public double2 FreezeVector(bool2 freezeAxis)
        {
            double2 vec;
            vec.x = freezeAxis.x ? 0d : x;
            vec.y = freezeAxis.y ? 0d : y;
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
        public static double2 SmoothDamp(double2 current, double2 target, ref double2 currentVelocity, double smoothTime, double maxSpeed, double deltaTime)
        {
            smoothTime = 0.0001d > smoothTime ? 0.0001d : smoothTime;
            double omega = 2d / smoothTime;
            double x = omega * deltaTime;
            double exp = 1d / (1d + x + 0.48d * x * x + 0.235d * x * x * x);
            double2 change;
            change.x = current.x - target.x;
            change.y = current.y - target.y;
            double2 originalTo;
            originalTo.x = target.x;
            originalTo.y = target.y;
            double maxChange = maxSpeed * smoothTime;
            change = ClampMagnitude(change, maxChange);
            target = current - change;
            double2 temp;
            temp.x = (currentVelocity.x + omega * change.x) * deltaTime;
            temp.y = (currentVelocity.y + omega * change.y) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * exp;
            double2 output;
            output.x = target.x + (change.x + temp.x) * exp;
            output.y = target.y + (change.y + temp.y) * exp;
            if (((originalTo.x - current.x) * (output.x - originalTo.x) + (originalTo.x - current.x) * (output.y - originalTo.y)) > 0d)
            {
                output = originalTo;
                currentVelocity = (output - originalTo) / deltaTime;
            }
            return output;
        }
        public static double2 operator -(double2 a)
        {
            a.x = -a.x;
            a.y = -a.y;
            return a;
        }
        public static double2 operator +(double2 a, double2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static double2 operator +(double a, double2 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            return b;
        }
        public static double2 operator +(double2 a, double b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            return a;
        }
        public static double2 operator -(double2 a, double2 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return b;
        }
        public static double2 operator -(double a, double2 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            return b;
        }
        public static double2 operator -(double2 a, double b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            return a;
        }
        public static double2 operator *(double2 a, double2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static double2 operator *(double a, double2 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            return b;
        }
        public static double2 operator *(double2 b, double a)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            return b;
        }
        public static double2 operator %(double2 a, double2 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return b;
        }
        public static double2 operator %(double a, double2 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            return b;
        }
        public static double2 operator %(double2 b, double a)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            return b;
        }
        public static double2 operator /(double2 a, double2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static double2 operator /(double a, double2 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            return b;
        }
        public static double2 operator /(double2 a, double b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            return a;
        }
        public static double2 operator +(double2 a, float2 b)
        {
            a.x = a.x + b.x;
            a.y = a.y + b.y;
            return a;
        }
        public static double2 operator +(float2 a, double2 b)
        {
            b.x = a.x + b.x;
            b.y = a.y + b.y;
            return a;
        }
        public static double2 operator +(float a, double2 b)
        {
            b.x = a + b.x;
            b.y = a + b.y;
            return b;
        }
        public static double2 operator +(double2 a, float b)
        {
            a.x = a.x + b;
            a.y = a.y + b;
            return a;
        }
        public static double2 operator -(double2 a, float2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a;
        }
        public static double2 operator -(float2 a, double2 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return a;
        }
        public static double2 operator -(float a, double2 b)
        {
            b.x = a - b.x;
            b.y = a - b.y;
            return b;
        }
        public static double2 operator -(double2 a, float b)
        {
            a.x = a.x - b;
            a.y = a.y - b;
            return a;
        }
        public static double2 operator *(double2 a, float2 b)
        {
            a.x = a.x * b.x;
            a.y = a.y * b.y;
            return a;
        }
        public static double2 operator *(float2 a, double2 b)
        {
            b.x = a.x * b.x;
            b.y = a.y * b.y;
            return a;
        }
        public static double2 operator *(float a, double2 b)
        {
            b.x = a * b.x;
            b.y = a * b.y;
            return b;
        }
        public static double2 operator *(double2 a, float b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            return a;
        }
        public static double2 operator /(double2 a, float2 b)
        {
            a.x = a.x / b.x;
            a.y = a.y / b.y;
            return a;
        }
        public static double2 operator /(float2 a, double2 b)
        {
            b.x = a.x / b.x;
            b.y = a.y / b.y;
            return a;
        }
        public static double2 operator /(float a, double2 b)
        {
            b.x = a / b.x;
            b.y = a / b.y;
            return b;
        }
        public static double2 operator /(double2 a, float b)
        {
            a.x = a.x / b;
            a.y = a.y / b;
            return a;
        }
        public static double2 operator %(double2 a, float2 b)
        {
            a.x = a.x % b.x;
            a.y = a.y % b.y;
            return a;
        }
        public static double2 operator %(float2 a, double2 b)
        {
            b.x = a.x % b.x;
            b.y = a.y % b.y;
            return a;
        }
        public static double2 operator %(float a, double2 b)
        {
            b.x = a % b.x;
            b.y = a % b.y;
            return b;
        }
        public static double2 operator %(double2 a, float b)
        {
            a.x = a.x % b;
            a.y = a.y % b;
            return a;
        }
        public static bool operator ==(double2 a, double2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a.x * a.x + a.y * a.y < 0.000000000001d;
        }
        public static bool operator !=(double2 a, double2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a.x * a.x + a.y * a.y >= 0.000000000001d;
        }
        public static bool operator ==(double2 a, float2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a.x * a.x + a.y * a.y < 0.000000000001d;
        }
        public static bool operator !=(double2 a, float2 b)
        {
            a.x = a.x - b.x;
            a.y = a.y - b.y;
            return a.x * a.x + a.y * a.y >= 0.000000000001d;
        }
        public static bool operator ==(float2 a, double2 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return a.x * a.x + a.y * a.y < 0.000000000001d;
        }
        public static bool operator !=(float2 a, double2 b)
        {
            b.x = a.x - b.x;
            b.y = a.y - b.y;
            return a.x * a.x + a.y * a.y >= 0.000000000001d;
        }
        
        public static explicit operator int2(double2 v)
        {
            int2 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            return vec;
        }
        public static explicit operator int3(double2 v)
        {
            int3 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = 0;
            return vec;
        }
        public static explicit operator int4(double2 v)
        {
            int4 vec;
            vec.x = (int)v.x;
            vec.y = (int)v.y;
            vec.z = 0;
            vec.w = 0;
            return vec;
        }
        public static implicit operator double3(double2 v)
        {
            double3 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0d;
            return vec;
        }
        public static explicit operator bool2(double2 v)
        {
            bool2 vec;
            vec.x = v.x != 0d;
            vec.y = v.y != 0d;
            return vec;
        }
        public static explicit operator bool3(double2 v)
        {
            bool3 vec;
            vec.x = v.x != 0d;
            vec.y = v.y != 0d;
            vec.z = false;
            return vec;
        }
        public static implicit operator double4(double2 v)
        {
            double4 vec;
            vec.x = v.x;
            vec.y = v.y;
            vec.z = 0d;
            vec.w = 0d;
            return vec;
        }
        public static implicit operator bool4(double2 v)
        {
            bool4 vec;
            vec.x = v.x != 0d;
            vec.y = v.y != 0d;
            vec.z = false;
            vec.w = false;
            return vec;
        }
        public static explicit operator float2(double2 v)
        {
            float2 vec;
            vec.x = (float)v.x;
            vec.y = (float)v.y;
            return vec;
        }
        public static explicit operator float3(double2 v)
        {
            float3 vec;
            vec.x = (float)v.x;
            vec.y = (float)v.y;
            vec.z = 0f;
            return vec;
        }
        public static explicit operator float4(double2 v)
        {
            float4 vec;
            vec.x = (float)v.x;
            vec.y = (float)v.y;
            vec.z = 0f;
            vec.w = 0f;
            return vec;
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, 0).
        /// </summary>
        [XmlIgnore]
        public static double2 Zero
        {
            get
            {
                double2 vec;
                vec.x = 0d;
                vec.y = 0d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(0.5, 0.5).
        /// </summary>
        [XmlIgnore]
        public static double2 Half
        {
            get
            {
                double2 vec;
                vec.x = 0.5d;
                vec.y = 0.5d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(1, 1).
        /// </summary>
        [XmlIgnore]
        public static double2 One
        {
            get
            {
                double2 vec;
                vec.x = 1d;
                vec.y = 1d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, 1).
        /// </summary>
        [XmlIgnore]
        public static double2 Up
        {
            get
            {
                double2 vec;
                vec.x = 0d;
                vec.y = 1d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(0, -1).
        /// </summary>
        [XmlIgnore]
        public static double2 Down
        {
            get
            {
                double2 vec;
                vec.x = 0d;
                vec.y = -1d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(-1, 0).
        /// </summary>
        [XmlIgnore]
        public static double2 Left
        {
            get
            {
                double2 vec;
                vec.x = -1d;
                vec.y = 0d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(1, 0).
        /// </summary>
        [XmlIgnore]
        public static double2 Right
        {
            get
            {
                double2 vec;
                vec.x = 1d;
                vec.y = 0d;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(double.PositiveInfinity, double.PositiveInfinity).
        /// </summary>
        [XmlIgnore]
        public static double2 PositiveInfinity
        {
            get
            {
                double2 vec;
                vec.x = double.PositiveInfinity;
                vec.y = double.PositiveInfinity;
                return vec;
            }
        }
        /// <summary>
        /// Shorthand for writing Vector2(double.NegativeInfinity, double.NegativeInfinity).
        /// </summary>
        [XmlIgnore]
        public static double2 NegativeInfinity
        {
            get
            {
                double2 vec;
                vec.x = double.NegativeInfinity;
                vec.y = double.NegativeInfinity;
                return vec;
            }
        }
        /// <summary>
        /// Return the angle between the direction of both vectors.
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public double AngleBetweenDirections(double2 to)
        {
            double denominator = Mathematics.Math.Sqrt((x * x + y * y) * (to.x * to.x + to.y * to.y));
            if (denominator < 1e-15d)
            {
                return 0d;
            }
            double valu = (x * to.x + y * to.y) / denominator;
            return System.Math.Acos(valu < -1d ? -1d : (valu > 1d ? 1d : valu)) * 57.2957795131d;
        }
        /// <summary>
        /// Moves a point current towards target.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="maxDistanceDelta"></param>
        /// <returns></returns>
        public double2 MoveTowards(double2 target, double maxDistanceDelta)
        {
            double2 toVector;
            toVector.x = target.x - x;
            toVector.y = target.y - y;
            double dist = Mathematics.Math.Sqrt(toVector.x * toVector.x + toVector.y * toVector.y);
            return (dist <= maxDistanceDelta || dist == 0d) ? target : this + toVector / dist * maxDistanceDelta;
        }
        /// <summary>
        /// Return the dot product angle of both vectors.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public double DotProductAngle(double2 target)
        {
            double2 normThis = Normalized;
            target.Normalize();
            normThis.x = normThis.x * target.x + normThis.y * target.y;
            normThis.x = normThis.x > 1d ? 1d : normThis.x < -1d ? -1d : normThis.x;
            return System.Math.Acos(normThis.x);
        }
        /// <summary>
        /// Returns the signed angle in degrees between from and to.
        /// </summary>
        /// <param name="to"></param>
        /// <returns></returns>
        public double SignedAngle(double2 to)
        {
            double denominator = Mathematics.Math.Sqrt((x * x + y * y) * (to.x * to.x + to.y * to.y));
            if (denominator < 1e-15d)
            {
                return 0d;
            }
            double a = x * to.y - x * to.x;
            a = a > 0d ? 1d : -1d;
            double valu = (x * to.x + y * to.y) / denominator;
            return (System.Math.Acos(valu < -1d ? -1d : (valu > 1d ? 1d : valu)) * 57.2957795131d) * a;
        }
    }
}
