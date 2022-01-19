using System;
namespace IkiCore.Binary
{
    public class ByteWriter : IDisposable
    {
        byte[] buffer;
        bool disposed = false;
        public long BitIndex { get; private set; }
        public int ByteIndex { get => (int)(BitIndex % 8); }
        public int BufferIndex { get => (int)(BitIndex / 8); }
        public bool EndOfBuffer { get => BufferIndex == buffer.Length; }
        protected ByteWriter(int bufferSize)
        {
            buffer = new byte[bufferSize];
            BitIndex = 0;
        }
        public static ByteWriter WriteToBuffer(int bufferSize) => new ByteWriter(bufferSize);
        public void Write(byte data)
        {
            int leftSize = 8 - ByteIndex;
            int rightSize = 8 - leftSize;
            buffer[BufferIndex] |= (byte)((data & ByteStream.FullBinaryMask[leftSize]) << ByteIndex);
            BitIndex += leftSize;
            buffer[BufferIndex] |= (byte)(((data >> leftSize) & ByteStream.FullBinaryMask[rightSize]) << ByteIndex);
            BitIndex += rightSize;
        }
        public void Write(sbyte data) => Write((byte)data);
        public void Write(short data) => WriteBits(data, 16);
        public void Write(ushort data) => WriteBits(data, 16);
        public void Write(half data) => WriteBits(data.BitsValues, 16);
        public void Write(int data) => WriteBits(data, 32);
        public void Write(uint data) => WriteBits(data, 32);
        public void Write(float data) => WriteBits(BinaryMod.GetIntFromFloatBits(data), 32);
        public void Write(long data) => WriteBits(data, 64);
        public void Write(double data) => WriteBits(BinaryMod.GetLongFromDoubleBits(data), 64);
        public void Write(decimal data)
        {
            foreach (int item in decimal.GetBits(data))
            {
                WriteBits(item, 32);
            }
        }
        public void Write(char data) => WriteBits(data, 16);
        public void Write(string data)
        {
            WriteBits(data.Length, 32);
            for (int i = 0; i < data.Length; i++)
            {
                WriteBits(data[i], 16);
            }
        }
        public void WriteBits(long data, int numberOfBits)
        {
            if (numberOfBits <= 0)
            {
                return;
            }
            if (numberOfBits > 64)
            {
                throw new Exception("Error: can't write more than 64 bits of data.");
            }
            int writeBytes = numberOfBits / 8;
            while (writeBytes > 0)
            {
                Write((byte)data);
                data >>= 8;
                writeBytes--;
            }
            int bitRemaining = numberOfBits % 8;
            if (bitRemaining > 0)
            {
                int rightSize = (ByteIndex + bitRemaining) % 8;
                int leftSize = bitRemaining - rightSize;
                buffer[BufferIndex] |= (byte)((data & ByteStream.FullBinaryMask[leftSize]) << ByteIndex);
                BitIndex += leftSize;
                if (rightSize == 0)
                {
                    return;
                }
                buffer[BufferIndex] |= (byte)((data >> leftSize) & ByteStream.FullBinaryMask[rightSize]);
                BitIndex += rightSize;
            }
        }
        public void Reset()
        {
            buffer.Reset();
            BitIndex = 0;
        }
        public byte[] ToArray()
        {
            byte[] actualBuffer = new byte[ByteIndex == 0 ? BufferIndex : BufferIndex + 1];
            Array.Copy(buffer, actualBuffer, actualBuffer.Length);
            return actualBuffer;
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
