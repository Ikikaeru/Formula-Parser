using System;
using System.Xml.Serialization;
using IkiCore.Core;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct double4x4
    {
        /// <summary>
        /// Cell located at row 0, column 0.
        /// </summary>
        public double rc00;
        /// <summary>
        /// Cell located at row 1, column 0.
        /// </summary>
        public double rc10;
        /// <summary>
        /// Cell located at row 2, column 0.
        /// </summary>
        public double rc20;
        /// <summary>
        /// Cell located at row 3, column 0.
        /// </summary>
        public double rc30;
        /// <summary>
        /// Cell located at row 0, column 1.
        /// </summary>
        public double rc01;
        /// <summary>
        /// Cell located at row 1, column 1.
        /// </summary>
        public double rc11;
        /// <summary>
        /// Cell located at row 2, column 1.
        /// </summary>
        public double rc21;
        /// <summary>
        /// Cell located at row 3, column 1.
        /// </summary>
        public double rc31;
        /// <summary>
        /// Cell located at row 0, column 2.
        /// </summary>
        public double rc02;
        /// <summary>
        /// Cell located at row 1, column 2.
        /// </summary>
        public double rc12;
        /// <summary>
        /// Cell located at row 2, column 2.
        /// </summary>
        public double rc22;
        /// <summary>
        /// Cell located at row 3, column 2.
        /// </summary>
        public double rc32;
        /// <summary>
        /// Cell located at row 0, column 3.
        /// </summary>
        public double rc03;
        /// <summary>
        /// Cell located at row 1, column 3.
        /// </summary>
        public double rc13;
        /// <summary>
        /// Cell located at row 2, column 3.
        /// </summary>
        public double rc23;
        /// <summary>
        /// Cell located at row 3, column 3.
        /// </summary>
        public double rc33;
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
                                return rc10;
                            case 2:
                                return rc20;
                            case 3:
                                return rc30;
                            default:
                                throw new System.IndexOutOfRangeException("Invalid matrix column index!");
                        }
                    case 1:
                        switch (column)
                        {
                            case 0:
                                return rc01;
                            case 1:
                                return rc11;
                            case 2:
                                return rc21;
                            case 3:
                                return rc31;
                            default:
                                throw new System.IndexOutOfRangeException("Invalid matrix column index!");
                        }
                    case 2:
                        switch (column)
                        {
                            case 0:
                                return rc02;
                            case 1:
                                return rc12;
                            case 2:
                                return rc22;
                            case 3:
                                return rc32;
                            default:
                                throw new System.IndexOutOfRangeException("Invalid matrix column index!");
                        }
                    case 3:
                        switch (column)
                        {
                            case 0:
                                return rc03;
                            case 1:
                                return rc13;
                            case 2:
                                return rc23;
                            case 3:
                                return rc33;
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
                                rc10 = value;
                                break;
                            case 2:
                                rc20 = value;
                                break;
                            case 3:
                                rc30 = value;
                                break;
                            default:
                                throw new System.IndexOutOfRangeException("Invalid matrix column index!");
                        }
                        break;
                    case 1:
                        switch (column)
                        {
                            case 0:
                                rc01 = value;
                                break;
                            case 1:
                                rc11 = value;
                                break;
                            case 2:
                                rc21 = value;
                                break;
                            case 3:
                                rc31 = value;
                                break;
                            default:
                                throw new System.IndexOutOfRangeException("Invalid matrix column index!");
                        }
                        break;
                    case 2:
                        switch (column)
                        {
                            case 0:
                                rc02 = value;
                                break;
                            case 1:
                                rc12 = value;
                                break;
                            case 2:
                                rc22 = value;
                                break;
                            case 3:
                                rc32 = value;
                                break;
                            default:
                                throw new System.IndexOutOfRangeException("Invalid matrix column index!");
                        }
                        break;
                    case 3:
                        switch (column)
                        {
                            case 0:
                                rc03 = value;
                                break;
                            case 1:
                                rc13 = value;
                                break;
                            case 2:
                                rc23 = value;
                                break;
                            case 3:
                                rc33 = value;
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
        /// Return the determinant of the matrix
        /// </summary>
        [XmlIgnore]
        public double Determinant
        {
            get
            {
                return rc30 * rc21 * rc12 * rc03 - rc20 * rc31 * rc12 * rc03 -
                        rc30 * rc11 * rc22 * rc03 + rc10 * rc31 * rc22 * rc03 +
                        rc20 * rc11 * rc32 * rc03 - rc10 * rc21 * rc32 * rc03 -
                        rc30 * rc21 * rc02 * rc13 + rc20 * rc31 * rc02 * rc13 +
                        rc30 * rc01 * rc22 * rc13 - rc00 * rc31 * rc22 * rc13 -
                        rc20 * rc01 * rc32 * rc13 + rc00 * rc21 * rc32 * rc13 +
                        rc30 * rc11 * rc02 * rc23 - rc10 * rc31 * rc02 * rc23 -
                        rc30 * rc01 * rc12 * rc23 + rc00 * rc31 * rc12 * rc23 +
                        rc10 * rc01 * rc32 * rc23 - rc00 * rc11 * rc32 * rc23 -
                        rc20 * rc11 * rc02 * rc33 + rc10 * rc21 * rc02 * rc33 +
                        rc20 * rc01 * rc12 * rc33 - rc00 * rc21 * rc12 * rc33 -
                        rc10 * rc01 * rc22 * rc33 + rc00 * rc11 * rc22 * rc33;
            }
        }
        /// <summary>
        /// Return the desired row of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public double4 GetRow(int i)
        {
            double4 a;
            switch (i)
            {
                case 0:
                    a.x = rc00;
                    a.y = rc01;
                    a.z = rc02;
                    a.w = rc03;
                    return a;
                case 1:
                    a.x = rc10;
                    a.y = rc11;
                    a.z = rc12;
                    a.w = rc13;
                    return a;
                case 2:
                    a.x = rc20;
                    a.y = rc21;
                    a.z = rc22;
                    a.w = rc23;
                    return a;
                default:
                    a.x = rc30;
                    a.y = rc31;
                    a.z = rc32;
                    a.w = rc33;
                    return a;
            }
        }
        /// <summary>
        /// Return the desired row of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public void SetRow(int i, double4 v)
        {
            switch (i)
            {
                case 0:
                    rc00 = v.x;
                    rc01 = v.y;
                    rc02 = v.z;
                    rc03 = v.w;
                    break;
                case 1:
                    rc10 = v.x;
                    rc11 = v.y;
                    rc12 = v.z;
                    rc13 = v.w;
                    break;
                case 2:
                    rc20 = v.x;
                    rc21 = v.y;
                    rc22 = v.z;
                    rc23 = v.w;
                    break;
                default:
                    rc30 = v.x;
                    rc31 = v.y;
                    rc32 = v.z;
                    rc33 = v.w;
                    break;
            }
        }
        /// <summary>
        /// Return the desired column of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public double4 GetColumn(int i)
        {
            double4 a;
            switch (i)
            {
                case 0:
                    a.x = rc00;
                    a.y = rc10;
                    a.z = rc20;
                    a.w = rc30;
                    return a;
                case 1:
                    a.x = rc01;
                    a.y = rc11;
                    a.z = rc21;
                    a.w = rc31;
                    return a;
                case 2:
                    a.x = rc02;
                    a.y = rc12;
                    a.z = rc22;
                    a.w = rc32;
                    return a;
                default:
                    a.x = rc03;
                    a.y = rc13;
                    a.z = rc23;
                    a.w = rc33;
                    return a;
            }
        }
        /// <summary>
        /// Set the desired column of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public void SetColumn(int i, double4 v)
        {
            switch (i)
            {
                case 0:
                    rc00 = v.x;
                    rc10 = v.y;
                    rc20 = v.z;
                    rc30 = v.w;
                    break;
                case 1:
                    rc01 = v.x;
                    rc11 = v.y;
                    rc21 = v.z;
                    rc31 = v.w;
                    break;
                case 2:
                    rc02 = v.x;
                    rc12 = v.y;
                    rc22 = v.z;
                    rc32 = v.w;
                    break;
                default:
                    rc03 = v.x;
                    rc13 = v.y;
                    rc23 = v.z;
                    rc33 = v.w;
                    break;
            }
        }
        /// <summary>
        /// Return the scale of the matrix.
        /// </summary>
        [XmlIgnore]
        public double4 Scale
        {
            get
            {
                double4 v;
                v.x = GetColumn(0).Magnitude;
                v.y = GetColumn(1).Magnitude;
                v.z = GetColumn(2).Magnitude;
                v.w = GetColumn(3).Magnitude;
                return v;
            }
        }
        /// <summary>
        /// Set a new scale for the matrix.
        /// </summary>
        /// <param name="scale"></param>
        public void SetScale(double4 scale)
        {
            SetColumn(0, GetColumn(0).Normalized * scale.x);
            SetColumn(1, GetColumn(1).Normalized * scale.y);
            SetColumn(2, GetColumn(2).Normalized * scale.z);
            SetColumn(3, GetColumn(3).Normalized * scale.w);
        }
        /// <summary>
        /// Return the matrix identity
        /// </summary>
        [XmlIgnore]
        public static double4x4 Identity
        {
            get
            {
                double4x4 rotMat;
                rotMat.rc00 = rotMat.rc11 = rotMat.rc22 = rotMat.rc33 = 1d;
                rotMat.rc10 = rotMat.rc20 = rotMat.rc30 = rotMat.rc01 = rotMat.rc21 = rotMat.rc31 = rotMat.rc02 = rotMat.rc12 = rotMat.rc32 = rotMat.rc03 = rotMat.rc13 = rotMat.rc23 = 0d;
                return rotMat;
            }
        }
        /// <summary>
        /// Return the matrix identity
        /// </summary>
        [XmlIgnore]
        public static double4x4 Zero
        {
            get
            {
                double4x4 rotMat;
                rotMat.rc00 = rotMat.rc11 = rotMat.rc22 = rotMat.rc33 = 0d;
                rotMat.rc10 = rotMat.rc20 = rotMat.rc30 = rotMat.rc01 = rotMat.rc21 = rotMat.rc31 = rotMat.rc02 = rotMat.rc12 = rotMat.rc32 = rotMat.rc03 = rotMat.rc13 = rotMat.rc23 = 0d;
                return rotMat;
            }
        }
        /// <summary>
        /// Return the transpose of the matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        [XmlIgnore]
        public double4x4 Transpose
        {
            get
            {
                double4x4 t;
                t.rc00 = rc00;
                t.rc10 = rc01;
                t.rc20 = rc02;
                t.rc30 = rc03;
                t.rc01 = rc10;
                t.rc11 = rc11;
                t.rc21 = rc12;
                t.rc31 = rc13;
                t.rc02 = rc20;
                t.rc12 = rc21;
                t.rc22 = rc22;
                t.rc32 = rc23;
                t.rc03 = rc30;
                t.rc13 = rc31;
                t.rc23 = rc32;
                t.rc33 = rc33;
                return t;
            }
        }
        /// <summary>
        /// Return the cofactors of the matrix.
        /// </summary>
        [XmlIgnore]
        public double4x4 Cofactors
        {
            get
            {
                double4x4 a;
                a.rc00 = rc00;
                a.rc10 = -rc10;
                a.rc20 = rc20;
                a.rc30 = -rc30;
                a.rc01 = -rc01;
                a.rc11 = rc11;
                a.rc21 = -rc21;
                a.rc31 = rc31;
                a.rc02 = rc02;
                a.rc12 = -rc12;
                a.rc22 = rc22;
                a.rc32 = -rc32;
                a.rc03 = -rc03;
                a.rc13 = rc13;
                a.rc23 = -rc23;
                a.rc33 = rc33;
                return a;
            }
        }
        /// <summary>
        /// Return a translation matrix.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 TranslationMatrix(double2 v)
        {
            double4x4 a;
            a.rc00 = 0d;
            a.rc01 = 0d;
            a.rc02 = 0d;
            a.rc03 = 0d;
            a.rc10 = 0d;
            a.rc11 = 0d;
            a.rc12 = 0d;
            a.rc13 = 0d;
            a.rc20 = 0d;
            a.rc21 = 0d;
            a.rc22 = 0d;
            a.rc23 = 0d;
            a.rc30 = v.x;
            a.rc31 = v.y;
            a.rc32 = 1d;
            a.rc33 = 1d;
            return a;
        }
        /// <summary>
        /// Return a translation matrix.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 TranslationMatrix(double3 v)
        {
            double4x4 a;
            a.rc00 = 0d;
            a.rc01 = 0d;
            a.rc02 = 0d;
            a.rc03 = 0d;
            a.rc10 = 0d;
            a.rc11 = 0d;
            a.rc12 = 0d;
            a.rc13 = 0d;
            a.rc20 = 0d;
            a.rc21 = 0d;
            a.rc22 = 0d;
            a.rc23 = 0d;
            a.rc30 = v.x;
            a.rc31 = v.y;
            a.rc32 = v.z;
            a.rc33 = 1d;
            return a;
        }
        /// <summary>
        /// Return a translation matrix.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 TranslationMatrix(double4 v)
        {
            double4x4 a;
            a.rc00 = 0d;
            a.rc01 = 0d;
            a.rc02 = 0d;
            a.rc03 = 0d;
            a.rc10 = 0d;
            a.rc11 = 0d;
            a.rc12 = 0d;
            a.rc13 = 0d;
            a.rc20 = 0d;
            a.rc21 = 0d;
            a.rc22 = 0d;
            a.rc23 = 0d;
            a.rc30 = v.x;
            a.rc31 = v.y;
            a.rc32 = v.z;
            a.rc33 = v.w;
            return a;
        }
        /// <summary>
        /// Return the most straightforward matrice to go from 3D to 2D space by discarding the z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 OrthographicMatrix(double3 v)
        {
            double4x4 rotMat;
            rotMat.rc00 = v.x;
            rotMat.rc11 = v.y;
            rotMat.rc22 = 0d;
            rotMat.rc33 = 1d;
            rotMat.rc10 = rotMat.rc20 = rotMat.rc30 = rotMat.rc01 = rotMat.rc21 = rotMat.rc31 = rotMat.rc02 = rotMat.rc12 = rotMat.rc32 = rotMat.rc03 = rotMat.rc13 = rotMat.rc23 = 0d;
            return rotMat;
        }
        /// <summary>
        /// Return a matrix that will show a 2D space and, because of the perspective, things that are further away appear smaller.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 PerspectiveMatrix(double3 v)
        {
            double4x4 rotMat;
            rotMat.rc00 = v.x;
            rotMat.rc11 = v.y;
            rotMat.rc22 = v.z;
            rotMat.rc32 = 1d;
            rotMat.rc33 = rotMat.rc10 = rotMat.rc20 = rotMat.rc30 = rotMat.rc01 = rotMat.rc21 = rotMat.rc31 = rotMat.rc02 = rotMat.rc12 = rotMat.rc03 = rotMat.rc13 = rotMat.rc23 = 0d;
            return rotMat;
        }
        /// <summary>
        /// Return a matrix that will show a 2D space and, because of the perspective, things that are further away appear smaller.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 FocalLengthMatrix(double focal)
        {
            double4x4 rotMat;
            rotMat.rc00 = focal;
            rotMat.rc11 = focal;
            rotMat.rc22 = 0d;
            rotMat.rc32 = 1d;
            rotMat.rc33 = rotMat.rc10 = rotMat.rc20 = rotMat.rc30 = rotMat.rc01 = rotMat.rc21 = rotMat.rc31 = rotMat.rc02 = rotMat.rc12 = rotMat.rc03 = rotMat.rc13 = rotMat.rc23 = 0d;
            return rotMat;
        }
        /// <summary>
        /// A scale matrix for 2D vector.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 ScaleMatrix(double3 v)
        {
            double4x4 rotMat;
            rotMat.rc00 = v.x;
            rotMat.rc11 = v.y;
            rotMat.rc22 = v.z;
            rotMat.rc33 = 1d;
            rotMat.rc10 = rotMat.rc20 = rotMat.rc30 = rotMat.rc01 = rotMat.rc21 = rotMat.rc31 = rotMat.rc02 = rotMat.rc12 = rotMat.rc32 = rotMat.rc03 = rotMat.rc13 = rotMat.rc23 = 0d;
            return rotMat;
        }
        /// <summary>
        /// Return the matric square by itself.
        /// </summary>
        [XmlIgnore]
        public double4x4 Square
        {
            get
            {
                double4x4 c;
                c.rc00 = rc00 * rc00 + rc10 * rc01 + rc20 * rc02 + rc30 * rc03;
                c.rc10 = rc00 * rc10 + rc10 * rc11 + rc20 * rc12 + rc30 * rc13;
                c.rc20 = rc00 * rc20 + rc10 * rc21 + rc20 * rc22 + rc30 * rc23;
                c.rc30 = rc00 * rc30 + rc10 * rc31 + rc20 * rc32 + rc30 * rc33;
                c.rc01 = rc01 * rc00 + rc11 * rc01 + rc21 * rc02 + rc31 * rc03;
                c.rc11 = rc01 * rc10 + rc11 * rc11 + rc21 * rc12 + rc31 * rc13;
                c.rc21 = rc01 * rc20 + rc11 * rc21 + rc21 * rc22 + rc31 * rc23;
                c.rc31 = rc01 * rc30 + rc11 * rc31 + rc21 * rc32 + rc31 * rc33;
                c.rc02 = rc02 * rc00 + rc12 * rc01 + rc22 * rc02 + rc32 * rc03;
                c.rc12 = rc02 * rc10 + rc12 * rc11 + rc22 * rc12 + rc32 * rc13;
                c.rc22 = rc02 * rc20 + rc12 * rc21 + rc22 * rc22 + rc32 * rc23;
                c.rc32 = rc02 * rc30 + rc12 * rc31 + rc22 * rc32 + rc32 * rc33;
                c.rc03 = rc03 * rc00 + rc13 * rc01 + rc23 * rc02 + rc33 * rc03;
                c.rc13 = rc03 * rc10 + rc13 * rc11 + rc23 * rc12 + rc33 * rc13;
                c.rc23 = rc03 * rc20 + rc13 * rc21 + rc23 * rc22 + rc33 * rc23;
                c.rc33 = rc03 * rc30 + rc13 * rc31 + rc23 * rc32 + rc33 * rc33;
                return c;
            }
        }
        /// <summary>
        /// Use this for double3 homogeneous coordinates. It multiply the double3 by the matrix and then, divide the coordinates by the w.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public double3 Mul(double3 a)
        {
            double3 vec;
            vec.x = rc00 * a.x + rc10 * a.y + rc20 * a.z + rc30;
            vec.y = rc01 * a.x + rc11 * a.y + rc21 * a.z + rc31;
            vec.z = rc02 * a.x + rc12 * a.y + rc22 * a.z + rc32;
            return vec / (rc03 + rc13 + rc23 + rc33);
        }
        /// <summary>
        /// Return an oblique matrix used for producing two-dimensional images of three-dimensional objects.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double4x4 ObliqueProjectionMatrix(double a)
        {
            double4x4 rotMat;
            rotMat.rc00 = 1d;
            rotMat.rc11 = 1d;
            rotMat.rc20 = System.Math.Cos(a);
            rotMat.rc21 = 0.5d * rotMat.rc20.SinFromCosTheta(a);
            rotMat.rc20 *= 0.5d;
            rotMat.rc22 = rotMat.rc10 = rotMat.rc01 = rotMat.rc02 = rotMat.rc12 = 0f;
            rotMat.rc30 = 0d;
            rotMat.rc31 = 0d;
            rotMat.rc32 = 0d;
            rotMat.rc33 = 0d;
            rotMat.rc23 = 0d;
            rotMat.rc13 = 0d;
            rotMat.rc03 = 0d;
            return rotMat;
        }
        /// <summary>
        /// Return a 3x3 Matrix that does a translation, rotation and scaling for 3D point.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="rotation"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static double4x4 TRSMatrix(double3 position, double3 rotation, double3 scale)
        {
            double sinX = System.Math.Sin(position.x);
            double cosX = System.Math.Cos(position.x);
            double sinY = System.Math.Sin(position.y);
            double cosY = System.Math.Cos(position.y);
            double sinZ = System.Math.Sin(position.z);
            double cosZ = System.Math.Cos(position.z);
            double4x4 a;
            a.rc00 = (cosY * cosZ) * scale.x;
            a.rc10 = (-cosY * sinZ) * scale.x;
            a.rc20 = sinY * scale.x;
            a.rc01 = (cosX * sinZ + sinX * sinY * cosZ) * scale.y;
            a.rc11 = (cosX * cosZ - sinX * sinY * sinZ) * scale.y;
            a.rc21 = (-sinX * cosY) * scale.y;
            a.rc02 = (sinX * sinZ - cosX * sinY * cosZ) * scale.z;
            a.rc12 = (sinX * cosZ + cosX * sinY * sinZ) * scale.z;
            a.rc22 = (cosX * cosY) * scale.z;
            a.rc30 = position.x;
            a.rc31 = position.y;
            a.rc32 = position.z;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix that rotate a certain amount of degree on the x, y and z axis depending on the input.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrix(double x, double y, double z)
        {
            double sinX = System.Math.Sin(x);
            double cosX = System.Math.Cos(x);
            double sinY = System.Math.Sin(y);
            double cosY = System.Math.Cos(y);
            double sinZ = System.Math.Sin(z);
            double cosZ = System.Math.Cos(z);
            double4x4 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = -cosY * sinZ;
            a.rc20 = sinY;
            a.rc30 = 0d;
            a.rc01 = cosX * sinZ + sinX * sinY * cosZ;
            a.rc11 = cosX * cosZ - sinX * sinY * sinZ;
            a.rc21 = -sinX * cosY;
            a.rc31 = 0d;
            a.rc02 = sinX * sinZ - cosX * sinY * cosZ;
            a.rc12 = sinX * cosZ + cosX * sinY * sinZ;
            a.rc22 = cosX * cosY;
            a.rc32 = 0d;
            a.rc03 = 0d;
            a.rc13 = 0d;
            a.rc23 = 0d;
            a.rc33 = 1d;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and y axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrixXY(double3 v)
        {
            double sinX = System.Math.Sin(v.x);
            double cosX = System.Math.Cos(v.x);
            double sinY = System.Math.Sin(v.y);
            double cosY = System.Math.Cos(v.y);
            double4x4 a;
            a.rc00 = cosY;
            a.rc10 = 0d;
            a.rc20 = sinY;
            a.rc01 = sinX * sinY;
            a.rc11 = cosX;
            a.rc21 = -sinX * cosY;
            a.rc02 = 0d - cosX * sinY;
            a.rc12 = sinX;
            a.rc22 = cosX * cosY;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrixXZ(double3 v)
        {
            double sinX = System.Math.Sin(v.x);
            double cosX = System.Math.Cos(v.x);
            double sinZ = System.Math.Sin(v.z);
            double cosZ = System.Math.Cos(v.z);
            double4x4 a;
            a.rc00 = cosZ;
            a.rc10 = -sinZ;
            a.rc20 = 0d;
            a.rc01 = cosX * sinZ;
            a.rc11 = cosX * cosZ;
            a.rc21 = -sinX;
            a.rc02 = sinX * sinZ;
            a.rc12 = sinX * cosZ;
            a.rc22 = cosX;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrixYZ(double3 v)
        {
            double sinY = System.Math.Sin(v.y);
            double cosY = System.Math.Cos(v.y);
            double sinZ = System.Math.Sin(v.z);
            double cosZ = System.Math.Cos(v.z);
            double4x4 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = -cosY * sinZ;
            a.rc20 = sinY;
            a.rc01 = sinZ;
            a.rc11 = cosZ;
            a.rc21 = 0d;
            a.rc02 = 0d - sinY * cosZ;
            a.rc12 = sinY * sinZ;
            a.rc22 = cosY;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and y axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrixXY(double2 v)
        {
            double sinX = System.Math.Sin(v.x);
            double cosX = System.Math.Cos(v.x);
            double sinY = System.Math.Sin(v.y);
            double cosY = System.Math.Cos(v.y);
            double4x4 a;
            a.rc00 = cosY;
            a.rc10 = 0d;
            a.rc20 = sinY;
            a.rc01 = sinX * sinY;
            a.rc11 = cosX;
            a.rc21 = -sinX * cosY;
            a.rc02 = 0d - cosX * sinY;
            a.rc12 = sinX;
            a.rc22 = cosX * cosY;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrixXZ(double2 v)
        {
            double sinX = System.Math.Sin(v.x);
            double cosX = System.Math.Cos(v.x);
            double sinZ = System.Math.Sin(v.y);
            double cosZ = System.Math.Cos(v.y);
            double4x4 a;
            a.rc00 = cosZ;
            a.rc10 = -sinZ;
            a.rc20 = 0d;
            a.rc01 = cosX * sinZ;
            a.rc11 = cosX * cosZ;
            a.rc21 = -sinX;
            a.rc02 = sinX * sinZ;
            a.rc12 = sinX * cosZ;
            a.rc22 = cosX;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrixYZ(double2 v)
        {
            double sinY = System.Math.Sin(v.x);
            double cosY = System.Math.Cos(v.x);
            double sinZ = System.Math.Sin(v.y);
            double cosZ = System.Math.Cos(v.y);
            double4x4 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = -cosY * sinZ;
            a.rc20 = sinY;
            a.rc01 = sinZ;
            a.rc11 = cosZ;
            a.rc21 = 0d;
            a.rc02 = 0d - sinY * cosZ;
            a.rc12 = sinY * sinZ;
            a.rc22 = cosY;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix that rotate a certain amount of degree on the x, y and z axis depending on the input.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrix(double3 v)
        {
            double sinX = System.Math.Sin(v.x);
            double cosX = System.Math.Cos(v.x);
            double sinY = System.Math.Sin(v.y);
            double cosY = System.Math.Cos(v.y);
            double sinZ = System.Math.Sin(v.z);
            double cosZ = System.Math.Cos(v.z);
            double4x4 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = -cosY * sinZ;
            a.rc20 = sinY;
            a.rc01 = cosX * sinZ + sinX * sinY * cosZ;
            a.rc11 = cosX * cosZ - sinX * sinY * sinZ;
            a.rc21 = -sinX * cosY;
            a.rc02 = sinX * sinZ - cosX * sinY * cosZ;
            a.rc12 = sinX * cosZ + cosX * sinY * sinZ;
            a.rc22 = cosX * cosY;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Rotation matric for angle X.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrixX(double angle)
        {
            double angleCos = System.Math.Cos(angle);
            double angleSin = System.Math.Sin(angle);
            double4x4 a;
            a.rc00 = 1d;
            a.rc11 = a.rc22 = angleCos;
            a.rc12 = angleSin;
            a.rc21 = -angleSin;
            a.rc10 = a.rc20 = a.rc01 = a.rc02 = 0d;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Rotation matric for angle Y.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrixY(double angle)
        {
            double angleCos = System.Math.Cos(angle);
            double angleSin = System.Math.Sin(angle);
            double4x4 a;
            a.rc10 = a.rc01 = a.rc21 = a.rc12 = 0d;
            a.rc11 = 1d;
            a.rc00 = a.rc22 = angleCos;
            a.rc20 = angleSin;
            a.rc02 = -angleSin;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Rotation matric for angle Z.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrixZ(double angle)
        {
            double angleCos = System.Math.Cos(angle);
            double angleSin = System.Math.Sin(angle);
            double4x4 a;
            a.rc00 = a.rc11 = angleCos;
            a.rc01 = angleSin;
            a.rc10 = -angleSin;
            a.rc22 = 1d;
            a.rc20 = a.rc21 = a.rc02 = a.rc12 = 0d;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix that will rotate around an axis by a certain angle.
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrixAxis(double3 axis, double angle)
        {
            double angleCos = System.Math.Cos(angle);
            double angleSin = System.Math.Sin(angle);
            double4x4 a;
            a.rc00 = (axis.x * axis.x) * (1d - angleCos) + angleCos;
            a.rc10 = axis.x * axis.y * (1d - angleCos) - axis.z * angleSin;
            a.rc20 = axis.x * axis.z * (1d - angleCos) + axis.y * angleSin;
            a.rc01 = axis.x * axis.y * (1d - angleCos) + axis.z * angleSin;
            a.rc11 = (axis.y * axis.y) * (1d - angleCos) + angleCos;
            a.rc21 = axis.y * axis.z * (1d - angleCos) - axis.x * angleSin;
            a.rc02 = axis.x * axis.z * (1d - angleCos) - axis.y * angleSin;
            a.rc12 = axis.y * axis.z * (1d - angleCos) + axis.x * angleSin;
            a.rc22 = (axis.z * axis.z) * (1d - angleCos) + angleCos;
            a.rc30 = 0d;
            a.rc31 = 0d;
            a.rc32 = 0d;
            a.rc33 = 1d;
            a.rc23 = 0d;
            a.rc13 = 0d;
            a.rc03 = 0d;
            return a;
        }
        /// <summary>
        /// Return a constrained billboard matrix.
        /// </summary>
        /// <param name="objectPosition"></param>
        /// <param name="cameraPosition"></param>
        /// <param name="rotateAxis"></param>
        /// <param name="cameraForwardVector"></param>
        /// <param name="objectForwardVector"></param>
        /// <returns></returns>
        public static double4x4 ConstrainedBillboardMatrix(double3 objectPosition, double3 cameraPosition, double3 rotateAxis, double3? cameraForwardVector, double3? objectForwardVector)
        {
            double num;
            double3 vector;
            double3 vector2;
            double3 vector3;
            vector2 = objectPosition - cameraPosition;
            num = vector2.SqrMagnitude;
            if (num < 0.0001d)
            {
                vector2 = cameraForwardVector.HasValue ? -cameraForwardVector.Value : double3.Forward;
            }
            else
            {
                vector2 = vector2 * (1d / Math.Sqrt(num));
            }
            double3 vector4 = rotateAxis;
            num = rotateAxis.x * vector2.x + rotateAxis.y * vector2.y + rotateAxis.z * vector2.z;
            if (Math.Abs(num) > 0.9982547d)
            {
                if (objectForwardVector.HasValue)
                {
                    vector = objectForwardVector.Value;
                    num = rotateAxis.x * vector.x + rotateAxis.y * vector.y + rotateAxis.z * vector.z;
                    if (Math.Abs(num) > 0.9982547d)
                    {
                        vector = (Math.Abs(rotateAxis.z) > 0.9982547d) ? double3.Right : double3.Forward;
                    }
                }
                else
                {
                    vector = (Math.Abs(rotateAxis.z) > 0.9982547d) ? double3.Right : double3.Forward;
                }
                vector3 = double3.Cross(rotateAxis, vector).Normalized;
                vector = double3.Cross(vector3, rotateAxis).Normalized;
            }
            else
            {
                vector3 = double3.Cross(rotateAxis, vector2).Normalized;
                vector = double3.Cross(vector3, vector4).Normalized;
            }
            double4x4 result;
            result.rc00 = vector3.x;
            result.rc01 = vector3.y;
            result.rc02 = vector3.z;
            result.rc03 = 0d;
            result.rc10 = vector4.x;
            result.rc11 = vector4.y;
            result.rc12 = vector4.z;
            result.rc13 = 0d;
            result.rc20 = vector.x;
            result.rc21 = vector.y;
            result.rc22 = vector.z;
            result.rc23 = 0d;
            result.rc30 = objectPosition.x;
            result.rc31 = objectPosition.y;
            result.rc32 = objectPosition.z;
            result.rc33 = 1d;
            return result;
        }
        /// <summary>
        /// Return a billboard matrix.
        /// </summary>
        /// <param name="objectPosition"></param>
        /// <param name="cameraPosition"></param>
        /// <param name="cameraUpVector"></param>
        /// <param name="cameraForwardVector"></param>
        /// <returns></returns>
        public static double4x4 BillboardMatrix(double3 objectPosition, double3 cameraPosition, double3 cameraUpVector, double3? cameraForwardVector = null)
        {
            double4x4 matrix;
            double3 vector;
            double3 vector2;
            double3 vector3;
            vector = objectPosition - cameraPosition;
            double num = vector.SqrMagnitude;
            if (num < 0.0001d)
            {
                vector = cameraForwardVector.HasValue ? -cameraForwardVector.Value : double3.Forward;
            }
            else
            {
                vector = vector * (1d / Math.Sqrt(num));
            }
            vector3 = double3.Cross(cameraUpVector, vector).Normalized;
            vector2 = double3.Cross(vector, vector3);
            matrix.rc00 = vector3.x;
            matrix.rc01 = vector3.y;
            matrix.rc02 = vector3.z;
            matrix.rc03 = 0d;
            matrix.rc10 = vector2.x;
            matrix.rc11 = vector2.y;
            matrix.rc12 = vector2.z;
            matrix.rc13 = 0d;
            matrix.rc20 = vector.x;
            matrix.rc21 = vector.y;
            matrix.rc22 = vector.z;
            matrix.rc23 = 0d;
            matrix.rc30 = objectPosition.x;
            matrix.rc31 = objectPosition.y;
            matrix.rc32 = objectPosition.z;
            matrix.rc33 = 1d;
            return matrix;
        }
        /// <summary>
        /// Return a world matrix
        /// </summary>
        /// <param name="position"></param>
        /// <param name="forward"></param>
        /// <param name="up"></param>
        /// <returns></returns>
        public static double4x4 WorldMatrix(double3 position, double3 forward, double3 up)
        {
            double4x4 result;
            double3 x = double3.Cross(forward, up);
            double3 y = double3.Cross(x, forward).Normalized;
            x.Normalize();
            result.rc00 = x.x;
            result.rc01 = x.y;
            result.rc02 = x.z;
            result.rc03 = 0d;
            result.rc10 = y.x;
            result.rc11 = y.y;
            result.rc12 = y.z;
            result.rc13 = 0d;
            result.rc20 = -forward.x;
            result.rc21 = -forward.y;
            result.rc22 = -forward.z;
            result.rc23 = 0d;
            result.rc30 = position.x;
            result.rc31 = position.y;
            result.rc32 = position.z;
            result.rc33 = 1d;
            return result;
        }
        /// <summary>
        /// Return an orthographic matrix that is off centered.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="top"></param>
        /// <param name="zNearPlane"></param>
        /// <param name="zFarPlane"></param>
        /// <returns></returns>
        public static double4x4 OrthographicOffCenter(double left, double right, double bottom, double top, double zNearPlane, double zFarPlane)
        {
            double4x4 matrix;
            matrix.rc00 = 2.0d / (right - left);
            matrix.rc01 = 0.0d;
            matrix.rc02 = 0.0d;
            matrix.rc03 = 0.0d;
            matrix.rc10 = 0.0d;
            matrix.rc11 = 2.0d / (top - bottom);
            matrix.rc12 = 0.0d;
            matrix.rc13 = 0.0d;
            matrix.rc20 = 0.0d;
            matrix.rc21 = 0.0d;
            matrix.rc22 = 1.0d / (zNearPlane - zFarPlane);
            matrix.rc23 = 0.0d;
            matrix.rc30 = (left + right) / (left - right);
            matrix.rc31 = (top + bottom) / (bottom - top);
            matrix.rc32 = zNearPlane / (zNearPlane - zFarPlane);
            matrix.rc33 = 1.0d;
            return matrix;
        }
        /// <summary>
        /// Return an orthographic matrix.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="zNearPlane"></param>
        /// <param name="zFarPlane"></param>
        /// <returns></returns>
        public static double4x4 OrthographicMatrix(double width, double height, double zNearPlane, double zFarPlane)
        {
            double4x4 matrix;
            matrix.rc00 = 2d / width;
            matrix.rc01 = matrix.rc02 = matrix.rc03 = 0d;
            matrix.rc11 = 2d / height;
            matrix.rc10 = matrix.rc12 = matrix.rc13 = 0d;
            matrix.rc22 = 1d / (zNearPlane - zFarPlane);
            matrix.rc20 = matrix.rc21 = matrix.rc23 = 0d;
            matrix.rc30 = matrix.rc31 = 0d;
            matrix.rc32 = zNearPlane / (zNearPlane - zFarPlane);
            matrix.rc33 = 1d;
            return matrix;
        }
        /// <summary>
        /// Return a matrix that look at a specified target.
        /// </summary>
        /// <param name="cameraPosition"></param>
        /// <param name="cameraTarget"></param>
        /// <param name="cameraUpVector"></param>
        /// <returns></returns>
        public static double4x4 LookAtMatrix(double3 cameraPosition, double3 cameraTarget, double3 cameraUpVector)
        {
            double3 targetDir = (cameraPosition - cameraTarget).Normalized;
            double3 upDirCross = double3.Cross(cameraUpVector, targetDir).Normalized;
            double3 targetUpDirCross = double3.Cross(targetDir, upDirCross);
            double4x4 matrix;
            matrix.rc00 = upDirCross.x;
            matrix.rc01 = targetUpDirCross.x;
            matrix.rc02 = targetDir.x;
            matrix.rc03 = 0.0d;
            matrix.rc10 = upDirCross.y;
            matrix.rc11 = targetUpDirCross.y;
            matrix.rc12 = targetDir.y;
            matrix.rc13 = 0.0d;
            matrix.rc20 = upDirCross.z;
            matrix.rc21 = targetUpDirCross.z;
            matrix.rc22 = targetDir.z;
            matrix.rc23 = 0.0d;
            matrix.rc30 = -(upDirCross.x * cameraPosition.x + upDirCross.y * cameraPosition.y + upDirCross.z * cameraPosition.z);
            matrix.rc31 = -(targetUpDirCross.x * cameraPosition.x + targetUpDirCross.y * cameraPosition.y + targetUpDirCross.z * cameraPosition.z);
            matrix.rc32 = -(targetDir.x * cameraPosition.x + targetDir.y * cameraPosition.y + targetDir.z * cameraPosition.z);
            matrix.rc33 = 1d;
            return matrix;
        }
        /// <summary>
        /// Return a perspective matrix.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="nearPlaneDistance"></param>
        /// <param name="farPlaneDistance"></param>
        /// <returns></returns>
        public static double4x4 PerspectiveMatrix(double width, double height, double nearPlaneDistance, double farPlaneDistance)
        {
            if (nearPlaneDistance <= 0d)
            {
                throw new ArgumentException("nearPlaneDistance <= 0");
            }
            if (farPlaneDistance <= 0d)
            {
                throw new ArgumentException("farPlaneDistance <= 0");
            }
            if (nearPlaneDistance >= farPlaneDistance)
            {
                throw new ArgumentException("nearPlaneDistance >= farPlaneDistance");
            }
            double4x4 result;
            result.rc00 = (2d * nearPlaneDistance) / width;
            result.rc01 = result.rc02 = result.rc03 = 0d;
            result.rc11 = (2d * nearPlaneDistance) / height;
            result.rc10 = result.rc12 = result.rc13 = 0d;
            result.rc22 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.rc20 = result.rc21 = 0d;
            result.rc23 = -1d;
            result.rc30 = result.rc31 = result.rc33 = 0d;
            result.rc32 = (nearPlaneDistance * farPlaneDistance) / (nearPlaneDistance - farPlaneDistance);
            return result;
        }
        /// <summary>
        /// Return a perspective matrix that is off centered.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="bottom"></param>
        /// <param name="top"></param>
        /// <param name="nearPlaneDistance"></param>
        /// <param name="farPlaneDistance"></param>
        /// <returns></returns>
        public static double4x4 PerspectiveOffCenterMatrix(double left, double right, double bottom, double top, double nearPlaneDistance, double farPlaneDistance)
        {
            if (nearPlaneDistance <= 0d)
            {
                throw new ArgumentException("nearPlaneDistance <= 0");
            }
            if (farPlaneDistance <= 0d)
            {
                throw new ArgumentException("farPlaneDistance <= 0");
            }
            if (nearPlaneDistance >= farPlaneDistance)
            {
                throw new ArgumentException("nearPlaneDistance >= farPlaneDistance");
            }
            double4x4 matrix;
            matrix.rc00 = (2d * nearPlaneDistance) / (right - left);
            matrix.rc01 = matrix.rc02 = matrix.rc03 = 0d;
            matrix.rc11 = (2d * nearPlaneDistance) / (top - bottom);
            matrix.rc10 = matrix.rc12 = matrix.rc13 = 0d;
            matrix.rc20 = (left + right) / (right - left);
            matrix.rc21 = (top + bottom) / (top - bottom);
            matrix.rc22 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            matrix.rc23 = -1d;
            matrix.rc32 = (nearPlaneDistance * farPlaneDistance) / (nearPlaneDistance - farPlaneDistance);
            matrix.rc30 = matrix.rc31 = matrix.rc33 = 0d;
            return matrix;
        }
        /// <summary>
        /// Return a perspective matrix that have a field of view.
        /// </summary>
        /// <param name="fieldOfView"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="nearPlaneDistance"></param>
        /// <param name="farPlaneDistance"></param>
        /// <returns></returns>
        public static double4x4 PerspectiveFieldOfViewMatrix(double fieldOfView, double aspectRatio, double nearPlaneDistance, double farPlaneDistance)
        {
            if ((fieldOfView <= 0d) || (fieldOfView >= MathConst.Pi))
            {
                throw new ArgumentException("fieldOfView <= 0 or >= PI");
            }
            if (nearPlaneDistance <= 0d)
            {
                throw new ArgumentException("nearPlaneDistance <= 0");
            }
            if (farPlaneDistance <= 0d)
            {
                throw new ArgumentException("farPlaneDistance <= 0");
            }
            if (nearPlaneDistance >= farPlaneDistance)
            {
                throw new ArgumentException("nearPlaneDistance >= farPlaneDistance");
            }
            double4x4 result;
            double num = 1d / System.Math.Tan(fieldOfView * 0.5d);
            result.rc00 = num / aspectRatio;
            result.rc01 = result.rc02 = result.rc03 = 0d;
            result.rc11 = num;
            result.rc10 = result.rc12 = result.rc13 = 0d;
            result.rc20 = result.rc21 = 0d;
            result.rc22 = farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result.rc23 = -1d;
            result.rc30 = result.rc31 = result.rc33 = 0d;
            result.rc32 = (nearPlaneDistance * farPlaneDistance) / (nearPlaneDistance - farPlaneDistance);
            return result;
        }
        /// <summary>
        /// Return the inverse of the matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static double4x4 Inverse(double4x4 matrix)
        {
            double4x4 result;
            double num17 = (matrix.rc22 * matrix.rc33 - matrix.rc23 * matrix.rc32);
            double num18 = (matrix.rc21 * matrix.rc33 - matrix.rc23 * matrix.rc31);
            double num19 = (matrix.rc21 * matrix.rc32 - matrix.rc22 * matrix.rc31);
            double num20 = (matrix.rc20 * matrix.rc33 - matrix.rc23 * matrix.rc30);
            double num21 = (matrix.rc20 * matrix.rc32 - matrix.rc22 * matrix.rc30);
            double num22 = (matrix.rc20 * matrix.rc31 - matrix.rc21 * matrix.rc30);
            double num23 = (matrix.rc11 * num17 - matrix.rc12 * num18 + matrix.rc13 * num19);
            double num24 = -(matrix.rc10 * num17 - matrix.rc12 * num20 + matrix.rc13 * num21);
            double num25 = (matrix.rc10 * num18 - matrix.rc11 * num20 + matrix.rc13 * num22);
            double num26 = -(matrix.rc10 * num19 - matrix.rc11 * num21 + matrix.rc12 * num22);
            double num27 = (1.0d / (matrix.rc00 * num23 + matrix.rc01 * num24 + matrix.rc02 * num25 + matrix.rc03 * num26));
            result.rc00 = num23 * num27;
            result.rc10 = num24 * num27;
            result.rc20 = num25 * num27;
            result.rc30 = num26 * num27;
            result.rc01 = -(matrix.rc01 * num17 - matrix.rc02 * num18 + matrix.rc03 * num19) * num27;
            result.rc11 = (matrix.rc00 * num17 - matrix.rc02 * num20 + matrix.rc03 * num21) * num27;
            result.rc21 = -(matrix.rc00 * num18 - matrix.rc01 * num20 + matrix.rc03 * num22) * num27;
            result.rc31 = (matrix.rc00 * num19 - matrix.rc01 * num21 + matrix.rc02 * num22) * num27;
            num17 = (matrix.rc12 * matrix.rc33 - matrix.rc13 * matrix.rc32);
            num18 = (matrix.rc11 * matrix.rc33 - matrix.rc13 * matrix.rc31);
            num19 = (matrix.rc11 * matrix.rc32 - matrix.rc12 * matrix.rc31);
            num20 = (matrix.rc10 * matrix.rc33 - matrix.rc13 * matrix.rc30);
            num21 = (matrix.rc10 * matrix.rc32 - matrix.rc12 * matrix.rc30);
            num22 = (matrix.rc10 * matrix.rc31 - matrix.rc11 * matrix.rc30);
            result.rc02 = (matrix.rc01 * num17 - matrix.rc02 * num18 + matrix.rc03 * num19) * num27;
            result.rc12 = -(matrix.rc00 * num17 - matrix.rc02 * num20 + matrix.rc03 * num21) * num27;
            result.rc22 = (matrix.rc00 * num18 - matrix.rc01 * num20 + matrix.rc03 * num22) * num27;
            result.rc32 = -(matrix.rc00 * num19 - matrix.rc01 * num21 + matrix.rc02 * num22) * num27;
            num17 = (matrix.rc12 * matrix.rc23 - matrix.rc13 * matrix.rc22);
            num18 = (matrix.rc11 * matrix.rc23 - matrix.rc13 * matrix.rc21);
            num19 = (matrix.rc11 * matrix.rc22 - matrix.rc12 * matrix.rc21);
            num20 = (matrix.rc10 * matrix.rc23 - matrix.rc13 * matrix.rc20);
            num21 = (matrix.rc10 * matrix.rc22 - matrix.rc12 * matrix.rc20);
            num22 = (matrix.rc10 * matrix.rc21 - matrix.rc11 * matrix.rc20);
            result.rc03 = -(matrix.rc01 * num17 - matrix.rc02 * num18 + matrix.rc23 * num19) * num27;
            result.rc13 = (matrix.rc00 * num17 - matrix.rc02 * num20 + matrix.rc23 * num21) * num27;
            result.rc23 = -(matrix.rc00 * num18 - matrix.rc01 * num20 + matrix.rc03 * num22) * num27;
            result.rc33 = (matrix.rc00 * num19 - matrix.rc01 * num21 + matrix.rc02 * num22) * num27;
            return result;
        }
        /// <summary>
        /// Lineary interpolate between two matrix.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double4x4 Lerp(double4x4 m1, double4x4 m2, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            m1.rc00 = m1.rc00 + (m2.rc00 - m1.rc00) * t;
            m1.rc10 = m1.rc10 + (m2.rc10 - m1.rc10) * t;
            m1.rc20 = m1.rc20 + (m2.rc20 - m1.rc20) * t;
            m1.rc30 = m1.rc30 + (m2.rc30 - m1.rc30) * t;
            m1.rc01 = m1.rc01 + (m2.rc01 - m1.rc01) * t;
            m1.rc11 = m1.rc11 + (m2.rc11 - m1.rc11) * t;
            m1.rc21 = m1.rc21 + (m2.rc21 - m1.rc21) * t;
            m1.rc31 = m1.rc31 + (m2.rc31 - m1.rc31) * t;
            m1.rc02 = m1.rc02 + (m2.rc02 - m1.rc02) * t;
            m1.rc12 = m1.rc12 + (m2.rc12 - m1.rc12) * t;
            m1.rc22 = m1.rc22 + (m2.rc22 - m1.rc22) * t;
            m1.rc32 = m1.rc32 + (m2.rc32 - m1.rc32) * t;
            m1.rc03 = m1.rc03 + (m2.rc03 - m1.rc03) * t;
            m1.rc13 = m1.rc13 + (m2.rc13 - m1.rc13) * t;
            m1.rc23 = m1.rc23 + (m2.rc23 - m1.rc23) * t;
            m1.rc33 = m1.rc33 + (m2.rc33 - m1.rc33) * t;
            return m1;
        }
        /// <summary>
        /// Lineary interpolate between two matrix.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double4x4 LerpUnclamped(double4x4 m1, double4x4 m2, double t)
        {
            m1.rc00 = m1.rc00 + (m2.rc00 - m1.rc00) * t;
            m1.rc10 = m1.rc10 + (m2.rc10 - m1.rc10) * t;
            m1.rc20 = m1.rc20 + (m2.rc20 - m1.rc20) * t;
            m1.rc30 = m1.rc30 + (m2.rc30 - m1.rc30) * t;
            m1.rc01 = m1.rc01 + (m2.rc01 - m1.rc01) * t;
            m1.rc11 = m1.rc11 + (m2.rc11 - m1.rc11) * t;
            m1.rc21 = m1.rc21 + (m2.rc21 - m1.rc21) * t;
            m1.rc31 = m1.rc31 + (m2.rc31 - m1.rc31) * t;
            m1.rc02 = m1.rc02 + (m2.rc02 - m1.rc02) * t;
            m1.rc12 = m1.rc12 + (m2.rc12 - m1.rc12) * t;
            m1.rc22 = m1.rc22 + (m2.rc22 - m1.rc22) * t;
            m1.rc32 = m1.rc32 + (m2.rc32 - m1.rc32) * t;
            m1.rc03 = m1.rc03 + (m2.rc03 - m1.rc03) * t;
            m1.rc13 = m1.rc13 + (m2.rc13 - m1.rc13) * t;
            m1.rc23 = m1.rc23 + (m2.rc23 - m1.rc23) * t;
            m1.rc33 = m1.rc33 + (m2.rc33 - m1.rc33) * t;
            return m1;
        }
        /// <summary>
        /// Return a rotation matrix that rotate a certain amount of degree on the x, y and z axis depending on the Quaternion.
        /// </summary>
        /// <param name="rotation"></param>
        /// <returns></returns>
        public static double4x4 RotationMatrix(dQuaternion rotation)
        {
            double xx = rotation.x * (rotation.x * 2.0d);
            double yy = rotation.y * (rotation.y * 2.0d);
            double zz = rotation.z * (rotation.z * 2.0d);
            double xy = rotation.x * (rotation.y * 2.0d);
            double xz = rotation.x * (rotation.z * 2.0d);
            double yz = rotation.y * (rotation.z * 2.0d);
            double wx = rotation.w * (rotation.x * 2.0d);
            double wy = rotation.w * (rotation.y * 2.0d);
            double wz = rotation.w * (rotation.z * 2.0d);
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
        /// <summary>
        /// Return a 3x3 Matrix that does a translation, rotation and scaling for 3D point.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="rotation"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static double4x4 TRSMatrix(double3 position, dQuaternion rotation, double3 scale)
        {
            double xx = rotation.x * (rotation.x * 2.0d);
            double yy = rotation.y * (rotation.y * 2.0d);
            double zz = rotation.z * (rotation.z * 2.0d);
            double xy = rotation.x * (rotation.y * 2.0d);
            double xz = rotation.x * (rotation.z * 2.0d);
            double yz = rotation.y * (rotation.z * 2.0d);
            double wx = rotation.w * (rotation.x * 2.0d);
            double wy = rotation.w * (rotation.y * 2.0d);
            double wz = rotation.w * (rotation.z * 2.0d);
            double4x4 m;
            m.rc00 = (1.0d - (yy + zz)) * scale.x;
            m.rc10 = (xy + wz) * scale.x;
            m.rc20 = (xz - wy) * scale.x;
            m.rc30 = 0d;
            m.rc01 = (xy - wz) * scale.y;
            m.rc11 = (1.0d - (xx + zz)) * scale.y;
            m.rc21 = (yz + wx) * scale.y;
            m.rc31 = 0d;
            m.rc02 = (xz + wy) * scale.z;
            m.rc12 = (yz - wx) * scale.z;
            m.rc22 = (1.0d - (xx + yy)) * scale.z;
            m.rc32 = 0d;
            m.rc03 = position.x;
            m.rc13 = position.y;
            m.rc23 = position.z;
            m.rc33 = 1d;
            return m;
        }
        /// <summary>
        /// Return the actual rotation of the matrix.
        /// </summary>
        public dQuaternion GetRotation
        {
            get
            {
                double3 s = Scale.xyz;
                double m00 = rc00 / s.x;
                double m11 = rc11 / s.y;
                double m22 = rc22 / s.z;
                dQuaternion q = new dQuaternion
                {
                    w = Math.Sqrt(Math.Max(0d, 1d + m00 + m11 + m22)) / 2d,
                    x = Math.Sqrt(Math.Max(0d, 1d + m00 - m11 - m22)) / 2d,
                    y = Math.Sqrt(Math.Max(0d, 1d - m00 + m11 - m22)) / 2d,
                    z = Math.Sqrt(Math.Max(0d, 1d - m00 - m11 + m22)) / 2d
                };
                q.x = q.x * Math.Sign(q.x * ((rc12 / s.y) - (rc21 / s.z)));
                q.y = q.y * Math.Sign(q.y * ((rc20 / s.z) - (rc02 / s.x)));
                q.z = q.z * Math.Sign(q.z * ((rc01 / s.x) - (rc10 / s.y)));
                m00 = Math.Sqrt(q.w * q.w + q.x * q.x + q.y * q.y + q.z * q.z);
                q.w = q.w / m00;
                q.x = q.x / m00;
                q.y = q.y / m00;
                q.z = q.z / m00;
                return q;
            }
        }
        public static double4x4 operator -(double4x4 a)
        {
            a.rc00 = -a.rc00;
            a.rc10 = -a.rc10;
            a.rc20 = -a.rc20;
            a.rc30 = -a.rc30;
            a.rc01 = -a.rc01;
            a.rc11 = -a.rc11;
            a.rc21 = -a.rc21;
            a.rc31 = -a.rc31;
            a.rc02 = -a.rc02;
            a.rc12 = -a.rc12;
            a.rc22 = -a.rc22;
            a.rc32 = -a.rc32;
            a.rc03 = -a.rc03;
            a.rc13 = -a.rc13;
            a.rc23 = -a.rc23;
            a.rc33 = -a.rc33;
            return a;
        }
        public static double4x4 operator +(double4x4 a, double4x4 b)
        {
            a.rc00 = a.rc00 + b.rc00;
            a.rc10 = a.rc10 + b.rc10;
            a.rc20 = a.rc20 + b.rc20;
            a.rc30 = a.rc30 + b.rc30;
            a.rc01 = a.rc01 + b.rc01;
            a.rc11 = a.rc11 + b.rc11;
            a.rc21 = a.rc21 + b.rc21;
            a.rc31 = a.rc31 + b.rc31;
            a.rc02 = a.rc02 + b.rc02;
            a.rc12 = a.rc12 + b.rc12;
            a.rc22 = a.rc22 + b.rc22;
            a.rc32 = a.rc32 + b.rc32;
            a.rc03 = a.rc03 + b.rc03;
            a.rc13 = a.rc13 + b.rc13;
            a.rc23 = a.rc23 + b.rc23;
            a.rc33 = a.rc33 + b.rc33;
            return a;
        }
        public static double4x4 operator -(double4x4 a, double4x4 b)
        {
            a.rc00 = a.rc00 - b.rc00;
            a.rc10 = a.rc10 - b.rc10;
            a.rc20 = a.rc20 - b.rc20;
            a.rc30 = a.rc30 - b.rc30;
            a.rc01 = a.rc01 - b.rc01;
            a.rc11 = a.rc11 - b.rc11;
            a.rc21 = a.rc21 - b.rc21;
            a.rc31 = a.rc31 - b.rc31;
            a.rc02 = a.rc02 - b.rc02;
            a.rc12 = a.rc12 - b.rc12;
            a.rc22 = a.rc22 - b.rc22;
            a.rc32 = a.rc32 - b.rc32;
            a.rc03 = a.rc03 - b.rc03;
            a.rc13 = a.rc13 - b.rc13;
            a.rc23 = a.rc23 - b.rc23;
            a.rc33 = a.rc33 - b.rc33;
            return a;
        }
        public static double4x4 operator *(double4x4 a, double b)
        {
            a.rc00 = a.rc00 * b;
            a.rc10 = a.rc10 * b;
            a.rc20 = a.rc20 * b;
            a.rc30 = a.rc30 * b;
            a.rc01 = a.rc01 * b;
            a.rc11 = a.rc11 * b;
            a.rc21 = a.rc21 * b;
            a.rc31 = a.rc31 * b;
            a.rc02 = a.rc02 * b;
            a.rc12 = a.rc12 * b;
            a.rc22 = a.rc22 * b;
            a.rc32 = a.rc32 * b;
            a.rc03 = a.rc03 * b;
            a.rc13 = a.rc13 * b;
            a.rc23 = a.rc23 * b;
            a.rc33 = a.rc33 * b;
            return a;
        }
        public static double4x4 operator *(double a, double4x4 b)
        {
            b.rc00 = b.rc00 * a;
            b.rc10 = b.rc10 * a;
            b.rc20 = b.rc20 * a;
            b.rc30 = b.rc30 * a;
            b.rc01 = b.rc01 * a;
            b.rc11 = b.rc11 * a;
            b.rc21 = b.rc21 * a;
            b.rc31 = b.rc31 * a;
            b.rc02 = b.rc02 * a;
            b.rc12 = b.rc12 * a;
            b.rc22 = b.rc22 * a;
            b.rc32 = b.rc32 * a;
            b.rc03 = b.rc03 * a;
            b.rc13 = b.rc13 * a;
            b.rc23 = b.rc23 * a;
            b.rc33 = b.rc33 * a;
            return b;
        }
        public static double4x4 operator *(double4x4 a, double4x4 b)
        {
            double4x4 c;
            c.rc00 = a.rc00 * b.rc00 + a.rc10 * b.rc01 + a.rc20 * b.rc02 + a.rc30 * b.rc03;
            c.rc10 = a.rc00 * b.rc10 + a.rc10 * b.rc11 + a.rc20 * b.rc12 + a.rc30 * b.rc13;
            c.rc20 = a.rc00 * b.rc20 + a.rc10 * b.rc21 + a.rc20 * b.rc22 + a.rc30 * b.rc23;
            c.rc30 = a.rc00 * b.rc30 + a.rc10 * b.rc31 + a.rc20 * b.rc32 + a.rc30 * b.rc33;
            c.rc01 = a.rc01 * b.rc00 + a.rc11 * b.rc01 + a.rc21 * b.rc02 + a.rc31 * b.rc03;
            c.rc11 = a.rc01 * b.rc10 + a.rc11 * b.rc11 + a.rc21 * b.rc12 + a.rc31 * b.rc13;
            c.rc21 = a.rc01 * b.rc20 + a.rc11 * b.rc21 + a.rc21 * b.rc22 + a.rc31 * b.rc23;
            c.rc31 = a.rc01 * b.rc30 + a.rc11 * b.rc31 + a.rc21 * b.rc32 + a.rc31 * b.rc33;
            c.rc02 = a.rc02 * b.rc00 + a.rc12 * b.rc01 + a.rc22 * b.rc02 + a.rc32 * b.rc03;
            c.rc12 = a.rc02 * b.rc10 + a.rc12 * b.rc11 + a.rc22 * b.rc12 + a.rc32 * b.rc13;
            c.rc22 = a.rc02 * b.rc20 + a.rc12 * b.rc21 + a.rc22 * b.rc22 + a.rc32 * b.rc23;
            c.rc32 = a.rc02 * b.rc30 + a.rc12 * b.rc31 + a.rc22 * b.rc32 + a.rc32 * b.rc33;
            c.rc03 = a.rc03 * b.rc00 + a.rc13 * b.rc01 + a.rc23 * b.rc02 + a.rc33 * b.rc03;
            c.rc13 = a.rc03 * b.rc10 + a.rc13 * b.rc11 + a.rc23 * b.rc12 + a.rc33 * b.rc13;
            c.rc23 = a.rc03 * b.rc20 + a.rc13 * b.rc21 + a.rc23 * b.rc22 + a.rc33 * b.rc23;
            c.rc33 = a.rc03 * b.rc30 + a.rc13 * b.rc31 + a.rc23 * b.rc32 + a.rc33 * b.rc33;
            return c;
        }
        public static double3 operator *(double4x4 a, double3 b)
        {
            double3 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02 * b.z + a.rc03;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12 * b.z + a.rc13;
            vec.z = a.rc20 * b.x + a.rc21 * b.y + a.rc22 * b.z + a.rc23;
            return vec;
        }
        public static double3 operator *(double3 b, double4x4 a)
        {
            double3 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02 * b.z + a.rc03;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12 * b.z + a.rc13;
            vec.z = a.rc20 * b.x + a.rc21 * b.y + a.rc22 * b.z + a.rc23;
            return vec;
        }
        public static double4 operator *(double4x4 a, double4 b)
        {
            double4 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02 * b.z + a.rc03 * b.w;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12 * b.z + a.rc13 * b.w;
            vec.z = a.rc20 * b.x + a.rc21 * b.y + a.rc22 * b.z + a.rc23 * b.w;
            vec.w = a.rc30 * b.x + a.rc31 * b.y + a.rc32 * b.z + a.rc33 * b.w;
            return vec;
        }
        public static double4 operator *(double4 b, double4x4 a)
        {
            double4 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02 * b.z + a.rc03 * b.w;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12 * b.z + a.rc13 * b.w;
            vec.z = a.rc20 * b.x + a.rc21 * b.y + a.rc22 * b.z + a.rc23 * b.w;
            vec.w = a.rc30 * b.x + a.rc31 * b.y + a.rc32 * b.z + a.rc33 * b.w;
            return vec;
        }
        public static implicit operator double2x2(double4x4 a)
        {
            double2x2 b;
            b.rc00 = a.rc00;
            b.rc01 = a.rc10;
            b.rc10 = a.rc01;
            b.rc11 = a.rc11;
            return a;
        }
        public static implicit operator double3x3(double4x4 a)
        {
            double3x3 b;
            b.rc00 = a.rc00;
            b.rc10 = a.rc10;
            b.rc20 = a.rc20;
            b.rc01 = a.rc01;
            b.rc11 = a.rc11;
            b.rc21 = a.rc21;
            b.rc02 = a.rc02;
            b.rc12 = a.rc12;
            b.rc22 = a.rc22;
            return a;
        }
    }
}
