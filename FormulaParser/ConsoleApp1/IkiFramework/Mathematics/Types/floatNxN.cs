using System;
using System.Text;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    public partial struct floatNxN
    {
        internal float[,] Matrix { get; set; }
        public floatNxN(int size)
        {
            if(size < 0)
            {
                throw new Exception("Matrix size can't be negative.");
            }
            Matrix = new float[size, size];
        }
        [XmlIgnore]
        public int Size
        {
            get
            {
                return Matrix.GetLength(0);
            }
        }
        [XmlIgnore] public float this[int row, int column]
        {
            get
            {
                return Matrix[column, row];
            }
            set
            {
                Matrix[column, row] = value;
            }
        }
        [XmlIgnore] public float GetDeterminant { get => Determinant(this); }
        public float[] GetRow(int row)
        {
            float[] elements = new float[Size];
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = this[row, i];
            }
            return elements;
        }
        public void SetRow(int row, float[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                this[row, i] = values[i];
            }
        }
        public float[] GetColumn(int col)
        {
            float[] elements = new float[Size];
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = this[i, col];
            }
            return elements;
        }
        public void SetColumn(int col, float[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                this[i, col] = values[i];
            }
        }
        public static floatNxN Transpose(floatNxN a)
        {
            floatNxN result = new floatNxN(a.Size);
            int r;
            for (int c = 0; c < a.Size; c++)
            {
                for (r = 0; r < a.Size; r++)
                {
                    result[r, c] = a[c, r];
                }
            }
            return result;
        }
        public static floatNxN Identity(int size)
        {
            floatNxN a = new floatNxN(size);
            for (int c = 0; c < size; c++)
            {
                a[c, c] = 1f;
            }
            return a;
        }
        public static float Trace(floatNxN a)
        {
            float x = 0f;
            for (int i = 0; i < a.Size; i++)
            {
                x += a[i, i];
            }
            return x;
        }
        public static IVector Diagonal(floatNxN a)
        {
            IVector v = new floatNx1(a.Size);
            for (int i = 0; i < a.Size; i++)
            {
                v[i] = a[i, i];
            }
            return v;
        }
        public static IVector Vectorization(floatNxN a)
        {
            IVector v = new float1xN(a.Size * a.Size);
            int i, j;
            for (i = 0; i < a.Size; i++)
            {
                for (j = 0; j < a.Size; j++)
                {
                    v[i * a.Size + j] = a[j, i];
                }
            }
            return v;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int c;
            for (int r = 0; r < Size; r++)
            {
                for (c = 0; c < Size; c++)
                {
                    sb.Append("|\t");
                    sb.AppendFormat($"{this[r, c]}\t");
                }
                sb.Append("|");
                sb.Append('\n');
            }
            return sb.ToString();
        }
        public static floatNxN DirectSum(floatNxN a, floatNxN b)
        {
            int size = a.Size + b.Size;
            floatNxN result = new floatNxN(size);
            int r, c;
            for (r = 0; r < a.Size; r++)
            {
                for (c = 0; c < a.Size; c++)
                {
                    result[r, c] = a[r, c];
                }
            }
            for (r = a.Size; r < size; r++)
            {
                for (c = a.Size; c < size; c++)
                {
                    result[r, c] = b[r - a.Size, c - a.Size];
                }
            }
            return result;
        }
        public static floatNxN HadamarProduct(floatNxN a, floatNxN b)
        {
            if (a.Size != b.Size)
            {
                throw new System.Exception("Matrix a and b doesn't have the same size!");
            }
            int size = a.Size;
            floatNxN newMatrix = new floatNxN(size);
            int row;
            for (int column = 0; column < size; column++)
            {
                for (row = 0; row < size; row++)
                {
                    newMatrix[row, column] = a[row, column] * b[row, column];
                }
            }
            return newMatrix;
        }
        public static floatNxN KroneckerProduct(floatNxN a, floatNxN b)
        {
            floatNxN result = new floatNxN(a.Size * b.Size);
            int size = a.Size;
            int r, c, r2, c2;
            for (r = 0; r < size; r++)
            {
                for (c = 0; c < size; c++)
                {
                    for (r2 = 0; r2 < b.Size; r2++)
                    {
                        for (c2 = 0; c2 < b.Size; c2++)
                        {
                            result[r2 + (r * b.Size), c2 + (c * b.Size)] = a[r, c] * b[r2, c2];
                        }
                    }
                }
            }
            return result;
        }
        public static float Determinant(floatNxN a)
        {
            switch(a.Size)
            {
                case 0:
                    return 0f;
                case 1:
                    return a[0, 0];
                case 2:
                    return a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
                case 3:
                    return a[1, 1] * (a[0, 0] * a[2, 2] - a[2, 0] * a[0, 2]) + a[1, 2] * (a[0, 1] * a[2, 0] - a[2, 1] * a[0, 0]) + a[1, 0] * (a[0, 2] * a[2, 1] - a[2, 2] * a[0, 1]);
                default:
                    float s = 0f;
                    for (int i = 1; i <= a.Size; i++)
                    {
                        s += a[i - 1, 0] * Math.MinusOnePowf(i) * Minor(a, i - 1, 0);
                    }
                    return s;
            }
        }
        public static floatNxN Cofactor(floatNxN a)
        {
            floatNxN result = new floatNxN(a.Size);
            int j;
            for (int i = 1; i <= a.Size; i++)
            {
                for (j = 1; j <= a.Size; j++)
                {
                    result[i - 1, j - 1] = Math.MinusOnePowf(i + j) * Minor(a, i - 1, j - 1);
                }
            }
            return result;
        }
        public static floatNxN Adjucate(floatNxN a) => Transpose(Cofactor(a));
        public static floatNxN Inverse(floatNxN a)
        {
            try
            {
                floatNxN inverse = Identity(a.Size);
                float localVar;
                int i, j, k;
                for (k = 0; k < a.Size; k++)
                {
                    localVar = a[k, k];
                    for (j = 0; j < a.Size; j++)
                    {
                        a[k, j] /= localVar;
                        inverse[k, j] /= localVar;
                    }
                    for (i = 0; i < a.Size; i++)
                    {
                        localVar = a[i, k];
                        for (j = 0; j < a.Size; j++)
                        {
                            if (i == k)
                            {
                                break;
                            }
                            a[i, j] -= a[k, j] * localVar;
                            inverse[i, j] -= inverse[k, j] * localVar;
                        }
                    }
                }
                return inverse;
            }
            catch(DivideByZeroException)
            {
                throw new Exception("The matrix have a determinant of 0. There's no inverse!");
            }
        }
        public static float Minor(floatNxN a, int row, int column)
        {
            floatNxN result = new floatNxN(a.Size - 1);
            int actualRow = 0, actualColumn;
            int c;
            for (int r = 0; r < a.Size; r++)
            {
                if(r != row)
                {
                    for (actualColumn = 0, c = 0; c < a.Size; c++)
                    {
                        if(c != column)
                        {
                            result[actualRow, actualColumn] = a[r, c];
                            actualColumn++;
                        }
                    }
                    actualRow++;
                }
            }
            return Determinant(result);
        }
        public static floatNxN operator *(float a, floatNxN b)
        {
            int c;
            for (int r = 0; r < b.Size; r++)
            {
                for (c = 0; c < b.Size; c++)
                {
                    b[r, c] *= a;
                }
            }
            return b;
        }
        public static floatNxN operator *(floatNxN a, float b)
        {
            int c;
            for (int r = 0; r < a.Size; r++)
            {
                for (c = 0; c < a.Size; c++)
                {
                    a[r, c] *= c;
                }
            }
            return a;
        }
        public static floatNxN operator +(floatNxN a, floatNxN b)
        {
            if (a.Size != b.Size)
            {
                throw new System.Exception("Matrix a and b doesn't have the same size!");
            }
            int size = a.Size;
            floatNxN newMatrix = new floatNxN(size);
            int row;
            for (int column = 0; column < size; column++)
            {
                for (row = 0; row < size; row++)
                {
                    newMatrix[row, column] = a[row, column] + b[row, column];
                }
            }
            return newMatrix;
        }
        public static floatNxN operator -(floatNxN a, floatNxN b)
        {
            if(a.Size != b.Size)
            {
                throw new System.Exception("Matrix a and b doesn't have the same size!");
            }
            int size = a.Size;
            floatNxN newMatrix = new floatNxN(size);
            int row;
            for (int column = 0; column < size; column++)
            {
                for (row = 0; row < size; row++)
                {
                    newMatrix[row, column] = a[row, column] - b[row, column];
                }
            }
            return newMatrix;
        }
        public static floatNxN operator *(floatNxN a, floatNxN b)
        {
            if(a.Size != b.Size)
            {
                throw new System.Exception("Matrix a and b doesn't have the same size!");
            }
            int size = a.Size;
            floatNxN newMatrix = new floatNxN(size);
            int c, s;
            for (int r = 0; r < size; r++)
            {
                for (c = 0; c < size; c++)
                {
                    for (s = 0; s < size; s++)
                    {
                        newMatrix[r, c] += a[r, s] * b[s, c];
                    }
                }
            }
            return newMatrix;
        }
        public static explicit operator floatNxN(float2x2 a)
        {
            floatNxN result = new floatNxN(2);
            result[0, 0] = a.rc00;
            result[1, 0] = a.rc10;
            result[0, 1] = a.rc01;
            result[1, 1] = a.rc11;
            return result;
        }
        public static explicit operator floatNxN(float3x3 a)
        {
            floatNxN result = new floatNxN(3);
            result[0, 0] = a.rc00;
            result[1, 0] = a.rc10;
            result[2, 0] = a.rc20;
            result[0, 1] = a.rc01;
            result[1, 1] = a.rc11;
            result[2, 1] = a.rc21;
            result[0, 2] = a.rc02;
            result[1, 2] = a.rc12;
            result[2, 2] = a.rc22;
            return result;
        }
        public static explicit operator floatNxN(float4x4 a)
        {
            floatNxN result = new floatNxN(4);
            result[0, 0] = a.rc00;
            result[1, 0] = a.rc10;
            result[2, 0] = a.rc20;
            result[3, 0] = a.rc30;
            result[0, 1] = a.rc01;
            result[1, 1] = a.rc11;
            result[2, 1] = a.rc21;
            result[3, 1] = a.rc31;
            result[0, 2] = a.rc02;
            result[1, 2] = a.rc12;
            result[2, 2] = a.rc22;
            result[3, 2] = a.rc32;
            result[0, 3] = a.rc03;
            result[1, 3] = a.rc13;
            result[2, 3] = a.rc23;
            result[3, 3] = a.rc33;
            return result;
        }
    }
}
