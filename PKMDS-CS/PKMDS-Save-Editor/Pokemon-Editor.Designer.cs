namespace PKMDS_Save_Editor
{
    partial class Pokemon_Editor_Form
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tablelayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.pbSprite = new System.Windows.Forms.PictureBox();
            this.speciesComboBox = new System.Windows.Forms.ComboBox();
            this.textNickname = new System.Windows.Forms.TextBox();
            this.checkNicknamed = new System.Windows.Forms.CheckBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.pokemonTabControl = new System.Windows.Forms.TabControl();
            this.statsTabPage = new System.Windows.Forms.TabPage();
            this.movesTabPage = new System.Windows.Forms.TabPage();
            this.historyTabPage = new System.Windows.Forms.TabPage();
            this.contestTabPage = new System.Windows.Forms.TabPage();
            this.ribbonsTabPage = new System.Windows.Forms.TabPage();
            this.genderPictureBox = new System.Windows.Forms.PictureBox();
            this.markingsPanel = new System.Windows.Forms.Panel();
            this.numericLevel = new System.Windows.Forms.NumericUpDown();
            this.labelHeldItem = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.picType1 = new System.Windows.Forms.PictureBox();
            this.picType2 = new System.Windows.Forms.PictureBox();
            this.formsComboBox = new System.Windows.Forms.ComboBox();
            this.labelForm = new System.Windows.Forms.Label();
            this.pbPentagon = new System.Windows.Forms.PictureBox();
            this.textOTName = new System.Windows.Forms.TextBox();
            this.radioOTMale = new System.Windows.Forms.RadioButton();
            this.radioOTFemale = new System.Windows.Forms.RadioButton();
            this.grouOT = new System.Windows.Forms.GroupBox();
            this.tablelayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.pokemonTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPentagon)).BeginInit();
            this.grouOT.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.AutoSize = true;
            this.buttonOk.Location = new System.Drawing.Point(331, 2);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(40, 27);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApply.AutoSize = true;
            this.buttonApply.Location = new System.Drawing.Point(88, 2);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(58, 27);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(551, 2);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(68, 27);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tablelayoutButtons
            // 
            this.tablelayoutButtons.ColumnCount = 3;
            this.tablelayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablelayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablelayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablelayoutButtons.Controls.Add(this.buttonApply, 0, 0);
            this.tablelayoutButtons.Controls.Add(this.buttonCancel, 2, 0);
            this.tablelayoutButtons.Controls.Add(this.buttonOk, 1, 0);
            this.tablelayoutButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablelayoutButtons.Location = new System.Drawing.Point(0, 493);
            this.tablelayoutButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablelayoutButtons.Name = "tablelayoutButtons";
            this.tablelayoutButtons.RowCount = 1;
            this.tablelayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelayoutButtons.Size = new System.Drawing.Size(702, 31);
            this.tablelayoutButtons.TabIndex = 13;
            // 
            // pbSprite
            // 
            this.pbSprite.Location = new System.Drawing.Point(114, 8);
            this.pbSprite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(80, 60);
            this.pbSprite.TabIndex = 4;
            this.pbSprite.TabStop = false;
            this.pbSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint_and_Resize);
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.speciesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(108, 71);
            this.speciesComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(87, 21);
            this.speciesComboBox.TabIndex = 3;
            this.speciesComboBox.SelectedIndexChanged += new System.EventHandler(this.speciesComboBox_SelectedIndexChanged);
            // 
            // textNickname
            // 
            this.textNickname.Location = new System.Drawing.Point(8, 8);
            this.textNickname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNickname.MaxLength = 12;
            this.textNickname.Name = "textNickname";
            this.textNickname.Size = new System.Drawing.Size(98, 20);
            this.textNickname.TabIndex = 0;
            // 
            // checkNicknamed
            // 
            this.checkNicknamed.AutoSize = true;
            this.checkNicknamed.Location = new System.Drawing.Point(30, 32);
            this.checkNicknamed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkNicknamed.Name = "checkNicknamed";
            this.checkNicknamed.Size = new System.Drawing.Size(80, 17);
            this.checkNicknamed.TabIndex = 1;
            this.checkNicknamed.Text = "Nicknamed";
            this.checkNicknamed.UseVisualStyleBackColor = true;
            // 
            // itemComboBox
            // 
            this.itemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(70, 185);
            this.itemComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(125, 21);
            this.itemComboBox.TabIndex = 10;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // pbItemImage
            // 
            this.pbItemImage.Location = new System.Drawing.Point(17, 201);
            this.pbItemImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(49, 32);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbItemImage.TabIndex = 5;
            this.pbItemImage.TabStop = false;
            // 
            // pokemonTabControl
            // 
            this.pokemonTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pokemonTabControl.Controls.Add(this.statsTabPage);
            this.pokemonTabControl.Controls.Add(this.movesTabPage);
            this.pokemonTabControl.Controls.Add(this.historyTabPage);
            this.pokemonTabControl.Controls.Add(this.contestTabPage);
            this.pokemonTabControl.Controls.Add(this.ribbonsTabPage);
            this.pokemonTabControl.HotTrack = true;
            this.pokemonTabControl.Location = new System.Drawing.Point(200, 0);
            this.pokemonTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.pokemonTabControl.Multiline = true;
            this.pokemonTabControl.Name = "pokemonTabControl";
            this.pokemonTabControl.SelectedIndex = 0;
            this.pokemonTabControl.Size = new System.Drawing.Size(503, 493);
            this.pokemonTabControl.TabIndex = 12;
            // 
            // statsTabPage
            // 
            this.statsTabPage.Location = new System.Drawing.Point(4, 22);
            this.statsTabPage.Name = "statsTabPage";
            this.statsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.statsTabPage.Size = new System.Drawing.Size(495, 467);
            this.statsTabPage.TabIndex = 0;
            this.statsTabPage.Text = "Stats";
            this.statsTabPage.UseVisualStyleBackColor = true;
            // 
            // movesTabPage
            // 
            this.movesTabPage.Location = new System.Drawing.Point(4, 22);
            this.movesTabPage.Name = "movesTabPage";
            this.movesTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.movesTabPage.Size = new System.Drawing.Size(495, 467);
            this.movesTabPage.TabIndex = 1;
            this.movesTabPage.Text = "Moves";
            this.movesTabPage.UseVisualStyleBackColor = true;
            // 
            // historyTabPage
            // 
            this.historyTabPage.Location = new System.Drawing.Point(4, 22);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Size = new System.Drawing.Size(495, 467);
            this.historyTabPage.TabIndex = 2;
            this.historyTabPage.Text = "History";
            this.historyTabPage.UseVisualStyleBackColor = true;
            // 
            // contestTabPage
            // 
            this.contestTabPage.Location = new System.Drawing.Point(4, 22);
            this.contestTabPage.Name = "contestTabPage";
            this.contestTabPage.Size = new System.Drawing.Size(495, 467);
            this.contestTabPage.TabIndex = 4;
            this.contestTabPage.Text = "Contest";
            this.contestTabPage.UseVisualStyleBackColor = true;
            // 
            // ribbonsTabPage
            // 
            this.ribbonsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ribbonsTabPage.Name = "ribbonsTabPage";
            this.ribbonsTabPage.Size = new System.Drawing.Size(495, 467);
            this.ribbonsTabPage.TabIndex = 3;
            this.ribbonsTabPage.Text = "Ribbons";
            this.ribbonsTabPage.UseVisualStyleBackColor = true;
            // 
            // genderPictureBox
            // 
            this.genderPictureBox.Location = new System.Drawing.Point(184, 8);
            this.genderPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderPictureBox.Name = "genderPictureBox";
            this.genderPictureBox.Size = new System.Drawing.Size(10, 10);
            this.genderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.genderPictureBox.TabIndex = 7;
            this.genderPictureBox.TabStop = false;
            // 
            // markingsPanel
            // 
            this.markingsPanel.Location = new System.Drawing.Point(70, 139);
            this.markingsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.markingsPanel.Name = "markingsPanel";
            this.markingsPanel.Size = new System.Drawing.Size(124, 21);
            this.markingsPanel.TabIndex = 6;
            // 
            // numericLevel
            // 
            this.numericLevel.Location = new System.Drawing.Point(114, 164);
            this.numericLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLevel.Name = "numericLevel";
            this.numericLevel.Size = new System.Drawing.Size(80, 20);
            this.numericLevel.TabIndex = 8;
            this.numericLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelHeldItem
            // 
            this.labelHeldItem.Location = new System.Drawing.Point(14, 187);
            this.labelHeldItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeldItem.Name = "labelHeldItem";
            this.labelHeldItem.Size = new System.Drawing.Size(52, 13);
            this.labelHeldItem.TabIndex = 9;
            this.labelHeldItem.Text = "Held Item";
            this.labelHeldItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpecies
            // 
            this.labelSpecies.Location = new System.Drawing.Point(57, 71);
            this.labelSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(47, 18);
            this.labelSpecies.TabIndex = 2;
            this.labelSpecies.Text = "Species";
            this.labelSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLevel
            // 
            this.labelLevel.Location = new System.Drawing.Point(76, 164);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(34, 17);
            this.labelLevel.TabIndex = 7;
            this.labelLevel.Text = "Level";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picType1
            // 
            this.picType1.Location = new System.Drawing.Point(57, 116);
            this.picType1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picType1.Name = "picType1";
            this.picType1.Size = new System.Drawing.Size(67, 19);
            this.picType1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picType1.TabIndex = 11;
            this.picType1.TabStop = false;
            // 
            // picType2
            // 
            this.picType2.Location = new System.Drawing.Point(127, 116);
            this.picType2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picType2.Name = "picType2";
            this.picType2.Size = new System.Drawing.Size(67, 19);
            this.picType2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picType2.TabIndex = 12;
            this.picType2.TabStop = false;
            // 
            // formsComboBox
            // 
            this.formsComboBox.FormattingEnabled = true;
            this.formsComboBox.Location = new System.Drawing.Point(47, 94);
            this.formsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formsComboBox.Name = "formsComboBox";
            this.formsComboBox.Size = new System.Drawing.Size(149, 21);
            this.formsComboBox.TabIndex = 5;
            // 
            // labelForm
            // 
            this.labelForm.Location = new System.Drawing.Point(5, 93);
            this.labelForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(37, 18);
            this.labelForm.TabIndex = 4;
            this.labelForm.Text = "Form";
            this.labelForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPentagon
            // 
            this.pbPentagon.Location = new System.Drawing.Point(45, 140);
            this.pbPentagon.Name = "pbPentagon";
            this.pbPentagon.Size = new System.Drawing.Size(20, 20);
            this.pbPentagon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPentagon.TabIndex = 13;
            this.pbPentagon.TabStop = false;
            // 
            // textOTName
            // 
            this.textOTName.Location = new System.Drawing.Point(6, 19);
            this.textOTName.MaxLength = 12;
            this.textOTName.Name = "textOTName";
            this.textOTName.Size = new System.Drawing.Size(170, 20);
            this.textOTName.TabIndex = 0;
            // 
            // radioOTMale
            // 
            this.radioOTMale.AutoSize = true;
            this.radioOTMale.Location = new System.Drawing.Point(6, 45);
            this.radioOTMale.Name = "radioOTMale";
            this.radioOTMale.Size = new System.Drawing.Size(48, 17);
            this.radioOTMale.TabIndex = 1;
            this.radioOTMale.TabStop = true;
            this.radioOTMale.Text = "Male";
            this.radioOTMale.UseVisualStyleBackColor = true;
            // 
            // radioOTFemale
            // 
            this.radioOTFemale.AutoSize = true;
            this.radioOTFemale.Location = new System.Drawing.Point(60, 45);
            this.radioOTFemale.Name = "radioOTFemale";
            this.radioOTFemale.Size = new System.Drawing.Size(59, 17);
            this.radioOTFemale.TabIndex = 2;
            this.radioOTFemale.TabStop = true;
            this.radioOTFemale.Text = "Female";
            this.radioOTFemale.UseVisualStyleBackColor = true;
            // 
            // grouOT
            // 
            this.grouOT.Controls.Add(this.radioOTFemale);
            this.grouOT.Controls.Add(this.textOTName);
            this.grouOT.Controls.Add(this.radioOTMale);
            this.grouOT.Location = new System.Drawing.Point(12, 238);
            this.grouOT.Name = "grouOT";
            this.grouOT.Size = new System.Drawing.Size(182, 70);
            this.grouOT.TabIndex = 11;
            this.grouOT.TabStop = false;
            this.grouOT.Text = "Original Trainer";
            // 
            // Pokemon_Editor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(702, 524);
            this.Controls.Add(this.grouOT);
            this.Controls.Add(this.pbPentagon);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.genderPictureBox);
            this.Controls.Add(this.formsComboBox);
            this.Controls.Add(this.picType2);
            this.Controls.Add(this.picType1);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.pokemonTabControl);
            this.Controls.Add(this.pbSprite);
            this.Controls.Add(this.tablelayoutButtons);
            this.Controls.Add(this.labelSpecies);
            this.Controls.Add(this.textNickname);
            this.Controls.Add(this.speciesComboBox);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.labelHeldItem);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.numericLevel);
            this.Controls.Add(this.markingsPanel);
            this.Controls.Add(this.checkNicknamed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(481, 416);
            this.Name = "Pokemon_Editor_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pokemon_Editor";
            this.Load += new System.EventHandler(this.Pokemon_Editor_Form_Load);
            this.tablelayoutButtons.ResumeLayout(false);
            this.tablelayoutButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.pokemonTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPentagon)).EndInit();
            this.grouOT.ResumeLayout(false);
            this.grouOT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tablelayoutButtons;
        private System.Windows.Forms.PictureBox pbSprite;
        private System.Windows.Forms.ComboBox speciesComboBox;
        private System.Windows.Forms.TextBox textNickname;
        private System.Windows.Forms.CheckBox checkNicknamed;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.TabControl pokemonTabControl;
        private System.Windows.Forms.TabPage statsTabPage;
        private System.Windows.Forms.TabPage movesTabPage;
        private System.Windows.Forms.TabPage historyTabPage;
        private System.Windows.Forms.TabPage contestTabPage;
        private System.Windows.Forms.TabPage ribbonsTabPage;
        private System.Windows.Forms.PictureBox genderPictureBox;
        private System.Windows.Forms.Panel markingsPanel;
        private System.Windows.Forms.NumericUpDown numericLevel;
        private System.Windows.Forms.Label labelHeldItem;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.PictureBox picType1;
        private System.Windows.Forms.PictureBox picType2;
        private System.Windows.Forms.ComboBox formsComboBox;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.PictureBox pbPentagon;
        private System.Windows.Forms.TextBox textOTName;
        private System.Windows.Forms.RadioButton radioOTMale;
        private System.Windows.Forms.RadioButton radioOTFemale;
        private System.Windows.Forms.GroupBox grouOT;
    }
}