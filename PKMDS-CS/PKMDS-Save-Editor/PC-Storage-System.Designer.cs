namespace PKMDS_Save_Editor
{
    partial class PC_Storage_System_Form
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
            this.panelBoxedPokemon = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxes
            // 
            this.comboBoxes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxes.FormattingEnabled = true;
            this.comboBoxes.Location = new System.Drawing.Point(103, 262);
            this.comboBoxes.Name = "comboBoxes";
            this.comboBoxes.Size = new System.Drawing.Size(240, 28);
            this.comboBoxes.TabIndex = 2;
            this.comboBoxes.SelectedIndexChanged += new System.EventHandler(this.comboBoxes_SelectedIndexChanged);
            // 
            // panelBoxedPokemon
            // 
            this.panelBoxedPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBoxedPokemon.Location = new System.Drawing.Point(103, 74);
            this.panelBoxedPokemon.Name = "panelBoxedPokemon";
            this.panelBoxedPokemon.Size = new System.Drawing.Size(240, 150);
            this.panelBoxedPokemon.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(103, 230);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(240, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // PKMDS_Save_Editor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(464, 343);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelBoxedPokemon);
            this.Controls.Add(this.comboBoxes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PKMDS_Save_Editor";
            this.Text = "PKMDS Save Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PKMDS_Save_Editor_FormClosing);
            this.Load += new System.EventHandler(this.PKMDS_Save_Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxes;
        private System.Windows.Forms.Panel panelBoxedPokemon;
        private System.Windows.Forms.TextBox textBoxName;


    }
}

