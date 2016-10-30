using System;
namespace Poke_Edit
{
    partial class EditorWin
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
            this.components = new System.ComponentModel.Container();
            this.trainerInfo = new System.Windows.Forms.Button();
            this.toolMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.pokeSpecies = new System.Windows.Forms.ComboBox();
            this.speciesL = new System.Windows.Forms.Label();
            this.boxData = new System.Windows.Forms.DataGridView();
            this.Poke1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cellMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewPoke = new System.Windows.Forms.ToolStripMenuItem();
            this.setPoke = new System.Windows.Forms.ToolStripMenuItem();
            this.Poke2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.poke3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.poke4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.poke5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.poke6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxData)).BeginInit();
            this.cellMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // trainerInfo
            // 
            this.trainerInfo.Enabled = false;
            this.trainerInfo.Location = new System.Drawing.Point(122, 225);
            this.trainerInfo.Name = "trainerInfo";
            this.trainerInfo.Size = new System.Drawing.Size(75, 23);
            this.trainerInfo.TabIndex = 5;
            this.trainerInfo.Text = "Trainer Info";
            this.trainerInfo.UseVisualStyleBackColor = true;
            this.trainerInfo.Click += new System.EventHandler(this.trainerInfo_Click);
            // 
            // toolMenu
            // 
            this.toolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.toolMenu.Location = new System.Drawing.Point(0, 0);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(552, 24);
            this.toolMenu.TabIndex = 6;
            this.toolMenu.Text = "Menu Bar";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.saveFile});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(155, 22);
            this.openFile.Text = "Open...";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFile.Size = new System.Drawing.Size(155, 22);
            this.saveFile.Text = "Save";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // pokeSpecies
            // 
            this.pokeSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pokeSpecies.Enabled = false;
            this.pokeSpecies.FormattingEnabled = true;
            this.pokeSpecies.Items.AddRange(new object[] {
            "???",
            "Bulbasaur",
            "Ivysaur",
            "Venusaur",
            "Charmander",
            "Charmeleon",
            "Charizard",
            "Squirtle",
            "Wartortle",
            "Blastoise",
            "Caterpie",
            "Metapod",
            "Butterfree",
            "Weedle",
            "Kakuna",
            "Beedrill",
            "Pidgey",
            "Pidgeotto",
            "Pidgeot",
            "Rattata",
            "Raticate",
            "Spearow",
            "Fearow",
            "Ekans",
            "Arbok",
            "Pikachu",
            "Raichu",
            "Sandshrew",
            "Sandslash",
            "Nidoran♀",
            "Nidorina",
            "Nidoqueen",
            "Nidoran♂",
            "Nidorino",
            "Nidoking",
            "Clefairy",
            "Clefable",
            "Vulpix",
            "Ninetales",
            "Jigglypuff",
            "Wigglytuff",
            "Zubat",
            "Golbat",
            "Oddish",
            "Gloom",
            "Vileplume",
            "Paras",
            "Parasect",
            "Venonat",
            "Venomoth",
            "Diglett",
            "Dugtrio",
            "Meowth",
            "Persian",
            "Psyduck",
            "Golduck",
            "Mankey",
            "Primeape",
            "Growlithe",
            "Arcanine",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            "Abra",
            "Kadabra",
            "Alakazam",
            "Machop",
            "Machoke",
            "Machamp",
            "Bellsprout",
            "Weepinbell",
            "Victreebel",
            "Tentacool",
            "Tentacruel",
            "Geodude",
            "Graveler",
            "Golem",
            "Ponyta",
            "Rapidash",
            "Slowpoke",
            "Slowbro",
            "Magnemite",
            "Magneton",
            "Farfetch’d",
            "Doduo",
            "Dodrio",
            "Seel",
            "Dewgong",
            "Grimer",
            "Muk",
            "Shellder",
            "Cloyster",
            "Gastly",
            "Haunter",
            "Gengar",
            "Onix",
            "Drowzee",
            "Hypno",
            "Krabby",
            "Kingler",
            "Voltorb",
            "Electrode",
            "Exeggcute",
            "Exeggutor",
            "Cubone",
            "Marowak",
            "Hitmonlee",
            "Hitmonchan",
            "Lickitung",
            "Koffing",
            "Weezing",
            "Rhyhorn",
            "Rhydon",
            "Chansey",
            "Tangela",
            "Kangaskhan",
            "Horsea",
            "Seadra",
            "Goldeen",
            "Seaking",
            "Staryu",
            "Starmie",
            "Mr. Mime",
            "Scyther",
            "Jynx",
            "Electabuzz",
            "Magmar",
            "Pinsir",
            "Tauros",
            "Magikarp",
            "Gyarados",
            "Lapras",
            "Ditto",
            "Eevee",
            "Vaporeon",
            "Jolteon",
            "Flareon",
            "Porygon",
            "Omanyte",
            "Omastar",
            "Kabuto",
            "Kabutops",
            "Aerodactyl",
            "Snorlax",
            "Articuno",
            "Zapdos",
            "Moltres",
            "Dratini",
            "Dragonair",
            "Dragonite",
            "Mewtwo",
            "Mew",
            "Chikorita",
            "Bayleef",
            "Meganium",
            "Cyndaquil",
            "Quilava",
            "Typhlosion",
            "Totodile",
            "Croconaw",
            "Feraligatr",
            "Sentret",
            "Furret",
            "Hoothoot",
            "Noctowl",
            "Ledyba",
            "Ledian",
            "Spinarak",
            "Ariados",
            "Crobat",
            "Chinchou",
            "Lanturn",
            "Pichu",
            "Cleffa",
            "Igglybuff",
            "Togepi",
            "Togetic",
            "Natu",
            "Xatu",
            "Mareep",
            "Flaaffy",
            "Ampharos",
            "Bellossom",
            "Marill",
            "Azumarill",
            "Sudowoodo",
            "Politoed",
            "Hoppip",
            "Skiploom",
            "Jumpluff",
            "Aipom",
            "Sunkern",
            "Sunflora",
            "Yanma",
            "Wooper",
            "Quagsire",
            "Espeon",
            "Umbreon",
            "Murkrow",
            "Slowking",
            "Misdreavus",
            "Unown",
            "Wobbuffet",
            "Girafarig",
            "Pineco",
            "Forretress",
            "Dunsparce",
            "Gligar",
            "Steelix",
            "Snubbull",
            "Granbull",
            "Qwilfish",
            "Scizor",
            "Shuckle",
            "Heracross",
            "Sneasel",
            "Teddiursa",
            "Ursaring",
            "Slugma",
            "Magcargo",
            "Swinub",
            "Piloswine",
            "Corsola",
            "Remoraid",
            "Octillery",
            "Delibird",
            "Mantine",
            "Skarmory",
            "Houndour",
            "Houndoom",
            "Kingdra",
            "Phanpy",
            "Donphan",
            "Porygon2",
            "Stantler",
            "Smeargle",
            "Tyrogue",
            "Hitmontop",
            "Smoochum",
            "Elekid",
            "Magby",
            "Miltank",
            "Blissey",
            "Raikou",
            "Entei",
            "Suicune",
            "Larvitar",
            "Pupitar",
            "Tyranitar",
            "Lugia",
            "Ho-Oh",
            "Celebi",
            "Treecko",
            "Grovyle",
            "Sceptile",
            "Torchic",
            "Combusken",
            "Blaziken",
            "Mudkip",
            "Marshtomp",
            "Swampert",
            "Poochyena",
            "Mightyena",
            "Zigzagoon",
            "Linoone",
            "Wurmple",
            "Silcoon",
            "Beautifly",
            "Cascoon",
            "Dustox",
            "Lotad",
            "Lombre",
            "Ludicolo",
            "Seedot",
            "Nuzleaf",
            "Shiftry",
            "Taillow",
            "Swellow",
            "Wingull",
            "Pelipper",
            "Ralts",
            "Kirlia",
            "Gardevoir",
            "Surskit",
            "Masquerain",
            "Shroomish",
            "Breloom",
            "Slakoth",
            "Vigoroth",
            "Slaking",
            "Nincada",
            "Ninjask",
            "Shedinja",
            "Whismur",
            "Loudred",
            "Exploud",
            "Makuhita",
            "Hariyama",
            "Azurill",
            "Nosepass",
            "Skitty",
            "Delcatty",
            "Sableye",
            "Mawile",
            "Aron",
            "Lairon",
            "Aggron",
            "Meditite",
            "Medicham",
            "Electrike",
            "Manectric",
            "Plusle",
            "Minun",
            "Volbeat",
            "Illumise",
            "Roselia",
            "Gulpin",
            "Swalot",
            "Carvanha",
            "Sharpedo",
            "Wailmer",
            "Wailord",
            "Numel",
            "Camerupt",
            "Torkoal",
            "Spoink",
            "Grumpig",
            "Spinda",
            "Trapinch",
            "Vibrava",
            "Flygon",
            "Cacnea",
            "Cacturne",
            "Swablu",
            "Altaria",
            "Zangoose",
            "Seviper",
            "Lunatone",
            "Solrock",
            "Barboach",
            "Whiscash",
            "Corphish",
            "Crawdaunt",
            "Baltoy",
            "Claydol",
            "Lileep",
            "Cradily",
            "Anorith",
            "Armaldo",
            "Feebas",
            "Milotic",
            "Castform",
            "Kecleon",
            "Shuppet",
            "Banette",
            "Duskull",
            "Dusclops",
            "Tropius",
            "Chimecho",
            "Absol",
            "Wynaut",
            "Snorunt",
            "Glalie",
            "Spheal",
            "Sealeo",
            "Walrein",
            "Clamperl",
            "Huntail",
            "Gorebyss",
            "Relicanth",
            "Luvdisc",
            "Bagon",
            "Shelgon",
            "Salamence",
            "Beldum",
            "Metang",
            "Metagross",
            "Regirock",
            "Regice",
            "Registeel",
            "Latias",
            "Latios",
            "Kyogre",
            "Groudon",
            "Rayquaza",
            "Jirachi",
            "Deoxys",
            "Egg"});
            this.pokeSpecies.Location = new System.Drawing.Point(13, 28);
            this.pokeSpecies.Name = "pokeSpecies";
            this.pokeSpecies.Size = new System.Drawing.Size(87, 21);
            this.pokeSpecies.TabIndex = 7;
            this.pokeSpecies.SelectedIndexChanged += new System.EventHandler(this.pokeSpecies_IndexChanged);
            // 
            // speciesL
            // 
            this.speciesL.AutoSize = true;
            this.speciesL.Location = new System.Drawing.Point(106, 31);
            this.speciesL.Name = "speciesL";
            this.speciesL.Size = new System.Drawing.Size(45, 13);
            this.speciesL.TabIndex = 8;
            this.speciesL.Text = "Species";
            // 
            // boxData
            // 
            this.boxData.AllowUserToAddRows = false;
            this.boxData.AllowUserToDeleteRows = false;
            this.boxData.AllowUserToResizeColumns = false;
            this.boxData.AllowUserToResizeRows = false;
            this.boxData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.boxData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.boxData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boxData.ColumnHeadersVisible = false;
            this.boxData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Poke1,
            this.Poke2,
            this.poke3,
            this.poke4,
            this.poke5,
            this.poke6});
            this.boxData.Location = new System.Drawing.Point(236, 31);
            this.boxData.MultiSelect = false;
            this.boxData.Name = "boxData";
            this.boxData.ReadOnly = true;
            this.boxData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.boxData.RowHeadersVisible = false;
            this.boxData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.boxData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.boxData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.boxData.Size = new System.Drawing.Size(304, 217);
            this.boxData.TabIndex = 9;
            // 
            // Poke1
            // 
            this.Poke1.ContextMenuStrip = this.cellMenu;
            this.Poke1.HeaderText = "i1";
            this.Poke1.Name = "Poke1";
            this.Poke1.ReadOnly = true;
            // 
            // cellMenu
            // 
            this.cellMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPoke,
            this.setPoke});
            this.cellMenu.Name = "cellMenu";
            this.cellMenu.Size = new System.Drawing.Size(100, 48);
            // 
            // viewPoke
            // 
            this.viewPoke.Name = "viewPoke";
            this.viewPoke.Size = new System.Drawing.Size(99, 22);
            this.viewPoke.Text = "View";
            this.viewPoke.Click += new System.EventHandler(this.viewPoke_Click);
            // 
            // setPoke
            // 
            this.setPoke.Name = "setPoke";
            this.setPoke.Size = new System.Drawing.Size(99, 22);
            this.setPoke.Text = "Set";
            this.setPoke.Click += new System.EventHandler(this.setPoke_Click);
            // 
            // Poke2
            // 
            this.Poke2.HeaderText = "i2";
            this.Poke2.Name = "Poke2";
            this.Poke2.ReadOnly = true;
            // 
            // poke3
            // 
            this.poke3.HeaderText = "i3";
            this.poke3.Name = "poke3";
            this.poke3.ReadOnly = true;
            // 
            // poke4
            // 
            this.poke4.HeaderText = "i4";
            this.poke4.Name = "poke4";
            this.poke4.ReadOnly = true;
            // 
            // poke5
            // 
            this.poke5.HeaderText = "i5";
            this.poke5.Name = "poke5";
            this.poke5.ReadOnly = true;
            // 
            // poke6
            // 
            this.poke6.HeaderText = "i6";
            this.poke6.Name = "poke6";
            this.poke6.ReadOnly = true;
            // 
            // EditorWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(552, 260);
            this.Controls.Add(this.boxData);
            this.Controls.Add(this.speciesL);
            this.Controls.Add(this.pokeSpecies);
            this.Controls.Add(this.trainerInfo);
            this.Controls.Add(this.toolMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.toolMenu;
            this.MaximizeBox = false;
            this.Name = "EditorWin";
            this.Text = "Poke Edit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxData)).EndInit();
            this.cellMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button trainerInfo;
        private System.Windows.Forms.MenuStrip toolMenu;
        private System.Windows.Forms.ComboBox pokeSpecies;
        private System.Windows.Forms.Label speciesL;
        private System.Windows.Forms.DataGridView boxData;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ContextMenuStrip cellMenu;
        private System.Windows.Forms.ToolStripMenuItem viewPoke;
        private System.Windows.Forms.ToolStripMenuItem setPoke;
        private System.Windows.Forms.DataGridViewImageColumn Poke1;
        private System.Windows.Forms.DataGridViewImageColumn Poke2;
        private System.Windows.Forms.DataGridViewImageColumn poke3;
        private System.Windows.Forms.DataGridViewImageColumn poke4;
        private System.Windows.Forms.DataGridViewImageColumn poke5;
        private System.Windows.Forms.DataGridViewImageColumn poke6;
    }
}

