using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Edit
{
    public class PokeData
    {
        const short DATA_SIZE = 48;

        public uint persVal, otId;
        public string nickname;
        public ushort lang;
        public string otName;
        public ushort checksum;
        public byte[] data = new byte[DATA_SIZE];
        public uint status;
        public byte level;
        public ushort hp, maxHp, atk, def, spd, sp_a, sp_d;
        public short dexNum;

        public Growth   gr;// 0
        public Attack   at;// 1
        public EV       ev;// 2  
        public Misc     mc;// 3

        const byte  G = 0, 
                    A = 1, 
                    M = 3, 
                    E = 2;

        uint key = 0;

        GetSet gs;
        uint pattern;

        byte[,] decMatrix = {
            { G, A, E, M }, // 0
            { G, A, M, E },
            { G, E, A, M },
            { G, E, M, A },
            { G, M, A, E }, // 4
            { G, M, E, A },
            { A, G, E, M },
            { A, G, M, E },
            { A, E, G, M }, // 8
            { A, E, M, G },
            { A, M, G, E },
            { A, M, E, G },
            { E, G, A, M }, // 12
            { E, G, M, A },
            { E, A, G, M },
            { E, A, M, G },
            { E, M, G, A }, // 16
            { E, M, A, G },
            { M, G, A, E },
            { M, G, E, A },
            { M, A, G, E }, // 20
            { M, A, E, G },
            { M, E, G, A }, // 22
            { M, E, A, G }  // 23
        };

        bool isEmpty {
            get {
                if (persVal == 0 && otId == 0)
                    return true;
                return false;
            }
        }

        public void Store() {
            if (isDecrypted) {
                StoreData();
                Checksum();
                EncryptData();
                data = gs.data;
            }
        }

        public void Init() {
            if (!isEmpty)
                DecryptData();
        }

        private void StoreData()
        {
            for (int i = 0; i < 4; i ++)
            {
                byte num = decMatrix[pattern, i];
                switch (num)
                {
                    case G: StoreGrowth(i); break;
                    case A: StoreAttack(i); break;
                    case M: StoreMisc(i); break;
                    case E: StoreEV(i); break;
                }
            }
        }

        private void StoreEV(int i)
        {
            int j = 12 * i;
            gs.StoreByte(j, ev.hp);
            gs.StoreByte(j + 1, ev.atk);
            gs.StoreByte(j + 2, ev.def);
            gs.StoreByte(j + 3, ev.spd);
            gs.StoreByte(j + 4, ev.sp_a);
            gs.StoreByte(j + 5, ev.sp_d);
            gs.StoreByte(j + 6, ev.cool);
            gs.StoreByte(j + 7, ev.bty);
            gs.StoreByte(j + 8, ev.cute);
            gs.StoreByte(j + 9, ev.smart);
            gs.StoreByte(j + 10, ev.tough);
            gs.StoreByte(j + 11, ev.feel);
        }

        private void StoreMisc(int i)
        {
            int j = 12 * i;
            gs.StoreByte(j, mc.prus);
            gs.StoreByte(j + 1, mc.met);
            gs.StoreUShort(j + 2, mc.origins);
            gs.StoreUInt(j + 4, mc.IvEggAbility);
            gs.StoreUInt(j + 8, mc.ribbons);
        }

        private void StoreAttack(int i)
        {
            int j = 12 * i;
            gs.StoreUShort(j, at.move1);
            gs.StoreUShort(j + 2, at.move2);
            gs.StoreUShort(j + 4, at.move3);
            gs.StoreUShort(j + 6, at.move4);
            gs.StoreByte(j + 8, at.pp1);
            gs.StoreByte(j + 9, at.pp2);
            gs.StoreByte(j + 10, at.pp3);
            gs.StoreByte(j + 11, at.pp4);
        }

        private void StoreGrowth(int i)
        {
            gr.species = PokeList.GetSpecies(dexNum);

            int j = 12 * i;
            gs.StoreUShort(j, gr.species);
            gs.StoreUShort(j + 2, gr.item);
            gs.StoreUInt(j + 4, gr.exp);
            gs.StoreByte(j + 8, gr.ppUp);
            gs.StoreByte(j + 9, gr.friend);
        }

        void Checksum() {
            ushort sum = 0;

            for (int i = 0; i < DATA_SIZE; i += 2)
                sum += gs.GetUShort(i);

            checksum = sum;
        }

        bool isDecrypted { get { return (key == 0 ? false : true); }}

        void EncryptData() {
            if (isDecrypted)
            {
                for (int k = 0; k < DATA_SIZE; k += 4)
                {
                    uint val = gs.GetUInt(k);
                    val ^= key;
                    gs.StoreUInt(k, val);
                }
                key = 0;
            }
        }

        void DecryptData() {
            if (!isDecrypted)
            {
                if (gs == null)
                    gs = new GetSet(data);

                key = (otId ^ persVal);

                for (int k = 0; k < DATA_SIZE; k += 4) {
                    uint val = gs.GetUInt(k);
                    val ^= key;
                    gs.StoreUInt(k, val); 
                }

                pattern = persVal % 24;
                for (int i = 0; i < DATA_SIZE; i += 12)
                {
                    byte num = decMatrix[pattern, i / 12];
                    switch (num)
                    {
                        case G: SetGrowth(i); break;
                        case A: SetAttack(i); break;
                        case M: SetMisc(i); break;
                        case E: SetEV(i); break;
                    }
                }
            }
        }

        void SetGrowth(int offset) {
            if (gr == null)
                gr = new Growth();

            gr.species = gs.GetUShort(offset);
            gr.item = gs.GetUShort(offset + 2);
            gr.exp = gs.GetUInt(offset + 4);
            gr.ppUp = gs.GetByte(offset + 8);
            gr.friend = gs.GetByte(offset + 9);

            dexNum = PokeList.GetDex(gr.species);
        }

        void SetAttack(int offset) {
            if (at == null)
                at = new Attack();

            at.move1 = gs.GetUShort(offset);
            at.move2 = gs.GetUShort(offset + 2);
            at.move3 = gs.GetUShort(offset + 4);
            at.move4 = gs.GetUShort(offset + 6);
            at.pp1 = gs.GetByte(offset + 8);
            at.pp2 = gs.GetByte(offset + 9);
            at.pp3 = gs.GetByte(offset + 10);
            at.pp4 = gs.GetByte(offset + 11);
        }

        void SetEV(int offset) {
            if (ev == null)
                ev = new EV();

            ev.hp = gs.GetByte(offset);
            ev.atk = gs.GetByte(offset + 1);
            ev.def = gs.GetByte(offset + 2);
            ev.spd = gs.GetByte(offset + 3);
            ev.sp_a = gs.GetByte(offset + 4);
            ev.sp_d = gs.GetByte(offset + 5);
            ev.cool = gs.GetByte(offset + 6);
            ev.bty = gs.GetByte(offset + 7);
            ev.cute = gs.GetByte(offset + 8);
            ev.smart = gs.GetByte(offset + 9);
            ev.tough = gs.GetByte(offset + 10);
            ev.feel = gs.GetByte(offset + 11);
        }

        void SetMisc(int offset) {
            if (mc == null)
                mc = new Misc();

            mc.prus = gs.GetByte(offset);
            mc.met = gs.GetByte(offset + 1);
            mc.origins = gs.GetUShort(offset + 2);
            mc.IvEggAbility = gs.GetUInt(offset + 4);
            mc.ribbons = gs.GetUInt(offset + 8);
        }
    }
}
