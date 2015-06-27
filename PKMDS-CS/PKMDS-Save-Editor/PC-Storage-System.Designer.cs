﻿namespace PKMDS_Save_Editor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeSaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.textBoxName.MaxLength = 17;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(240, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSaveFileToolStripMenuItem,
            this.writeSaveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllPokemonToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // viewAllPokemonToolStripMenuItem
            // 
            this.viewAllPokemonToolStripMenuItem.Name = "viewAllPokemonToolStripMenuItem";
            this.viewAllPokemonToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.viewAllPokemonToolStripMenuItem.Text = "View all Pokemon";
            this.viewAllPokemonToolStripMenuItem.Click += new System.EventHandler(this.viewAllPokemonToolStripMenuItem_Click);
            // 
            // loadSaveFileToolStripMenuItem
            // 
            this.loadSaveFileToolStripMenuItem.Name = "loadSaveFileToolStripMenuItem";
            this.loadSaveFileToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.loadSaveFileToolStripMenuItem.Text = "Load Save File";
            // 
            // writeSaveFileToolStripMenuItem
            // 
            this.writeSaveFileToolStripMenuItem.Name = "writeSaveFileToolStripMenuItem";
            this.writeSaveFileToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.writeSaveFileToolStripMenuItem.Text = "Write Save File";
            // 
            // PC_Storage_System_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(464, 343);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panelBoxedPokemon);
            this.Controls.Add(this.comboBoxes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PC_Storage_System_Form";
            this.Text = "PKMDS Save Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PKMDS_Save_Editor_FormClosing);
            this.Load += new System.EventHandler(this.PKMDS_Save_Editor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxes;
        private System.Windows.Forms.Panel panelBoxedPokemon;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeSaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllPokemonToolStripMenuItem;
    }
}

