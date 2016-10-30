using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Edit
{
    class Section
    {
        const short DATA_SIZE = 4080, NAME_SIZE = 7, TEAM_SIZE = 6,
             NICK_LEN = 10;

        ushort _sectionId, _checksum;
        uint _saveIndex;
        byte[] data = new byte[DATA_SIZE];
        byte[] _sectionData;
        public GetSet gs;

        public ushort sectionId { get { return _sectionId; }}
        public ushort checksum { get { return _checksum; }}
        public uint saveIndex { get { return _saveIndex; }}
        public byte[] sectionData { get { return _sectionData; }}

        public Section(byte[] sectionData) {
            gs = new GetSet(sectionData);
            _sectionData = sectionData;
            Array.Copy(sectionData, data, DATA_SIZE);
            _sectionId = gs.GetUShort(0x0FF4);
            _checksum = gs.GetUShort(0x0FF6);
            _saveIndex = gs.GetUInt(0x0FFC);
        }

        public void SetData() {
            switch (_sectionId) {
                case 0: SetTrainerInfo(); break;
                case 1: SetTeamInfo(); break;
                default:  /*Console.WriteLine("Not Implemented/An Error occured. " + _sectionId);*/ break;
            }
        }

        public void StoreData() {
            switch (_sectionId)
            {
                case 0: StoreTrainerInfo(); break;
                case 1: StoreTeamInfo(); break;
                default: /*Console.WriteLine("Not Implemented/An Error occured. " + _sectionId)*/; break;
            }
            Checksum();
            _sectionData = gs.data;
        }

        private void StoreTeamInfo()
        {
            StoreParty();
            Console.WriteLine("Get Sec Key: " + TrainerInfo.securityKey);
            gs.StoreUInt(0x0290, (TrainerInfo.money ^ TrainerInfo.securityKey));
        }

        void Checksum() {
            uint sum = 0;

            for (int off = 0; off < data.Length; off += 4) {
                sum += gs.GetUInt(off);
            }

            ushort part1 = (ushort)(sum >> 16);
            ushort part2 = (ushort)(sum & 0xFFFF);

            ushort res = (ushort)(part1 + part2);

            gs.StoreUShort(0x0FF6, res);
        }

        void SetTrainerInfo() {
            TrainerInfo.playerName = PkmString.GetString(gs.GetBytes(0x00, NAME_SIZE));
            TrainerInfo.playerGender = (Gender)gs.GetByte(0x08);
            TrainerInfo.playerId.Public = gs.GetUShort(0x0A);
            TrainerInfo.playerId.Secret = gs.GetUShort(0x0C);
            TrainerInfo.playTime.hours = gs.GetUShort(0x0E);
            TrainerInfo.playTime.minutes = gs.GetByte(0x10);
            TrainerInfo.playTime.seconds = gs.GetByte(0x11);
        }

        void StoreTrainerInfo()
        {
            gs.StoreBytes(0x00, NAME_SIZE, PkmString.GetBytes(TrainerInfo.playerName));
            gs.StoreByte(0x08, (byte)TrainerInfo.playerGender);
            gs.StoreUShort(0x0A, TrainerInfo.playerId.Public);
            gs.StoreUShort(0x0C, TrainerInfo.playerId.Secret);
            gs.StoreUShort(0x0E, TrainerInfo.playTime.hours);
            gs.StoreByte(0x10, TrainerInfo.playTime.minutes);
            gs.StoreByte(0x11, TrainerInfo.playTime.seconds);
        }

        void SetTeamInfo() {
            SetParty();
            Console.WriteLine("Get Sec Key: " + TrainerInfo.securityKey);
            TrainerInfo.money = (gs.GetUInt(0x0290) ^ TrainerInfo.securityKey);
        }

        void SetParty() {
            int tO = 0x38; // Team offset in section 
            for (int i = 0; i < TEAM_SIZE * 100; i += 100)
            {
                PokeData newMon = new PokeData();
                newMon.persVal = gs.GetUInt(tO + 0x00 + i);
                newMon.otId = gs.GetUInt(tO + 0x04 + i);
                newMon.nickname = PkmString.GetString(gs.GetBytes(tO + 0x08 + i, NICK_LEN));
                newMon.lang = gs.GetUShort(tO + 0x12 + i);
                newMon.otName = PkmString.GetString(gs.GetBytes(tO + 0x14 + i, NAME_SIZE));
                newMon.checksum = gs.GetUShort(tO + 0x1C + i);
                newMon.data = gs.GetBytes(tO + 0x20 + i, 48);
                newMon.status = gs.GetUInt(tO + 0x50 + i);
                newMon.level = gs.GetByte(tO + 0x54 + i);
                newMon.hp = gs.GetUShort(tO + 0x56 + i);
                newMon.maxHp = gs.GetUShort(tO + 0x58 + i);
                newMon.atk = gs.GetUShort(tO + 0x5A + i);
                newMon.def = gs.GetUShort(tO + 0x5C + i);
                newMon.spd = gs.GetUShort(tO + 0x5E + i);
                newMon.sp_a = gs.GetUShort(tO + 0x60 + i);
                newMon.sp_d = gs.GetUShort(tO + 0x62 + i);
                newMon.Init();

                TeamInfo.pokeTeam[i / 100] = newMon;
            }
        }

        void StoreParty() {
            int tO = 0x38; // Team offset in section 
            for (int i = 0; i < TEAM_SIZE; i++)
            {
                PokeData sDat = TeamInfo.pokeTeam[i];
                sDat.Store();
                int j = i * 100;
                gs.StoreUInt(tO + 0x00 + j, sDat.persVal);
                gs.StoreUInt(tO + 0x04 + j, sDat.otId);
                gs.StoreBytes (tO + 0x08 + j, NICK_LEN, PkmString.GetBytes(sDat.nickname));
                gs.StoreUShort(tO + 0x12 + j, sDat.lang);
                gs.StoreBytes(tO + 0x14 + j, NAME_SIZE, PkmString.GetBytes(sDat.otName));
                gs.StoreUShort(tO + 0x1C + j, sDat.checksum);
                gs.StoreBytes(tO + 0x20 + j, 48, sDat.data);
                gs.StoreUInt(tO + 0x50 + j, sDat.status);
                gs.StoreByte(tO + 0x54 + j, sDat.level);
                gs.StoreUShort(tO + 0x56 + j, sDat.hp);
                gs.StoreUShort(tO + 0x58 + j, sDat.maxHp);
                gs.StoreUShort(tO + 0x5A + j, sDat.atk);
                gs.StoreUShort(tO + 0x5C + j, sDat.def);
                gs.StoreUShort(tO + 0x5E + j, sDat.spd);
                gs.StoreUShort(tO + 0x60 + j, sDat.sp_a);
                gs.StoreUShort(tO + 0x62 + j, sDat.sp_d);
            }
        }
    }
}
