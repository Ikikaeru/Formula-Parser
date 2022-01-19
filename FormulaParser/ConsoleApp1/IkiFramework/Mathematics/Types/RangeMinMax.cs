using IkiCore.Core;
namespace IkiCore.Mathematics
{
    [System.Serializable]
    public struct iRangeMinMax
    {
        /// <summary>
        /// Minimum value of the range.
        /// </summary>
        public int Min;
        /// <summary>
        /// Maximum value of the range.
        /// </summary>
        public int Max;
        /// <summary>
        /// Create an int range min - max
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public iRangeMinMax(int min = int.MaxValue, int max = int.MinValue)
        {
            Min = min;
            Max = max;
        }
        /// <summary>
        /// Get the min at index 0 and max at index 1.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                switch(index)
                {
                    case 0:
                        return Min;
                    case 1:
                        return Max.Max(Min);
                }
                return 0;
            }
        }
        /// <summary>
        /// Test if the value is the min or max value, if it is, then it's assign, otherwise, it's ignored.
        /// </summary>
        /// <param name="val"></param>
        public void MinMax(int val)
        {
            Max = val.Max(Max);
            Min = val.Min(Min);
        }
    }
    [System.Serializable]
    public struct fRangeMinMax
    {
        /// <summary>
        /// Minimum value of the range.
        /// </summary>
        public float Min;
        /// <summary>
        /// Maximum value of the range.
        /// </summary>
        public float Max;
        /// <summary>
        /// Create a float range min - max
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public fRangeMinMax(float min = float.MaxValue, float max = float.MinValue)
        {
            Min = min;
            Max = max;
        }
        /// <summary>
        /// Get the min at index 0 and max at index 1.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Min;
                    case 1:
                        return Max.Max(Min);
                }
                return 0;
            }
        }
        /// <summary>
        /// Test if the value is the min or max value, if it is, then it's assign, otherwise, it's ignored.
        /// </summary>
        /// <param name="val"></param>
        public void Evaluate(float val)
        {
            Max = val.Max(Max);
            Min = val.Min(Min);
        }
    }
    [System.Serializable]
    public struct dRangeMinMax
    {
        /// <summary>
        /// Minimum value of the range.
        /// </summary>
        public double Min;
        /// <summary>
        /// Maximum value of the range.
        /// </summary>
        public double Max;
        /// <summary>
        /// Create a float range min - max
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public dRangeMinMax(double min = double.MaxValue, double max = double.MinValue)
        {
            Min = min;
            Max = max;
        }
        /// <summary>
        /// Get the min at index 0 and max at index 1.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Min;
                    case 1:
                        return Max.Max(Min);
                }
                return 0;
            }
        }
        /// <summary>
        /// Test if the value is the min or max value, if it is, then it's assign, otherwise, it's ignored.
        /// </summary>
        /// <param name="val"></param>
        public void MinMax(double val)
        {
            Max = val.Max(Max);
            Min = val.Min(Min);
        }
    }
    [System.Serializable]
    public struct f3RangeMinMax
    {
        /// <summary>
        /// Minimum value of the range.
        /// </summary>
        public float3 Min;
        /// <summary>
        /// Maximum value of the range.
        /// </summary>
        public float3 Max;
        /// <summary>
        /// Create a float range min - max
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public f3RangeMinMax(float min = float.MaxValue, float max = float.MinValue)
        {
            Min.x = min;
            Min.y = min;
            Min.z = min;
            Max.x = max;
            Max.y = max;
            Max.z = max;
        }
        /// <summary>
        /// Get the min at index 0 and max at index 1.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public float3 this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Min;
                    case 1:
                        return Max.Max(Min);
                }
                return float3.Zero;
            }
        }
        /// <summary>
        /// Test if the value is the min or max value, if it is, then it's assign, otherwise, it's ignored.
        /// </summary>
        /// <param name="val"></param>
        public void MinMax(float3 val)
        {
            Max = val.Max(Max);
            Min = val.Min(Min);
        }
    }
}
