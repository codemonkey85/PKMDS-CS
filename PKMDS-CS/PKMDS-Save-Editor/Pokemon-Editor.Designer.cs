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
            this.tablelayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.AutoSize = true;
            this.buttonOk.Location = new System.Drawing.Point(286, 3);
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
            this.buttonApply.Location = new System.Drawing.Point(62, 3);
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
            this.buttonCancel.Location = new System.Drawing.Point(476, 3);
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
            this.tablelayoutButtons.Location = new System.Drawing.Point(0, 446);
            this.tablelayoutButtons.Name = "tablelayoutButtons";
            this.tablelayoutButtons.RowCount = 1;
            this.tablelayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelayoutButtons.Size = new System.Drawing.Size(633, 48);
            this.tablelayoutButtons.TabIndex = 3;
            // 
            // pbSprite
            // 
            this.pbSprite.Location = new System.Drawing.Point(488, 17);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(129, 55);
            this.pbSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSprite.TabIndex = 4;
            this.pbSprite.TabStop = false;
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.speciesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(488, 78);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(127, 28);
            this.speciesComboBox.TabIndex = 5;
            // 
            // textNickname
            // 
            this.textNickname.Location = new System.Drawing.Point(337, 17);
            this.textNickname.MaxLength = 12;
            this.textNickname.Name = "textNickname";
            this.textNickname.Size = new System.Drawing.Size(145, 26);
            this.textNickname.TabIndex = 6;
            // 
            // checkNicknamed
            // 
            this.checkNicknamed.AutoSize = true;
            this.checkNicknamed.Location = new System.Drawing.Point(369, 48);
            this.checkNicknamed.Name = "checkNicknamed";
            this.checkNicknamed.Size = new System.Drawing.Size(114, 24);
            this.checkNicknamed.TabIndex = 7;
            this.checkNicknamed.Text = "Nicknamed";
            this.checkNicknamed.UseVisualStyleBackColor = true;
            // 
            // Pokemon_Editor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 494);
            this.Controls.Add(this.checkNicknamed);
            this.Controls.Add(this.textNickname);
            this.Controls.Add(this.speciesComboBox);
            this.Controls.Add(this.pbSprite);
            this.Controls.Add(this.tablelayoutButtons);
            this.Name = "Pokemon_Editor_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pokemon_Editor";
            this.tablelayoutButtons.ResumeLayout(false);
            this.tablelayoutButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
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
    }
}