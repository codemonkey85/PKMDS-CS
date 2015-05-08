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
            this.ribbonsTabPage = new System.Windows.Forms.TabPage();
            this.contestTabPage = new System.Windows.Forms.TabPage();
            this.tablelayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.pokemonTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.AutoSize = true;
            this.buttonOk.Location = new System.Drawing.Point(212, 2);
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
            this.buttonApply.Location = new System.Drawing.Point(48, 2);
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
            this.buttonCancel.Location = new System.Drawing.Point(354, 2);
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
            this.tablelayoutButtons.Location = new System.Drawing.Point(0, 353);
            this.tablelayoutButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablelayoutButtons.Name = "tablelayoutButtons";
            this.tablelayoutButtons.RowCount = 1;
            this.tablelayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelayoutButtons.Size = new System.Drawing.Size(467, 31);
            this.tablelayoutButtons.TabIndex = 4;
            // 
            // pbSprite
            // 
            this.pbSprite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSprite.Location = new System.Drawing.Point(376, 11);
            this.pbSprite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(80, 60);
            this.pbSprite.TabIndex = 4;
            this.pbSprite.TabStop = false;
            this.pbSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSprite_Paint);
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speciesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.speciesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(370, 75);
            this.speciesComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(86, 21);
            this.speciesComboBox.TabIndex = 2;
            // 
            // textNickname
            // 
            this.textNickname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textNickname.Location = new System.Drawing.Point(270, 11);
            this.textNickname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNickname.MaxLength = 12;
            this.textNickname.Name = "textNickname";
            this.textNickname.Size = new System.Drawing.Size(98, 20);
            this.textNickname.TabIndex = 0;
            // 
            // checkNicknamed
            // 
            this.checkNicknamed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkNicknamed.AutoSize = true;
            this.checkNicknamed.Location = new System.Drawing.Point(288, 35);
            this.checkNicknamed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkNicknamed.Name = "checkNicknamed";
            this.checkNicknamed.Size = new System.Drawing.Size(80, 17);
            this.checkNicknamed.TabIndex = 1;
            this.checkNicknamed.Text = "Nicknamed";
            this.checkNicknamed.UseVisualStyleBackColor = true;
            // 
            // itemComboBox
            // 
            this.itemComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(331, 100);
            this.itemComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(125, 21);
            this.itemComboBox.TabIndex = 3;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // pbItemImage
            // 
            this.pbItemImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbItemImage.Location = new System.Drawing.Point(331, 64);
            this.pbItemImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(33, 32);
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
            this.pokemonTabControl.Location = new System.Drawing.Point(12, 12);
            this.pokemonTabControl.Name = "pokemonTabControl";
            this.pokemonTabControl.SelectedIndex = 0;
            this.pokemonTabControl.Size = new System.Drawing.Size(253, 336);
            this.pokemonTabControl.TabIndex = 6;
            // 
            // statsTabPage
            // 
            this.statsTabPage.Location = new System.Drawing.Point(4, 22);
            this.statsTabPage.Name = "statsTabPage";
            this.statsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statsTabPage.Size = new System.Drawing.Size(245, 310);
            this.statsTabPage.TabIndex = 0;
            this.statsTabPage.Text = "Stats";
            this.statsTabPage.UseVisualStyleBackColor = true;
            // 
            // movesTabPage
            // 
            this.movesTabPage.Location = new System.Drawing.Point(4, 22);
            this.movesTabPage.Name = "movesTabPage";
            this.movesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.movesTabPage.Size = new System.Drawing.Size(200, 247);
            this.movesTabPage.TabIndex = 1;
            this.movesTabPage.Text = "Moves";
            this.movesTabPage.UseVisualStyleBackColor = true;
            // 
            // historyTabPage
            // 
            this.historyTabPage.Location = new System.Drawing.Point(4, 22);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Size = new System.Drawing.Size(200, 247);
            this.historyTabPage.TabIndex = 2;
            this.historyTabPage.Text = "History";
            this.historyTabPage.UseVisualStyleBackColor = true;
            // 
            // ribbonsTabPage
            // 
            this.ribbonsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ribbonsTabPage.Name = "ribbonsTabPage";
            this.ribbonsTabPage.Size = new System.Drawing.Size(200, 247);
            this.ribbonsTabPage.TabIndex = 3;
            this.ribbonsTabPage.Text = "Ribbons";
            this.ribbonsTabPage.UseVisualStyleBackColor = true;
            // 
            // contestTabPage
            // 
            this.contestTabPage.Location = new System.Drawing.Point(4, 22);
            this.contestTabPage.Name = "contestTabPage";
            this.contestTabPage.Size = new System.Drawing.Size(200, 247);
            this.contestTabPage.TabIndex = 4;
            this.contestTabPage.Text = "Contest";
            this.contestTabPage.UseVisualStyleBackColor = true;
            // 
            // Pokemon_Editor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 384);
            this.Controls.Add(this.pokemonTabControl);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.checkNicknamed);
            this.Controls.Add(this.textNickname);
            this.Controls.Add(this.speciesComboBox);
            this.Controls.Add(this.pbSprite);
            this.Controls.Add(this.tablelayoutButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(483, 422);
            this.Name = "Pokemon_Editor_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pokemon_Editor";
            this.tablelayoutButtons.ResumeLayout(false);
            this.tablelayoutButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.pokemonTabControl.ResumeLayout(false);
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
    }
}