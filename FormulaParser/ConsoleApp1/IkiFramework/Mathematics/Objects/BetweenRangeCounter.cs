namespace IkiCore.Mathematics
{
    /// <summary>
    /// Count every element that are add in the specified range.
    /// </summary>
    public class BetweenRangeCounter
    {
        readonly double min;
        readonly double max;
        /// <summary>
        /// Initialize a new counter of element in specified range between a minimal value and a maximal value.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public BetweenRangeCounter(double a, double b)
        {
            Count = 0;
            this.min = a < b ? a : b;
            this.max = b > a ? b : a;
        }
        /// <summary>
        /// Count of every element that where counted between min and max.
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Count a new element in the range if that element is between the range.
        /// </summary>
        /// <param name="x"></param>
        public void Add(double x)
        {
            if (x >= min && x <= max)
            {
                Count++;
            }
        }
    }
    /// <summary>
    /// Count every element that are add in the specified range.
    /// </summary>
    public class BetweenRangeCounterFloat
    {
        readonly float min;
        readonly float max;
        /// <summary>
        /// Initialize a new counter of element in specified range between a minimal value and a maximal value.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public BetweenRangeCounterFloat(float a, float b)
        {
            Count = 0;
            this.min = a < b ? a : b;
            this.max = b > a ? b : a;
        }
        /// <summary>
        /// Count of every element that where counted between min and max.
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Count a new element in the range if that element is between the range.
        /// </summary>
        /// <param name="x"></param>
        public void Add(float x)
        {
            if (x >= min && x <= max)
            {
                Count++;
            }
        }
    }
}
