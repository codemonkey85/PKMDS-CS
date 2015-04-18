namespace PKMDS_Save_Editor
{
    partial class PKMDS_Save_Editor
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.pbSpeciesImage = new System.Windows.Forms.PictureBox();
            this.cbSpecies = new System.Windows.Forms.ComboBox();
            this.numForm = new System.Windows.Forms.NumericUpDown();
            this.cbPokemonGender = new System.Windows.Forms.ComboBox();
            this.pbPokemonImageLarge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeciesImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemonImageLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 44);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Location = new System.Drawing.Point(12, 12);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(200, 26);
            this.txtIdentifier.TabIndex = 0;
            this.txtIdentifier.TextChanged += new System.EventHandler(this.txtIdentifier_TextChanged);
            // 
            // cbItems
            // 
            this.cbItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(218, 10);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(200, 28);
            this.cbItems.TabIndex = 1;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // pbItemImage
            // 
            this.pbItemImage.Location = new System.Drawing.Point(218, 44);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(200, 200);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbItemImage.TabIndex = 2;
            this.pbItemImage.TabStop = false;
            // 
            // pbSpeciesImage
            // 
            this.pbSpeciesImage.Location = new System.Drawing.Point(424, 44);
            this.pbSpeciesImage.Name = "pbSpeciesImage";
            this.pbSpeciesImage.Size = new System.Drawing.Size(50, 50);
            this.pbSpeciesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSpeciesImage.TabIndex = 4;
            this.pbSpeciesImage.TabStop = false;
            // 
            // cbSpecies
            // 
            this.cbSpecies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSpecies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Location = new System.Drawing.Point(424, 10);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(200, 28);
            this.cbSpecies.TabIndex = 2;
            this.cbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbSpecies_SelectedIndexChanged);
            // 
            // numForm
            // 
            this.numForm.Location = new System.Drawing.Point(630, 12);
            this.numForm.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numForm.Name = "numForm";
            this.numForm.Size = new System.Drawing.Size(121, 26);
            this.numForm.TabIndex = 5;
            this.numForm.ValueChanged += new System.EventHandler(this.numForm_ValueChanged);
            // 
            // cbPokemonGender
            // 
            this.cbPokemonGender.FormattingEnabled = true;
            this.cbPokemonGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Genderless"});
            this.cbPokemonGender.Location = new System.Drawing.Point(630, 44);
            this.cbPokemonGender.Name = "cbPokemonGender";
            this.cbPokemonGender.Size = new System.Drawing.Size(121, 28);
            this.cbPokemonGender.TabIndex = 6;
            this.cbPokemonGender.SelectedIndexChanged += new System.EventHandler(this.cbPokemonGender_SelectedIndexChanged);
            // 
            // pbPokemonImageLarge
            // 
            this.pbPokemonImageLarge.Location = new System.Drawing.Point(424, 100);
            this.pbPokemonImageLarge.Name = "pbPokemonImageLarge";
            this.pbPokemonImageLarge.Size = new System.Drawing.Size(160, 120);
            this.pbPokemonImageLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPokemonImageLarge.TabIndex = 7;
            this.pbPokemonImageLarge.TabStop = false;
            // 
            // PKMDS_Save_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 530);
            this.Controls.Add(this.pbPokemonImageLarge);
            this.Controls.Add(this.cbPokemonGender);
            this.Controls.Add(this.numForm);
            this.Controls.Add(this.pbSpeciesImage);
            this.Controls.Add(this.cbSpecies);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.txtIdentifier);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PKMDS_Save_Editor";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PKMDS_Save_Editor_FormClosing);
            this.Load += new System.EventHandler(this.PKMDS_Save_Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeciesImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemonImageLarge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.PictureBox pbSpeciesImage;
        private System.Windows.Forms.ComboBox cbSpecies;
        private System.Windows.Forms.NumericUpDown numForm;
        private System.Windows.Forms.ComboBox cbPokemonGender;
        private System.Windows.Forms.PictureBox pbPokemonImageLarge;

    }
}

