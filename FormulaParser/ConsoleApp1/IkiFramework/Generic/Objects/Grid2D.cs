using System;
using System.Collections.Generic;
namespace IkiCore.Generic
{
    [Serializable]
    public class Grid2D<T>
    {
        /// <summary>
        /// Width of the grid.
        /// </summary>
        public int Width;
        /// <summary>
        /// Height of the grid.
        /// </summary>
        public int Height;
        /// <summary>
        /// Construct a grid.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Grid2D(int width = 1, int height = 1)
        {
            Width = width < 1 ? 1 : width;
            Height = height < 1 ? 1 : height;
            Initiate();
        }
        [Serializable]
        public struct GridRow
        {
            /// <summary>
            /// Columns
            /// </summary>
            public T[] Cols;
        }
        /// <summary>
        /// Rows.
        /// </summary>
        public GridRow[] Rows;
        protected void Initiate()
        {
            if (Rows == null)
            {
                Rows = MakeArray();
                Resize(Width, Height);
            }
        }
        protected GridRow[] MakeArray(int width = -1, int height = -1)
        {
            GridRow[] rows = new GridRow[height == -1 ? Height : height < 1 ? 1 : height];
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i].Cols = new T[width == -1 ? Width : width < 1 ? 1 : width];
            }
            return rows;
        }
        public T this[int width, int height]
        {
            get
            {
                return Rows[height].Cols[width];
            }
            set
            {
                Rows[height].Cols[width] = value;
            }
        }
        /// <summary>
        /// Resize the 2D Grid.
        /// </summary>
        /// <param name="width">Resizing width</param>
        /// <param name="height">Resizing height</param>
        public void Resize(int width, int height)
        {
            if (width != Width || Height != height)
            {
                width = width < 1 ? 1 : width;
                height = height < 1 ? 1 : height;
                bool SmallerW = width < Width;
                bool SmallerH = height < Height;
                GridRow[] tmp;
                tmp = MakeArray(width, height);
                int yFor = SmallerH ? tmp.Length : Height;
                for (int y = 0; y < yFor; y++)
                {
                    for (int x = 0; x < (SmallerW ? tmp[y].Cols.Length : Width); x++)
                    {
                        tmp[y].Cols[x] = this[x, y];
                    }
                }
                Width = width;
                Height = height;
                Rows = tmp;
            }
        }
        /// <summary>
        /// Return true if the position is a corner of the grid.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsCorner(int x, int y)
        {
            return (x == Width - 1 && y == Height - 1) || (x == 0 && y == Height - 1) || (x == 0 && y == 0) || (x == Width - 1 && y == 0);
        }
        /// <summary>
        /// Return true if the position is on the edge of the grid.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsInEdge(int x, int y)
        {
            return (x == 0 || x == Width - 1 || y == 0 || y == Height - 1);
        }
        /// <summary>
        /// Return true if the position is on the grid.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsInRange(int x, int y)
        {
            return (x > -1 && x < Width && y > -1 && y < Height);
        }
        /// <summary>
        /// Return true if the element is a neighbour of the checked position.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="neighbour"></param>
        /// <returns></returns>
        public bool IsNeighbour(int x, int y, T neighbour)
        {
            int x2 = x + 2;
            int y2 = y + 2;
            for (int i = x - 1; i < x2; i++)
            {
                for (int j = y - 1; j < y2; j++)
                {
                    if (IsInRange(i, j) && Rows[i].Cols[j].Equals(neighbour))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Return the neighbour of the position + the n distance.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="nX"></param>
        /// <param name="nY"></param>
        /// <returns></returns>
        public T GetNeighbour(int x, int y, int nX = 0, int nY = 0)
        {
            int xnX = x + nX;
            int ynY = y + nY;
            if (IsInRange(xnX, ynY) && (nX != 0 && nY != 0))
            {
                return this[xnX, ynY];
            }
            return default(T);
        }
        /// <summary>
        /// Get all the neighbours of the position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public T[] GetAllNeighbours(int x, int y)
        {
            List<T> lst = new List<T>();
            int x2 = x + 2;
            int y2 = y + 2;
            for (int i = x - 1; i < x2; i++)
            {
                for (int j = y - 1; j < y2; j++)
                {
                    if (IsInRange(i, j) && (i != x && j != y))
                    {
                        lst.Add(this[j, i]);
                    }
                }
            }
            return lst.ToArray();
        }
        /// <summary>
        /// Swap two position.
        /// </summary>
        /// <param name="aX"></param>
        /// <param name="aY"></param>
        /// <param name="bX"></param>
        /// <param name="bY"></param>
        public void Swap(int aX, int aY, int bX, int bY)
        {
            if (IsInRange(aX, aY) && IsInRange(bX, bY))
            {
                T type = this[aX, aY];
                this[aX, aY] = this[bX, bY];
                this[bX, bY] = type;
            }
        }
    }
}
