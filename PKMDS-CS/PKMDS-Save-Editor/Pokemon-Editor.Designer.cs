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
            this.tablelayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.pokemonTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.AutoSize = true;
            this.buttonOk.Location = new System.Drawing.Point(496, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(60, 42);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApply.AutoSize = true;
            this.buttonApply.Location = new System.Drawing.Point(132, 3);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(87, 42);
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
            this.buttonCancel.Location = new System.Drawing.Point(826, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 42);
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
            this.tablelayoutButtons.Location = new System.Drawing.Point(0, 758);
            this.tablelayoutButtons.Name = "tablelayoutButtons";
            this.tablelayoutButtons.RowCount = 1;
            this.tablelayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelayoutButtons.Size = new System.Drawing.Size(1053, 48);
            this.tablelayoutButtons.TabIndex = 12;
            // 
            // pbSprite
            // 
            this.pbSprite.Location = new System.Drawing.Point(171, 12);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(120, 92);
            this.pbSprite.TabIndex = 4;
            this.pbSprite.TabStop = false;
            this.pbSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint_and_Resize);
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.speciesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(162, 110);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(129, 28);
            this.speciesComboBox.TabIndex = 3;
            this.speciesComboBox.SelectedIndexChanged += new System.EventHandler(this.speciesComboBox_SelectedIndexChanged);
            // 
            // textNickname
            // 
            this.textNickname.Location = new System.Drawing.Point(12, 12);
            this.textNickname.MaxLength = 12;
            this.textNickname.Name = "textNickname";
            this.textNickname.Size = new System.Drawing.Size(145, 26);
            this.textNickname.TabIndex = 0;
            // 
            // checkNicknamed
            // 
            this.checkNicknamed.AutoSize = true;
            this.checkNicknamed.Location = new System.Drawing.Point(45, 49);
            this.checkNicknamed.Name = "checkNicknamed";
            this.checkNicknamed.Size = new System.Drawing.Size(114, 24);
            this.checkNicknamed.TabIndex = 1;
            this.checkNicknamed.Text = "Nicknamed";
            this.checkNicknamed.UseVisualStyleBackColor = true;
            // 
            // itemComboBox
            // 
            this.itemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(105, 284);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(186, 28);
            this.itemComboBox.TabIndex = 10;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // pbItemImage
            // 
            this.pbItemImage.Location = new System.Drawing.Point(25, 310);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(74, 49);
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
            this.pokemonTabControl.Location = new System.Drawing.Point(300, 0);
            this.pokemonTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.pokemonTabControl.Multiline = true;
            this.pokemonTabControl.Name = "pokemonTabControl";
            this.pokemonTabControl.SelectedIndex = 0;
            this.pokemonTabControl.Size = new System.Drawing.Size(755, 758);
            this.pokemonTabControl.TabIndex = 11;
            // 
            // statsTabPage
            // 
            this.statsTabPage.Location = new System.Drawing.Point(4, 29);
            this.statsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statsTabPage.Name = "statsTabPage";
            this.statsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statsTabPage.Size = new System.Drawing.Size(747, 725);
            this.statsTabPage.TabIndex = 0;
            this.statsTabPage.Text = "Stats";
            this.statsTabPage.UseVisualStyleBackColor = true;
            // 
            // movesTabPage
            // 
            this.movesTabPage.Location = new System.Drawing.Point(4, 29);
            this.movesTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movesTabPage.Name = "movesTabPage";
            this.movesTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movesTabPage.Size = new System.Drawing.Size(747, 725);
            this.movesTabPage.TabIndex = 1;
            this.movesTabPage.Text = "Moves";
            this.movesTabPage.UseVisualStyleBackColor = true;
            // 
            // historyTabPage
            // 
            this.historyTabPage.Location = new System.Drawing.Point(4, 29);
            this.historyTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Size = new System.Drawing.Size(747, 725);
            this.historyTabPage.TabIndex = 2;
            this.historyTabPage.Text = "History";
            this.historyTabPage.UseVisualStyleBackColor = true;
            // 
            // contestTabPage
            // 
            this.contestTabPage.Location = new System.Drawing.Point(4, 29);
            this.contestTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contestTabPage.Name = "contestTabPage";
            this.contestTabPage.Size = new System.Drawing.Size(747, 725);
            this.contestTabPage.TabIndex = 4;
            this.contestTabPage.Text = "Contest";
            this.contestTabPage.UseVisualStyleBackColor = true;
            // 
            // ribbonsTabPage
            // 
            this.ribbonsTabPage.Location = new System.Drawing.Point(4, 29);
            this.ribbonsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonsTabPage.Name = "ribbonsTabPage";
            this.ribbonsTabPage.Size = new System.Drawing.Size(747, 725);
            this.ribbonsTabPage.TabIndex = 3;
            this.ribbonsTabPage.Text = "Ribbons";
            this.ribbonsTabPage.UseVisualStyleBackColor = true;
            // 
            // genderPictureBox
            // 
            this.genderPictureBox.Location = new System.Drawing.Point(276, 12);
            this.genderPictureBox.Name = "genderPictureBox";
            this.genderPictureBox.Size = new System.Drawing.Size(15, 15);
            this.genderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.genderPictureBox.TabIndex = 7;
            this.genderPictureBox.TabStop = false;
            // 
            // markingsPanel
            // 
            this.markingsPanel.Location = new System.Drawing.Point(105, 214);
            this.markingsPanel.Name = "markingsPanel";
            this.markingsPanel.Size = new System.Drawing.Size(186, 32);
            this.markingsPanel.TabIndex = 6;
            // 
            // numericLevel
            // 
            this.numericLevel.Location = new System.Drawing.Point(171, 252);
            this.numericLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLevel.Name = "numericLevel";
            this.numericLevel.Size = new System.Drawing.Size(120, 26);
            this.numericLevel.TabIndex = 8;
            this.numericLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelHeldItem
            // 
            this.labelHeldItem.Location = new System.Drawing.Point(21, 287);
            this.labelHeldItem.Name = "labelHeldItem";
            this.labelHeldItem.Size = new System.Drawing.Size(78, 20);
            this.labelHeldItem.TabIndex = 9;
            this.labelHeldItem.Text = "Held Item";
            this.labelHeldItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpecies
            // 
            this.labelSpecies.Location = new System.Drawing.Point(85, 110);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(71, 28);
            this.labelSpecies.TabIndex = 2;
            this.labelSpecies.Text = "Species";
            this.labelSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLevel
            // 
            this.labelLevel.Location = new System.Drawing.Point(114, 252);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(51, 26);
            this.labelLevel.TabIndex = 7;
            this.labelLevel.Text = "Level";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picType1
            // 
            this.picType1.Location = new System.Drawing.Point(85, 178);
            this.picType1.Name = "picType1";
            this.picType1.Size = new System.Drawing.Size(100, 30);
            this.picType1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picType1.TabIndex = 11;
            this.picType1.TabStop = false;
            // 
            // picType2
            // 
            this.picType2.Location = new System.Drawing.Point(191, 178);
            this.picType2.Name = "picType2";
            this.picType2.Size = new System.Drawing.Size(100, 30);
            this.picType2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picType2.TabIndex = 12;
            this.picType2.TabStop = false;
            // 
            // formsComboBox
            // 
            this.formsComboBox.FormattingEnabled = true;
            this.formsComboBox.Location = new System.Drawing.Point(70, 144);
            this.formsComboBox.Name = "formsComboBox";
            this.formsComboBox.Size = new System.Drawing.Size(221, 28);
            this.formsComboBox.TabIndex = 5;
            // 
            // labelForm
            // 
            this.labelForm.Location = new System.Drawing.Point(8, 143);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(56, 28);
            this.labelForm.TabIndex = 4;
            this.labelForm.Text = "Form";
            this.labelForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pokemon_Editor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1053, 806);
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
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(714, 619);
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
    }
}