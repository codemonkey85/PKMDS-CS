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
            this.comboBoxes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxes
            // 
            this.comboBoxes.FormattingEnabled = true;
            this.comboBoxes.Location = new System.Drawing.Point(546, 767);
            this.comboBoxes.Name = "comboBoxes";
            this.comboBoxes.Size = new System.Drawing.Size(484, 28);
            this.comboBoxes.TabIndex = 0;
            this.comboBoxes.SelectedIndexChanged += new System.EventHandler(this.comboBoxes_SelectedIndexChanged);
            // 
            // PKMDS_Save_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 909);
            this.Controls.Add(this.comboBoxes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PKMDS_Save_Editor";
            this.Text = "PKMDS Save Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PKMDS_Save_Editor_FormClosing);
            this.Load += new System.EventHandler(this.PKMDS_Save_Editor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxes;


    }
}

