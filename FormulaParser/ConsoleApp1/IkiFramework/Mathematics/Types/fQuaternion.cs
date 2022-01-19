using System;
using System.Xml.Serialization;
using IkiCore.Core;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct fQuaternion : IEquatable<fQuaternion>
    {
        /// <summary>
        /// X component of the Quaternion. Don't modify this directly unless you know quaternions inside out.
        /// </summary>
        public float x;
        /// <summary>
        /// Y component of the Quaternion. Don't modify this directly unless you know quaternions inside out.
        /// </summary>
        public float y;
        /// <summary>
        /// Z component of the Quaternion. Don't modify this directly unless you know quaternions inside out.
        /// </summary>
        public float z;
        /// <summary>
        /// W component of the Quaternion. Do not directly modify quaternions.
        /// </summary>
        public float w;
        /// <summary>
        /// Constructs new Quaternion with given x,y,z,w components.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public fQuaternion(float x = 0f, float y = 0f, float z = 0f, float w = 0f)
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
        public float3 EulerAngle
        {
            get
            {
                float3 v;
                v.y = (float)System.Math.Atan2(2f * (w * y + z * x), 1f - 2f * (x * x + y * y));
                v.x = (float)System.Math.Asin(2f * (w * x - y * z));
                v.z = (float)System.Math.Atan2(2f * (w * z + x * y), 1f - 2f * (z * z + x * x));
                return v;
            }
            set
            {
                float num6 = (float)System.Math.Sin(value.z * 0.5f);
                float num5 = (float)System.Math.Cos(value.z * 0.5f);
                float num4 = (float)System.Math.Sin(value.x * 0.5f);
                float num3 = (float)System.Math.Cos(value.x * 0.5f);
                float num2 = (float)System.Math.Sin(value.y * 0.5f);
                float num = (float)System.Math.Cos(value.y * 0.5f);
                x = num * num4 * num5 + num2 * num3 * num6;
                y = num2 * num3 * num5 - num * num4 * num6;
                z = num * num3 * num6 - num2 * num4 * num5;
                w = num * num3 * num5 + num2 * num4 * num6;
            }
        }
        /// <summary>
        /// The identity rotation
        /// </summary>
        [XmlIgnore]
        public static fQuaternion Identity
        {
            get
            {
                fQuaternion dQ;
                dQ.x = 0f;
                dQ.y = 0f;
                dQ.z = 0f;
                dQ.w = 0f;
                return dQ;
            }
        }
        /// <summary>
        /// Returns the conjugate of a quaternion value.
        /// </summary>
        [XmlIgnore]
        public fQuaternion Conjugate
        {
            get
            {
                fQuaternion dQ;
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
        public fQuaternion Normalized
        {
            get
            {
                float l = Math.Sqrt(x * x + y * y + z * z + w * w);
                fQuaternion q;
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
            float l = Math.Sqrt(x * x + y * y + z * z + w * w);
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
        public static float Angle(fQuaternion a, fQuaternion b) => (float)System.Math.Acos(Math.Min(Math.Abs(a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w), 1f)) * 2f;
        /// <summary>
        /// Return a rotation matrix that rotate a certain amount of defree on the x, y and z axis depending on the quaterion.
        /// </summary>
        [XmlIgnore]
        public float4x4 GetMatrix
        {
            get
            {
                float4x4 m;
                m.rc00 = 1.0f - (y * (y * 2.0f) + z * (z * 2.0f));
                m.rc10 = x * (y * 2.0f) + w * (z * 2.0f);
                m.rc20 = x * (z * 2.0f) - w * (y * 2.0f);
                m.rc30 = 0f;
                m.rc01 = x * (y * 2.0f) - w * (z * 2.0f);
                m.rc11 = 1.0f - (x * (x * 2.0f) + z * (z * 2.0f));
                m.rc21 = y * (z * 2.0f) + w * (x * 2.0f);
                m.rc31 = 0f;
                m.rc02 = x * (z * 2.0f) + w * (y * 2.0f);
                m.rc12 = y * (z * 2.0f) - w * (x * 2.0f);
                m.rc22 = 1.0f - (x * (x * 2.0f) + y * (y * 2.0f));
                m.rc32 = 0f;
                m.rc03 = 0f;
                m.rc13 = 0f;
                m.rc23 = 0f;
                m.rc33 = 1f;
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
        public static fQuaternion RotateTowards(fQuaternion a, fQuaternion b, float maxDegreesDelta)
        {
            float angle = (float)System.Math.Acos(Math.Min(Math.Abs(a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w), 1f)) * 2f;
            if (angle == 0f)
            {
                return b;
            }
            float t = Math.Min(1f, maxDegreesDelta / angle);
            if (a.SqrMagnitude == 0.0f)
            {
                if (b.SqrMagnitude == 0.0f)
                {
                    return Identity;
                }
                return b;
            }
            else if (b.SqrMagnitude == 0.0f)
            {
                return a;
            }
            float cosHalfAngle = a.w * b.w + (a.x * b.x + a.y * b.y + a.z * b.z);
            if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
            {
                return a;
            }
            else if (cosHalfAngle < 0.0f)
            {
                b.x = -b.x;
                b.y = -b.y;
                b.z = -b.z;
                b.w = -b.w;
                cosHalfAngle = -cosHalfAngle;
            }
            float blendA;
            float blendB;
            if (cosHalfAngle < 0.99f)
            {
                cosHalfAngle = (float)System.Math.Acos(cosHalfAngle);
                float oneOverSinHalfAngle = 1.0f / (float)System.Math.Sin(cosHalfAngle);
                blendA = (float)System.Math.Sin(cosHalfAngle * (1.0f - t)) * oneOverSinHalfAngle;
                blendB = (float)System.Math.Sin(cosHalfAngle * t) * oneOverSinHalfAngle;
            }
            else
            {
                blendA = 1.0f - t;
                blendB = t;
            }
            a.x = blendA * a.x + blendB * b.x;
            a.y = blendA * a.y + blendB * b.y;
            a.z = blendA * a.z + blendB * b.z;
            a.w = blendA * a.w + blendB * b.w;
            cosHalfAngle = a.SqrMagnitude;
            if (cosHalfAngle > 0.0f)
            {
                cosHalfAngle = (float)Math.Sqrt(cosHalfAngle);
                a.x /= cosHalfAngle;
                a.y /= cosHalfAngle;
                a.z /= cosHalfAngle;
                a.w /= cosHalfAngle;
                return a;
            }
            return Identity;
        }
        /// <summary>
        /// Set the quaternion depending on a rotation matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static fQuaternion RotationMatrix(float3x3 matrix)
        {
            float num8 = (matrix.rc00 + matrix.rc11) + matrix.rc22;
            fQuaternion quaternion;
            if (num8 > 0f)
            {
                num8 = Math.Sqrt((num8 + 1f));
                quaternion.w = num8 * 0.5f;
                num8 = 0.5f / num8;
                quaternion.x = (matrix.rc21 - matrix.rc12) * num8;
                quaternion.y = (matrix.rc02 - matrix.rc20) * num8;
                quaternion.z = (matrix.rc10 - matrix.rc01) * num8;
                return quaternion;
            }
            if ((matrix.rc00 >= matrix.rc11) && (matrix.rc00 >= matrix.rc22))
            {
                float num7 = Math.Sqrt(1f + matrix.rc00 - matrix.rc11 - matrix.rc22);
                num8 = 0.5f / num7;
                quaternion.x = 0.5f * num7;
                quaternion.y = (matrix.rc10 + matrix.rc01) * num8;
                quaternion.z = (matrix.rc20 + matrix.rc02) * num8;
                quaternion.w = (matrix.rc21 - matrix.rc12) * num8;
                return quaternion;
            }
            if (matrix.rc11 > matrix.rc22)
            {
                float num6 = Math.Sqrt(1f + matrix.rc11 - matrix.rc00 - matrix.rc22);
                num8 = 0.5f / num6;
                quaternion.x = (matrix.rc01 + matrix.rc10) * num8;
                quaternion.y = 0.5f * num6;
                quaternion.z = (matrix.rc12 + matrix.rc21) * num8;
                quaternion.w = (matrix.rc02 - matrix.rc20) * num8;
                return quaternion;
            }
            float num5 = Math.Sqrt(1f + matrix.rc22 - matrix.rc00 - matrix.rc11);
            num8 = 0.5f / num5;
            quaternion.x = (matrix.rc02 + matrix.rc20) * num8;
            quaternion.y = (matrix.rc12 + matrix.rc21) * num8;
            quaternion.z = 0.5f * num5;
            quaternion.w = (matrix.rc10 - matrix.rc01) * num8;
            return quaternion;
        }
        /// <summary>
        /// Set the quaternion depending on a rotation matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static fQuaternion RotationMatrix(float4x4 matrix)
        {
            float num8 = (matrix.rc00 + matrix.rc11) + matrix.rc22;
            fQuaternion quaternion;
            if (num8 > 0f)
            {
                num8 = Math.Sqrt((num8 + 1f));
                quaternion.w = num8 * 0.5f;
                num8 = 0.5f / num8;
                quaternion.x = (matrix.rc21 - matrix.rc12) * num8;
                quaternion.y = (matrix.rc02 - matrix.rc20) * num8;
                quaternion.z = (matrix.rc10 - matrix.rc01) * num8;
                return quaternion;
            }
            if ((matrix.rc00 >= matrix.rc11) && (matrix.rc00 >= matrix.rc22))
            {
                float num7 = Math.Sqrt(1f + matrix.rc00 - matrix.rc11 - matrix.rc22);
                num8 = 0.5f / num7;
                quaternion.x = 0.5f * num7;
                quaternion.y = (matrix.rc10 + matrix.rc01) * num8;
                quaternion.z = (matrix.rc20 + matrix.rc02) * num8;
                quaternion.w = (matrix.rc21 - matrix.rc12) * num8;
                return quaternion;
            }
            if (matrix.rc11 > matrix.rc22)
            {
                float num6 = Math.Sqrt(1f + matrix.rc11 - matrix.rc00 - matrix.rc22);
                num8 = 0.5f / num6;
                quaternion.x = (matrix.rc01 + matrix.rc10) * num8;
                quaternion.y = 0.5f * num6;
                quaternion.z = (matrix.rc12 + matrix.rc21) * num8;
                quaternion.w = (matrix.rc02 - matrix.rc20) * num8;
                return quaternion;
            }
            float num5 = Math.Sqrt(1f + matrix.rc22 - matrix.rc00 - matrix.rc11);
            num8 = 0.5f / num5;
            quaternion.x = (matrix.rc02 + matrix.rc20) * num8;
            quaternion.y = (matrix.rc12 + matrix.rc21) * num8;
            quaternion.z = 0.5f * num5;
            quaternion.w = (matrix.rc10 - matrix.rc01) * num8;
            return quaternion;
        }
        /// <summary>
        /// The dot product between two rotations.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static float Dot(fQuaternion a, fQuaternion b) => a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        /// <summary>
        /// Creates a rotation which rotates angle degrees (in radian) around axis.
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static fQuaternion AngleAxis(float3 axis, float angle)
        {
            float num;
            angle *= 0.5f;
            num = (float)System.Math.Sin(angle);
            fQuaternion quaternion;
            quaternion.x = axis.x * num;
            quaternion.y = axis.y * num;
            quaternion.z = axis.z * num;
            quaternion.w = (float)System.Math.Cos(angle);
            return quaternion;
        }
        /// <summary>
        /// Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis. Euler angle need to be in radian.
        /// </summary>
        /// <param name="euler"></param>
        /// <returns></returns>
        public static fQuaternion Euler(float3 euler)
        {
            fQuaternion quaternion;
            float num6 = (float)System.Math.Sin(euler.z * 0.5f);
            float num5 = (float)System.Math.Cos(euler.z * 0.5f);
            float num4 = (float)System.Math.Sin(euler.x * 0.5f);
            float num3 = (float)System.Math.Cos(euler.x * 0.5f);
            float num2 = (float)System.Math.Sin(euler.y * 0.5f);
            float num = (float)System.Math.Cos(euler.y * 0.5f);
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
        public static fQuaternion Concatenate(fQuaternion value1, fQuaternion value2)
        {
            fQuaternion quaternion;
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
        public static fQuaternion LookRotation(float3 forward)
        {
            float3 t = float3.Up.Cross(forward).Normalized;
            float3 fct = forward.Cross(t);
            float3x3 f3;
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
        public static fQuaternion LookRotation(float3 forward, float3 up)
        {
            float3 t = up.Cross(forward).Normalized;
            float3 fct = forward.Cross(t);
            float3x3 f3;
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
        public static fQuaternion FromToRotation(float3 fromDirection, float3 toDirection)
        {
            return RotateTowards(LookRotation(fromDirection), LookRotation(toDirection), float.MaxValue);
        }
        /// <summary>
        /// Returns the Inverse of rotation.
        /// </summary>
        /// <param name="quaternion"></param>
        /// <returns></returns>
        public static fQuaternion Inversed(fQuaternion quaternion)
        {
            fQuaternion quaternion2;
            float num = (((quaternion.x * quaternion.x) + (quaternion.y * quaternion.y)) + (quaternion.z * quaternion.z)) + (quaternion.w * quaternion.w);
            quaternion2.x = -quaternion.x / num;
            quaternion2.y = -quaternion.y / num;
            quaternion2.z = -quaternion.z / num;
            quaternion2.w = quaternion.w / num;
            return quaternion2;
        }
        /// <summary>
        /// Returns the Inverse of rotation.
        /// </summary>
        [XmlIgnore]
        public fQuaternion Inverse
        {
            get
            {
                fQuaternion quaternion;
                float num = (((x * x) + (y * y)) + (z * z)) + (w * w);
                quaternion.x = -x / num;
                quaternion.y = -y / num;
                quaternion.z = -z / num;
                quaternion.w = w / num;
                return quaternion;
            }
        }
        /// <summary>
        /// Gets the length of the quaternion.
        /// </summary>
        [XmlIgnore]
        public float Magnitude
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
        public float SqrMagnitude
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
        public static fQuaternion Lerp(fQuaternion quaternion1, fQuaternion quaternion2, float t)
        {
            t = t > 1.0f ? 1.0f : t < 0.0f ? 0.0f : t;
            if (((((quaternion1.x * quaternion2.x) + (quaternion1.y * quaternion2.y)) + (quaternion1.z * quaternion2.z)) + (quaternion1.w * quaternion2.w)) >= 0f)
            {
                quaternion1.x = ((1f - t) * quaternion1.x) + (t * quaternion2.x);
                quaternion1.y = ((1f - t) * quaternion1.y) + (t * quaternion2.y);
                quaternion1.z = ((1f - t) * quaternion1.z) + (t * quaternion2.z);
                quaternion1.w = ((1f - t) * quaternion1.w) + (t * quaternion2.w);
            }
            else
            {
                quaternion1.x = ((1f - t) * quaternion1.x) - (t * quaternion2.x);
                quaternion1.y = ((1f - t) * quaternion1.y) - (t * quaternion2.y);
                quaternion1.z = ((1f - t) * quaternion1.z) - (t * quaternion2.z);
                quaternion1.w = ((1f - t) * quaternion1.w) - (t * quaternion2.w);
            }
            t = 1f / (Math.Sqrt((((quaternion1.x * quaternion1.x) + (quaternion1.y * quaternion1.y)) + (quaternion1.z * quaternion1.z)) + (quaternion1.w * quaternion1.w)));
            quaternion1.x = quaternion1.x * t;
            quaternion1.y = quaternion1.y * t;
            quaternion1.z = quaternion1.z * t;
            quaternion1.w = quaternion1.w * t;
            return quaternion1;
        }
        /// <summary>
        /// Interpolates between a and b by t and normalizes the result afterwards. The parameter t is not clamped.
        /// </summary>
        /// <param name="quaternion1"></param>
        /// <param name="quaternion2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static fQuaternion LerpUnclamped(fQuaternion quaternion1, fQuaternion quaternion2, float t)
        {
            if (((((quaternion1.x * quaternion2.x) + (quaternion1.y * quaternion2.y)) + (quaternion1.z * quaternion2.z)) + (quaternion1.w * quaternion2.w)) >= 0f)
            {
                quaternion1.x = ((1f - t) * quaternion1.x) + (t * quaternion2.x);
                quaternion1.y = ((1f - t) * quaternion1.y) + (t * quaternion2.y);
                quaternion1.z = ((1f - t) * quaternion1.z) + (t * quaternion2.z);
                quaternion1.w = ((1f - t) * quaternion1.w) + (t * quaternion2.w);
            }
            else
            {
                quaternion1.x = ((1f - t) * quaternion1.x) - (t * quaternion2.x);
                quaternion1.y = ((1f - t) * quaternion1.y) - (t * quaternion2.y);
                quaternion1.z = ((1f - t) * quaternion1.z) - (t * quaternion2.z);
                quaternion1.w = ((1f - t) * quaternion1.w) - (t * quaternion2.w);
            }
            t = 1f / (Math.Sqrt((((quaternion1.x * quaternion1.x) + (quaternion1.y * quaternion1.y)) + (quaternion1.z * quaternion1.z)) + (quaternion1.w * quaternion1.w)));
            quaternion1.x = quaternion1.x * t;
            quaternion1.y = quaternion1.y * t;
            quaternion1.z = quaternion1.z * t;
            quaternion1.w = quaternion1.w * t;
            return quaternion1;
        }
        const float maxCosine = 1.0f - 1e-6f;
        /// <summary>
        /// Spherically interpolates between a and b by t. The parameter t is clamped to the range [0, 1].
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static fQuaternion Slerp(fQuaternion a, fQuaternion b, float t)
        {
            if (a.SqrMagnitude == 0.0f)
            {
                if (b.SqrMagnitude == 0.0f)
                {
                    return Identity;
                }
                return b;
            }
            else if (b.SqrMagnitude == 0.0f)
            {
                return a;
            }
            float cosHalfAngle = a.w * b.w + (a.x * b.x + a.y * b.y + a.z * b.z);
            if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
            {
                return a;
            }
            else if (cosHalfAngle < 0.0f)
            {
                b.x = -b.x;
                b.y = -b.y;
                b.z = -b.z;
                b.w = -b.w;
                cosHalfAngle = -cosHalfAngle;
            }
            float blendA;
            float blendB;
            t = t > 1.0f ? 1.0f : t < 0.0f ? 0.0f : t;
            if (cosHalfAngle < maxCosine)
            {
                cosHalfAngle = (float)System.Math.Acos(cosHalfAngle);
                float oneOverSinHalfAngle = 1.0f / (float)System.Math.Sin(cosHalfAngle);
                blendA = (float)System.Math.Sin(cosHalfAngle * (1.0f - t)) * oneOverSinHalfAngle;
                blendB = (float)System.Math.Sin(cosHalfAngle * t) * oneOverSinHalfAngle;
            }
            else
            {
                blendA = 1.0f - t;
                blendB = t;
            }
            a.x = blendA * a.x + blendB * b.x;
            a.y = blendA * a.y + blendB * b.y;
            a.z = blendA * a.z + blendB * b.z;
            a.w = blendA * a.w + blendB * b.w;
            cosHalfAngle = a.SqrMagnitude;
            if (cosHalfAngle > 0.0f)
            {
                cosHalfAngle = Math.Sqrt(cosHalfAngle);
                a.x /= cosHalfAngle;
                a.y /= cosHalfAngle;
                a.z /= cosHalfAngle;
                a.w /= cosHalfAngle;
                return a;
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
        public static fQuaternion SlerpUnclamped(fQuaternion a, fQuaternion b, float t)
        {
            if (a.SqrMagnitude == 0.0f)
            {
                if (b.SqrMagnitude == 0.0f)
                {
                    return Identity;
                }
                return b;
            }
            else if (b.SqrMagnitude == 0.0f)
            {
                return a;
            }
            float cosHalfAngle = a.w * b.w + (a.x * b.x + a.y * b.y + a.z * b.z);
            if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
            {
                return a;
            }
            else if (cosHalfAngle < 0.0f)
            {
                b.x = -b.x;
                b.y = -b.y;
                b.z = -b.z;
                b.w = -b.w;
                cosHalfAngle = -cosHalfAngle;
            }
            float blendA;
            float blendB;
            if (cosHalfAngle < maxCosine)
            {
                cosHalfAngle = (float)System.Math.Acos(cosHalfAngle);
                float oneOverSinHalfAngle = 1.0f / (float)System.Math.Sin(cosHalfAngle);
                blendA = (float)System.Math.Sin(cosHalfAngle * (1.0f - t)) * oneOverSinHalfAngle;
                blendB = (float)System.Math.Sin(cosHalfAngle * t) * oneOverSinHalfAngle;
            }
            else
            {
                blendA = 1.0f - t;
                blendB = t;
            }
            a.x = blendA * a.x + blendB * b.x;
            a.y = blendA * a.y + blendB * b.y;
            a.z = blendA * a.z + blendB * b.z;
            a.w = blendA * a.w + blendB * b.w;
            cosHalfAngle = a.SqrMagnitude;
            if (cosHalfAngle > 0.0f)
            {
                cosHalfAngle = Math.Sqrt(cosHalfAngle);
                a.x = a.x / cosHalfAngle;
                a.y = a.y / cosHalfAngle;
                a.z = a.z / cosHalfAngle;
                a.w = a.w / cosHalfAngle;
                return a;
            }
            return Identity;
        }
        public override bool Equals(object obj)
        {
            if (obj is fQuaternion)
            {
                return Equals((fQuaternion)obj);
            }
            return false;
        }
        public bool Equals(fQuaternion other)
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
        public static bool operator ==(fQuaternion quaternion1, fQuaternion quaternion2)
        {
            return ((((quaternion1.x == quaternion2.x) && (quaternion1.y == quaternion2.y)) && (quaternion1.z == quaternion2.z)) && (quaternion1.w == quaternion2.w));
        }
        public static bool operator !=(fQuaternion quaternion1, fQuaternion quaternion2)
        {
            if (((quaternion1.x == quaternion2.x) && (quaternion1.y == quaternion2.y)) && (quaternion1.z == quaternion2.z))
            {
                return (quaternion1.w != quaternion2.w);
            }
            return true;
        }
        public static implicit operator dQuaternion(fQuaternion a)
        {
            dQuaternion b;
            b.x = a.x;
            b.y = a.y;
            b.z = a.z;
            b.w = a.w;
            return b;
        }
        public static fQuaternion operator *(fQuaternion a, float b)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            a.w = a.w * b;
            return a;
        }
        public static fQuaternion operator *(float b, fQuaternion a)
        {
            a.x = a.x * b;
            a.y = a.y * b;
            a.z = a.z * b;
            a.w = a.w * b;
            return a;
        }
        public static fQuaternion operator *(fQuaternion lhs, fQuaternion rhs)
        {
            fQuaternion q;
            q.x = lhs.w * rhs.x + lhs.x * rhs.w + lhs.y * rhs.z - lhs.z * rhs.y;
            q.y = lhs.w * rhs.y + lhs.y * rhs.w + lhs.z * rhs.x - lhs.x * rhs.z;
            q.z = lhs.w * rhs.z + lhs.z * rhs.w + lhs.x * rhs.y - lhs.y * rhs.x;
            q.w = lhs.w * rhs.w - lhs.x * rhs.x - lhs.y * rhs.y - lhs.z * rhs.z;
            return q;
        }
        public static float3 operator *(fQuaternion rotation, float3 point)
        {
            float num1 = rotation.x * 2f;
            float num2 = rotation.y * 2f;
            float num3 = rotation.z * 2f;
            float num4 = rotation.x * num1;
            float num5 = rotation.y * num2;
            float num6 = rotation.z * num3;
            float num7 = rotation.x * num2;
            float num8 = rotation.x * num3;
            float num9 = rotation.y * num3;
            float num10 = rotation.w * num1;
            float num11 = rotation.w * num2;
            float num12 = rotation.w * num3;
            float3 vector3;
            vector3.x = (1.0f - (num5 + num6)) * point.x + (num7 - num12) * point.y + (num8 + num11) * point.z;
            vector3.y = (num7 + num12) * point.x + (1.0f - (num4 + num6)) * point.y + (num9 - num10) * point.z;
            vector3.z = (num8 - num11) * point.x + (num9 + num10) * point.y + (1.0f - (num4 + num5)) * point.z;
            return vector3;
        }
        public static float3 operator *(float3 point, fQuaternion rotation)
        {
            float num1 = rotation.x * 2f;
            float num2 = rotation.y * 2f;
            float num3 = rotation.z * 2f;
            float num4 = rotation.x * num1;
            float num5 = rotation.y * num2;
            float num6 = rotation.z * num3;
            float num7 = rotation.x * num2;
            float num8 = rotation.x * num3;
            float num9 = rotation.y * num3;
            float num10 = rotation.w * num1;
            float num11 = rotation.w * num2;
            float num12 = rotation.w * num3;
            float3 vector3;
            vector3.x = (1.0f - (num5 + num6)) * point.x + (num7 - num12) * point.y + (num8 + num11) * point.z;
            vector3.y = (num7 + num12) * point.x + (1.0f - (num4 + num6)) * point.y + (num9 - num10) * point.z;
            vector3.z = (num8 - num11) * point.x + (num9 + num10) * point.y + (1.0f - (num4 + num5)) * point.z;
            return vector3;
        }
        public static fQuaternion operator +(fQuaternion quaternion1, fQuaternion quaternion2)
        {
            quaternion1.x = quaternion1.x + quaternion2.x;
            quaternion1.y = quaternion1.y + quaternion2.y;
            quaternion1.z = quaternion1.z + quaternion2.z;
            quaternion1.w = quaternion1.w + quaternion2.w;
            return quaternion1;
        }
        public static fQuaternion operator -(fQuaternion quaternion1, fQuaternion quaternion2)
        {
            quaternion1.x = quaternion1.x - quaternion2.x;
            quaternion1.y = quaternion1.y - quaternion2.y;
            quaternion1.z = quaternion1.z - quaternion2.z;
            quaternion1.w = quaternion1.w - quaternion2.w;
            return quaternion1;
        }
        public static fQuaternion operator -(fQuaternion quaternion1)
        {
            quaternion1.x = -quaternion1.x;
            quaternion1.y = -quaternion1.y;
            quaternion1.z = -quaternion1.z;
            quaternion1.w = -quaternion1.w;
            return quaternion1;
        }
        public static fQuaternion operator /(fQuaternion quaternion1, fQuaternion quaternion2)
        {
            fQuaternion quaternion;
            float num5 = 1f / ((((quaternion2.x * quaternion2.x) + (quaternion2.y * quaternion2.y)) + (quaternion2.z * quaternion2.z)) + (quaternion2.w * quaternion2.w));
            float num4 = -quaternion2.x * num5;
            float num3 = -quaternion2.y * num5;
            float num2 = -quaternion2.z * num5;
            float num = quaternion2.w * num5;
            float num13 = (quaternion1.y * num2) - (quaternion1.z * num3);
            float num12 = (quaternion1.z * num4) - (quaternion1.x * num2);
            float num11 = (quaternion1.x * num3) - (quaternion1.y * num4);
            float num10 = ((quaternion1.x * num4) + (quaternion1.y * num3)) + (quaternion1.z * num2);
            quaternion.x = ((quaternion1.x * num) + (num4 * quaternion1.w)) + num13;
            quaternion.y = ((quaternion1.y * num) + (num3 * quaternion1.w)) + num12;
            quaternion.z = ((quaternion1.z * num) + (num2 * quaternion1.w)) + num11;
            quaternion.w = (quaternion1.w * num) - num10;
            return quaternion;
        }
    }
}
