using System;
using System.Xml.Serialization;
using IkiCore.Core;
namespace IkiCore.Mathematics
{
    [Serializable]
    public partial struct float3x3
    {
        /// <summary>
        /// Cell located at row 0, column 0.
        /// </summary>
        public float rc00;
        /// <summary>
        /// Cell located at row 1, column 0.
        /// </summary>
        public float rc10;
        /// <summary>
        /// Cell located at row 2, column 0.
        /// </summary>
        public float rc20;
        /// <summary>
        /// Cell located at row 0, column 1.
        /// </summary>
        public float rc01;
        /// <summary>
        /// Cell located at row 1, column 1.
        /// </summary>
        public float rc11;
        /// <summary>
        /// Cell located at row 2, column 1.
        /// </summary>
        public float rc21;
        /// <summary>
        /// Cell located at row 0, column 2.
        /// </summary>
        public float rc02;
        /// <summary>
        /// Cell located at row 1, column 2.
        /// </summary>
        public float rc12;
        /// <summary>
        /// Cell located at row 2, column 2.
        /// </summary>
        public float rc22;
        /// <summary>
        /// Access element at row and column index.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        [XmlIgnore]
        public float this[int row, int column]
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
        public float3 GetRow(int i)
        {
            float3 a;
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
        public void SetRow(int i, float3 v)
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
        public float3 GetColumn(int i)
        {
            float3 a;
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
        public void SetColumn(int i, float3 v)
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
        public float3 Scale
        {
            get
            {
                float3 v;
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
        public void SetScale(float3 scale)
        {
            SetColumn(0, GetColumn(0).Normalized * scale.x);
            SetColumn(1, GetColumn(1).Normalized * scale.y);
            SetColumn(2, GetColumn(2).Normalized * scale.z);
        }
        /// <summary>
        /// Return the matrix identity
        /// </summary>
        [XmlIgnore]
        public static float3x3 Identity
        {
            get
            {
                float3x3 rotMat;
                rotMat.rc00 = rotMat.rc11 = rotMat.rc22 = 1f;
                rotMat.rc10 = rotMat.rc20 = rotMat.rc01 = rotMat.rc21 = rotMat.rc02 = rotMat.rc12 = 0f;
                return rotMat;
            }
        }
        /// <summary>
        /// Return the matrix identity
        /// </summary>
        [XmlIgnore]
        public static float3x3 Zero
        {
            get
            {
                float3x3 rotMat;
                rotMat.rc00 = rotMat.rc11 = rotMat.rc22 = 0f;
                rotMat.rc10 = rotMat.rc20 = rotMat.rc01 = rotMat.rc21 = rotMat.rc02 = rotMat.rc12 = 0f;
                return rotMat;
            }
        }
        /// <summary>
        /// Return the determinant of the matrix
        /// </summary>
        [XmlIgnore]
        public float Determinant
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
        public float3x3 Adjugate
        {
            get
            {
                float2x2 a;
                float3x3 b;
                a.rc00 = rc11;
                a.rc10 = rc21;
                a.rc01 = rc12;
                a.rc11 = rc22;
                b.rc00 = a.Determinant;
                a.rc00 = rc01;
                a.rc10 = rc21;
                a.rc01 = rc02;
                a.rc11 = rc22;
                b.rc10 = -a.Determinant;
                a.rc00 = rc01;
                a.rc10 = rc11;
                a.rc01 = rc02;
                a.rc11 = rc12;
                b.rc20 = a.Determinant;
                a.rc00 = rc10;
                a.rc10 = rc20;
                a.rc01 = rc12;
                a.rc11 = rc22;
                b.rc01 = -a.Determinant;
                a.rc00 = rc00;
                a.rc10 = rc10;
                a.rc01 = rc02;
                a.rc11 = rc22;
                b.rc11 = a.Determinant;
                a.rc00 = rc00;
                a.rc10 = rc10;
                a.rc01 = rc02;
                a.rc11 = rc12;
                b.rc21 = -a.Determinant;
                a.rc00 = rc10;
                a.rc10 = rc20;
                a.rc01 = rc11;
                a.rc11 = rc21;
                b.rc02 = a.Determinant;
                a.rc00 = rc00;
                a.rc10 = rc20;
                a.rc01 = rc01;
                a.rc11 = rc21;
                b.rc12 = -a.Determinant;
                a.rc00 = rc00;
                a.rc10 = rc10;
                a.rc01 = rc01;
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
        public float3x3 Transpose
        {
            get
            {
                float3x3 t;
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
        public float3x3? Inverse
        {
            get
            {
                float det = Determinant;
                if (det == 0f)
                {
                    return null;
                }
                det = 1f / det;
                return MinorMatrix.Cofactors.Transpose * det;
            }
        }
        /// <summary>
        /// Return the cofactors of the matrix.
        /// </summary>
        [XmlIgnore]
        public float3x3 Cofactors
        {
            get
            {
                float3x3 a;
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
        public static float3x3 TRSMatrix(float2 position, float rotation, float2 scale)
        {
            float angleCos = (float)System.Math.Cos(rotation);
            float angleSin = (float)System.Math.Sin(rotation);
            float3x3 a;
            a.rc00 = angleCos * scale.x;
            a.rc10 = -angleSin * scale.x;
            a.rc01 = angleSin * scale.y;
            a.rc11 = angleCos * scale.y;
            a.rc22 = 1f;
            a.rc20 = position.x;
            a.rc21 = position.y;
            a.rc02 = a.rc12 = 0f;
            return a;
        }
        /// <summary>
        /// Return a 3x3 Matrix that does a rotation and scaling for 3D point.
        /// </summary>
        /// <param name="rotation"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static float3x3 RSMatrix(float3 rotation, float3 scale)
        {
            float sinX = (float)System.Math.Sin(rotation.x);
            float cosX = (float)System.Math.Cos(rotation.x);
            float sinY = (float)System.Math.Sin(rotation.y);
            float cosY = (float)System.Math.Cos(rotation.y);
            float sinZ = (float)System.Math.Sin(rotation.z);
            float cosZ = (float)System.Math.Cos(rotation.z);
            float3x3 a;
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
        public static float3x3 TranslationMatrix(float2 v)
        {
            float3x3 a;
            a.rc00 = 0f;
            a.rc10 = 0f;
            a.rc01 = 0f;
            a.rc11 = 0f;
            a.rc02 = 0f;
            a.rc12 = 0f;
            a.rc20 = v.x;
            a.rc21 = v.y;
            a.rc22 = 1f;
            return a;
        }
        /// <summary>
        /// Return a translation matrix.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static float3x3 TranslationMatrix(float3 v)
        {
            float3x3 a;
            a.rc00 = 0f;
            a.rc10 = 0f;
            a.rc01 = 0f;
            a.rc11 = 0f;
            a.rc02 = 0f;
            a.rc12 = 0f;
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
        public static float3x3 ObliqueProjectionMatrix(float a)
        {
            float3x3 rotMat;
            rotMat.rc00 = 1f;
            rotMat.rc11 = 1f;
            rotMat.rc20 = 0.5f * (float)System.Math.Cos(a);
            rotMat.rc21 = 0.5f * (float)System.Math.Sin(a);
            rotMat.rc22 = rotMat.rc10 = rotMat.rc01 = rotMat.rc02 = rotMat.rc12 = 0f;
            return rotMat;
        }
        /// <summary>
        /// A scale matrix for 2D vector.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static float3x3 ScaleMatrix(float2 v)
        {
            float3x3 rotMat;
            rotMat.rc00 = v.x;
            rotMat.rc11 = v.y;
            rotMat.rc22 = 1f;
            rotMat.rc10 = rotMat.rc20 = rotMat.rc01 = rotMat.rc21 = rotMat.rc02 = rotMat.rc12 = 0f;
            return rotMat;
        }
        /// <summary>
        /// A scale matrix for 3D vector.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static float3x3 ScaleMatrix(float3 v)
        {
            float3x3 rotMat;
            rotMat.rc00 = v.x;
            rotMat.rc11 = v.y;
            rotMat.rc22 = v.z;
            rotMat.rc10 = rotMat.rc20 = rotMat.rc01 = rotMat.rc21 = rotMat.rc02 = rotMat.rc12 = 0f;
            return rotMat;
        }
        /// <summary>
        /// Return a rotation matrix that rotate a certain amount of degree on the x, y and z axis depending on the input.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static float3x3 RotationMatrix(float x, float y, float z)
        {
            float sinX = (float)System.Math.Sin(x);
            float cosX = (float)System.Math.Cos(x);
            float sinY = (float)System.Math.Sin(y);
            float cosY = (float)System.Math.Cos(y);
            float sinZ = (float)System.Math.Sin(z);
            float cosZ = (float)System.Math.Cos(z);
            float3x3 a;
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
        public static float3x3 RotationMatrixXY(float3 v)
        {
            float sinX = (float)System.Math.Sin(v.x);
            float cosX = (float)System.Math.Cos(v.x);
            float sinY = (float)System.Math.Sin(v.y);
            float cosY = (float)System.Math.Cos(v.y);
            float3x3 a;
            a.rc00 = cosY;
            a.rc10 = 0f;
            a.rc20 = sinY;
            a.rc01 = sinX * sinY;
            a.rc11 = cosX;
            a.rc21 = -sinX * cosY;
            a.rc02 = 0f - cosX * sinY;
            a.rc12 = sinX;
            a.rc22 = cosX * cosY;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static float3x3 RotationMatrixXZ(float3 v)
        {
            float sinX = (float)System.Math.Sin(v.x);
            float cosX = (float)System.Math.Cos(v.x);
            float sinZ = (float)System.Math.Sin(v.z);
            float cosZ = (float)System.Math.Cos(v.z);
            float3x3 a;
            a.rc00 = cosZ;
            a.rc10 = -sinZ;
            a.rc20 = 0f;
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
        public static float3x3 RotationMatrixYZ(float3 v)
        {
            float sinY = (float)System.Math.Sin(v.y);
            float cosY = (float)System.Math.Cos(v.y);
            float sinZ = (float)System.Math.Sin(v.z);
            float cosZ = (float)System.Math.Cos(v.z);
            float3x3 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = -cosY * sinZ;
            a.rc20 = sinY;
            a.rc01 = sinZ;
            a.rc11 = cosZ;
            a.rc21 = 0f;
            a.rc02 = 0f - sinY * cosZ;
            a.rc12 = sinY * sinZ;
            a.rc22 = cosY;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and y axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static float3x3 RotationMatrixXY(float2 v)
        {
            float sinX = (float)System.Math.Sin(v.x);
            float cosX = (float)System.Math.Cos(v.x);
            float sinY = (float)System.Math.Sin(v.y);
            float cosY = (float)System.Math.Cos(v.y);
            float3x3 a;
            a.rc00 = cosY;
            a.rc10 = 0f;
            a.rc20 = sinY;
            a.rc01 = sinX * sinY;
            a.rc11 = cosX;
            a.rc21 = -sinX * cosY;
            a.rc02 = 0f - cosX * sinY;
            a.rc12 = sinX;
            a.rc22 = cosX * cosY;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix on the x and z axis.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static float3x3 RotationMatrixXZ(float2 v)
        {
            float sinX = (float)System.Math.Sin(v.x);
            float cosX = (float)System.Math.Cos(v.x);
            float sinZ = (float)System.Math.Sin(v.y);
            float cosZ = (float)System.Math.Cos(v.y);
            float3x3 a;
            a.rc00 = cosZ;
            a.rc10 = -sinZ;
            a.rc20 = 0f;
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
        public static float3x3 RotationMatrixYZ(float2 v)
        {
            float sinY = (float)System.Math.Sin(v.x);
            float cosY = (float)System.Math.Cos(v.x);
            float sinZ = (float)System.Math.Sin(v.y);
            float cosZ = (float)System.Math.Cos(v.y);
            float3x3 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = -cosY * sinZ;
            a.rc20 = sinY;
            a.rc01 = sinZ;
            a.rc11 = cosZ;
            a.rc21 = 0f;
            a.rc02 = 0f - sinY * cosZ;
            a.rc12 = sinY * sinZ;
            a.rc22 = cosY;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix that rotate a certain amount of degree on the x, y and z axis depending on the input (in that specific order).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static float3x3 RotationMatrix(float3 v)
        {
            float sinX = (float)System.Math.Sin(v.x);
            float cosX = (float)System.Math.Cos(v.x);
            float sinY = (float)System.Math.Sin(v.y);
            float cosY = (float)System.Math.Cos(v.y);
            float sinZ = (float)System.Math.Sin(v.z);
            float cosZ = (float)System.Math.Cos(v.z);
            float3x3 a;
            a.rc00 = cosY * cosZ;
            a.rc10 = cosY * sinZ;
            a.rc20 = -sinY;
            a.rc01 = sinX * sinY * cosZ - cosX * sinZ;
            a.rc11 = cosX * cosZ + sinX * sinY * sinZ;
            a.rc21 = sinX * cosY;
            a.rc02 = sinX * sinZ + cosX * sinY * cosZ;
            a.rc12 = cosX * sinY * sinZ - sinX * cosZ;
            a.rc22 = cosX * cosY;
            return a;
        }
        /// <summary>
        /// Rotation matric for angle X.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static float3x3 RotationMatrixX(float angle)
        {
            float angleCos = (float)System.Math.Cos(angle);
            float angleSin = (float)System.Math.Sin(angle);
            float3x3 a;
            a.rc00 = 1f;
            a.rc11 = a.rc22 = angleCos;
            a.rc12 = angleSin;
            a.rc21 = -angleSin;
            a.rc10 = a.rc20 = a.rc01 = a.rc02 = 0f;
            return a;
        }
        /// <summary>
        /// Rotation matric for angle Y.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static float3x3 RotationMatrixY(float angle)
        {
            float angleCos = (float)System.Math.Cos(angle);
            float angleSin = (float)System.Math.Sin(angle);
            float3x3 a;
            a.rc10 = a.rc01 = a.rc21 = a.rc12 = 0f;
            a.rc11 = 1f;
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
        public static float3x3 RotationMatrixZ(float angle)
        {
            float angleCos = (float)System.Math.Cos(angle);
            float angleSin = (float)System.Math.Sin(angle);
            float3x3 a;
            a.rc00 = a.rc11 = angleCos;
            a.rc01 = angleSin;
            a.rc10 = -angleSin;
            a.rc22 = 1f;
            a.rc20 = a.rc21 = a.rc02 = a.rc12 = 0f;
            return a;
        }
        /// <summary>
        /// Return a rotation matrix that will rotate around an axis by a certain angle.
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static float3x3 RotationMatrixAxis(float3 axis, float angle)
        {
            float angleCos = (float)System.Math.Cos(angle);
            float angleSin = (float)System.Math.Sin(angle);
            float3x3 a;
            a.rc00 = (axis.x * axis.x) * (1f - angleCos) + angleCos;
            a.rc10 = axis.x * axis.y * (1f - angleCos) - axis.z * angleSin;
            a.rc20 = axis.x * axis.z * (1f - angleCos) + axis.y * angleSin;
            a.rc01 = axis.x * axis.y * (1f - angleCos) + axis.z * angleSin;
            a.rc11 = (axis.y * axis.y) * (1f - angleCos) + angleCos;
            a.rc21 = axis.y * axis.z * (1f - angleCos) - axis.x * angleSin;
            a.rc02 = axis.x * axis.z * (1f - angleCos) - axis.y * angleSin;
            a.rc12 = axis.y * axis.z * (1f - angleCos) + axis.x * angleSin;
            a.rc22 = (axis.z * axis.z) * (1f - angleCos) + angleCos;
            return a;
        }
        /// <summary>
        /// Return the determinant of some smaller square matrix, cut down from A by removing one or more of its rows and columns.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public float Minor(int row, int column)
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
        public float3x3 MinorMatrix
        {
            get
            {
                float3x3 a;
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
        public float3x3 Square
        {
            get
            {
                float3x3 c;
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
        /// Use this for float2 homogeneous coordinates. It multiply the float2 by the matrix and then, divide the coordinates by the z.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public float2 Mul(float2 a)
        {
            float2 vec;
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
        public static float3x3 Lerp(float3x3 m1, float3x3 m2, float t)
        {
            t = t > 1f ? 1f : t < 0f ? 0f : t;
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
        public static float3x3 LerpUnclamped(float3x3 m1, float3x3 m2, float t)
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
        public static float3x3 RotationMatrix(fQuaternion q)
        {
            float xx = q.x * q.x * 2.0f;
            float yy = q.y * q.y * 2.0f;
            float zz = q.z * q.z * 2.0f;
            float xy = q.x * q.y * 2.0f;
            float xz = q.x * q.z * 2.0f;
            float yz = q.y * q.z * 2.0f;
            float wx = q.w * q.x * 2.0f;
            float wy = q.w * q.y * 2.0f;
            float wz = q.w * q.z * 2.0f;
            float3x3 m;
            m.rc00 = 1.0f - (yy + zz);
            m.rc10 = xy + wz;
            m.rc20 = xz - wy;
            m.rc01 = xy - wz;
            m.rc11 = 1.0f - (xx + zz);
            m.rc21 = yz + wx;
            m.rc02 = xz + wy;
            m.rc12 = yz - wx;
            m.rc22 = 1.0f - (xx + yy);
            return m;
        }
        /// <summary>
        /// Return a rotation matrix that rotate and resize.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static float3x3 RSMatrix(fQuaternion q, float3 size)
        {
            float xx = q.x * q.x * 2.0f;
            float yy = q.y * q.y * 2.0f;
            float zz = q.z * q.z * 2.0f;
            float xy = q.x * q.y * 2.0f;
            float xz = q.x * q.z * 2.0f;
            float yz = q.y * q.z * 2.0f;
            float wx = q.w * q.x * 2.0f;
            float wy = q.w * q.y * 2.0f;
            float wz = q.w * q.z * 2.0f;
            float3x3 m;
            m.rc00 = (1.0f - (yy + zz)) * size.x;
            m.rc10 = (xy + wz) * size.x;
            m.rc20 = (xz - wy) * size.x;
            m.rc01 = (xy - wz) * size.y;
            m.rc11 = (1.0f - (xx + zz)) * size.y;
            m.rc21 = (yz + wx) * size.y;
            m.rc02 = (xz + wy) * size.z;
            m.rc12 = (yz - wx) * size.z;
            m.rc22 = (1.0f - (xx + yy)) * size.z;
            return m;
        }
        /// <summary>
        /// Return the actual rotation of the matrix.
        /// </summary>
        [XmlIgnore]
        public fQuaternion GetRotation
        {
            get
            {
                float3 s = Scale;
                float m00 = rc00 / s.x;
                float m11 = rc11 / s.y;
                float m22 = rc22 / s.z;
                fQuaternion q = new fQuaternion
                {
                    w = (float)Math.Sqrt(Math.Max(0f, 1f + m00 + m11 + m22)) / 2f,
                    x = (float)Math.Sqrt(Math.Max(0f, 1f + m00 - m11 - m22)) / 2f,
                    y = (float)Math.Sqrt(Math.Max(0f, 1f - m00 + m11 - m22)) / 2f,
                    z = (float)Math.Sqrt(Math.Max(0f, 1f - m00 - m11 + m22)) / 2f
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
        public static float3x3 operator *(float3x3 a, float3x3 b)
        {
            float3x3 c;
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
        public static float3x3? operator /(float3x3 a, float3x3 b)
        {
            float3x3? inv = b.Inverse;
            if (inv != null)
            {
                return a * (float3x3)inv;
            }
            return null;
        }
        public static float3x3 operator +(float3x3 a, float3x3 b)
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
        public static float3x3 operator -(float3x3 a, float3x3 b)
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
        public static float3x3 operator *(float3x3 a, float b)
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
        public static float3x3 operator *(float a, float3x3 b)
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
        public static float2 operator *(float3x3 a, float2 b)
        {
            float2 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12;
            return vec;
        }
        public static float2 operator *(float2 b, float3x3 a)
        {
            float2 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12;
            return vec;
        }
        public static float3 operator *(float3x3 a, float3 b)
        {
            float3 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02 * b.z;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12 * b.z;
            vec.z = a.rc20 * b.x + a.rc21 * b.y + a.rc22 * b.z;
            return vec;
        }
        public static float3 operator *(float3 b, float3x3 a)
        {
            float3 vec;
            vec.x = a.rc00 * b.x + a.rc01 * b.y + a.rc02 * b.z;
            vec.y = a.rc10 * b.x + a.rc11 * b.y + a.rc12 * b.z;
            vec.z = a.rc20 * b.x + a.rc21 * b.y + a.rc22 * b.z;
            return vec;
        }
        public static float3x3 operator -(float3x3 a)
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
        public static implicit operator float2x2(float3x3 a)
        {
            float2x2 b;
            b.rc00 = a.rc00;
            b.rc10 = a.rc10;
            b.rc01 = a.rc01;
            b.rc11 = a.rc11;
            return a;
        }
    }
}
