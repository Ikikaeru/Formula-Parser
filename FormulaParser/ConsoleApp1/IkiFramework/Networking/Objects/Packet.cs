using System;
using System.Collections.Generic;
using System.Text;
namespace IkiCore.Networking
{
    public class Packet : IDisposable
    {
        List<byte> buffer;
        byte[] readableBuffer;
        int indexPos;
        bool disposed = false;
        public Packet()
        {
            buffer = new List<byte>();
            indexPos = 0;
        }
        public Packet(int id)
        {
            buffer = new List<byte>();
            indexPos = 0;
            Write(id);
        }
        public Packet(byte[] data)
        {
            buffer = new List<byte>();
            indexPos = 0;
            SetBytes(data);
        }
        public void SetBytes(byte[] data)
        {
            Write(data);
            readableBuffer = buffer.ToArray();
        }
        public void WriteLength() => buffer.InsertRange(0, BitConverter.GetBytes(buffer.Count));
        public void InsertInt(int value) => buffer.InsertRange(0, BitConverter.GetBytes(value));
        public byte[] ToArray()
        {
            readableBuffer = buffer.ToArray();
            return readableBuffer;
        }
        public int Length() => buffer.Count;
        public int UnreadLength() => Length() - indexPos;
        public void Reset(bool shouldReset = true)
        {
            if (shouldReset)
            {
                buffer.Clear();
                readableBuffer = null;
                indexPos = 0;
            }
            else
            {
                indexPos -= 4;
            }
        }
        public void Write(byte[] value) => buffer.AddRange(value);
        public void Write(bool value) => buffer.AddRange(BitConverter.GetBytes(value));
        public void Write(sbyte value) => buffer.Add((byte)value);
        public void Write(byte value) => buffer.Add(value);
        public void Write(short value) => buffer.AddRange(BitConverter.GetBytes(value));
        public void Write(ushort value) => buffer.AddRange(BitConverter.GetBytes(value));
        public void Write(int value) => buffer.AddRange(BitConverter.GetBytes(value));
        public void Write(uint value) => buffer.AddRange(BitConverter.GetBytes(value));
        public void Write(long value) => buffer.AddRange(BitConverter.GetBytes(value));
        public void Write(ulong value) => buffer.AddRange(BitConverter.GetBytes(value));
        public void Write(float value) => buffer.AddRange(BitConverter.GetBytes(value));
        public void Write(double value) => buffer.AddRange(BitConverter.GetBytes(value));
        public void Write(decimal value)
        {
            foreach (int item in decimal.GetBits(value))
            {
                Write(item);
            }
        }
        public void Write(string value)
        {
            Write(value.Length);
            buffer.AddRange(Encoding.ASCII.GetBytes(value));
        }
        public byte[] ReadBytes(int length, bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                byte[] value = buffer.GetRange(indexPos, length).ToArray();
                if (moveReadPos)
                {
                    indexPos += length;
                }
                return value;
            }
            throw new Exception("Can't read the byte array.");
        }
        public bool ReadBool(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                bool value = BitConverter.ToBoolean(readableBuffer, indexPos);
                if (moveReadPos)
                {
                    indexPos++;
                }
                return value;
            }
            throw new Exception("Can't read the boolean.");
        }
        public sbyte ReadSbyte(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                sbyte value = (sbyte)readableBuffer[indexPos];
                if (moveReadPos)
                {
                    indexPos++;
                }
                return value;
            }
            throw new Exception("Can't read the sbyte value.");
        }
        public byte ReadByte(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                byte value = readableBuffer[indexPos];
                if (moveReadPos)
                {
                    indexPos++;
                }
                return value;
            }
            throw new Exception("Can't read the byte value.");
        }
        public short ReadShort(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                short value = BitConverter.ToInt16(readableBuffer, indexPos);
                if (moveReadPos)
                {
                    indexPos += 2;
                }
                return value;
            }
            throw new Exception("Can't read the short value.");
        }
        public ushort ReadUshort(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                ushort value = (ushort)BitConverter.ToInt16(readableBuffer, indexPos);
                if (moveReadPos)
                {
                    indexPos += 2;
                }
                return value;
            }
            throw new Exception("Can't read the ushort value.");
        }
        public int ReadInt(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                int value = BitConverter.ToInt32(readableBuffer, indexPos);
                if (moveReadPos)
                {
                    indexPos += 4;
                }
                return value;
            }
            throw new Exception("Can't read the int value.");
        }
        public uint ReadUint(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                uint value = (uint)BitConverter.ToInt32(readableBuffer, indexPos);
                if (moveReadPos)
                {
                    indexPos += 4;
                }
                return value;
            }
            throw new Exception("Can't read the uint value.");
        }
        public long ReadLong(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                long value = BitConverter.ToInt64(readableBuffer, indexPos);
                if (moveReadPos)
                {
                    indexPos += 8;
                }
                return value;
            }
            throw new Exception("Can't read the long value.");
        }
        public ulong ReadUlong(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                ulong value = (ulong)BitConverter.ToInt64(readableBuffer, indexPos);
                if (moveReadPos)
                {
                    indexPos += 8;
                }
                return value;
            }
            throw new Exception("Can't read the ulong value.");
        }
        public float ReadFloat(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                float value = BitConverter.ToSingle(readableBuffer, indexPos);
                if (moveReadPos)
                {
                    indexPos += 4;
                }
                return value;
            }
            throw new Exception("Can't read the float value.");
        }
        public double ReadDouble(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                double value = BitConverter.ToDouble(readableBuffer, indexPos);
                if (moveReadPos)
                {
                    indexPos += 8;
                }
                return value;
            }
            throw new Exception("Can't read the double value.");
        }
        public decimal ReadDecimal(bool moveReadPos = true)
        {
            if (buffer.Count > indexPos)
            {
                int v0 = ReadInt(moveReadPos);
                int v1 = ReadInt(moveReadPos);
                int v2 = ReadInt(moveReadPos);
                int v3 = ReadInt(moveReadPos);
                return new decimal(v0, v1, v2, (v3 & 0x80000000) != 0, (byte)((v3 >> 16) & 0x7F));
            }
            throw new Exception("Can't read the decimal value.");
        }
        public string ReadString(bool moveReadPos = true)
        {
            try
            {
                int length = ReadInt();
                string value = Encoding.ASCII.GetString(readableBuffer, indexPos, length);
                if (moveReadPos && value.Length > 0)
                {
                    indexPos += length;
                }
                return value;
            }
            catch
            {
                throw new Exception("Can't read the string value.");
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    buffer = null;
                    readableBuffer = null;
                    indexPos = 0;
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
