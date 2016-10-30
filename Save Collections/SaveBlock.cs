using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Edit
{
    class SaveBlock
    {
        const short SECTIONS = 14, SECTION_SIZE = 4096;

        public Section[] sections = new Section[SECTIONS];
        byte[] _blockData;
        GetSet gs;

        public byte[] blockData { get { return _blockData; }}

        public SaveBlock(byte[] blockData) {
            gs = new GetSet(blockData);
            _blockData = blockData;
            for (int i = 0; i < SECTIONS; i++) {
                byte[] sectionData = new byte[SECTION_SIZE];
                Array.Copy(_blockData, SECTION_SIZE * i, sectionData, 0, SECTION_SIZE);
                sections[i] = new Section(sectionData);
            }
        }

        public void SetForAll() {
            foreach (Section sect in sections) {
                if (sect.sectionId == 0)
                    TrainerInfo.securityKey = sect.gs.GetUInt(0x0AF8);
            }
                
            Console.WriteLine("Set Sec Key: " + TrainerInfo.securityKey);

            foreach (Section sect in sections)
                sect.SetData();
        }

        public void StoreForAll()
        {
            for (int i = 0; i < SECTIONS; i++) {
                sections[i].StoreData();
                for (int j = 0; j < SECTION_SIZE; j++)
                    _blockData[(SECTION_SIZE * i) + j] = sections[i].sectionData[j];
            }
        }
    }
}
