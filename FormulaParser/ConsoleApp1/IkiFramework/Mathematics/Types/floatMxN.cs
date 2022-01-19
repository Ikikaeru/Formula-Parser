using System;
using System.Text;
using System.Xml.Serialization;
namespace IkiCore.Mathematics
{
    public partial struct floatMxN
    {
        internal float[,] Matrix { get; set; }
        public floatMxN(int rowCount, int columnCount)
        {
            Matrix = new float[columnCount, rowCount];
        }
        [XmlIgnore] public int RowCount
        {
            get
            {
                return Matrix.GetLength(1);
            }
        }
        [XmlIgnore] public int ColumnCount
        {
            get
            {
                return Matrix.GetLength(0);
            }
        }
        [XmlIgnore] public float PseudoDeterminant
        {
            get
            {
                floatMxN t = this * Transpose(this);
                return Math.Sqrt(GetSquareMatrixFrom(t).GetDeterminant);
            }
        }
        [XmlIgnore] public bool IsSquareMatrix { get => RowCount == ColumnCount; }
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
        public float[] GetRow(int row)
        {
            float[] elements = new float[Matrix.GetLength(0)];
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = this[row, i];
            }
            return elements;
        }
        public void SetRow(int row, float[] values)
        {
            if (values.Length >= Matrix.GetLength(0))
            {
                throw new Exception("Too many elements to set in the row of the matrix!");
            }
            for (int i = 0; i < values.Length; i++)
            {
                this[row, i] = values[i];
            }
        }
        public float[] GetColumn(int col)
        {
            float[] elements = new float[Matrix.GetLength(1)];
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = this[i, col];
            }
            return elements;
        }
        public void SetColumn(int col, float[] values)
        {
            if(values.Length >= Matrix.GetLength(1))
            {
                throw new Exception("Too many elements to set in the column of the matrix!");
            }
            for (int i = 0; i < values.Length; i++)
            {
                this[i, col] = values[i];
            }
        }
        public floatNxN GetSquareMatrixFrom(floatMxN a)
        {
            if(IsSquareMatrix)
            {
                floatNxN result = new floatNxN(a.ColumnCount)
                {
                    Matrix = a.Matrix
                };
                return result;
            }
            throw new Exception("The matrix is not a square matrix!");
        }
        public static floatMxN Transpose(floatMxN a)
        {
            floatMxN result = new floatMxN(a.ColumnCount, a.RowCount);
            int r;
            for (int c = 0; c < result.ColumnCount; c++)
            {
                for (r = 0; r < result.RowCount; r++)
                {
                    result[r, c] = a[c, r];
                }
            }
            return result;
        }
        public static floatMxN DirectSum(floatMxN a, floatMxN b)
        {
            int rowSize = a.RowCount + b.RowCount;
            int columnSize = a.ColumnCount + b.ColumnCount;
            floatMxN result = new floatMxN(rowSize, columnSize);
            int r, c;
            for (r = 0; r < a.RowCount; r++)
            {
                for (c = 0; c < a.ColumnCount; c++)
                {
                    result[r, c] = a[r, c];
                }
            }
            for (r = a.RowCount; r < rowSize; r++)
            {
                for (c = a.ColumnCount; c < columnSize; c++)
                {
                    result[r, c] = b[r - a.RowCount, c - a.ColumnCount];
                }
            }
            return result;
        }
        public static floatMxN HadamarProduct(floatMxN a, floatMxN b)
        {
            if (a.RowCount != b.RowCount || a.ColumnCount != b.ColumnCount)
            {
                throw new System.Exception("Matrix a and b doesn't have the same size!");
            }
            int rowC = a.RowCount;
            int colC = a.ColumnCount;
            floatMxN newMatrix = new floatMxN(rowC, colC);
            int row;
            for (int column = 0; column < colC; column++)
            {
                for (row = 0; row < rowC; row++)
                {
                    newMatrix[row, column] = a[row, column] * b[row, column];
                }
            }
            return newMatrix;
        }
        public static floatMxN KroneckerProduct(floatMxN a, floatMxN b)
        {
            floatMxN result = new floatMxN(a.RowCount * b.RowCount, a.ColumnCount * b.ColumnCount);
            int rowCa = a.RowCount;
            int colCa = a.ColumnCount;
            int rowCb = b.RowCount;
            int colCb = b.ColumnCount;
            int r, c, r2, c2;
            for (r = 0; r < rowCa; r++)
            {
                for (c = 0; c < colCa; c++)
                {
                    for (r2 = 0; r2 < rowCb; r2++)
                    {
                        for (c2 = 0; c2 < colCb; c2++)
                        {
                            result[r2 + (r * rowCb), c2 + (c * colCb)] = a[r, c] * b[r2, c2];
                        }
                    }
                }
            }
            return result;
        }
        public static IVector Diagonal(floatMxN a)
        {
            int size = Math.Min(a.ColumnCount, a.RowCount);
            IVector v = new floatNx1(size);
            for (int i = 0; i < size; i++)
            {
                v[i] = a[i, i];
            }
            return v;
        }
        public static IVector Vectorization(floatMxN a)
        {
            IVector v = new float1xN(a.ColumnCount * a.RowCount);
            int i, j;
            for (i = 0; i < a.ColumnCount; i++)
            {
                for (j = 0; j < a.RowCount; j++)
                {
                    v[i * a.ColumnCount + j] = a[j, i];
                }
            }
            return v;
        }
        public static floatMxN operator +(floatMxN a, floatMxN b)
        {
            if (a.RowCount != b.RowCount || a.ColumnCount != b.ColumnCount)
            {
                throw new System.Exception("Matrix a and b doesn't have the same size!");
            }
            int rC = a.RowCount, cC = a.ColumnCount;
            floatMxN newMatrix = new floatMxN(rC, cC);
            int row;
            for (int column = 0; column < cC; column++)
            {
                for (row = 0; row < rC; row++)
                {
                    newMatrix[row, column] = a[row, column] + b[row, column];
                }
            }
            return newMatrix;
        }
        public static floatMxN operator -(floatMxN a, floatMxN b)
        {
            if (a.RowCount != b.RowCount || a.ColumnCount != b.ColumnCount)
            {
                throw new System.Exception("Matrix a and b doesn't have the same size!");
            }
            int rC = a.RowCount, cC = a.ColumnCount;
            floatMxN newMatrix = new floatMxN(rC, cC);
            int row;
            for (int column = 0; column < cC; column++)
            {
                for (row = 0; row < rC; row++)
                {
                    newMatrix[row, column] = a[row, column] - b[row, column];
                }
            }
            return newMatrix;
        }
        public static floatMxN operator *(float a, floatMxN b)
        {
            int c, row = b.RowCount, col = b.ColumnCount;
            for (int r = 0; r < row; r++)
            {
                for (c = 0; c < col; c++)
                {
                    b[r, c] *= a;
                }
            }
            return b;
        }
        public static floatMxN operator *(floatMxN a, float b)
        {
            int c, row = a.RowCount, col = a.ColumnCount;
            for (int r = 0; r < row; r++)
            {
                for (c = 0; c < col; c++)
                {
                    a[r, c] *= b;
                }
            }
            return a;
        }
        public static floatMxN operator *(floatMxN a, floatMxN b)
        {
            if (a.ColumnCount != b.RowCount)
            {
                throw new System.Exception("Matrix a don't have the same column size as b's row size!");
            }
            floatMxN newMatrix = new floatMxN(a.RowCount, b.ColumnCount);
            int c, s;
            int size = a.ColumnCount;
            int row = a.RowCount;
            int col = b.ColumnCount;
            for (int r = 0; r < row; r++)
            {
                for (c = 0; c < col; c++)
                {
                    for (s = 0; s < size; s++)
                    {
                        newMatrix[r, c] = a[r, s] + b[s, c];
                    }
                }
            }
            return newMatrix;
        }
        public static floatMxN operator *(floatMxN a, floatNx1 b)
        {
            if (a.ColumnCount != b.Dimension)
            {
                throw new System.Exception("Matrix a don't have the same column size as b's row size!");
            }
            floatMxN newMatrix = new floatMxN(a.RowCount, 1);
            int c, s;
            int size = a.ColumnCount;
            int row = a.RowCount;
            for (int r = 0; r < row; r++)
            {
                for (c = 0; c < 1; c++)
                {
                    for (s = 0; s < size; s++)
                    {
                        newMatrix[r, c] = a[r, s] + b[s];
                    }
                }
            }
            return newMatrix;
        }
        public static floatMxN operator *(floatMxN a, float1xN b)
        {
            if (a.ColumnCount != 1)
            {
                throw new System.Exception("Matrix a don't have the same column size as b's row size!");
            }
            floatMxN newMatrix = new floatMxN(a.RowCount, b.Dimension);
            int c, s;
            int row = a.RowCount;
            for (int r = 0; r < row; r++)
            {
                for (c = 0; c < b.Dimension; c++)
                {
                    for (s = 0; s < 1; s++)
                    {
                        newMatrix[r, c] = a[r, s] + b[s];
                    }
                }
            }
            return newMatrix;
        }
        public static floatMxN operator *(float1xN b, floatMxN a)
        {
            if (a.RowCount != b.Dimension)
            {
                throw new System.Exception("Matrix a don't have the same column size as b's row size!");
            }
            floatMxN newMatrix = new floatMxN(1, a.ColumnCount);
            int c, s;
            int size = a.RowCount;
            int col = a.ColumnCount;
            for (int r = 0; r < 1; r++)
            {
                for (c = 0; c < col; c++)
                {
                    for (s = 0; s < size; s++)
                    {
                        newMatrix[r, c] = a[r, s] + b[s];
                    }
                }
            }
            return newMatrix;
        }
        public static floatMxN operator *(floatNx1 b, floatMxN a)
        {
            if (a.RowCount != 1)
            {
                throw new System.Exception("Matrix a don't have the same column size as b's row size!");
            }
            floatMxN newMatrix = new floatMxN(b.Dimension, a.ColumnCount);
            int c, s;
            int col = a.ColumnCount;
            for (int r = 0; r < b.Dimension; r++)
            {
                for (c = 0; c < col; c++)
                {
                    for (s = 0; s < 1; s++)
                    {
                        newMatrix[r, c] = a[r, s] + b[s];
                    }
                }
            }
            return newMatrix;
        }
        public static implicit operator floatMxN(floatNxN a)
        {
            floatMxN result = new floatMxN(a.Size, a.Size)
            {
                Matrix = a.Matrix
            };
            return result;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int c;
            for (int r = 0; r < RowCount; r++)
            {
                for (c = 0; c < ColumnCount; c++)
                {
                    sb.Append("|\t");
                    sb.AppendFormat($"{this[r, c]}\t");
                }
                sb.Append("|");
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}
