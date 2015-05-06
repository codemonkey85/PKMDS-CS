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
            this.tablelayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.AutoSize = true;
            this.buttonOk.Location = new System.Drawing.Point(190, 2);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonApply.Location = new System.Drawing.Point(41, 2);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonCancel.Location = new System.Drawing.Point(317, 2);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
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
            this.tablelayoutButtons.Location = new System.Drawing.Point(0, 290);
            this.tablelayoutButtons.Margin = new System.Windows.Forms.Padding(2);
            this.tablelayoutButtons.Name = "tablelayoutButtons";
            this.tablelayoutButtons.RowCount = 1;
            this.tablelayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelayoutButtons.Size = new System.Drawing.Size(422, 31);
            this.tablelayoutButtons.TabIndex = 4;
            // 
            // pbSprite
            // 
            this.pbSprite.Location = new System.Drawing.Point(331, 11);
            this.pbSprite.Margin = new System.Windows.Forms.Padding(2);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(80, 60);
            this.pbSprite.TabIndex = 4;
            this.pbSprite.TabStop = false;
            this.pbSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSprite_Paint);
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.speciesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(325, 75);
            this.speciesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(86, 21);
            this.speciesComboBox.TabIndex = 2;
            // 
            // textNickname
            // 
            this.textNickname.Location = new System.Drawing.Point(225, 11);
            this.textNickname.Margin = new System.Windows.Forms.Padding(2);
            this.textNickname.MaxLength = 12;
            this.textNickname.Name = "textNickname";
            this.textNickname.Size = new System.Drawing.Size(98, 20);
            this.textNickname.TabIndex = 0;
            // 
            // checkNicknamed
            // 
            this.checkNicknamed.AutoSize = true;
            this.checkNicknamed.Location = new System.Drawing.Point(243, 35);
            this.checkNicknamed.Margin = new System.Windows.Forms.Padding(2);
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
            this.itemComboBox.Location = new System.Drawing.Point(286, 100);
            this.itemComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(125, 21);
            this.itemComboBox.TabIndex = 3;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // pbItemImage
            // 
            this.pbItemImage.Location = new System.Drawing.Point(261, 100);
            this.pbItemImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(21, 21);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbItemImage.TabIndex = 5;
            this.pbItemImage.TabStop = false;
            // 
            // Pokemon_Editor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 321);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.checkNicknamed);
            this.Controls.Add(this.textNickname);
            this.Controls.Add(this.speciesComboBox);
            this.Controls.Add(this.pbSprite);
            this.Controls.Add(this.tablelayoutButtons);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pokemon_Editor_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pokemon_Editor";
            this.tablelayoutButtons.ResumeLayout(false);
            this.tablelayoutButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
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
    }
}