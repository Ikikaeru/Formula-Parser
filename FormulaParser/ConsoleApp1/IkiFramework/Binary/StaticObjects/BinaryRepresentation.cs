namespace IkiCore.Binary
{
    public static class BinaryRepresentation
    {
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this int a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 32; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            return builder.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this uint a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 32; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            return builder.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this ushort a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 16; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            return builder.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this short a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 16; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            return builder.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this byte a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 8; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            return builder.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this sbyte a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 8; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            return builder.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this char a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 16; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            return builder.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this long a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 64; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            return builder.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this ulong a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString((long)a, 2);
            for (int i = bits.Length; i < 64; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            return builder.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this double a)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            byte[] ba = System.BitConverter.GetBytes(a);
            for (int i = 0; i < ba.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    sb.Insert(0, ((ba[i] >> j) & 1) == 1 ? "1" : "0");
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Binary(this float a)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            byte[] ba = System.BitConverter.GetBytes(a);
            for (int i = 0; i < ba.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    sb.Insert(0, ((ba[i] >> j) & 1) == 1 ? "1" : "0");
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// Return the binary representation of the value formated (sign - exponent - mantissa).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string FormatedBinary(this float a)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            byte[] ba = System.BitConverter.GetBytes(a);
            for (int i = 0; i < ba.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    sb.Insert(0, ((ba[i] >> j) & 1) == 1 ? "1" : "0");
                }
            }
            string s = sb.ToString();
            return s.Substring(0, 1) + " " + s.Substring(1, 8) + " " + s.Substring(9);
        }
        /// <summary>
        /// Return the binary representation of the value formated (sign - exponent - mantissa).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string FormatedBinary(this double a)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            byte[] ba = System.BitConverter.GetBytes(a);
            for (int i = 0; i < ba.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    sb.Insert(0, ((ba[i] >> j) & 1) == 1 ? "1" : "0");
                }
            }
            string s = sb.ToString();
            return s.Substring(0, 1) + " " + s.Substring(1, 11) + " " + s.Substring(12);
        }
        /// <summary>
        /// Return the binary representation of the value formated (sign - number).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string FormatedBinary(this sbyte a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 8; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            string s = builder.ToString();
            return s.Substring(0, 1) + " " + s.Substring(1);
        }
        /// <summary>
        /// Return the binary representation of the value formated (sign - number).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string FormatedBinary(this short a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 16; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            string s = builder.ToString();
            return s.Substring(0, 1) + " " + s.Substring(1);
        }
        /// <summary>
        /// Return the binary representation of the value formated (sign - number).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string FormatedBinary(this half a)
        {
            return ((short)a.BitsValues).FormatedBinary();
        }
        /// <summary>
        /// Return the binary representation of the value formated (sign - number).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string FormatedBinary(this int a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 32; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            string s = builder.ToString();
            return s.Substring(0, 1) + " " + s.Substring(1);
        }
        /// <summary>
        /// Return the binary representation of the value formated (sign - number).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string FormatedBinary(this long a)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            string bits = System.Convert.ToString(a, 2);
            for (int i = bits.Length; i < 32; i++)
            {
                builder.Append("0");
            }
            builder.Append(bits);
            string s = builder.ToString();
            return s.Substring(0, 1) + " " + s.Substring(1);
        }
    }
}
