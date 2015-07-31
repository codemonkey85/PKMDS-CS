namespace PKMDS_Save_Editor
{
    partial class ItemForm
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
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.numericItemQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pbItemImage
            // 
            this.pbItemImage.Location = new System.Drawing.Point(14, 23);
            this.pbItemImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(49, 32);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbItemImage.TabIndex = 11;
            this.pbItemImage.TabStop = false;
            // 
            // labelItem
            // 
            this.labelItem.Location = new System.Drawing.Point(11, 9);
            this.labelItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(52, 13);
            this.labelItem.TabIndex = 12;
            this.labelItem.Text = "Held Item";
            this.labelItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemComboBox
            // 
            this.itemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(67, 7);
            this.itemComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(125, 21);
            this.itemComboBox.TabIndex = 13;
            // 
            // numericItemQuantity
            // 
            this.numericItemQuantity.Location = new System.Drawing.Point(72, 35);
            this.numericItemQuantity.Name = "numericItemQuantity";
            this.numericItemQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericItemQuantity.TabIndex = 14;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 294);
            this.Controls.Add(this.numericItemQuantity);
            this.Controls.Add(this.pbItemImage);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.itemComboBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericItemQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.NumericUpDown numericItemQuantity;
    }
}