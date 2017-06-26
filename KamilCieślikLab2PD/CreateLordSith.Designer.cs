namespace KamilCieślikLab2PD
{
    partial class CreateLordSith
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLordSith));
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelGiveData = new System.Windows.Forms.Label();
            this.buttonAddSith = new System.Windows.Forms.Button();
            this.labelYearOfDeath = new System.Windows.Forms.Label();
            this.labelAmountOfKilledJedi = new System.Windows.Forms.Label();
            this.labelLightSaberCombat = new System.Windows.Forms.Label();
            this.labelColourOfLightSaber = new System.Windows.Forms.Label();
            this.labelWasJedi = new System.Windows.Forms.Label();
            this.labelYearOfBirth = new System.Windows.Forms.Label();
            this.labelPlanet = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxYearOfDeath = new System.Windows.Forms.TextBox();
            this.textBoxAmountOfKilledJedi = new System.Windows.Forms.TextBox();
            this.comboBoxLightSaberCombat = new System.Windows.Forms.ComboBox();
            this.comboBoxColourOfLightsaber = new System.Windows.Forms.ComboBox();
            this.checkBoxWasJedi = new System.Windows.Forms.CheckBox();
            this.textBoxYearOfBirth = new System.Windows.Forms.TextBox();
            this.comboBoxPlanet = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.pictureBoxStarWars = new System.Windows.Forms.PictureBox();
            this.pictureBoxSithImage = new System.Windows.Forms.PictureBox();
            this.labelKindOfPossesedArmy = new System.Windows.Forms.Label();
            this.labelNumberOfHolocrones = new System.Windows.Forms.Label();
            this.labelSpecialPower = new System.Windows.Forms.Label();
            this.comboBoxKindOfPossesedArmy = new System.Windows.Forms.ComboBox();
            this.textBoxNumberOfHolocrones = new System.Windows.Forms.TextBox();
            this.comboBoxSpecialPower = new System.Windows.Forms.ComboBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonChooseImage = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStarWars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSithImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(402, 536);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(320, 20);
            this.textBoxPath.TabIndex = 46;
            this.textBoxPath.Visible = false;
            // 
            // labelGiveData
            // 
            this.labelGiveData.AutoSize = true;
            this.labelGiveData.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGiveData.Location = new System.Drawing.Point(36, 72);
            this.labelGiveData.Name = "labelGiveData";
            this.labelGiveData.Size = new System.Drawing.Size(201, 42);
            this.labelGiveData.TabIndex = 43;
            this.labelGiveData.Text = "Podaj dane:";
            // 
            // buttonAddSith
            // 
            this.buttonAddSith.Location = new System.Drawing.Point(44, 611);
            this.buttonAddSith.Name = "buttonAddSith";
            this.buttonAddSith.Size = new System.Drawing.Size(309, 47);
            this.buttonAddSith.TabIndex = 42;
            this.buttonAddSith.Text = "Dodaj";
            this.buttonAddSith.UseVisualStyleBackColor = true;
            this.buttonAddSith.Click += new System.EventHandler(this.buttonAddSith_Click);
            // 
            // labelYearOfDeath
            // 
            this.labelYearOfDeath.AutoSize = true;
            this.labelYearOfDeath.Location = new System.Drawing.Point(41, 276);
            this.labelYearOfDeath.Name = "labelYearOfDeath";
            this.labelYearOfDeath.Size = new System.Drawing.Size(136, 26);
            this.labelYearOfDeath.TabIndex = 40;
            this.labelYearOfDeath.Text = "Rok śmierci\r\n- pozostawić puste jeśli żyje";
            // 
            // labelAmountOfKilledJedi
            // 
            this.labelAmountOfKilledJedi.AutoSize = true;
            this.labelAmountOfKilledJedi.Location = new System.Drawing.Point(41, 402);
            this.labelAmountOfKilledJedi.Name = "labelAmountOfKilledJedi";
            this.labelAmountOfKilledJedi.Size = new System.Drawing.Size(93, 13);
            this.labelAmountOfKilledJedi.TabIndex = 39;
            this.labelAmountOfKilledJedi.Text = "Ilość zabitych Jedi";
            // 
            // labelLightSaberCombat
            // 
            this.labelLightSaberCombat.AutoSize = true;
            this.labelLightSaberCombat.Location = new System.Drawing.Point(41, 368);
            this.labelLightSaberCombat.Name = "labelLightSaberCombat";
            this.labelLightSaberCombat.Size = new System.Drawing.Size(143, 13);
            this.labelLightSaberCombat.TabIndex = 38;
            this.labelLightSaberCombat.Text = "Styl walki mieczem świetlnym";
            // 
            // labelColourOfLightSaber
            // 
            this.labelColourOfLightSaber.AutoSize = true;
            this.labelColourOfLightSaber.Location = new System.Drawing.Point(41, 333);
            this.labelColourOfLightSaber.Name = "labelColourOfLightSaber";
            this.labelColourOfLightSaber.Size = new System.Drawing.Size(120, 13);
            this.labelColourOfLightSaber.TabIndex = 37;
            this.labelColourOfLightSaber.Text = "Kolor miecza świetlnego";
            // 
            // labelWasJedi
            // 
            this.labelWasJedi.AutoSize = true;
            this.labelWasJedi.Location = new System.Drawing.Point(41, 307);
            this.labelWasJedi.Name = "labelWasJedi";
            this.labelWasJedi.Size = new System.Drawing.Size(69, 13);
            this.labelWasJedi.TabIndex = 36;
            this.labelWasJedi.Text = "Mroczny Jedi";
            // 
            // labelYearOfBirth
            // 
            this.labelYearOfBirth.AutoSize = true;
            this.labelYearOfBirth.Location = new System.Drawing.Point(41, 243);
            this.labelYearOfBirth.Name = "labelYearOfBirth";
            this.labelYearOfBirth.Size = new System.Drawing.Size(76, 13);
            this.labelYearOfBirth.TabIndex = 35;
            this.labelYearOfBirth.Text = "Rok urodzenia";
            // 
            // labelPlanet
            // 
            this.labelPlanet.AutoSize = true;
            this.labelPlanet.Location = new System.Drawing.Point(41, 209);
            this.labelPlanet.Name = "labelPlanet";
            this.labelPlanet.Size = new System.Drawing.Size(43, 13);
            this.labelPlanet.TabIndex = 34;
            this.labelPlanet.Text = "Planeta";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(41, 174);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 13);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Imię";
            // 
            // textBoxYearOfDeath
            // 
            this.textBoxYearOfDeath.Location = new System.Drawing.Point(232, 276);
            this.textBoxYearOfDeath.Name = "textBoxYearOfDeath";
            this.textBoxYearOfDeath.Size = new System.Drawing.Size(121, 20);
            this.textBoxYearOfDeath.TabIndex = 32;
            // 
            // textBoxAmountOfKilledJedi
            // 
            this.textBoxAmountOfKilledJedi.Location = new System.Drawing.Point(232, 402);
            this.textBoxAmountOfKilledJedi.Name = "textBoxAmountOfKilledJedi";
            this.textBoxAmountOfKilledJedi.Size = new System.Drawing.Size(121, 20);
            this.textBoxAmountOfKilledJedi.TabIndex = 31;
            // 
            // comboBoxLightSaberCombat
            // 
            this.comboBoxLightSaberCombat.FormattingEnabled = true;
            this.comboBoxLightSaberCombat.Items.AddRange(new object[] {
            "Forma I - \"Determinacja\"",
            "Forma II - \"Rywalizacja\"",
            "Forma III - \"Wyciszenie\"",
            "Forma IV - \"Wytrwałość\"",
            "Forma V - \"Agresja\"",
            "Forma VI - \"Równowaga\"",
            "Forma VII - \"Zażartość\""});
            this.comboBoxLightSaberCombat.Location = new System.Drawing.Point(232, 368);
            this.comboBoxLightSaberCombat.Name = "comboBoxLightSaberCombat";
            this.comboBoxLightSaberCombat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLightSaberCombat.TabIndex = 30;
            // 
            // comboBoxColourOfLightsaber
            // 
            this.comboBoxColourOfLightsaber.FormattingEnabled = true;
            this.comboBoxColourOfLightsaber.Items.AddRange(new object[] {
            "czerwony",
            "fioletowy",
            "pomarańczowy ",
            "niebieski",
            "zielony",
            "srebrny"});
            this.comboBoxColourOfLightsaber.Location = new System.Drawing.Point(232, 333);
            this.comboBoxColourOfLightsaber.Name = "comboBoxColourOfLightsaber";
            this.comboBoxColourOfLightsaber.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColourOfLightsaber.TabIndex = 29;
            // 
            // checkBoxWasJedi
            // 
            this.checkBoxWasJedi.AutoSize = true;
            this.checkBoxWasJedi.Location = new System.Drawing.Point(284, 307);
            this.checkBoxWasJedi.Name = "checkBoxWasJedi";
            this.checkBoxWasJedi.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWasJedi.TabIndex = 28;
            this.checkBoxWasJedi.UseVisualStyleBackColor = true;
            // 
            // textBoxYearOfBirth
            // 
            this.textBoxYearOfBirth.Location = new System.Drawing.Point(232, 243);
            this.textBoxYearOfBirth.Name = "textBoxYearOfBirth";
            this.textBoxYearOfBirth.Size = new System.Drawing.Size(121, 20);
            this.textBoxYearOfBirth.TabIndex = 27;
            // 
            // comboBoxPlanet
            // 
            this.comboBoxPlanet.FormattingEnabled = true;
            this.comboBoxPlanet.Items.AddRange(new object[] {
            "Aargau",
            "Abanol",
            "Byss ",
            "Centurious",
            "Chardaan",
            "Ebaq",
            "Eclipse",
            "Khomm",
            "Kieł Tarkina",
            "Tython",
            "Alderaan",
            "Anaxes",
            "Corulag",
            "Coruscant",
            "Corellia",
            "Kuat",
            "Duro",
            "Hosnian Prime",
            "Balmorra",
            "Manaan",
            "Bothawui",
            "Kashyyyk",
            "Haruun Kal",
            "Faleen",
            "Naboo",
            "Bakura",
            "Dantooine",
            "Geonosis",
            "Kessel",
            "Mustafar",
            "Ryloth",
            "Tatooine",
            "Yavin",
            "Endor",
            "Lehon"});
            this.comboBoxPlanet.Location = new System.Drawing.Point(232, 209);
            this.comboBoxPlanet.Name = "comboBoxPlanet";
            this.comboBoxPlanet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlanet.TabIndex = 26;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(232, 174);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 25;
            // 
            // pictureBoxStarWars
            // 
            this.pictureBoxStarWars.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStarWars.Image")));
            this.pictureBoxStarWars.Location = new System.Drawing.Point(270, 21);
            this.pictureBoxStarWars.Name = "pictureBoxStarWars";
            this.pictureBoxStarWars.Size = new System.Drawing.Size(507, 145);
            this.pictureBoxStarWars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStarWars.TabIndex = 47;
            this.pictureBoxStarWars.TabStop = false;
            // 
            // pictureBoxSithImage
            // 
            this.pictureBoxSithImage.Location = new System.Drawing.Point(402, 172);
            this.pictureBoxSithImage.Name = "pictureBoxSithImage";
            this.pictureBoxSithImage.Size = new System.Drawing.Size(320, 301);
            this.pictureBoxSithImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSithImage.TabIndex = 45;
            this.pictureBoxSithImage.TabStop = false;
            // 
            // labelKindOfPossesedArmy
            // 
            this.labelKindOfPossesedArmy.AutoSize = true;
            this.labelKindOfPossesedArmy.Location = new System.Drawing.Point(41, 510);
            this.labelKindOfPossesedArmy.Name = "labelKindOfPossesedArmy";
            this.labelKindOfPossesedArmy.Size = new System.Drawing.Size(64, 13);
            this.labelKindOfPossesedArmy.TabIndex = 84;
            this.labelKindOfPossesedArmy.Text = "Rodzaj armii";
            // 
            // labelNumberOfHolocrones
            // 
            this.labelNumberOfHolocrones.AutoSize = true;
            this.labelNumberOfHolocrones.Location = new System.Drawing.Point(41, 477);
            this.labelNumberOfHolocrones.Name = "labelNumberOfHolocrones";
            this.labelNumberOfHolocrones.Size = new System.Drawing.Size(121, 13);
            this.labelNumberOfHolocrones.TabIndex = 83;
            this.labelNumberOfHolocrones.Text = "Liczba HOLOKRONÓW";
            // 
            // labelSpecialPower
            // 
            this.labelSpecialPower.AutoSize = true;
            this.labelSpecialPower.Location = new System.Drawing.Point(41, 438);
            this.labelSpecialPower.Name = "labelSpecialPower";
            this.labelSpecialPower.Size = new System.Drawing.Size(113, 13);
            this.labelSpecialPower.TabIndex = 82;
            this.labelSpecialPower.Text = "Specjalna umiejętność";
            // 
            // comboBoxKindOfPossesedArmy
            // 
            this.comboBoxKindOfPossesedArmy.FormattingEnabled = true;
            this.comboBoxKindOfPossesedArmy.Items.AddRange(new object[] {
            "Armia Żołnierzy - Klonów",
            "Korpus Szturmowców",
            "Armia Imperialna",
            "Armia Nowego Porządku",
            "Armia Mrocznych Jedi",
            "Rycerze Ren",
            "Wielka Armia Droidów"});
            this.comboBoxKindOfPossesedArmy.Location = new System.Drawing.Point(232, 507);
            this.comboBoxKindOfPossesedArmy.Name = "comboBoxKindOfPossesedArmy";
            this.comboBoxKindOfPossesedArmy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKindOfPossesedArmy.TabIndex = 81;
            // 
            // textBoxNumberOfHolocrones
            // 
            this.textBoxNumberOfHolocrones.Location = new System.Drawing.Point(232, 474);
            this.textBoxNumberOfHolocrones.Name = "textBoxNumberOfHolocrones";
            this.textBoxNumberOfHolocrones.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumberOfHolocrones.TabIndex = 80;
            // 
            // comboBoxSpecialPower
            // 
            this.comboBoxSpecialPower.FormattingEnabled = true;
            this.comboBoxSpecialPower.Items.AddRange(new object[] {
            "Zabójczy Wzrok",
            "Korupcja Mocą",
            "Błyskawica Mocy",
            "Duszenie Mocą",
            "Ranienie Mocą",
            "Wyssanie Mocy",
            "Destrukcja Mocą",
            "Zjawa Mocy",
            "Zwolnienie Mocą",
            "Moc Strachu",
            "Krzyk Mocy",
            "Wściekłość Mocy",
            "Moc Ukrycia",
            "Bomba Myśli",
            "Spacer Pamięci",
            "Włócznia Północy",
            "Transfer Esencji"});
            this.comboBoxSpecialPower.Location = new System.Drawing.Point(232, 438);
            this.comboBoxSpecialPower.Name = "comboBoxSpecialPower";
            this.comboBoxSpecialPower.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecialPower.TabIndex = 79;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialog1";
            // 
            // buttonChooseImage
            // 
            this.buttonChooseImage.Location = new System.Drawing.Point(44, 546);
            this.buttonChooseImage.Name = "buttonChooseImage";
            this.buttonChooseImage.Size = new System.Drawing.Size(309, 34);
            this.buttonChooseImage.TabIndex = 85;
            this.buttonChooseImage.Text = "Wybierz wizerunek Lorda Sithów";
            this.buttonChooseImage.UseVisualStyleBackColor = true;
            this.buttonChooseImage.Click += new System.EventHandler(this.buttonChooseImage_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(402, 611);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(309, 47);
            this.buttonClose.TabIndex = 86;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // CreateLordSith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 689);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonChooseImage);
            this.Controls.Add(this.labelKindOfPossesedArmy);
            this.Controls.Add(this.labelNumberOfHolocrones);
            this.Controls.Add(this.labelSpecialPower);
            this.Controls.Add(this.comboBoxKindOfPossesedArmy);
            this.Controls.Add(this.textBoxNumberOfHolocrones);
            this.Controls.Add(this.comboBoxSpecialPower);
            this.Controls.Add(this.pictureBoxStarWars);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.pictureBoxSithImage);
            this.Controls.Add(this.labelGiveData);
            this.Controls.Add(this.buttonAddSith);
            this.Controls.Add(this.labelYearOfDeath);
            this.Controls.Add(this.labelAmountOfKilledJedi);
            this.Controls.Add(this.labelLightSaberCombat);
            this.Controls.Add(this.labelColourOfLightSaber);
            this.Controls.Add(this.labelWasJedi);
            this.Controls.Add(this.labelYearOfBirth);
            this.Controls.Add(this.labelPlanet);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxYearOfDeath);
            this.Controls.Add(this.textBoxAmountOfKilledJedi);
            this.Controls.Add(this.comboBoxLightSaberCombat);
            this.Controls.Add(this.comboBoxColourOfLightsaber);
            this.Controls.Add(this.checkBoxWasJedi);
            this.Controls.Add(this.textBoxYearOfBirth);
            this.Controls.Add(this.comboBoxPlanet);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateLordSith";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateLordSith";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStarWars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSithImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStarWars;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.PictureBox pictureBoxSithImage;
        private System.Windows.Forms.Label labelGiveData;
        private System.Windows.Forms.Button buttonAddSith;
        private System.Windows.Forms.Label labelYearOfDeath;
        private System.Windows.Forms.Label labelAmountOfKilledJedi;
        private System.Windows.Forms.Label labelLightSaberCombat;
        private System.Windows.Forms.Label labelColourOfLightSaber;
        private System.Windows.Forms.Label labelWasJedi;
        private System.Windows.Forms.Label labelYearOfBirth;
        private System.Windows.Forms.Label labelPlanet;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxYearOfDeath;
        private System.Windows.Forms.TextBox textBoxAmountOfKilledJedi;
        private System.Windows.Forms.ComboBox comboBoxLightSaberCombat;
        private System.Windows.Forms.ComboBox comboBoxColourOfLightsaber;
        private System.Windows.Forms.CheckBox checkBoxWasJedi;
        private System.Windows.Forms.TextBox textBoxYearOfBirth;
        private System.Windows.Forms.ComboBox comboBoxPlanet;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelKindOfPossesedArmy;
        private System.Windows.Forms.Label labelNumberOfHolocrones;
        private System.Windows.Forms.Label labelSpecialPower;
        private System.Windows.Forms.ComboBox comboBoxKindOfPossesedArmy;
        private System.Windows.Forms.TextBox textBoxNumberOfHolocrones;
        private System.Windows.Forms.ComboBox comboBoxSpecialPower;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Button buttonChooseImage;
        private System.Windows.Forms.Button buttonClose;
    }
}