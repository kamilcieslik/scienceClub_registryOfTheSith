namespace KamilCieślikLab2PD
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAddSith = new System.Windows.Forms.Button();
            this.dataGridViewSith = new System.Windows.Forms.DataGridView();
            this.buttonDeleteSith = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddLordSith = new System.Windows.Forms.Button();
            this.dataGridViewLordSith = new System.Windows.Forms.DataGridView();
            this.radioButtonShowGridOfLordSith = new System.Windows.Forms.RadioButton();
            this.radioButtonShowGridOfSith = new System.Windows.Forms.RadioButton();
            this.pictureBoxVader = new System.Windows.Forms.PictureBox();
            this.pictureBoxSithImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLordSith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSithImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddSith
            // 
            this.buttonAddSith.Location = new System.Drawing.Point(139, 147);
            this.buttonAddSith.Name = "buttonAddSith";
            this.buttonAddSith.Size = new System.Drawing.Size(100, 70);
            this.buttonAddSith.TabIndex = 0;
            this.buttonAddSith.Text = "Dodaj Sitha";
            this.buttonAddSith.UseVisualStyleBackColor = true;
            this.buttonAddSith.Click += new System.EventHandler(this.buttonAddSith_Click);
            // 
            // dataGridViewSith
            // 
            this.dataGridViewSith.AllowUserToAddRows = false;
            this.dataGridViewSith.AllowUserToDeleteRows = false;
            this.dataGridViewSith.AllowUserToResizeColumns = false;
            this.dataGridViewSith.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSith.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSith.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSith.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSith.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewSith.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSith.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSith.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSith.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSith.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewSith.Location = new System.Drawing.Point(271, 147);
            this.dataGridViewSith.Name = "dataGridViewSith";
            this.dataGridViewSith.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSith.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSith.Size = new System.Drawing.Size(952, 506);
            this.dataGridViewSith.TabIndex = 1;
            this.dataGridViewSith.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSith_CellClick);
            // 
            // buttonDeleteSith
            // 
            this.buttonDeleteSith.Location = new System.Drawing.Point(20, 493);
            this.buttonDeleteSith.Name = "buttonDeleteSith";
            this.buttonDeleteSith.Size = new System.Drawing.Size(219, 60);
            this.buttonDeleteSith.TabIndex = 3;
            this.buttonDeleteSith.Text = "Usuń zaznaczonych Sithów";
            this.buttonDeleteSith.UseVisualStyleBackColor = true;
            this.buttonDeleteSith.Click += new System.EventHandler(this.buttonDeleteSith_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(20, 593);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(219, 60);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(20, 263);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 42);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(139, 263);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 42);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Wczytaj";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.AcceptsReturn = true;
            this.textBoxDetails.AcceptsTab = true;
            this.textBoxDetails.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDetails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDetails.Location = new System.Drawing.Point(1252, 516);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.Size = new System.Drawing.Size(320, 127);
            this.textBoxDetails.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(1252, 137);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(320, 38);
            this.textBoxName.TabIndex = 9;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Gabriola", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(504, -3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(669, 147);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "REGISTRY OF THE SITH";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(20, 413);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(219, 42);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edytuj dane";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddLordSith
            // 
            this.buttonAddLordSith.Location = new System.Drawing.Point(20, 147);
            this.buttonAddLordSith.Name = "buttonAddLordSith";
            this.buttonAddLordSith.Size = new System.Drawing.Size(100, 70);
            this.buttonAddLordSith.TabIndex = 13;
            this.buttonAddLordSith.Text = "Dodaj Lorda Sithów";
            this.buttonAddLordSith.UseVisualStyleBackColor = true;
            this.buttonAddLordSith.Click += new System.EventHandler(this.buttonAddLordSith_Click);
            // 
            // dataGridViewLordSith
            // 
            this.dataGridViewLordSith.AllowUserToAddRows = false;
            this.dataGridViewLordSith.AllowUserToDeleteRows = false;
            this.dataGridViewLordSith.AllowUserToResizeColumns = false;
            this.dataGridViewLordSith.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = "-";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLordSith.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewLordSith.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLordSith.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLordSith.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewLordSith.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.NullValue = "-";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLordSith.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewLordSith.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.NullValue = "-";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLordSith.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewLordSith.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewLordSith.Location = new System.Drawing.Point(271, 147);
            this.dataGridViewLordSith.Name = "dataGridViewLordSith";
            this.dataGridViewLordSith.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.NullValue = "-";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLordSith.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewLordSith.Size = new System.Drawing.Size(952, 506);
            this.dataGridViewLordSith.TabIndex = 14;
            this.dataGridViewLordSith.Visible = false;
            this.dataGridViewLordSith.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLordSith_CellClick);
            // 
            // radioButtonShowGridOfLordSith
            // 
            this.radioButtonShowGridOfLordSith.AutoSize = true;
            this.radioButtonShowGridOfLordSith.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonShowGridOfLordSith.ForeColor = System.Drawing.Color.Maroon;
            this.radioButtonShowGridOfLordSith.Location = new System.Drawing.Point(71, 374);
            this.radioButtonShowGridOfLordSith.Name = "radioButtonShowGridOfLordSith";
            this.radioButtonShowGridOfLordSith.Size = new System.Drawing.Size(139, 17);
            this.radioButtonShowGridOfLordSith.TabIndex = 15;
            this.radioButtonShowGridOfLordSith.TabStop = true;
            this.radioButtonShowGridOfLordSith.Text = "Lista Lordów Sithów";
            this.radioButtonShowGridOfLordSith.UseVisualStyleBackColor = true;
            this.radioButtonShowGridOfLordSith.CheckedChanged += new System.EventHandler(this.radioButtonShowGridOfLordSith_CheckedChanged);
            // 
            // radioButtonShowGridOfSith
            // 
            this.radioButtonShowGridOfSith.AutoSize = true;
            this.radioButtonShowGridOfSith.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonShowGridOfSith.ForeColor = System.Drawing.Color.Maroon;
            this.radioButtonShowGridOfSith.Location = new System.Drawing.Point(71, 332);
            this.radioButtonShowGridOfSith.Name = "radioButtonShowGridOfSith";
            this.radioButtonShowGridOfSith.Size = new System.Drawing.Size(94, 17);
            this.radioButtonShowGridOfSith.TabIndex = 16;
            this.radioButtonShowGridOfSith.TabStop = true;
            this.radioButtonShowGridOfSith.Text = "Lista Sithów";
            this.radioButtonShowGridOfSith.UseVisualStyleBackColor = true;
            this.radioButtonShowGridOfSith.CheckedChanged += new System.EventHandler(this.radioButtonShowGridOfSith_CheckedChanged);
            // 
            // pictureBoxVader
            // 
            this.pictureBoxVader.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVader.Image")));
            this.pictureBoxVader.Location = new System.Drawing.Point(71, 18);
            this.pictureBoxVader.Name = "pictureBoxVader";
            this.pictureBoxVader.Size = new System.Drawing.Size(114, 126);
            this.pictureBoxVader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVader.TabIndex = 11;
            this.pictureBoxVader.TabStop = false;
            // 
            // pictureBoxSithImage
            // 
            this.pictureBoxSithImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSithImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSithImage.ErrorImage")));
            this.pictureBoxSithImage.Location = new System.Drawing.Point(1252, 198);
            this.pictureBoxSithImage.Name = "pictureBoxSithImage";
            this.pictureBoxSithImage.Size = new System.Drawing.Size(320, 301);
            this.pictureBoxSithImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSithImage.TabIndex = 8;
            this.pictureBoxSithImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 678);
            this.Controls.Add(this.radioButtonShowGridOfSith);
            this.Controls.Add(this.radioButtonShowGridOfLordSith);
            this.Controls.Add(this.dataGridViewLordSith);
            this.Controls.Add(this.buttonAddLordSith);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.pictureBoxVader);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBoxSithImage);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDeleteSith);
            this.Controls.Add(this.dataGridViewSith);
            this.Controls.Add(this.buttonAddSith);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLordSith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSithImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddSith;
        private System.Windows.Forms.DataGridView dataGridViewSith;
        private System.Windows.Forms.Button buttonDeleteSith;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.PictureBox pictureBoxSithImage;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxVader;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAddLordSith;
        private System.Windows.Forms.DataGridView dataGridViewLordSith;
        private System.Windows.Forms.RadioButton radioButtonShowGridOfLordSith;
        private System.Windows.Forms.RadioButton radioButtonShowGridOfSith;
    }
}

