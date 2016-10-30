using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Edit
{
    public class Misc
    {
        public byte prus, met;
        public ushort origins;
        public uint IvEggAbility;
        public uint ribbons;

        public byte hpIv { get { return GetIV(1); } set { SetIV(1, value); }}
        public byte atkIv { get { return GetIV(2); } set { SetIV(2, value); }}
        public byte defIv { get { return GetIV(3); } set { SetIV(3, value); }}
        public byte spdIv { get { return GetIV(4); } set { SetIV(4, value); }}
        public byte sp_aIv { get { return GetIV(5); } set { SetIV(5, value); }}
        public byte sp_dIv { get { return GetIV(6); } set { SetIV(6, value); }}

        byte GetIV(int index) {
            int shift = 0x20 - (5 * index);
            return (byte)((IvEggAbility & (0x1F << shift)) >> shift);
        }

        void SetIV(int index, byte value) {
            value = (value > 0x1F) ? (byte)0x1F : value;
            int shift = 0x20 - (5 * index);
            uint mask = (uint)(IvEggAbility & ~(0x1F << shift));
            IvEggAbility = (mask | ((uint)value << shift));
        }
    }
}
