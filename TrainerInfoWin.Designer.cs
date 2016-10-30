namespace Poke_Edit
{
    partial class TrainerInfoWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pGenL = new System.Windows.Forms.Label();
            this.playerGender = new System.Windows.Forms.ComboBox();
            this.pNickL = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.playerMoney = new System.Windows.Forms.TextBox();
            this.pMoneyL = new System.Windows.Forms.Label();
            this.timeH = new System.Windows.Forms.TextBox();
            this.timeM = new System.Windows.Forms.TextBox();
            this.timeS = new System.Windows.Forms.TextBox();
            this.pTimeL = new System.Windows.Forms.Label();
            this.hL = new System.Windows.Forms.Label();
            this.mL = new System.Windows.Forms.Label();
            this.sL = new System.Windows.Forms.Label();
            this.pID = new System.Windows.Forms.TextBox();
            this.sID = new System.Windows.Forms.TextBox();
            this.pIdL = new System.Windows.Forms.Label();
            this.sIdL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pGenL
            // 
            this.pGenL.AutoSize = true;
            this.pGenL.Location = new System.Drawing.Point(118, 41);
            this.pGenL.Name = "pGenL";
            this.pGenL.Size = new System.Drawing.Size(42, 13);
            this.pGenL.TabIndex = 7;
            this.pGenL.Text = "Gender";
            // 
            // playerGender
            // 
            this.playerGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerGender.FormattingEnabled = true;
            this.playerGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.playerGender.Location = new System.Drawing.Point(11, 38);
            this.playerGender.Name = "playerGender";
            this.playerGender.Size = new System.Drawing.Size(101, 21);
            this.playerGender.TabIndex = 6;
            this.playerGender.TextChanged += new System.EventHandler(this.playerGender_TextChanged);
            // 
            // pNickL
            // 
            this.pNickL.AutoSize = true;
            this.pNickL.Location = new System.Drawing.Point(118, 15);
            this.pNickL.Name = "pNickL";
            this.pNickL.Size = new System.Drawing.Size(84, 13);
            this.pNickL.TabIndex = 5;
            this.pNickL.Text = "Character Name";
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(12, 12);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(100, 20);
            this.playerName.TabIndex = 4;
            this.playerName.TabStop = false;
            this.playerName.TextChanged += new System.EventHandler(this.playerName_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(11, 227);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(119, 227);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // playerMoney
            // 
            this.playerMoney.Location = new System.Drawing.Point(13, 66);
            this.playerMoney.Name = "playerMoney";
            this.playerMoney.Size = new System.Drawing.Size(100, 20);
            this.playerMoney.TabIndex = 10;
            this.playerMoney.TextChanged += new System.EventHandler(this.playerMoney_TextChanged);
            // 
            // pMoneyL
            // 
            this.pMoneyL.AutoSize = true;
            this.pMoneyL.Location = new System.Drawing.Point(119, 69);
            this.pMoneyL.Name = "pMoneyL";
            this.pMoneyL.Size = new System.Drawing.Size(39, 13);
            this.pMoneyL.TabIndex = 11;
            this.pMoneyL.Text = "Money";
            // 
            // timeH
            // 
            this.timeH.Location = new System.Drawing.Point(16, 113);
            this.timeH.Name = "timeH";
            this.timeH.Size = new System.Drawing.Size(33, 20);
            this.timeH.TabIndex = 12;
            this.timeH.TextChanged += new System.EventHandler(this.timeH_TextChanged);
            // 
            // timeM
            // 
            this.timeM.Location = new System.Drawing.Point(64, 113);
            this.timeM.Name = "timeM";
            this.timeM.Size = new System.Drawing.Size(33, 20);
            this.timeM.TabIndex = 13;
            this.timeM.TextChanged += new System.EventHandler(this.timeM_TextChanged);
            // 
            // timeS
            // 
            this.timeS.Location = new System.Drawing.Point(113, 113);
            this.timeS.Name = "timeS";
            this.timeS.Size = new System.Drawing.Size(33, 20);
            this.timeS.TabIndex = 14;
            this.timeS.TextChanged += new System.EventHandler(this.timeS_TextChanged);
            // 
            // pTimeL
            // 
            this.pTimeL.AutoSize = true;
            this.pTimeL.Location = new System.Drawing.Point(13, 97);
            this.pTimeL.Name = "pTimeL";
            this.pTimeL.Size = new System.Drawing.Size(65, 13);
            this.pTimeL.TabIndex = 15;
            this.pTimeL.Text = "Time Played";
            // 
            // hL
            // 
            this.hL.AutoSize = true;
            this.hL.Location = new System.Drawing.Point(50, 116);
            this.hL.Name = "hL";
            this.hL.Size = new System.Drawing.Size(13, 13);
            this.hL.TabIndex = 16;
            this.hL.Text = "h";
            // 
            // mL
            // 
            this.mL.Location = new System.Drawing.Point(97, 116);
            this.mL.Name = "mL";
            this.mL.Size = new System.Drawing.Size(10, 13);
            this.mL.TabIndex = 17;
            this.mL.Text = "m";
            // 
            // sL
            // 
            this.sL.AutoSize = true;
            this.sL.Location = new System.Drawing.Point(146, 116);
            this.sL.Name = "sL";
            this.sL.Size = new System.Drawing.Size(12, 13);
            this.sL.TabIndex = 18;
            this.sL.Text = "s";
            // 
            // pID
            // 
            this.pID.Location = new System.Drawing.Point(15, 148);
            this.pID.Name = "pID";
            this.pID.Size = new System.Drawing.Size(100, 20);
            this.pID.TabIndex = 19;
            this.pID.TextChanged += new System.EventHandler(this.pID_TextChanged);
            // 
            // sID
            // 
            this.sID.Location = new System.Drawing.Point(15, 174);
            this.sID.Name = "sID";
            this.sID.Size = new System.Drawing.Size(100, 20);
            this.sID.TabIndex = 20;
            this.sID.TextChanged += new System.EventHandler(this.sID_TextChanged);
            // 
            // pIdL
            // 
            this.pIdL.AutoSize = true;
            this.pIdL.Location = new System.Drawing.Point(121, 151);
            this.pIdL.Name = "pIdL";
            this.pIdL.Size = new System.Drawing.Size(50, 13);
            this.pIdL.TabIndex = 21;
            this.pIdL.Text = "Public ID";
            // 
            // sIdL
            // 
            this.sIdL.AutoSize = true;
            this.sIdL.Location = new System.Drawing.Point(121, 177);
            this.sIdL.Name = "sIdL";
            this.sIdL.Size = new System.Drawing.Size(52, 13);
            this.sIdL.TabIndex = 22;
            this.sIdL.Text = "Secret ID";
            // 
            // TrainerInfoWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 262);
            this.Controls.Add(this.sIdL);
            this.Controls.Add(this.pIdL);
            this.Controls.Add(this.sID);
            this.Controls.Add(this.pID);
            this.Controls.Add(this.sL);
            this.Controls.Add(this.mL);
            this.Controls.Add(this.hL);
            this.Controls.Add(this.pTimeL);
            this.Controls.Add(this.timeS);
            this.Controls.Add(this.timeM);
            this.Controls.Add(this.timeH);
            this.Controls.Add(this.pMoneyL);
            this.Controls.Add(this.playerMoney);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.pGenL);
            this.Controls.Add(this.playerGender);
            this.Controls.Add(this.pNickL);
            this.Controls.Add(this.playerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TrainerInfoWin";
            this.Text = "Trainer Info";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainerInfoWin_FormClosing);
            this.Load += new System.EventHandler(this.TrainerInfoWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pGenL;
        private System.Windows.Forms.ComboBox playerGender;
        private System.Windows.Forms.Label pNickL;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox playerMoney;
        private System.Windows.Forms.Label pMoneyL;
        private System.Windows.Forms.TextBox timeH;
        private System.Windows.Forms.TextBox timeM;
        private System.Windows.Forms.TextBox timeS;
        private System.Windows.Forms.Label pTimeL;
        private System.Windows.Forms.Label hL;
        private System.Windows.Forms.Label mL;
        private System.Windows.Forms.Label sL;
        private System.Windows.Forms.TextBox pID;
        private System.Windows.Forms.TextBox sID;
        private System.Windows.Forms.Label sIdL;
        private System.Windows.Forms.Label pIdL;
    }
}