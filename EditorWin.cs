using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poke_Edit
{
    public partial class EditorWin : Form
    {
        SaveFile loadedSave;
        PokeData pokeditor;
        Bitmap[] spriteDex = new Bitmap[388];
        public bool unsavedChanges = false;

        public EditorWin()
        {
            InitializeComponent();
            for (int i = 0; i < spriteDex.Length; i++)
                spriteDex[i] = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + i.ToString().PadLeft(3, '0'));
        }

        private void Form1_Load(object sender, EventArgs e) {  }

        private void trainerInfo_Click(object sender, EventArgs e)
        {
            TrainerInfoWin tInfo = new TrainerInfoWin();
            tInfo.ShowDialog(this);
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "SAV files (*.SAV)|*.SAV";

            if (file.ShowDialog(this) == DialogResult.OK) {
                if (unsavedChanges) {
                    if (Warning.UnsavedAbort(this))
                        return;
                }
                loadedSave = new SaveFile(file.FileName);
                Enable();
                UpdateBoxInfo();
                unsavedChanges = false;
            }
        }

        void Enable() {
            trainerInfo.Enabled = true;
            pokeSpecies.Enabled = true;
        }

        void UpdateBoxInfo()
        {
            boxData.Rows.Clear();
            boxData.Rows.Add();
            for (int i = 0; i < TeamInfo.pokeTeam.Length; i++)
            {
                boxData.Rows[0].Cells[i].Value = spriteDex[TeamInfo.pokeTeam[i].dexNum];
                boxData.Rows[0].Cells[i].Tag = TeamInfo.pokeTeam[i];
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            loadedSave.SaveEdit();
            unsavedChanges = false;
        }

        private void viewPoke_Click(object sender, EventArgs e)
        {
            pokeditor = (PokeData)boxData.CurrentCell.Tag;
            UpdateEdit();
        }

        private void UpdateEdit()
        {
            pokeSpecies.SelectedIndex = pokeditor.dexNum;
        }

        private void setPoke_Click(object sender, EventArgs e)
        {
            boxData.CurrentCell.Tag = pokeditor;
            boxData.CurrentCell.Value = spriteDex[pokeditor.dexNum];
            unsavedChanges = true;
        }

        private void pokeSpecies_IndexChanged(object sender, EventArgs e) { pokeditor.dexNum = (short)pokeSpecies.SelectedIndex; }
    }
}
