namespace IkiCore.Mathematics
{
    [System.Serializable]
    public struct Intervald
    {
        public double Min { get; private set; }
        public double Max { get; private set; }
        public Intervald(double a, double b)
        {
            Min = a < b ? a : b;
            Max = b > a ? b : a;
        }
        public bool IntervalIncluded(double x) => x >= Min && x <= Max;
        public bool IntervalNotIncluded(double x) => x > Min && x < Max;
        public bool IntervalIncludedMin(double x) => x >= Min && x < Max;
        public bool IntervalIncludedMax(double x) => x > Min && x <= Max;
    }
    [System.Serializable]
    public struct Intervalf
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public Intervalf(float a, float b)
        {
            Min = a < b ? a : b;
            Max = b > a ? b : a;
        }
        public bool IntervalIncluded(float x) => x >= Min && x <= Max;
        public bool IntervalNotIncluded(float x) => x > Min && x < Max;
        public bool IntervalIncludedMin(float x) => x >= Min && x < Max;
        public bool IntervalIncludedMax(float x) => x > Min && x <= Max;
    }
    [System.Serializable]
    public struct Intervali
    {
        public int Min { get; private set; }
        public int Max { get; private set; }
        public Intervali(int a, int b)
        {
            Min = a < b ? a : b;
            Max = b > a ? b : a;
        }
        public bool IntervalIncluded(int x) => x >= Min && x <= Max;
        public bool IntervalNotIncluded(int x) => x > Min && x < Max;
        public bool IntervalIncludedMin(int x) => x >= Min && x < Max;
        public bool IntervalIncludedMax(int x) => x > Min && x <= Max;
    }
    [System.Serializable]
    public struct Intervall
    {
        public long Min { get; private set; }
        public long Max { get; private set; }
        public Intervall(int a, int b)
        {
            Min = a < b ? a : b;
            Max = b > a ? b : a;
        }
        public bool IntervalIncluded(long x) => x >= Min && x <= Max;
        public bool IntervalNotIncluded(long x) => x > Min && x < Max;
        public bool IntervalIncludedMin(long x) => x >= Min && x < Max;
        public bool IntervalIncludedMax(long x) => x > Min && x <= Max;
    }
}
