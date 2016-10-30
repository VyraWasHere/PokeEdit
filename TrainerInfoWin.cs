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
    public partial class TrainerInfoWin : Form
    {
        bool noErr = true, unsavedChanges = false;

        public TrainerInfoWin()
        {
            InitializeComponent();
        }

        private void TrainerInfoWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsavedChanges)
            {
                if (Warning.UnsavedAbort(this))
                    e.Cancel = true;
            }
        }

        private void TrainerInfoWin_Load(object sender, EventArgs e)
        {
            playerName.Text = TrainerInfo.playerName;
            playerGender.SelectedIndex = (int)TrainerInfo.playerGender;
            playerMoney.Text = TrainerInfo.money.ToString();
            timeH.Text = TrainerInfo.playTime.hours.ToString();
            timeM.Text = TrainerInfo.playTime.minutes.ToString();
            timeS.Text = TrainerInfo.playTime.seconds.ToString();
            pID.Text = TrainerInfo.playerId.Public.ToString().PadLeft(5, '0');
            sID.Text = TrainerInfo.playerId.Secret.ToString().PadLeft(5, '0');
            unsavedChanges = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            noErr = true;

            TrainerInfo.playerName = playerName.Text;
            TrainerInfo.playerGender = (Gender)playerGender.SelectedIndex;
            ParseString(playerMoney.Text, ref TrainerInfo.money, maxVal: 999999);
            ParseString(timeH.Text, ref TrainerInfo.playTime.hours);
            ParseString(timeM.Text, ref TrainerInfo.playTime.minutes, maxVal: 59);
            ParseString(timeS.Text, ref TrainerInfo.playTime.seconds, maxVal: 59);
            ParseString(pID.Text, ref TrainerInfo.playerId.Public);
            ParseString(sID.Text, ref TrainerInfo.playerId.Secret);

            if (noErr)
            {
                unsavedChanges = false;
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ParseString(string s, ref uint value, uint maxVal = uint.MaxValue) {
            uint res;
            if (!UInt32.TryParse(s, out res))
            {
                ParseError("UInt32");
                return;
            }
            res = (res > maxVal) ? maxVal : res;
            value = res;
        }

        void ParseString(string s, ref ushort value, ushort maxVal = ushort.MaxValue) {
            ushort res;
            if (!UInt16.TryParse(s, out res)) {
                ParseError("UInt16");
                return;
            }
            res = (res > maxVal) ? maxVal : res;
            value = res;
        }

        void ParseString(string s, ref byte value, byte maxVal = byte.MaxValue) {
            byte res;
            if (!Byte.TryParse(s, out res)) {
                ParseError("Byte");
                return;
            }
            res = (res > maxVal) ? maxVal : res;
            value = res;
        }

        private void playerName_TextChanged(object sender, EventArgs e) { unsavedChanges = true; }
        private void playerGender_TextChanged(object sender, EventArgs e) { unsavedChanges = true; }
        private void playerMoney_TextChanged(object sender, EventArgs e) { unsavedChanges = true; }
        private void timeH_TextChanged(object sender, EventArgs e) { unsavedChanges = true; }
        private void timeM_TextChanged(object sender, EventArgs e) { unsavedChanges = true; }
        private void timeS_TextChanged(object sender, EventArgs e) { unsavedChanges = true; }
        private void pID_TextChanged(object sender, EventArgs e) { unsavedChanges = true; }
        private void sID_TextChanged(object sender, EventArgs e) { unsavedChanges = true; }

        void ParseError(string type) {
            noErr = false;
            MessageBox.Show(this, $"Parse error: Please make sure the string is a valid {type}!", 
                $"{type} Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
