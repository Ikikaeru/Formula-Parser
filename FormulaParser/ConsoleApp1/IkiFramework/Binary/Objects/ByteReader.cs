using System;
using System.Text;
namespace IkiCore.Binary
{
    public class ByteReader : IDisposable
    {
        byte[] buffer;
        bool disposed = false;
        public long BitIndex { get; private set; }
        public int ByteIndex { get => (int)(BitIndex % 8); }
        public int BufferIndex { get => (int)(BitIndex / 8); }
        public long TheoricalBitLength { get => buffer.Length * 8L; }
        public bool EndOfBuffer { get => BufferIndex == buffer.Length; }
        protected ByteReader(byte[] actualBuffer)
        {
            buffer = actualBuffer;
            BitIndex = 0;
        }
        public static ByteReader ReadFromBuffer(byte[] actualBuffer) => new ByteReader(actualBuffer);
        public object ReadNextData(ByteStream.DataType type)
        {
            if (EndOfBuffer)
            {
                throw new Exception("End of the buffer reached.");
            }
            switch (type)
            {
                case ByteStream.DataType.integer_1:
                    byte data = (byte)((buffer[BufferIndex] >> ByteIndex) & 0x1);
                    BitIndex++;
                    return data;
                case ByteStream.DataType.integer_8:
                    byte data2;
                    int leftSize = 8 - ByteIndex;
                    int rightSize = 8 - leftSize;
                    data2 = (byte)((buffer[BufferIndex] >> ByteIndex) & ByteStream.FullBinaryMask[leftSize]);
                    BitIndex += leftSize;
                    data2 |= (byte)((buffer[BufferIndex] & ByteStream.FullBinaryMask[rightSize]) << leftSize);
                    BitIndex += rightSize;
                    return data2;
                case ByteStream.DataType.integer_16:
                    return (short)((byte)ReadNextData(ByteStream.DataType.integer_8) | ((byte)ReadNextData(ByteStream.DataType.integer_8) << 8));
                case ByteStream.DataType.integer_32:
                    return (int)(short)ReadNextData(ByteStream.DataType.integer_16) | ((short)ReadNextData(ByteStream.DataType.integer_16) << 16);
                case ByteStream.DataType.integer_64:
                    return (long)(int)ReadNextData(ByteStream.DataType.integer_32) | ((long)(int)ReadNextData(ByteStream.DataType.integer_32) << 32);
                case ByteStream.DataType.float_16:
                    return half.GetFromBits((byte)ReadNextData(ByteStream.DataType.integer_8) | ((byte)ReadNextData(ByteStream.DataType.integer_8) << 8));
                case ByteStream.DataType.float_32:
                    return BinaryMod.GetFloatFromIntBits((int)(short)ReadNextData(ByteStream.DataType.integer_16) | ((short)ReadNextData(ByteStream.DataType.integer_16) << 16));
                case ByteStream.DataType.float_64:
                    return BinaryMod.GetDoubleFromLongBits((long)(int)ReadNextData(ByteStream.DataType.integer_32) | ((long)(int)ReadNextData(ByteStream.DataType.integer_32) << 32));
                case ByteStream.DataType.decimal_128:
                    int v0 = (int)ReadNextData(ByteStream.DataType.integer_32);
                    int v1 = (int)ReadNextData(ByteStream.DataType.integer_32);
                    int v2 = (int)ReadNextData(ByteStream.DataType.integer_32);
                    int v3 = (int)ReadNextData(ByteStream.DataType.integer_32);
                    return new decimal(v0, v1, v2, (v3 & 0x80000000) != 0, (byte)((v3 >> 16) & 0x7F));
                case ByteStream.DataType.character:
                    return (char)(short)ReadNextData(ByteStream.DataType.integer_16);
                case ByteStream.DataType.text:
                    int length = (int)ReadNextData(ByteStream.DataType.integer_32);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < length; i++)
                    {
                        sb.Append((char)ReadNextData(ByteStream.DataType.character));
                    }
                    return sb.ToString();
                default:
                    return null;
            }
        }
        public long ReadNextBits(int numberOfBits)
        {
            if (numberOfBits <= 0)
            {
                return 0L;
            }
            else if (numberOfBits > 64)
            {
                throw new Exception("Unable to read more than 64 bits.");
            }
            int elements = numberOfBits / 8;
            int i = 0;
            long result = 0L;
            while (elements > 0)
            {
                result |= (long)(byte)ReadNextData(ByteStream.DataType.integer_8) << (i * 8);
                elements--;
                i++;
            }
            int remaining = numberOfBits % 8;
            if (remaining > 0)
            {
                i = numberOfBits - remaining;
                int rightSize = (ByteIndex + remaining) % 8;
                int leftSize = remaining - rightSize;
                result |= (byte)(((buffer[BufferIndex] >> ByteIndex) & ByteStream.FullBinaryMask[leftSize]) << i);
                BitIndex += leftSize;
                i += leftSize;
                if (rightSize == 0)
                {
                    return result;
                }
                BitIndex += rightSize;
                result |= (byte)((buffer[BufferIndex] & ByteStream.FullBinaryMask[rightSize]) << i);
            }
            return result;
        }
        protected void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    buffer = null;
                    BitIndex = 0L;
                }
                disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
