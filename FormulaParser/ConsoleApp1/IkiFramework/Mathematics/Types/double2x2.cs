using System;
using System.Xml.Serialization;
using IkiCore.Core;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct double2x2
    {
        /// <summary>
        /// Cell located at row 0, column 0.
        /// </summary>
        public double rc00;
        /// <summary>
        /// Cell located at row 0, column 1.
        /// </summary>
        public double rc01;
        /// <summary>
        /// Cell located at row 1, column 0.
        /// </summary>
        public double rc10;
        /// <summary>
        /// Cell located at row 1, column 1.
        /// </summary>
        public double rc11;
        /// <summary>
        /// Access element at row and column index.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        [XmlIgnore]
        public double this[int row, int column]
        {
            get
            {
                switch (row)
                {
                    case 0:
                        switch (column)
                        {
                            case 0:
                                return rc00;
                            case 1:
                                return rc01;
                            default:
                                throw new System.IndexOutOfRangeException("Invalid matrix column index!");
                        }
                    case 1:
                        switch (column)
                        {
                            case 0:
                                return rc10;
                            case 1:
                                return rc11;
                            default:
                                throw new System.IndexOutOfRangeException("Invalid matrix column index!");
                        }
                    default:
                        throw new System.IndexOutOfRangeException("Invalid matrix row index!");
                }
            }
            set
            {
                switch (row)
                {
                    case 0:
                        switch (column)
                        {
                            case 0:
                                rc00 = value;
                                break;
                            case 1:
                                rc01 = value;
                                break;
                            default:
                                throw new System.IndexOutOfRangeException("Invalid matrix column index!");
                        }
                        break;
                    case 1:
                        switch (column)
                        {
                            case 0:
                                rc10 = value;
                                break;
                            case 1:
                                rc11 = value;
                                break;
                            default:
                                throw new System.IndexOutOfRangeException("Invalid matrix column index!");
                        }
                        break;
                    default:
                        throw new System.IndexOutOfRangeException("Invalid matrix row index!");
                }
            }
        }
        /// <summary>
        /// Return the desired row of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public double2 GetRow(int i)
        {
            double2 a;
            if (i == 0)
            {
                a.x = rc00;
                a.y = rc01;
            }
            else
            {
                a.x = rc10;
                a.y = rc11;
            }
            return a;
        }
        /// <summary>
        /// Return the desired row of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public void SetRow(int i, double2 v)
        {
            if (i == 0)
            {
                rc00 = v.x;
                rc01 = v.y;
            }
            else
            {
                rc10 = v.x;
                rc11 = v.y;
            }
        }
        /// <summary>
        /// Return the desired column of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public double2 GetColumn(int i)
        {
            double2 a;
            if (i == 0)
            {
                a.x = rc00;
                a.y = rc10;
            }
            else
            {
                a.x = rc01;
                a.y = rc11;
            }
            return a;
        }
        /// <summary>
        /// Set the desired column of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public void SetColumn(int i, double2 v)
        {
            if (i == 0)
            {
                rc00 = v.x;
                rc10 = v.y;
            }
            else
            {
                rc01 = v.x;
                rc11 = v.y;
            }
        }
        /// <summary>
        /// Return the determinant of the matrix
        /// </summary>
        [XmlIgnore]
        public double Determinant
        {
            get
            {
                return rc00 * rc11 - rc01 * rc10;
            }
        }
        /// <summary>
        /// Return a scale matrix 2x2
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double2x2 ScaleMatrix(double2 v)
        {
            double2x2 a;
            a.rc00 = v.x;
            a.rc01 = 0d;
            a.rc10 = 0d;
            a.rc11 = v.y;
            return a;
        }
        /// <summary>
        /// Return the scale of the matrix.
        /// </summary>
        [XmlIgnore]
        public double2 Scale
        {
            get
            {
                double2 v;
                v.x = GetColumn(0).Magnitude;
                v.y = GetColumn(1).Magnitude;
                return v;
            }
        }
        /// <summary>
        /// Set a new scale for the matrix.
        /// </summary>
        /// <param name="scale"></param>
        public void SetScale(double2 scale)
        {
            SetColumn(0, GetColumn(0).Normalized * scale.x);
            SetColumn(1, GetColumn(1).Normalized * scale.y);
        }
        /// <summary>
        /// Return a matrix that scale and rotate.
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static double2x2 RSMatrix(double angle, double2 scale)
        {
            double angleCos = System.Math.Cos(angle);
            double angleSin = angleCos.SinFromCosTheta(angle);
            double2x2 rotMat;
            rotMat.rc00 = angleCos * scale.x;
            rotMat.rc11 = angleCos * scale.y;
            rotMat.rc01 = -angleSin * scale.x;
            rotMat.rc10 = angleSin * scale.y;
            return rotMat;
        }
        /// <summary>
        /// Return a rotation matrix. The angle is in radian.
        /// </summary>
        /// <param name="angle"></param>
        public static double2x2 RotationMatrix(double angle = 0d)
        {
            double angleSin = System.Math.Sin(angle);
            double2x2 rotMat;
            rotMat.rc00 = rotMat.rc11 = angleSin.CosFromSinTheta(angle);
            rotMat.rc01 = -angleSin;
            rotMat.rc10 = angleSin;
            return rotMat;
        }
        /// <summary>
        /// Return a matrix that shear in x direction from angle.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double2x2 ShearXMatrix(double angle = 0d)
        {
            double2x2 a;
            a.rc00 = a.rc11 = 1d;
            a.rc10 = 0d;
            a.rc01 = System.Math.Tan(angle);
            return a;
        }
        /// <summary>
        /// Return a matrix that shear in y direction from angle.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double2x2 ShearYMatrix(double angle = 0d)
        {
            double2x2 a;
            a.rc00 = a.rc11 = 1f;
            a.rc10 = System.Math.Tan(angle);
            a.rc01 = 0f;
            return a;
        }
        /// <summary>
        /// Do a symetry from the origin.
        /// </summary>
        [XmlIgnore]
        public static double2x2 ReflectOrigin
        {
            get
            {
                double2x2 rotMat;
                rotMat.rc00 = rotMat.rc11 = -1d;
                rotMat.rc01 = rotMat.rc10 = 0d;
                return rotMat;
            }
        }
        /// <summary>
        /// Do a symetry on the x axis.
        /// </summary>
        [XmlIgnore]
        public static double2x2 ReflectXAxis
        {
            get
            {
                double2x2 rotMat;
                rotMat.rc00 = 0d;
                rotMat.rc11 = -1d;
                rotMat.rc01 = rotMat.rc10 = 0d;
                return rotMat;
            }
        }
        /// <summary>
        /// Do a symetry on the y axis.
        /// </summary>
        [XmlIgnore]
        public static double2x2 ReflectYAxis
        {
            get
            {
                double2x2 rotMat;
                rotMat.rc00 = -1d;
                rotMat.rc11 = 1d;
                rotMat.rc01 = rotMat.rc10 = 0d;
                return rotMat;
            }
        }
        /// <summary>
        /// Return the matrix identity
        /// </summary>
        [XmlIgnore]
        public static double2x2 Identity
        {
            get
            {
                double2x2 rotMat;
                rotMat.rc00 = rotMat.rc11 = 1d;
                rotMat.rc01 = rotMat.rc10 = 0d;
                return rotMat;
            }
        }
        /// <summary>
        /// Return a 0 matrix.
        /// </summary>
        [XmlIgnore]
        public static double2x2 Zero
        {
            get
            {
                double2x2 v;
                v.rc00 = v.rc11 = v.rc01 = v.rc10 = 0d;
                return v;
            }
        }
        /// <summary>
        /// Return the transpose of the matrix.
        /// </summary>
        [XmlIgnore]
        public double2x2 Transpose
        {
            get
            {
                double2x2 matrix;
                matrix.rc00 = rc00;
                matrix.rc01 = rc10;
                matrix.rc10 = rc01;
                matrix.rc11 = rc11;
                return matrix;
            }
        }
        /// <summary>
        /// Return the transpose of the matrix's cofactor.
        /// </summary>
        [XmlIgnore]
        public double2x2 Adjugate
        {
            get
            {
                double2x2 a;
                a.rc00 = rc11;
                a.rc01 = -rc01;
                a.rc10 = -rc10;
                a.rc11 = rc00;
                return a;
            }
        }
        /// <summary>
        /// Return the cofactors of the matrix.
        /// </summary>
        [XmlIgnore]
        public double2x2 Cofactor
        {
            get
            {
                double2x2 a;
                a.rc00 = rc00;
                a.rc01 = -rc01;
                a.rc10 = -rc10;
                a.rc11 = rc11;
                return a;
            }
        }
        /// <summary>
        /// Return the inverse of the matrix. If there's no inverse, then it will return null.
        /// </summary>
        [XmlIgnore]
        public double2x2? Inverse
        {
            get
            {
                double det = rc00 * rc11 - rc01 * rc10;
                if (det == 0d)
                {
                    return null;
                }
                double2x2 mat;
                mat.rc00 = rc11;
                mat.rc01 = -rc01;
                mat.rc10 = -rc10;
                mat.rc11 = rc00;
                return (1d / det) * mat;
            }
        }
        /// <summary>
        /// Return the matric square by itself.
        /// </summary>
        [XmlIgnore]
        public double2x2 Square
        {
            get
            {
                double2x2 a;
                a.rc00 = rc00 * rc00 + rc10 * rc10;
                a.rc01 = rc00 * rc01 + rc01 * rc11;
                a.rc10 = rc10 * rc00 + rc11 * rc10;
                a.rc11 = rc10 * rc01 + rc11 * rc11;
                return a;
            }
        }
        /// <summary>
        /// Lineary interpolate between two matrix.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double2x2 Lerp(double2x2 m1, double2x2 m2, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            m1.rc00 = m1.rc00 + (m2.rc00 - m1.rc00) * t;
            m1.rc01 = m1.rc01 + (m2.rc01 - m1.rc01) * t;
            m1.rc10 = m1.rc10 + (m2.rc10 - m1.rc10) * t;
            m1.rc11 = m1.rc11 + (m2.rc11 - m1.rc11) * t;
            return m1;
        }
        /// <summary>
        /// Lineary interpolate between two matrix.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double2x2 LerpUnclamped(double2x2 m1, double2x2 m2, double t)
        {
            m1.rc00 = m1.rc00 + (m2.rc00 - m1.rc00) * t;
            m1.rc01 = m1.rc01 + (m2.rc01 - m1.rc01) * t;
            m1.rc10 = m1.rc10 + (m2.rc10 - m1.rc10) * t;
            m1.rc11 = m1.rc11 + (m2.rc11 - m1.rc11) * t;
            return m1;
        }
        public static double2x2 operator *(double2x2 a, double2x2 b)
        {
            double2x2 mat;
            mat.rc00 = a.rc00 * b.rc00 + a.rc01 * b.rc10;
            mat.rc01 = a.rc00 * b.rc01 + a.rc01 * b.rc11;
            mat.rc10 = a.rc10 * b.rc00 + a.rc11 * b.rc10;
            mat.rc11 = a.rc10 * b.rc01 + a.rc11 * b.rc11;
            return mat;
        }
        public static double2x2? operator /(double2x2 a, double2x2 b)
        {
            double2x2? inv = b.Inverse;
            if (inv != null)
            {
                return a * (double2x2)inv;
            }
            return null;
        }
        public static double2x2 operator +(double2x2 a, double2x2 b)
        {
            a.rc00 = a.rc00 + b.rc00;
            a.rc01 = a.rc01 + b.rc01;
            a.rc10 = a.rc10 + b.rc10;
            a.rc11 = a.rc11 + b.rc11;
            return a;
        }
        public static double2x2 operator -(double2x2 a, double2x2 b)
        {
            a.rc00 = a.rc00 - b.rc00;
            a.rc01 = a.rc01 - b.rc01;
            a.rc10 = a.rc10 - b.rc10;
            a.rc11 = a.rc11 - b.rc11;
            return a;
        }
        public static double2 operator *(double2x2 a, double2 b)
        {
            double2 vec;
            vec.x = a.rc00 * b.x + a.rc10 * b.y;
            vec.y = a.rc01 * b.x + a.rc11 * b.y;
            return vec;
        }
        public static double2 operator *(double2 a, double2x2 b)
        {
            double2 vec;
            vec.x = b.rc00 * a.x + b.rc10 * a.y;
            vec.y = b.rc01 * a.x + b.rc11 * a.y;
            return vec;
        }
        public static double2x2 operator *(double2x2 a, double b)
        {
            a.rc00 = a.rc00 * b;
            a.rc01 = a.rc01 * b;
            a.rc10 = a.rc10 * b;
            a.rc11 = a.rc11 * b;
            return a;
        }
        public static double2x2 operator *(double a, double2x2 b)
        {
            b.rc00 = a * b.rc00;
            b.rc01 = a * b.rc01;
            b.rc10 = a * b.rc10;
            b.rc11 = a * b.rc11;
            return b;
        }
        public static double2x2 operator -(double2x2 a)
        {
            a.rc00 = -a.rc00;
            a.rc01 = -a.rc01;
            a.rc10 = -a.rc10;
            a.rc11 = -a.rc11;
            return a;
        }
        public static explicit operator double3x3(double2x2 a)
        {
            double3x3 b;
            b.rc00 = a.rc00;
            b.rc10 = a.rc01;
            b.rc20 = 0d;
            b.rc01 = a.rc10;
            b.rc11 = a.rc11;
            b.rc21 = 0d;
            b.rc02 = 0d;
            b.rc12 = 0d;
            b.rc22 = 1d;
            return b;
        }
    }
}
