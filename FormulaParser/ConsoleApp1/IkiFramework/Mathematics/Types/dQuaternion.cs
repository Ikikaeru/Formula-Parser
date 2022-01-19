using System;
using System.Xml.Serialization;
using IkiCore.Core;
namespace IkiCore.Mathematics
{
	public partial struct dQuaternion : IEquatable<dQuaternion>
    {
        /// <summary>
        /// X component of the Quaternion. Don't modify this directly unless you know quaternions inside out.
        /// </summary>
        public double x;
        /// <summary>
        /// Y component of the Quaternion. Don't modify this directly unless you know quaternions inside out.
        /// </summary>
        public double y;
        /// <summary>
        /// Z component of the Quaternion. Don't modify this directly unless you know quaternions inside out.
        /// </summary>
        public double z;
        /// <summary>
        /// W component of the Quaternion. Do not directly modify quaternions.
        /// </summary>
        public double w;
        /// <summary>
        /// Constructs new Quaternion with given x,y,z,w components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public dQuaternion(double x = 0d, double y = 0d, double z = 0d, double w = 0d)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        /// <summary>
        /// Returns or sets the euler angle representation of the rotation in radians.
        /// </summary>
        [XmlIgnore]
        public double3 EulerAngle
        {
            get
            {
                double3 v;
                v.y = System.Math.Atan2(2f * (w * y + z * x), 1f - 2f * (x * x + y * y));
                v.x = System.Math.Asin(2f * (w * x - y * z));
                v.z = System.Math.Atan2(2f * (w * z + x * y), 1f - 2f * (z * z + x * x));
                return v;
            }
            set
            {
                double num6 = System.Math.Sin(value.z * 0.5d);
                double num5 = System.Math.Cos(value.z * 0.5d);
                double num4 = System.Math.Sin(value.x * 0.5d);
                double num3 = System.Math.Cos(value.x * 0.5d);
                double num2 = System.Math.Sin(value.y * 0.5d);
                double num = System.Math.Cos(value.y * 0.5d);
                x = ((num * num4) * num5) + ((num2 * num3) * num6);
                y = ((num2 * num3) * num5) - ((num * num4) * num6);
                z = ((num * num3) * num6) - ((num2 * num4) * num5);
                w = ((num * num3) * num5) + ((num2 * num4) * num6);
            }
        }
        /// <summary>
        /// The identity rotation
        /// </summary>
        [XmlIgnore]
        public static dQuaternion Identity
        {
            get
            {
                dQuaternion dQ;
                dQ.x = 0d;
                dQ.y = 0d;
                dQ.z = 0d;
                dQ.w = 0d;
                return dQ;
            }
        }
        /// <summary>
        /// Returns the conjugate of a quaternion value.
        /// </summary>
        [XmlIgnore]
        public dQuaternion Conjugate
        {
            get
            {
                dQuaternion dQ;
                dQ.x = -x;
                dQ.y = -y;
                dQ.z = -z;
                dQ.w = w;
                return dQ;
            }
        }
        /// <summary>
        /// Set the conjugate of the quaternion's value.
        /// </summary>
        public void SetConjugate()
        {
            x = -x;
            y = -y;
            z = -z;
        }
        /// <summary>
        /// Returns this quaternion with a magnitude of 1.
        /// </summary>
        [XmlIgnore]
        public dQuaternion Normalized
        {
            get
            {
                double l = Math.Sqrt(x * x + y * y + z * z + w * w);
                dQuaternion q;
                q.x = x / l;
                q.y = y / l;
                q.z = z / l;
                q.w = w / l;
                return q;
            }
        }
        /// <summary>
        /// Converts this quaternion to one with the same orientation but with a magnitude of 1.
        /// </summary>
        public void Normalize()
        {
            double l = Math.Sqrt(x * x + y * y + z * z + w * w);
            x = x / l;
            y = y / l;
            z = z / l;
            w = w / l;
        }
        /// <summary>
        /// Returns the angle in radians between two rotations a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Angle(dQuaternion a, dQuaternion b)
        {
            return System.Math.Acos(Math.Min(Math.Abs(a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w), 1d)) * 2d;
        }
        /// <summary>
        /// Return a rotation matrix that rotate a certain amount of defree on the x, y and z axis depending on the quaterion.
        /// </summary>
        [XmlIgnore]
        public double4x4 GetMatrix
        {
            get
            {
                double xx = x * (x * 2.0d);
                double yy = y * (y * 2.0d);
                double zz = z * (z * 2.0d);
                double xy = x * (y * 2.0d);
                double xz = x * (z * 2.0d);
                double yz = y * (z * 2.0d);
                double wx = w * (x * 2.0d);
                double wy = w * (y * 2.0d);
                double wz = w * (z * 2.0d);
                double4x4 m;
                m.rc00 = 1.0d - (yy + zz);
                m.rc10 = xy + wz;
                m.rc20 = xz - wy;
                m.rc30 = 0d;
                m.rc01 = xy - wz;
                m.rc11 = 1.0d - (xx + zz);
                m.rc21 = yz + wx;
                m.rc31 = 0d;
                m.rc02 = xz + wy;
                m.rc12 = yz - wx;
                m.rc22 = 1.0d - (xx + yy);
                m.rc32 = 0d;
                m.rc03 = 0d;
                m.rc13 = 0d;
                m.rc23 = 0d;
                m.rc33 = 1d;
                return m;
            }
        }
        /// <summary>
        /// Rotates a rotation from towards to.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="maxDegreesDelta"></param>
        /// <returns></returns>
        public static dQuaternion RotateTowards(dQuaternion a, dQuaternion b, double maxDegreesDelta)
        {
            double angle = System.Math.Acos(Math.Min(Math.Abs(a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w), 1d)) * 2d;
            if (angle == 0d)
            {
                return b;
            }
            double t = Math.Min(1d, maxDegreesDelta / angle);
            if (a.SqrMagnitude == 0.0)
            {
                if (b.SqrMagnitude == 0.0)
                {
                    return Identity;
                }
                return b;
            }
            else if (b.SqrMagnitude == 0.0)
            {
                return a;
            }
            double cosHalfAngle = a.w * b.w + (a.x * b.x + a.y * b.y + a.z * b.z);
            if (cosHalfAngle >= 1.0 || cosHalfAngle <= -1.0)
            {
                return a;
            }
            else if (cosHalfAngle < 0.0)
            {
                b.x = -b.x;
                b.y = -b.y;
                b.z = -b.z;
                b.w = -b.w;
                cosHalfAngle = -cosHalfAngle;
            }
            double blendA;
            double blendB;
            if (cosHalfAngle < 0.99)
            {
                double halfAngle = System.Math.Acos(cosHalfAngle);
                double oneOverSinHalfAngle = 1.0 / System.Math.Sin(halfAngle);
                blendA = System.Math.Sin(halfAngle * (1.0 - t)) * oneOverSinHalfAngle;
                blendB = System.Math.Sin(halfAngle * t) * oneOverSinHalfAngle;
            }
            else
            {
                blendA = 1.0d - t;
                blendB = t;
            }
            dQuaternion result;
            result.x = blendA * a.x + blendB * b.x;
            result.y = blendA * a.y + blendB * b.y;
            result.z = blendA * a.z + blendB * b.z;
            result.w = blendA * a.w + blendB * b.w;
            cosHalfAngle = result.SqrMagnitude;
            if (cosHalfAngle > 0.0)
            {
                cosHalfAngle = Math.Sqrt(cosHalfAngle);
                result.x = result.x / cosHalfAngle;
                result.y = result.y / cosHalfAngle;
                result.z = result.z / cosHalfAngle;
                result.w = result.w / cosHalfAngle;
                return result;
            }
            return Identity;
        }
        /// <summary>
        /// Set the quaternion depending on a rotation matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static dQuaternion RotationMatrix(double3x3 matrix)
        {
            double num8 = (matrix.rc00 + matrix.rc11) + matrix.rc22;
            dQuaternion quaternion = new dQuaternion();
            if (num8 > 0d)
            {
                num8 = Math.Sqrt((num8 + 1d));
                quaternion.w = num8 * 0.5d;
                num8 = 0.5d / num8;
                quaternion.x = (matrix.rc21 - matrix.rc12) * num8;
                quaternion.y = (matrix.rc02 - matrix.rc20) * num8;
                quaternion.z = (matrix.rc10 - matrix.rc01) * num8;
                return quaternion;
            }
            if ((matrix.rc00 >= matrix.rc11) && (matrix.rc00 >= matrix.rc22))
            {
                double num7 = Math.Sqrt(1d + matrix.rc00 - matrix.rc11 - matrix.rc22);
                num8 = 0.5d / num7;
                quaternion.x = 0.5d * num7;
                quaternion.y = (matrix.rc10 + matrix.rc01) * num8;
                quaternion.z = (matrix.rc20 + matrix.rc02) * num8;
                quaternion.w = (matrix.rc21 - matrix.rc12) * num8;
                return quaternion;
            }
            if (matrix.rc11 > matrix.rc22)
            {
                double num6 = Math.Sqrt(1d + matrix.rc11 - matrix.rc00 - matrix.rc22);
                num8 = 0.5f / num6;
                quaternion.x = (matrix.rc01 + matrix.rc10) * num8;
                quaternion.y = 0.5d * num6;
                quaternion.z = (matrix.rc12 + matrix.rc21) * num8;
                quaternion.w = (matrix.rc02 - matrix.rc20) * num8;
                return quaternion;
            }
            double num5 = Math.Sqrt(1d + matrix.rc22 - matrix.rc00 - matrix.rc11);
            num8 = 0.5d / num5;
            quaternion.x = (matrix.rc02 + matrix.rc20) * num8;
            quaternion.y = (matrix.rc12 + matrix.rc21) * num8;
            quaternion.z = 0.5d * num5;
            quaternion.w = (matrix.rc10 - matrix.rc01) * num8;
            return quaternion;
        }
        /// <summary>
        /// Set the quaternion depending on a rotation matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static dQuaternion RotationMatrix(double4x4 matrix)
        {
            double num8 = (matrix.rc00 + matrix.rc11) + matrix.rc22;
            dQuaternion quaternion = new dQuaternion();
            if (num8 > 0d)
            {
                num8 = Math.Sqrt((num8 + 1d));
                quaternion.w = num8 * 0.5d;
                num8 = 0.5d / num8;
                quaternion.x = (matrix.rc21 - matrix.rc12) * num8;
                quaternion.y = (matrix.rc02 - matrix.rc20) * num8;
                quaternion.z = (matrix.rc10 - matrix.rc01) * num8;
                return quaternion;
            }
            if ((matrix.rc00 >= matrix.rc11) && (matrix.rc00 >= matrix.rc22))
            {
                double num7 = Math.Sqrt(1d + matrix.rc00 - matrix.rc11 - matrix.rc22);
                num8 = 0.5d / num7;
                quaternion.x = 0.5d * num7;
                quaternion.y = (matrix.rc10 + matrix.rc01) * num8;
                quaternion.z = (matrix.rc20 + matrix.rc02) * num8;
                quaternion.w = (matrix.rc21 - matrix.rc12) * num8;
                return quaternion;
            }
            if (matrix.rc11 > matrix.rc22)
            {
                double num6 = Math.Sqrt(1d + matrix.rc11 - matrix.rc00 - matrix.rc22);
                num8 = 0.5d / num6;
                quaternion.x = (matrix.rc01 + matrix.rc10) * num8;
                quaternion.y = 0.5d * num6;
                quaternion.z = (matrix.rc12 + matrix.rc21) * num8;
                quaternion.w = (matrix.rc02 - matrix.rc20) * num8;
                return quaternion;
            }
            double num5 = Math.Sqrt(1d + matrix.rc22 - matrix.rc00 - matrix.rc11);
            num8 = 0.5d / num5;
            quaternion.x = (matrix.rc02 + matrix.rc20) * num8;
            quaternion.y = (matrix.rc12 + matrix.rc21) * num8;
            quaternion.z = 0.5d * num5;
            quaternion.w = (matrix.rc10 - matrix.rc01) * num8;
            return quaternion;
        }
        /// <summary>
        /// The dot product between two rotations.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static double Dot(dQuaternion a, dQuaternion b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }
        /// <summary>
        /// Creates a rotation which rotates angle degrees (in radian) around axis.
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static dQuaternion AngleAxis(double3 axis, double angle)
        {
            angle = angle * 0.5d;
            double num = System.Math.Sin(angle);
            dQuaternion quaternion;
            quaternion.x = axis.x * num;
            quaternion.y = axis.y * num;
            quaternion.z = axis.z * num;
            quaternion.w = System.Math.Cos(angle);
            return quaternion;
        }
        /// <summary>
        /// Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis. Euler angle need to be in radian.
        /// </summary>
        /// <param name="euler"></param>
        /// <returns></returns>
        public static dQuaternion Euler(double3 euler)
        {
            dQuaternion quaternion;
            double num6 = System.Math.Sin(euler.z * 0.5d);
            double num5 = System.Math.Cos(euler.z * 0.5d);
            double num4 = System.Math.Sin(euler.x * 0.5d);
            double num3 = System.Math.Cos(euler.x * 0.5d);
            double num2 = System.Math.Sin(euler.y * 0.5d);
            double num = System.Math.Cos(euler.y * 0.5d);
            quaternion.x = ((num * num4) * num5) + ((num2 * num3) * num6);
            quaternion.y = ((num2 * num3) * num5) - ((num * num4) * num6);
            quaternion.z = ((num * num3) * num6) - ((num2 * num4) * num5);
            quaternion.w = ((num * num3) * num5) + ((num2 * num4) * num6);
            return quaternion;
        }
        /// <summary>
        /// Concatenates two Quaternions. The result represents the value1 rotation followed by the value2 rotation.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static dQuaternion Concatenate(dQuaternion value1, dQuaternion value2)
        {
            dQuaternion quaternion;
            quaternion.x = ((value2.x * value1.w) + (value1.x * value2.w)) + ((value2.y * value1.z) - (value2.z * value1.y));
            quaternion.y = ((value2.y * value1.w) + (value1.y * value2.w)) + ((value2.z * value1.x) - (value2.x * value1.z));
            quaternion.z = ((value2.z * value1.w) + (value1.z * value2.w)) + ((value2.x * value1.y) - (value2.y * value1.x));
            quaternion.w = (value2.w * value1.w) - (((value2.x * value1.x) + (value2.y * value1.y)) + (value2.z * value1.z));
            return quaternion;
        }
        /// <summary>
        /// Creates a rotation with the specified forward and upwards directions.
        /// </summary>
        /// <param name="forward"></param>
        /// <returns></returns>
        public static dQuaternion LookRotation(double3 forward)
        {
            double3 t = double3.Up.Cross(forward).Normalized;
            double3 fct = forward.Cross(t);
            double3x3 f3;
            f3.rc00 = t.x;
            f3.rc10 = t.y;
            f3.rc20 = t.z;
            f3.rc01 = fct.x;
            f3.rc11 = fct.y;
            f3.rc21 = fct.z;
            f3.rc02 = forward.x;
            f3.rc12 = forward.y;
            f3.rc22 = forward.z;
            return RotationMatrix(f3);
        }
        /// <summary>
        /// Creates a rotation with the specified forward and upwards directions. Both vectors must be normalized.
        /// </summary>
        /// <param name="forward"></param>
        /// <param name="up"></param>
        /// <returns></returns>
        public static dQuaternion LookRotation(double3 forward, double3 up)
        {
            double3 t = up.Cross(forward).Normalized;
            double3 fct = forward.Cross(t);
            double3x3 f3;
            f3.rc00 = t.x;
            f3.rc10 = t.y;
            f3.rc20 = t.z;
            f3.rc01 = fct.x;
            f3.rc11 = fct.y;
            f3.rc21 = fct.z;
            f3.rc02 = forward.x;
            f3.rc12 = forward.y;
            f3.rc22 = forward.z;
            return RotationMatrix(f3);
        }
        /// <summary>
        /// Creates a rotation which rotates from fromDirection to toDirection.
        /// </summary>
        /// <param name="fromDirection"></param>
        /// <param name="toDirection"></param>
        /// <returns></returns>
        public static dQuaternion FromToRotation(double3 fromDirection, double3 toDirection)
        {
            return RotateTowards(LookRotation(fromDirection), LookRotation(toDirection), double.MaxValue);
        }
        /// <summary>
        /// Returns the Inverse of rotation.
        /// </summary>
        /// <param name="quaternion"></param>
        /// <returns></returns>
        public static dQuaternion Inversed(dQuaternion quaternion)
        {
            dQuaternion quaternion2;
            double num = 1d / ((((quaternion.x * quaternion.x) + (quaternion.y * quaternion.y)) + (quaternion.z * quaternion.z)) + (quaternion.w * quaternion.w));
            quaternion2.x = -quaternion.x * num;
            quaternion2.y = -quaternion.y * num;
            quaternion2.z = -quaternion.z * num;
            quaternion2.w = quaternion.w * num;
            return quaternion2;
        }
        /// <summary>
        /// Returns the Inverse of rotation.
        /// </summary>
        [XmlIgnore]
        public dQuaternion Inverse
        {
            get
            {
                dQuaternion quaternion;
                double num = 1d / ((((x * x) + (y * y)) + (z * z)) + (w * w));
                quaternion.x = -x * num;
                quaternion.y = -y * num;
                quaternion.z = -z * num;
                quaternion.w = w * num;
                return quaternion;
            }
        }
        /// <summary>
        /// Gets the length of the quaternion.
        /// </summary>
        [XmlIgnore]
        public double Magnitude
        {
            get
            {
                return Math.Sqrt(x * x + y * y + z * z + w * w);
            }
        }
        /// <summary>
        /// Gets the square of the quaternion's length (magnitude).
        /// </summary>
        [XmlIgnore]
        public double SqrMagnitude
        {
            get
            {
                return x * x + y * y + z * z + w * w;
            }
        }
        /// <summary>
        /// Interpolates between a and b by t and normalizes the result afterwards. The parameter t is clamped to the range [0, 1].
        /// </summary>
        /// <param name="quaternion1"></param>
        /// <param name="quaternion2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static dQuaternion Lerp(dQuaternion quaternion1, dQuaternion quaternion2, double t)
        {
            t = t > 1.0 ? 1.0 : t < 0.0 ? 0.0 : t;
            double num = t;
            double num2 = 1d - num;
            dQuaternion quaternion;
            if (((((quaternion1.x * quaternion2.x) + (quaternion1.y * quaternion2.y)) + (quaternion1.z * quaternion2.z)) + (quaternion1.w * quaternion2.w)) >= 0d)
            {
                quaternion.x = (num2 * quaternion1.x) + (num * quaternion2.x);
                quaternion.y = (num2 * quaternion1.y) + (num * quaternion2.y);
                quaternion.z = (num2 * quaternion1.z) + (num * quaternion2.z);
                quaternion.w = (num2 * quaternion1.w) + (num * quaternion2.w);
            }
            else
            {
                quaternion.x = (num2 * quaternion1.x) - (num * quaternion2.x);
                quaternion.y = (num2 * quaternion1.y) - (num * quaternion2.y);
                quaternion.z = (num2 * quaternion1.z) - (num * quaternion2.z);
                quaternion.w = (num2 * quaternion1.w) - (num * quaternion2.w);
            }
            num = 1d / (Math.Sqrt((((quaternion.x * quaternion.x) + (quaternion.y * quaternion.y)) + (quaternion.z * quaternion.z)) + (quaternion.w * quaternion.w)));
            quaternion.x = quaternion.x * num;
            quaternion.y = quaternion.y * num;
            quaternion.z = quaternion.z * num;
            quaternion.w = quaternion.w * num;
            return quaternion;
        }
        /// <summary>
        /// Interpolates between a and b by t and normalizes the result afterwards. The parameter t is not clamped.
        /// </summary>
        /// <param name="quaternion1"></param>
        /// <param name="quaternion2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static dQuaternion LerpUnclamped(dQuaternion quaternion1, dQuaternion quaternion2, double t)
        {
            double num = t;
            double num2 = 1d - num;
            dQuaternion quaternion;
            if (((((quaternion1.x * quaternion2.x) + (quaternion1.y * quaternion2.y)) + (quaternion1.z * quaternion2.z)) + (quaternion1.w * quaternion2.w)) >= 0d)
            {
                quaternion.x = (num2 * quaternion1.x) + (num * quaternion2.x);
                quaternion.y = (num2 * quaternion1.y) + (num * quaternion2.y);
                quaternion.z = (num2 * quaternion1.z) + (num * quaternion2.z);
                quaternion.w = (num2 * quaternion1.w) + (num * quaternion2.w);
            }
            else
            {
                quaternion.x = (num2 * quaternion1.x) - (num * quaternion2.x);
                quaternion.y = (num2 * quaternion1.y) - (num * quaternion2.y);
                quaternion.z = (num2 * quaternion1.z) - (num * quaternion2.z);
                quaternion.w = (num2 * quaternion1.w) - (num * quaternion2.w);
            }
            num = 1d / (Math.Sqrt((((quaternion.x * quaternion.x) + (quaternion.y * quaternion.y)) + (quaternion.z * quaternion.z)) + (quaternion.w * quaternion.w)));
            quaternion.x = quaternion.x * num;
            quaternion.y = quaternion.y * num;
            quaternion.z = quaternion.z * num;
            quaternion.w = quaternion.w * num;
            return quaternion;
        }
        /// <summary>
        /// Spherically interpolates between a and b by t. The parameter t is clamped to the range [0, 1].
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static dQuaternion Slerp(dQuaternion a, dQuaternion b, double t)
        {
            if (a.SqrMagnitude == 0.0)
            {
                if (b.SqrMagnitude == 0.0)
                {
                    return Identity;
                }
                return b;
            }
            else if (b.SqrMagnitude == 0.0)
            {
                return a;
            }
            double cosHalfAngle = a.w * b.w + (a.x * b.x + a.y * b.y + a.z * b.z);
            if (cosHalfAngle >= 1.0 || cosHalfAngle <= -1.0)
            {
                return a;
            }
            else if (cosHalfAngle < 0.0)
            {
                b.x = -b.x;
                b.y = -b.y;
                b.z = -b.z;
                b.w = -b.w;
                cosHalfAngle = -cosHalfAngle;
            }
            double blendA;
            double blendB;
            t = t > 1.0 ? 1.0 : t < 0.0 ? 0.0 : t;
            if (cosHalfAngle < 0.99)
            {
                double halfAngle = System.Math.Acos(cosHalfAngle);
                double oneOverSinHalfAngle = 1.0 / System.Math.Sin(halfAngle);
                blendA = System.Math.Sin(halfAngle * (1.0 - t)) * oneOverSinHalfAngle;
                blendB = System.Math.Sin(halfAngle * t) * oneOverSinHalfAngle;
            }
            else
            {
                blendA = 1.0d - t;
                blendB = t;
            }
            dQuaternion result;
            result.x = blendA * a.x + blendB * b.x;
            result.y = blendA * a.y + blendB * b.y;
            result.z = blendA * a.z + blendB * b.z;
            result.w = blendA * a.w + blendB * b.w;
            cosHalfAngle = result.SqrMagnitude;
            if (cosHalfAngle > 0.0)
            {
                cosHalfAngle = Math.Sqrt(cosHalfAngle);
                result.x = result.x / cosHalfAngle;
                result.y = result.y / cosHalfAngle;
                result.z = result.z / cosHalfAngle;
                result.w = result.w / cosHalfAngle;
                return result;
            }
            return Identity;
        }
        /// <summary>
        /// Spherically interpolates between a and b by t. The parameter t is not clamped.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static dQuaternion SlerpUnclamped(dQuaternion a, dQuaternion b, double t)
        {
            if (a.SqrMagnitude == 0.0)
            {
                if (b.SqrMagnitude == 0.0)
                {
                    return Identity;
                }
                return b;
            }
            else if (b.SqrMagnitude == 0.0)
            {
                return a;
            }
            double cosHalfAngle = a.w * b.w + (a.x * b.x + a.y * b.y + a.z * b.z);
            if (cosHalfAngle >= 1.0 || cosHalfAngle <= -1.0)
            {
                return a;
            }
            else if (cosHalfAngle < 0.0)
            {
                b.x = -b.x;
                b.y = -b.y;
                b.z = -b.z;
                b.w = -b.w;
                cosHalfAngle = -cosHalfAngle;
            }
            double blendA;
            double blendB;
            if (cosHalfAngle < 0.99)
            {
                double halfAngle = System.Math.Acos(cosHalfAngle);
                double oneOverSinHalfAngle = 1.0 / System.Math.Sin(halfAngle);
                blendA = System.Math.Sin(halfAngle * (1.0 - t)) * oneOverSinHalfAngle;
                blendB = System.Math.Sin(halfAngle * t) * oneOverSinHalfAngle;
            }
            else
            {
                blendA = 1.0d - t;
                blendB = t;
            }
            dQuaternion result;
            result.x = blendA * a.x + blendB * b.x;
            result.y = blendA * a.y + blendB * b.y;
            result.z = blendA * a.z + blendB * b.z;
            result.w = blendA * a.w + blendB * b.w;
            cosHalfAngle = result.SqrMagnitude;
            if (cosHalfAngle > 0.0)
            {
                cosHalfAngle = Math.Sqrt(cosHalfAngle);
                result.x = result.x / cosHalfAngle;
                result.y = result.y / cosHalfAngle;
                result.z = result.z / cosHalfAngle;
                result.w = result.w / cosHalfAngle;
                return result;
            }
            return Identity;
        }
        public override bool Equals(object obj)
        {
            if (obj is dQuaternion)
            {
                return Equals((dQuaternion)obj);
            }
            return false;
        }
        public bool Equals(dQuaternion other)
        {
            return ((((x == other.x) && (y == other.y)) && (z == other.z)) && (w == other.w));
        }
        public override int GetHashCode()
        {
            return (((x.GetHashCode() + y.GetHashCode()) + z.GetHashCode()) + w.GetHashCode());
        }
        /// <summary>
        /// Returns a nicely formatted string for this vector.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("({0:F1}, {1:F1}, {2:F1})", x, y, z);
        }
        public static bool operator ==(dQuaternion quaternion1, dQuaternion quaternion2)
        {
            return ((((quaternion1.x == quaternion2.x) && (quaternion1.y == quaternion2.y)) && (quaternion1.z == quaternion2.z)) && (quaternion1.w == quaternion2.w));
        }
        public static bool operator !=(dQuaternion quaternion1, dQuaternion quaternion2)
        {
            if (((quaternion1.x == quaternion2.x) && (quaternion1.y == quaternion2.y)) && (quaternion1.z == quaternion2.z))
            {
                return (quaternion1.w != quaternion2.w);
            }
            return true;
        }
        public static dQuaternion operator *(dQuaternion a, double b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            a.w = a.w * b;
            return a;
        }
        public static dQuaternion operator *(double b, dQuaternion a)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            a.w = a.w * b;
            return a;
        }
        public static dQuaternion operator *(dQuaternion lhs, dQuaternion rhs)
        {
            dQuaternion q;
            q.x = lhs.w * rhs.x + lhs.x * rhs.w + lhs.y * rhs.z - lhs.z * rhs.y;
            q.y = lhs.w * rhs.y + lhs.y * rhs.w + lhs.z * rhs.x - lhs.x * rhs.z;
            q.z = lhs.w * rhs.z + lhs.z * rhs.w + lhs.x * rhs.y - lhs.y * rhs.x;
            q.w = lhs.w * rhs.w - lhs.x * rhs.x - lhs.y * rhs.y - lhs.z * rhs.z;
            return q;
        }
        public static double3 operator *(dQuaternion rotation, double3 point)
        {
            double num1 = rotation.x * 2d;
            double num2 = rotation.y * 2d;
            double num3 = rotation.z * 2d;
            double num4 = rotation.x * num1;
            double num5 = rotation.y * num2;
            double num6 = rotation.z * num3;
            double num7 = rotation.x * num2;
            double num8 = rotation.x * num3;
            double num9 = rotation.y * num3;
            double num10 = rotation.w * num1;
            double num11 = rotation.w * num2;
            double num12 = rotation.w * num3;
            double3 vector3;
            vector3.x = (1.0 - (num5 + num6)) * point.x + (num7 - num12) * point.y + (num8 + num11) * point.z;
            vector3.y = (num7 + num12) * point.x + (1.0 - (num4 + num6)) * point.y + (num9 - num10) * point.z;
            vector3.z = (num8 - num11) * point.x + (num9 + num10) * point.y + (1.0 - (num4 + num5)) * point.z;
            return vector3;
        }
        public static double3 operator *(double3 point, dQuaternion rotation)
        {
            double num1 = rotation.x * 2d;
            double num2 = rotation.y * 2d;
            double num3 = rotation.z * 2d;
            double num4 = rotation.x * num1;
            double num5 = rotation.y * num2;
            double num6 = rotation.z * num3;
            double num7 = rotation.x * num2;
            double num8 = rotation.x * num3;
            double num9 = rotation.y * num3;
            double num10 = rotation.w * num1;
            double num11 = rotation.w * num2;
            double num12 = rotation.w * num3;
            double3 vector3;
            vector3.x = (1.0 - (num5 + num6)) * point.x + (num7 - num12) * point.y + (num8 + num11) * point.z;
            vector3.y = (num7 + num12) * point.x + (1.0 - (num4 + num6)) * point.y + (num9 - num10) * point.z;
            vector3.z = (num8 - num11) * point.x + (num9 + num10) * point.y + (1.0 - (num4 + num5)) * point.z;
            return vector3;
        }
        public static dQuaternion operator +(dQuaternion quaternion1, dQuaternion quaternion2)
        {
            quaternion1.x = quaternion1.x + quaternion2.x;
            quaternion1.y = quaternion1.y + quaternion2.y;
            quaternion1.z = quaternion1.z + quaternion2.z;
            quaternion1.w = quaternion1.w + quaternion2.w;
            return quaternion1;
        }
        public static dQuaternion operator -(dQuaternion quaternion1, dQuaternion quaternion2)
        {
            quaternion1.x = quaternion1.x - quaternion2.x;
            quaternion1.y = quaternion1.y - quaternion2.y;
            quaternion1.z = quaternion1.z - quaternion2.z;
            quaternion1.w = quaternion1.w - quaternion2.w;
            return quaternion1;
        }
        public static dQuaternion operator -(dQuaternion quaternion1)
        {
            quaternion1.x = -quaternion1.x;
            quaternion1.y = -quaternion1.y;
            quaternion1.z = -quaternion1.z;
            quaternion1.w = -quaternion1.w;
            return quaternion1;
        }
        public static dQuaternion operator /(dQuaternion quaternion1, dQuaternion quaternion2)
        {
            dQuaternion quaternion;
            double num5 = 1d / ((((quaternion2.x * quaternion2.x) + (quaternion2.y * quaternion2.y)) + (quaternion2.z * quaternion2.z)) + (quaternion2.w * quaternion2.w));
            double num4 = -quaternion2.x * num5;
            double num3 = -quaternion2.y * num5;
            double num2 = -quaternion2.z * num5;
            double num = quaternion2.w * num5;
            double num13 = (quaternion1.y * num2) - (quaternion1.z * num3);
            double num12 = (quaternion1.z * num4) - (quaternion1.x * num2);
            double num11 = (quaternion1.x * num3) - (quaternion1.y * num4);
            double num10 = ((quaternion1.x * num4) + (quaternion1.y * num3)) + (quaternion1.z * num2);
            quaternion.x = ((quaternion1.x * num) + (num4 * quaternion1.w)) + num13;
            quaternion.y = ((quaternion1.y * num) + (num3 * quaternion1.w)) + num12;
            quaternion.z = ((quaternion1.z * num) + (num2 * quaternion1.w)) + num11;
            quaternion.w = (quaternion1.w * num) - num10;
            return quaternion;
        }
        public static explicit operator fQuaternion(dQuaternion a)
        {
            fQuaternion b;
            b.x = (float)a.x;
            b.y = (float)a.y;
            b.z = (float)a.z;
            b.w = (float)a.w;
            return b;
        }
    }
}
