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
            this.dgData = new System.Windows.Forms.DataGridView();
            this.boxesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(11, 11);
            this.dgData.Margin = new System.Windows.Forms.Padding(2);
            this.dgData.Name = "dgData";
            this.dgData.RowTemplate.Height = 28;
            this.dgData.Size = new System.Drawing.Size(475, 315);
            this.dgData.TabIndex = 0;
            // 
            // boxesComboBox
            // 
            this.boxesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxesComboBox.FormattingEnabled = true;
            this.boxesComboBox.Items.AddRange(new object[] {
            "Box 1",
            "Box 2",
            "Box 3",
            "Box 4",
            "Box 5",
            "Box 6",
            "Box 7",
            "Box 8",
            "Box 9",
            "Box 10",
            "Box 11",
            "Box 12",
            "Box 13",
            "Box 14",
            "Box 15",
            "Box 16",
            "Box 17",
            "Box 18",
            "Box 19",
            "Box 20",
            "Box 21",
            "Box 22",
            "Box 23",
            "Box 24",
            "Box 25",
            "Box 26",
            "Box 27",
            "Box 28",
            "Box 29",
            "Box 30",
            "Box 31"});
            this.boxesComboBox.Location = new System.Drawing.Point(12, 331);
            this.boxesComboBox.Name = "boxesComboBox";
            this.boxesComboBox.Size = new System.Drawing.Size(473, 21);
            this.boxesComboBox.TabIndex = 1;
            this.boxesComboBox.SelectedIndexChanged += new System.EventHandler(this.boxesComboBox_SelectedIndexChanged);
            // 
            // PKMDS_Save_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 364);
            this.Controls.Add(this.boxesComboBox);
            this.Controls.Add(this.dgData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PKMDS_Save_Editor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PKMDS_Save_Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.ComboBox boxesComboBox;
    }
}

