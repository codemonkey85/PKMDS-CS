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
            this.tablelayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.AutoSize = true;
            this.buttonOk.Location = new System.Drawing.Point(190, 4);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(40, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApply.AutoSize = true;
            this.buttonApply.Location = new System.Drawing.Point(48, 4);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(43, 23);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(326, 4);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 23);
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
            this.tablelayoutButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablelayoutButtons.Name = "tablelayoutButtons";
            this.tablelayoutButtons.RowCount = 1;
            this.tablelayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelayoutButtons.Size = new System.Drawing.Size(422, 31);
            this.tablelayoutButtons.TabIndex = 3;
            // 
            // pbSprite
            // 
            this.pbSprite.Location = new System.Drawing.Point(325, 11);
            this.pbSprite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(86, 36);
            this.pbSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSprite.TabIndex = 4;
            this.pbSprite.TabStop = false;
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.speciesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(325, 51);
            this.speciesComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(86, 21);
            this.speciesComboBox.TabIndex = 5;
            // 
            // Pokemon_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 321);
            this.Controls.Add(this.speciesComboBox);
            this.Controls.Add(this.pbSprite);
            this.Controls.Add(this.tablelayoutButtons);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pokemon_Editor";
            this.Text = "Pokemon_Editor";
            this.tablelayoutButtons.ResumeLayout(false);
            this.tablelayoutButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tablelayoutButtons;
        private System.Windows.Forms.PictureBox pbSprite;
        private System.Windows.Forms.ComboBox speciesComboBox;
    }
}