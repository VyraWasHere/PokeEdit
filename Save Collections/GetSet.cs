using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Edit
{
    public class GetSet
    {
        byte[] _data;

        public byte[] data { get { return _data; }}

        public GetSet(byte[] data) {
            _data = data;
        }

        public uint GetUInt(int offset, bool isLittle = true)
        {
            byte[] bin = new byte[sizeof(uint)];
            Array.Copy(_data, offset, bin, 0, sizeof(uint));

            if (!BitConverter.IsLittleEndian && isLittle)
                Array.Reverse(bin);
            else if (BitConverter.IsLittleEndian && !isLittle)
                Array.Reverse(bin);

            return BitConverter.ToUInt32(bin, 0);
        }

        public ushort GetUShort(int offset, bool isLittle = true)
        {
            byte[] bin = new byte[sizeof(ushort)];
            Array.Copy(_data, offset, bin, 0, sizeof(ushort));

            if (!BitConverter.IsLittleEndian && isLittle)
                Array.Reverse(bin);
            else if (BitConverter.IsLittleEndian && !isLittle)
                Array.Reverse(bin);

            return BitConverter.ToUInt16(bin, 0);
        }

        public byte[] GetBytes(int offset, int length, bool isLittle = false)
        {
            byte[] bin = new byte[length];
            Array.Copy(_data, offset, bin, 0, length);

            if (!BitConverter.IsLittleEndian && !isLittle)
                Array.Reverse(bin);
            else if (BitConverter.IsLittleEndian && isLittle)
                Array.Reverse(bin);

            return bin;
        }

        public byte GetByte(int offset)
        {
            return _data[offset];
        }

        public void StoreByte(int offset, byte val)
        {
            _data[offset] = val;
        }

        public void StoreBytes(int offset, int length, byte[] vals, bool isLittle = false)
        {
            if (!BitConverter.IsLittleEndian && !isLittle)
                Array.Reverse(vals);
            else if (BitConverter.IsLittleEndian && isLittle)
                Array.Reverse(vals);

            for (int i = 0; (i < length) && (i < vals.Length); i++)
                _data[offset + i] = vals[i];
        }

        public void StoreUInt(int offset, uint val, bool isLittle = true)
        {
            byte[] bin = BitConverter.GetBytes(val);

            if (!BitConverter.IsLittleEndian && isLittle)
                Array.Reverse(bin);
            else if (BitConverter.IsLittleEndian && !isLittle)
                Array.Reverse(bin);

            for (int i = 0; i < sizeof(uint); i++)
                _data[offset + i] = bin[i];
        }

        public void StoreUShort(int offset, ushort val, bool isLittle = true)
        {
            byte[] bin = BitConverter.GetBytes(val);

            if (!BitConverter.IsLittleEndian && isLittle)
                Array.Reverse(bin);
            else if (BitConverter.IsLittleEndian && !isLittle)
                Array.Reverse(bin);

            for (int i = 0; i < sizeof(ushort); i++)
                _data[offset + i] = bin[i];
        }
    }
}
