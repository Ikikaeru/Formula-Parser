using System;
using System.Xml.Serialization;
using IkiCore.Core;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct double3x3
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
        public double3 GetRow(int i)
        {
            double3 a;
            switch (i)
            {
                case 0:
                    a.x = rc00;
                    a.y = rc01;
                    a.z = rc02;
                    return a;
                case 1:
                    a.x = rc10;
                    a.y = rc11;
                    a.z = rc12;
                    return a;
                default:
                    a.x = rc20;
                    a.y = rc21;
                    a.z = rc22;
                    return a;
            }
        }
        /// <summary>
        /// Return the desired row of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public void SetRow(int i, double3 v)
        {
            switch (i)
            {
                case 0:
                    rc00 = v.x;
                    rc01 = v.y;
                    rc02 = v.z;
                    break;
                case 1:
                    rc10 = v.x;
                    rc11 = v.y;
                    rc12 = v.z;
                    break;
                default:
                    rc20 = v.x;
                    rc21 = v.y;
                    rc22 = v.z;
                    break;
            }
        }
        /// <summary>
        /// Return the desired column of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public double3 GetColumn(int i)
        {
            double3 a;
            switch (i)
            {
                case 0:
                    a.x = rc00;
                    a.y = rc10;
                    a.z = rc20;
                    return a;
                case 1:
                    a.x = rc01;
                    a.y = rc11;
                    a.z = rc21;
                    return a;
                default:
                    a.x = rc02;
                    a.y = rc12;
                    a.z = rc22;
                    return a;
            }
        }
        /// <summary>
        /// Set the desired column of the matrix.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public void SetColumn(int i, double3 v)
        {
            switch (i)
            {
                case 0:
                    rc00 = v.x;
                    rc10 = v.y;
                    rc20 = v.z;
                    break;
                case 1:
                    rc01 = v.x;
                    rc11 = v.y;
                    rc21 = v.z;
                    break;
                default:
                    rc02 = v.x;
                    rc12 = v.y;
                    rc22 = v.z;
                    break;
            }
        }
        /// <summary>
        /// Return the scale of the matrix.
        /// </summary>
        [XmlIgnore]
        public double3 Scale
        {
            get
            {
                double3 v;
                v.x = GetColumn(0).Magnitude;
                v.y = GetColumn(1).Magnitude;
                v.z = GetColumn(2).Magnitude;
                return v;
            }
        }
        /// <summary>
        /// Set a new scale for the matrix.
        /// </summary>
        /// <param name="scale"></param>
        public void SetScale(double3 scale)
        {
            SetColumn(0, GetColumn(0).Normalized * scale.x);
            SetColumn(1, GetColumn(1).Normalized * scale.y);
            SetColumn(2, GetColumn(2).Normalized * scale.z);
        }
        /// <summary>
        /// Return the matrix identity
        /// </summary>
        [XmlIgnore]
        public static double3x3 Identity
        {
            get
            {
                double3x3 rotMat;
                rotMat.rc00 = rotMat.rc11 = rotMat.rc22 = 1d;
                rotMat.rc10 = rotMat.rc20 = rotMat.rc01 = rotMat.rc21 = rotMat.rc02 = rotMat.rc12 = 0d;
                return rotMat;
            }
        }
        /// <summary>
        /// Return the matrix identity
        /// </summary>
        [XmlIgnore]
        public static double3x3 Zero
        {
            get
            {
                double3x3 rotMat;
                rotMat.rc00 = rotMat.rc11 = rotMat.rc22 = 0d;
                rotMat.rc10 = rotMat.rc20 = rotMat.rc01 = rotMat.rc21 = rotMat.rc02 = rotMat.rc12 = 0d;
                return rotMat;
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
                return rc00 * (rc11 * rc22 - rc12 * rc21) - rc01 * (rc10 * rc22 - rc12 * rc20) + rc02 * (rc10 * rc21 - rc11 * rc20);
            }
        }
        /// <summary>
        /// Return the transpose of the matrix's cofactor.
        /// </summary>
        [XmlIgnore]
        public double3x3 Adjugate
        {
            get
            {
                double2x2 a;
                double3x3 b;
                a.rc00 = rc11;
                a.rc01 = rc21;
                a.rc10 = rc12;
                a.rc11 = rc22;
                b.rc00 = a.Determinant;
                a.rc00 = rc01;
                a.rc01 = rc21;
                a.rc10 = rc02;
                a.rc11 = rc22;
                b.rc10 = -a.Determinant;
                a.rc00 = rc01;
                a.rc01 = rc11;
                a.rc10 = rc02;
                a.rc11 = rc12;
                b.rc20 = a.Determinant;
                a.rc00 = rc10;
                a.rc01 = rc20;
                a.rc10 = rc12;
                a.rc11 = rc22;
                b.rc01 = -a.Determinant;
                a.rc00 = rc00;
                a.rc01 = rc10;
                a.rc10 = rc02;
                a.rc11 = rc22;
                b.rc11 = a.Determinant;
                a.rc00 = rc00;
                a.rc01 = rc10;
                a.rc10 = rc02;
                a.rc11 = rc12;
                b.rc21 = -a.Determinant;
                a.rc00 = rc10;
                a.rc01 = rc20;
                a.rc10 = rc11;
                a.rc11 = rc21;
                b.rc02 = a.Determinant;
                a.rc00 = rc00;
                a.rc01 = rc20;
                a.rc10 = rc01;
                a.rc11 = rc21;
                b.rc12 = -a.Determinant;
                a.rc00 = rc00;
                a.rc01 = rc10;
                a.rc10 = rc01;
                a.rc11 = rc11;
                b.rc22 = a.Determinant;
                return b;
            }
        }
        /// <summary>
        /// Return the transpose of the matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        [XmlIgnore]
        public double3x3 Transpose
        {
            get
            {
                double3x3 t;
                t.rc00 = rc00;
                t.rc10 = rc01;
                t.rc20 = rc02;
                t.rc01 = rc10;
                t.rc11 = rc11;
                t.rc21 = rc12;
                t.rc02 = rc20;
                t.rc12 = rc21;
                t.rc22 = rc22;
                return t;
            }
        }
        /// <summary>
        /// Return the inverse of the matrix. If there's no inverse, then it will return null.
        /// </summary>
        [XmlIgnore]
        public double3x3? Inverse
        {
            get
            {
                double det = Determinant;
                if (det == 0d)
                {
                    return null;
                }
                det = 1d / det;
                return MinorMatrix.Cofactors.Transpose * det;
            }
        }
        /// <summary>
        /// Return the cofactors of the matrix.
        /// </summary>
        [XmlIgnore]
        public double3x3 Cofactors
        {
            get
            {
                double3x3 a;
                a.rc00 = rc00;
                a.rc10 = -rc10;
                a.rc20 = rc20;
                a.rc01 = -rc01;
                a.rc11 = rc11;
                a.rc21 = -rc21;
                a.rc02 = rc02;
                a.rc12 = -rc12;
                a.rc22 = rc22;
                return a;
            }
        }
        /// <summary>
        /// Return a 3x3 Matrix that does a translation, rotation and scaling for 2D point.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="rotation"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static double3x3 TRSMatrix(double2 position, double rotation, double2 scale)
        {
            double angleCos = System.Math.Cos(rotation);
            double angleSin = angleCos.SinFromCosTheta(rotation);
            double3x3 a;
            a.rc00 = angleCos * scale.x;
            a.rc10 = -angleSin * scale.x;
            a.rc11 = angleCos * scale.y;
            a.rc01 = angleSin * scale.y;
            a.rc22 = 1d;
            a.rc20 = position.x;
            a.rc21 = position.y;
            a.rc02 = a.rc12 = 0d;
            return a;
        }
        /// <summary>
        /// Return a 3x3 Matrix that does a rotation and scaling for 3D point.
        /// </summary>
        /// <param name="rotation"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static double3x3 RSMatrix(double3 rotation, double3 scale)
        {
            double sinX = System.Math.Sin(rotation.x);
            double cosX = sinX.CosFromSinTheta(rotation.x);
            double sinY = System.Math.Sin(rotation.y);
            double cosY = sinY.CosFromSinTheta(rotation.y);
            double sinZ = System.Math.Sin(rotation.z);
            double cosZ = sinZ.CosFromSinTheta(rotation.z);
            double3x3 a;
            a.rc00 = (cosY * cosZ) * scale.x;
            a.rc10 = (-cosY * sinZ) * scale.x;
            a.rc20 = sinY * scale.x;
            a.rc01 = (cosX * sinZ + sinX * sinY * cosZ) * scale.y;
            a.rc11 = (cosX * cosZ - sinX * sinY * sinZ) * scale.y;
            a.rc21 = (-sinX * cosY) * scale.y;
            a.rc02 = (sinX * sinZ - cosX * sinY * cosZ) * scale.z;
            a.rc12 = (sinX * cosZ + cosX * sinY * sinZ) * scale.z;
            a.rc22 = (cosX * cosY) * scale.z;
            return a;
        }
        /// <summary>
        /// Return a translation matrix.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double3x3 TranslationMatrix(double2 v)
        {
            double3x3 a;
            a.rc00 = 0d;
            a.rc10 = 0d;
            a.rc01 = 0d;
            a.rc11 = 0d;
            a.rc02 = 0d;
            a.rc12 = 0d;
            a.rc20 = v.x;
            a.rc21 = v.y;
            a.rc22 = 1d;
            return a;
        }
        /// <summary>
        /// Return a translation matrix.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double3x3 TranslationMatrix(double3 v)
        {
            double3x3 a;
            a.rc00 = 0d;
            a.rc10 = 0d;
            a.rc01 = 0d;
            a.rc11 = 0d;
            a.rc02 = 0d;
            a.rc12 = 0d;
            a.rc20 = v.x;
            a.rc21 = v.y;
            a.rc22 = v.z;
            return a;
        }
        /// <summary>
        /// Return an oblique matrix used for producing two-dimensional images of three-dimensional objects.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double3x3 ObliqueProjectionMatrix(double a)
        {
            double3x3 rotMat;
            rotMat.rc00 = 1d;
            rotMat.rc11 = 1d;
            rotMat.rc20 = System.Math.Cos(a);
            rotMat.rc21 = rotMat.rc20.SinFromCosTheta(a) * 0.5d;
            rotMat.rc20 *= 0.5d;
            rotMat.rc22 = rotMat.rc10 = rotMat.rc01 = rotMat.rc02 = rotMat.rc12 = 0d;
            return rotMat;
        }
        /// <summary>
        /// A scale matrix for 2D vector.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double3x3 ScaleMatrix(double2 v)
        {
            double3x3 rotMat;
            rotMat.rc00 = v.x;
            rotMat.rc11 = v.y;
            rotMat.rc22 = 1d;
            rotMat.rc10 = rotMat.rc20 = rotMat.rc01 = rotMat.rc21 = rotMat.rc02 = rotMat.rc12 = 0d;
            return rotMat;
        }
        /// <summary>
        /// A scale matrix for 3D vector.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double3x3 ScaleMatrix(double3 v)
        {
            double3x3 rotMat;
            rotMat.rc00 = v.x;
            rotMat.rc11 = v.y;
            rotMat.rc22 = v.z;
            rotMat.rc10 = rotMat.rc20 = rotMat.rc01 = rotMat.rc21 = rotMat.rc02 = rotMat.rc12 = 0d;
            return rotMat;
        }
        /// <summary>
        /// Return a rotation matrix that rotate a certain amount of degree on the x, y and z axis depending on the input.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrix(double x, double y, double z)
        {
            double sinX = System.Math.Sin(x);
            double cosX = sinX.CosFromSinTheta(x);
            double sinY = System.Math.Sin(y);
            double cosY = sinX.CosFromSinTheta(x);
            double sinZ = System.Math.Sin(z);
            double cosZ = sinZ.CosFromSinTheta(z);
            double3x3 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = -cosY * sinZ;
            a.rc20 = sinY;
            a.rc01 = cosX * sinZ + sinX * sinY * cosZ;
            a.rc11 = cosX * cosZ - sinX * sinY * sinZ;
            a.rc21 = -sinX * cosY;
            a.rc02 = sinX * sinZ - cosX * sinY * cosZ;
            a.rc12 = sinX * cosZ + cosX * sinY * sinZ;
            a.rc22 = cosX * cosY;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and y axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrixXY(double3 v)
        {
            double sinX = System.Math.Sin(v.x);
            double cosX = sinX.CosFromSinTheta(v.x);
            double sinY = System.Math.Sin(v.y);
            double cosY = sinY.CosFromSinTheta(v.y);
            double3x3 a;
            a.rc00 = cosY;
            a.rc10 = 0d;
            a.rc20 = sinY;
            a.rc01 = sinX * sinY;
            a.rc11 = cosX;
            a.rc21 = -sinX * cosY;
            a.rc02 = 0d - cosX * sinY;
            a.rc12 = sinX;
            a.rc22 = cosX * cosY;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrixXZ(double3 v)
        {
            double sinX = System.Math.Sin(v.x);
            double cosX = sinX.CosFromSinTheta(v.x);
            double sinZ = System.Math.Sin(v.z);
            double cosZ = sinZ.CosFromSinTheta(v.z);
            double3x3 a;
            a.rc00 = cosZ;
            a.rc10 = -sinZ;
            a.rc20 = 0d;
            a.rc01 = cosX * sinZ;
            a.rc11 = cosX * cosZ;
            a.rc21 = -sinX;
            a.rc02 = sinX * sinZ;
            a.rc12 = sinX * cosZ;
            a.rc22 = cosX;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrixYZ(double3 v)
        {
            double sinY = System.Math.Sin(v.y);
            double cosY = sinY.CosFromSinTheta(v.y);
            double sinZ = System.Math.Sin(v.z);
            double cosZ = sinZ.CosFromSinTheta(v.z);
            double3x3 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = -cosY * sinZ;
            a.rc20 = sinY;
            a.rc01 = sinZ;
            a.rc11 = cosZ;
            a.rc21 = 0d;
            a.rc02 = 0d - sinY * cosZ;
            a.rc12 = sinY * sinZ;
            a.rc22 = cosY;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and y axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrixXY(double2 v)
        {
            double sinX = System.Math.Sin(v.x);
            double cosX = sinX.CosFromSinTheta(v.x);
            double sinY = System.Math.Sin(v.y);
            double cosY = sinY.CosFromSinTheta(v.y);
            double3x3 a;
            a.rc00 = cosY;
            a.rc10 = 0d;
            a.rc20 = sinY;
            a.rc01 = sinX * sinY;
            a.rc11 = cosX;
            a.rc21 = -sinX * cosY;
            a.rc02 = 0d - cosX * sinY;
            a.rc12 = sinX;
            a.rc22 = cosX * cosY;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrixXZ(double2 v)
        {
            double sinX = System.Math.Sin(v.x);
            double cosX = sinX.CosFromSinTheta(v.x);
            double sinZ = System.Math.Sin(v.y);
            double cosZ = sinZ.CosFromSinTheta(v.y);
            double3x3 a;
            a.rc00 = cosZ;
            a.rc10 = -sinZ;
            a.rc20 = 0d;
            a.rc01 = cosX * sinZ;
            a.rc11 = cosX * cosZ;
            a.rc21 = -sinX;
            a.rc02 = sinX * sinZ;
            a.rc12 = sinX * cosZ;
            a.rc22 = cosX;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrixYZ(double2 v)
        {
            double sinY = System.Math.Sin(v.x);
            double cosY = sinY.CosFromSinTheta(v.x);
            double sinZ = System.Math.Sin(v.y);
            double cosZ = sinZ.CosFromSinTheta(v.y);
            double3x3 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = -cosY * sinZ;
            a.rc20 = sinY;
            a.rc01 = sinZ;
            a.rc11 = cosZ;
            a.rc21 = 0d;
            a.rc02 = 0d - sinY * cosZ;
            a.rc12 = sinY * sinZ;
            a.rc22 = cosY;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix that rotate a certain amount of degree on the x, y and z axis depending on the input.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrix(double3 v)
        {
            double sinX = System.Math.Sin(v.x);
            double cosX = sinX.CosFromSinTheta(v.x);
            double sinY = System.Math.Sin(v.y);
            double cosY = sinY.CosFromSinTheta(v.y);
            double sinZ = System.Math.Sin(v.z);
            double cosZ = sinZ.CosFromSinTheta(v.z);
            double3x3 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = -cosY * sinZ;
            a.rc20 = sinY;
            a.rc01 = cosX * sinZ + sinX * sinY * cosZ;
            a.rc11 = cosX * cosZ - sinX * sinY * sinZ;
            a.rc21 = -sinX * cosY;
            a.rc02 = sinX * sinZ - cosX * sinY * cosZ;
            a.rc12 = sinX * cosZ + cosX * sinY * sinZ;
            a.rc22 = cosX * cosY;
            return a;
        }
        /// <summary>
        /// Rotation matric for angle X.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrixX(double angle)
        {
            double angleCos = System.Math.Cos(angle);
            double angleSin = angleCos.SinFromCosTheta(angle);
            double3x3 a;
            a.rc00 = 1d;
            a.rc11 = a.rc22 = angleCos;
            a.rc12 = angleSin;
            a.rc21 = -angleSin;
            a.rc10 = a.rc20 = a.rc01 = a.rc02 = 0d;
            return a;
        }
        /// <summary>
        /// Rotation matric for angle Y.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrixY(double angle)
        {
            double angleCos = System.Math.Cos(angle);
            double angleSin = angleCos.SinFromCosTheta(angle);
            double3x3 a;
            a.rc10 = a.rc01 = a.rc21 = a.rc12 = 0d;
            a.rc11 = 1d;
            a.rc00 = a.rc22 = angleCos;
            a.rc20 = angleSin;
            a.rc02 = -angleSin;
            return a;
        }
        /// <summary>
        /// Rotation matric for angle Z.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrixZ(double angle)
        {
            double angleCos = System.Math.Cos(angle);
            double angleSin = angleCos.SinFromCosTheta(angle);
            double3x3 a;
            a.rc00 = a.rc11 = angleCos;
            a.rc01 = angleSin;
            a.rc10 = -angleSin;
            a.rc22 = 1d;
            a.rc20 = a.rc21 = a.rc02 = a.rc12 = 0d;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix that will rotate around an axis by a certain angle.
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrixAxis(double3 axis, double angle)
        {
            double angleCos = System.Math.Cos(angle);
            double angleSin = angleCos.SinFromCosTheta(angle);
            double3x3 a;
            a.rc00 = (axis.x * axis.x) * (1d - angleCos) + angleCos;
            a.rc10 = axis.x * axis.y * (1d - angleCos) - axis.z * angleSin;
            a.rc20 = axis.x * axis.z * (1d - angleCos) + axis.y * angleSin;
            a.rc01 = axis.x * axis.y * (1d - angleCos) + axis.z * angleSin;
            a.rc11 = (axis.y * axis.y) * (1d - angleCos) + angleCos;
            a.rc21 = axis.y * axis.z * (1d - angleCos) - axis.x * angleSin;
            a.rc02 = axis.x * axis.z * (1d - angleCos) - axis.y * angleSin;
            a.rc12 = axis.y * axis.z * (1d - angleCos) + axis.x * angleSin;
            a.rc22 = (axis.z * axis.z) * (1d - angleCos) + angleCos;
            return a;
        }
        /// <summary>
        /// Return the determinant of some smaller square matrix, cut down from A by removing one or more of its rows and columns.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public double Minor(int row, int column)
        {
            switch (row)
            {
                case 1:
                    switch (column)
                    {
                        case 1:
                            return rc00 * rc22 - rc20 * rc02;
                        case 2:
                            return rc00 * rc12 - rc10 * rc02;
                        default:
                            return rc10 * rc22 - rc20 * rc12;
                    }
                case 2:
                    switch (column)
                    {
                        case 1:
                            return rc00 * rc21 - rc20 * rc01;
                        case 2:
                            return rc00 * rc11 - rc10 * rc01;
                        default:
                            return rc10 * rc21 - rc20 * rc11;
                    }
                default:
                    switch (column)
                    {
                        case 1:
                            return rc01 * rc22 - rc21 * rc02;
                        case 2:
                            return rc01 * rc12 - rc11 * rc02;
                        default:
                            return rc11 * rc21 - rc12 * rc22;
                    }
            }
        }
        /// <summary>
        /// Return the determinant of some smaller square matrix, cut down from A by removing one or more of its rows and columns.
        /// </summary>
        [XmlIgnore]
        public double3x3 MinorMatrix
        {
            get
            {
                double3x3 a;
                a.rc00 = rc11 * rc21 - rc12 * rc22;
                a.rc10 = rc01 * rc22 - rc21 * rc02;
                a.rc20 = rc01 * rc12 - rc11 * rc02;
                a.rc01 = rc10 * rc22 - rc20 * rc12;
                a.rc11 = rc00 * rc22 - rc20 * rc02;
                a.rc21 = rc00 * rc12 - rc10 * rc02;
                a.rc02 = rc10 * rc21 - rc20 * rc11;
                a.rc12 = rc00 * rc21 - rc20 * rc01;
                a.rc22 = rc00 * rc11 - rc10 * rc01;
                return a;
            }
        }
        /// <summary>
        /// Return the matric square by itself.
        /// </summary>
        [XmlIgnore]
        public double3x3 Square
        {
            get
            {
                double3x3 c;
                c.rc00 = rc00 * rc00 + rc10 * rc01 + rc20 * rc02;
                c.rc10 = rc00 * rc10 + rc10 * rc11 + rc20 * rc12;
                c.rc20 = rc00 * rc20 + rc10 * rc21 + rc20 * rc22;
                c.rc01 = rc01 * rc00 + rc11 * rc01 + rc21 * rc02;
                c.rc11 = rc01 * rc10 + rc11 * rc11 + rc21 * rc12;
                c.rc21 = rc01 * rc20 + rc11 * rc21 + rc21 * rc22;
                c.rc02 = rc02 * rc00 + rc12 * rc01 + rc22 * rc02;
                c.rc12 = rc02 * rc10 + rc12 * rc11 + rc22 * rc12;
                c.rc22 = rc02 * rc20 + rc12 * rc21 + rc22 * rc22;
                return c;
            }
        }
        /// <summary>
        /// Use this for double2 homogeneous coordinates. It multiply the double2 by the matrix and then, divide the coordinates by the z.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public double2 Mul(double2 a)
        {
            double2 vec;
            vec.x = rc00 * a.x + rc10 * a.y + rc20;
            vec.y = rc01 * a.x + rc11 * a.y + rc21;
            return vec / (rc02 + rc12 + rc22);
        }
        /// <summary>
        /// Lineary interpolate between two matrix.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double3x3 Lerp(double3x3 m1, double3x3 m2, double t)
        {
            t = t > 1d ? 1d : t < 0d ? 0d : t;
            m1.rc00 = m1.rc00 + (m2.rc00 - m1.rc00) * t;
            m1.rc10 = m1.rc10 + (m2.rc10 - m1.rc10) * t;
            m1.rc20 = m1.rc20 + (m2.rc20 - m1.rc20) * t;
            m1.rc01 = m1.rc01 + (m2.rc01 - m1.rc01) * t;
            m1.rc11 = m1.rc11 + (m2.rc11 - m1.rc11) * t;
            m1.rc21 = m1.rc21 + (m2.rc21 - m1.rc21) * t;
            m1.rc02 = m1.rc02 + (m2.rc02 - m1.rc02) * t;
            m1.rc12 = m1.rc12 + (m2.rc12 - m1.rc12) * t;
            m1.rc22 = m1.rc22 + (m2.rc22 - m1.rc22) * t;
            return m1;
        }
        /// <summary>
        /// Lineary interpolate between two matrix.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static double3x3 LerpUnclamped(double3x3 m1, double3x3 m2, double t)
        {
            m1.rc00 = m1.rc00 + (m2.rc00 - m1.rc00) * t;
            m1.rc10 = m1.rc10 + (m2.rc10 - m1.rc10) * t;
            m1.rc20 = m1.rc20 + (m2.rc20 - m1.rc20) * t;
            m1.rc01 = m1.rc01 + (m2.rc01 - m1.rc01) * t;
            m1.rc11 = m1.rc11 + (m2.rc11 - m1.rc11) * t;
            m1.rc21 = m1.rc21 + (m2.rc21 - m1.rc21) * t;
            m1.rc02 = m1.rc02 + (m2.rc02 - m1.rc02) * t;
            m1.rc12 = m1.rc12 + (m2.rc12 - m1.rc12) * t;
            m1.rc22 = m1.rc22 + (m2.rc22 - m1.rc22) * t;
            return m1;
        }
        /// <summary>
        /// Return a rotation matrix that rotate a certain amount of degree on the x, y and z axis depending on the Quaternion.
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public static double3x3 RotationMatrix(dQuaternion q)
        {
            double xx = q.x * q.x * 2.0d;
            double yy = q.y * q.y * 2.0d;
            double zz = q.z * q.z * 2.0d;
            double xy = q.x * q.y * 2.0d;
            double xz = q.x * q.z * 2.0d;
            double yz = q.y * q.z * 2.0d;
            double wx = q.w * q.x * 2.0d;
            double wy = q.w * q.y * 2.0d;
            double wz = q.w * q.z * 2.0d;
            double3x3 m;
            m.rc00 = 1.0d - (yy + zz);
            m.rc10 = xy + wz;
            m.rc20 = xz - wy;
            m.rc01 = xy - wz;
            m.rc11 = 1.0d - (xx + zz);
            m.rc21 = yz + wx;
            m.rc02 = xz + wy;
            m.rc12 = yz - wx;
            m.rc22 = 1.0d - (xx + yy);
            return m;
        }
        /// <summary>
        /// Return a rotation matrix that rotate and resize.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static double3x3 RSMatrix(dQuaternion q, double3 size)
        {
            double xx = q.x * q.x * 2.0d;
            double yy = q.y * q.y * 2.0d;
            double zz = q.z * q.z * 2.0d;
            double xy = q.x * q.y * 2.0d;
            double xz = q.x * q.z * 2.0d;
            double yz = q.y * q.z * 2.0d;
            double wx = q.w * q.x * 2.0d;
            double wy = q.w * q.y * 2.0d;
            double wz = q.w * q.z * 2.0d;
            double3x3 m;
            m.rc00 = (1.0d - (yy + zz)) * size.x;
            m.rc10 = (xy + wz) * size.x;
            m.rc20 = (xz - wy) * size.x;
            m.rc01 = (xy - wz) * size.y;
            m.rc11 = (1.0d - (xx + zz)) * size.y;
            m.rc21 = (yz + wx) * size.y;
            m.rc02 = (xz + wy) * size.z;
            m.rc12 = (yz - wx) * size.z;
            m.rc22 = (1.0d - (xx + yy)) * size.z;
            return m;
        }
        /// <summary>
        /// Return the actual rotation of the matrix.
        /// </summary>
        [XmlIgnore]
        public dQuaternion GetRotation
        {
            get
            {
                double3 s = Scale;
                double m00 = rc00 / s.x;
                double m11 = rc11 / s.y;
                double m22 = rc22 / s.z;
                dQuaternion q = new dQuaternion
                {
                    w = Math.Sqrt(Math.Max(0d, 1d + m00 + m11 + m22)) * 0.5d,
                    x = Math.Sqrt(Math.Max(0d, 1d + m00 - m11 - m22)) * 0.5d,
                    y = Math.Sqrt(Math.Max(0d, 1d - m00 + m11 - m22)) * 0.5d,
                    z = Math.Sqrt(Math.Max(0d, 1d - m00 - m11 + m22)) * 0.5d
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
        public static double3x3 operator *(double3x3 a, double3x3 b)
        {
            double3x3 c;
            c.rc00 = a.rc00 * b.rc00 + a.rc10 * b.rc01 + a.rc20 * b.rc02;
            c.rc10 = a.rc00 * b.rc10 + a.rc10 * b.rc11 + a.rc20 * b.rc12;
            c.rc20 = a.rc00 * b.rc20 + a.rc10 * b.rc21 + a.rc20 * b.rc22;
            c.rc01 = a.rc01 * b.rc00 + a.rc11 * b.rc01 + a.rc21 * b.rc02;
            c.rc11 = a.rc01 * b.rc10 + a.rc11 * b.rc11 + a.rc21 * b.rc12;
            c.rc21 = a.rc01 * b.rc20 + a.rc11 * b.rc21 + a.rc21 * b.rc22;
            c.rc02 = a.rc02 * b.rc00 + a.rc12 * b.rc01 + a.rc22 * b.rc02;
            c.rc12 = a.rc02 * b.rc10 + a.rc12 * b.rc11 + a.rc22 * b.rc12;
            c.rc22 = a.rc02 * b.rc20 + a.rc12 * b.rc21 + a.rc22 * b.rc22;
            return c;
        }
        public static double3x3? operator /(double3x3 a, double3x3 b)
        {
            double3x3? inv = b.Inverse;
            if (inv != null)
            {
                return a * (double3x3)inv;
            }
            return null;
        }
        public static double3x3 operator +(double3x3 a, double3x3 b)
        {
            a.rc00 = a.rc00 + b.rc00;
            a.rc10 = a.rc10 + b.rc10;
            a.rc20 = a.rc20 + b.rc20;
            a.rc01 = a.rc01 + b.rc01;
            a.rc11 = a.rc11 + b.rc11;
            a.rc21 = a.rc21 + b.rc21;
            a.rc02 = a.rc02 + b.rc02;
            a.rc12 = a.rc12 + b.rc12;
            a.rc22 = a.rc22 + b.rc22;
            return a;
        }
        public static double3x3 operator -(double3x3 a, double3x3 b)
        {
            a.rc00 = a.rc00 - b.rc00;
            a.rc10 = a.rc10 - b.rc10;
            a.rc20 = a.rc20 - b.rc20;
            a.rc01 = a.rc01 - b.rc01;
            a.rc11 = a.rc11 - b.rc11;
            a.rc21 = a.rc21 - b.rc21;
            a.rc02 = a.rc02 - b.rc02;
            a.rc12 = a.rc12 - b.rc12;
            a.rc22 = a.rc22 - b.rc22;
            return a;
        }
        public static double3x3 operator *(double3x3 a, double b)
        {
            a.rc00 = a.rc00 * b;
            a.rc10 = a.rc10 * b;
            a.rc20 = a.rc20 * b;
            a.rc01 = a.rc01 * b;
            a.rc11 = a.rc11 * b;
            a.rc21 = a.rc21 * b;
            a.rc02 = a.rc02 * b;
            a.rc12 = a.rc12 * b;
            a.rc22 = a.rc22 * b;
            return a;
        }
        public static double3x3 operator *(double a, double3x3 b)
        {
            b.rc00 = a * b.rc00;
            b.rc10 = a * b.rc10;
            b.rc20 = a * b.rc20;
            b.rc01 = a * b.rc01;
            b.rc11 = a * b.rc11;
            b.rc21 = a * b.rc21;
            b.rc02 = a * b.rc02;
            b.rc12 = a * b.rc12;
            b.rc22 = a * b.rc22;
            return b;
        }
        public static double2 operator *(double3x3 a, double2 b)
        {
            double2 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12;
            return vec;
        }
        public static double2 operator *(double2 b, double3x3 a)
        {
            double2 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12;
            return vec;
        }
        public static double3 operator *(double3x3 a, double3 b)
        {
            double3 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02 * b.z;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12 * b.z;
            vec.z = a.rc20 * b.x + a.rc21 * b.y + a.rc22 * b.z;
            return vec;
        }
        public static double3 operator *(double3 b, double3x3 a)
        {
            double3 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02 * b.z;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12 * b.z;
            vec.z = a.rc20 * b.x + a.rc21 * b.y + a.rc22 * b.z;
            return vec;
        }
        public static double3x3 operator -(double3x3 a)
        {
            a.rc00 = -a.rc00;
            a.rc10 = -a.rc10;
            a.rc20 = -a.rc20;
            a.rc01 = -a.rc01;
            a.rc11 = -a.rc11;
            a.rc21 = -a.rc21;
            a.rc02 = -a.rc02;
            a.rc12 = -a.rc12;
            a.rc22 = -a.rc22;
            return a;
        }
        public static implicit operator double2x2(double3x3 a)
        {
            double2x2 b;
            b.rc00 = a.rc00;
            b.rc01 = a.rc10;
            b.rc10 = a.rc01;
            b.rc11 = a.rc11;
            return a;
        }
    }
}
