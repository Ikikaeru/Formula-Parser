namespace IkiCore.Mathematics
{
    public static class IVec
    {
        public static IVector Add(IVector a, IVector b)
        {
            if (a.Dimension != b.Dimension)
            {
                throw new System.Exception("Both vectors doesn't have the same size!");
            }
            for (int i = 0; i < a.Dimension; i++)
            {
                a[i] += b[i];
            }
            return a;
        }
        public static IVector Add(float a, IVector b)
        {
            for (int i = 0; i < b.Dimension; i++)
            {
                b[i] += a;
            }
            return b;
        }
        public static IVector Add(IVector a, float b)
        {
            for (int i = 0; i < a.Dimension; i++)
            {
                a[i] += b;
            }
            return a;
        }
        public static IVector Sub(IVector a, IVector b)
        {
            if (a.Dimension != b.Dimension)
            {
                throw new System.Exception("Both vectors doesn't have the same size!");
            }
            for (int i = 0; i < a.Dimension; i++)
            {
                a[i] += b[i];
            }
            return a;
        }
        public static IVector Sub(float a, IVector b)
        {
            for (int i = 0; i < b.Dimension; i++)
            {
                b[i] = a - b[i];
            }
            return b;
        }
        public static IVector Sub(IVector a, float b)
        {
            for (int i = 0; i < a.Dimension; i++)
            {
                a[i] -= b;
            }
            return a;
        }
        public static IVector Mul(float a, IVector b)
        {
            for (int i = 0; i < b.Dimension; i++)
            {
                b[i] *= a;
            }
            return b;
        }
        public static IVector Mul(IVector a, float b)
        {
            for (int i = 0; i < a.Dimension; i++)
            {
                a[i] *= b;
            }
            return a;
        }
        public static IVector Mul(IVector a, IVector b)
        {
            if (a.Dimension != b.Dimension)
            {
                throw new System.Exception("Both vectors doesn't have the same size!");
            }
            for (int i = 0; i < a.Dimension; i++)
            {
                a[i] *= b[i];
            }
            return a;
        }
        public static IVector Div(IVector a, IVector b)
        {
            if (a.Dimension != b.Dimension)
            {
                throw new System.Exception("Both vectors doesn't have the same size!");
            }
            for (int i = 0; i < a.Dimension; i++)
            {
                a[i] /= b[i];
            }
            return a;
        }
        public static IVector Div(float a, IVector b)
        {
            for (int i = 0; i < b.Dimension; i++)
            {
                b[i] = a / b[i];
            }
            return b;
        }
        public static IVector Div(IVector a, float b)
        {
            for (int i = 0; i < a.Dimension; i++)
            {
                a[i] /= b;
            }
            return a;
        }
    }
}
