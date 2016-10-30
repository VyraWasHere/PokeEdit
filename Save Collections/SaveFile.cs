using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Poke_Edit
{
    public class SaveFile
    {
        const ushort BLOCKS = 2, BLOCK_SIZE = 0xE000;
        
        SaveBlock[] blocks = new SaveBlock[BLOCKS];
        string _savePath;
        byte[] _saveData;
        int biggest;
        

        public SaveFile(string savePath) {
            _savePath = savePath;
            _saveData = File.ReadAllBytes(_savePath);
        
            for (int i = 0; i < BLOCKS; i++) {
                byte[] blockData = new byte[BLOCK_SIZE];
                Array.Copy(_saveData, BLOCK_SIZE * i, blockData, 0, BLOCK_SIZE);
                blocks[i] = new SaveBlock(blockData);
            }

            biggest = (blocks[0].sections[0].saveIndex > blocks[1].sections[0].saveIndex) ? 0 : 1;
            blocks[biggest].SetForAll();
        }

        public void SaveEdit() {
            blocks[biggest].StoreForAll();

            for (int i = (BLOCK_SIZE * biggest); i < (BLOCK_SIZE * biggest) + BLOCK_SIZE; i++)
                _saveData[i] = blocks[biggest].blockData[i - (BLOCK_SIZE * biggest)];

            Console.WriteLine("Save: "+_saveData[0x8001]);
            File.WriteAllBytes(_savePath, _saveData);
        }
    }
}
