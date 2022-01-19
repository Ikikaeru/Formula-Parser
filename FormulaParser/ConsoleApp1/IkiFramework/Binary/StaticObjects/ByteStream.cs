namespace IkiCore.Binary
{
    public static class ByteStream
    {
        public enum DataType
        {
            integer_1,
            integer_8,
            integer_16,
            integer_32,
            integer_64,
            float_16,
            float_32,
            float_64,
            decimal_128,
            character,
            text
        }
        public static int[] FullBinaryMask = new int[]
        {
            0x0,
            0x1,
            0x3,
            0x7,
            0xF,
            0x1F,
            0x3F,
            0x7F,
            0xFF
        };
        public static int BoolLength() => 1;
        public static int ByteLength() => 1;
        public static int CharLength() => 2;
        public static int ShortLength() => 2;
        public static int HalfLength() => 2;
        public static int IntLength() => 4;
        public static int FloatLength() => 4;
        public static int LongLength() => 8;
        public static int DoubleLength() => 8;
        public static int DecimalLength() => 16;
        public static int Length(string x) => x.Length * 2 + 4;
    }
}
