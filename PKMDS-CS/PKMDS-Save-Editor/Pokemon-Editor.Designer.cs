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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupNature = new System.Windows.Forms.GroupBox();
            this.comboNature = new System.Windows.Forms.ComboBox();
            this.groupEncryptionConstant = new System.Windows.Forms.GroupBox();
            this.numericEncryptionConstant = new System.Windows.Forms.NumericUpDown();
            this.checkEncryptionConstantHex = new System.Windows.Forms.CheckBox();
            this.groupPID = new System.Windows.Forms.GroupBox();
            this.numericPID = new System.Windows.Forms.NumericUpDown();
            this.checkPIDHex = new System.Windows.Forms.CheckBox();
            this.tableLayoutStats = new System.Windows.Forms.TableLayoutPanel();
            this.labelIVs = new System.Windows.Forms.Label();
            this.labelEVs = new System.Windows.Forms.Label();
            this.labelCalcStats = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelAttack = new System.Windows.Forms.Label();
            this.labelDefense = new System.Windows.Forms.Label();
            this.labelSpAtk = new System.Windows.Forms.Label();
            this.labelSpDef = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numHPIV = new System.Windows.Forms.NumericUpDown();
            this.numAttackIV = new System.Windows.Forms.NumericUpDown();
            this.numDefenseIV = new System.Windows.Forms.NumericUpDown();
            this.numSpAtkIV = new System.Windows.Forms.NumericUpDown();
            this.numSpDefIV = new System.Windows.Forms.NumericUpDown();
            this.numSpeedIV = new System.Windows.Forms.NumericUpDown();
            this.numHPEV = new System.Windows.Forms.NumericUpDown();
            this.numAttackEV = new System.Windows.Forms.NumericUpDown();
            this.numDefenseEV = new System.Windows.Forms.NumericUpDown();
            this.numSpAtkEV = new System.Windows.Forms.NumericUpDown();
            this.numSpDefEV = new System.Windows.Forms.NumericUpDown();
            this.numSpeedEV = new System.Windows.Forms.NumericUpDown();
            this.textHP = new System.Windows.Forms.TextBox();
            this.textAttack = new System.Windows.Forms.TextBox();
            this.textDefense = new System.Windows.Forms.TextBox();
            this.textSpAtk = new System.Windows.Forms.TextBox();
            this.textSpDef = new System.Windows.Forms.TextBox();
            this.textSpeed = new System.Windows.Forms.TextBox();
            this.movesTabPage = new System.Windows.Forms.TabPage();
            this.groupRelearnableMoves = new System.Windows.Forms.GroupBox();
            this.labelRelearnableMoveFlavorText = new System.Windows.Forms.Label();
            this.dataGridRelearnableMoves = new System.Windows.Forms.DataGridView();
            this.groupCurrentMoves = new System.Windows.Forms.GroupBox();
            this.labelMoveFlavorText = new System.Windows.Forms.Label();
            this.dataGridMoves = new System.Windows.Forms.DataGridView();
            this.historyTabPage = new System.Windows.Forms.TabPage();
            this.checkBoxEggMet = new System.Windows.Forms.CheckBox();
            this.comboMetLocation = new System.Windows.Forms.ComboBox();
            this.comboEggLocation = new System.Windows.Forms.ComboBox();
            this.labelMetLocation = new System.Windows.Forms.Label();
            this.labelEggLocation = new System.Windows.Forms.Label();
            this.labelEggDate = new System.Windows.Forms.Label();
            this.dateTimeEggDate = new System.Windows.Forms.DateTimePicker();
            this.labelMetDate = new System.Windows.Forms.Label();
            this.dateTimeMetDate = new System.Windows.Forms.DateTimePicker();
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
            this.pbPentagon = new System.Windows.Forms.PictureBox();
            this.textOTName = new System.Windows.Forms.TextBox();
            this.radioOTMale = new System.Windows.Forms.RadioButton();
            this.radioOTFemale = new System.Windows.Forms.RadioButton();
            this.grouOT = new System.Windows.Forms.GroupBox();
            this.tablelayoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.pokemonTabControl.SuspendLayout();
            this.statsTabPage.SuspendLayout();
            this.groupNature.SuspendLayout();
            this.groupEncryptionConstant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEncryptionConstant)).BeginInit();
            this.groupPID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPID)).BeginInit();
            this.tableLayoutStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHPIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefenseIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAtkIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHPEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefenseEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAtkEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefEV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedEV)).BeginInit();
            this.movesTabPage.SuspendLayout();
            this.groupRelearnableMoves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelearnableMoves)).BeginInit();
            this.groupCurrentMoves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoves)).BeginInit();
            this.historyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPentagon)).BeginInit();
            this.grouOT.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.AutoSize = true;
            this.buttonOk.Location = new System.Drawing.Point(332, 2);
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
            this.buttonApply.Location = new System.Drawing.Point(88, 2);
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
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(554, 2);
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
            this.tablelayoutButtons.Location = new System.Drawing.Point(0, 494);
            this.tablelayoutButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablelayoutButtons.Name = "tablelayoutButtons";
            this.tablelayoutButtons.RowCount = 1;
            this.tablelayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelayoutButtons.Size = new System.Drawing.Size(706, 31);
            this.tablelayoutButtons.TabIndex = 13;
            // 
            // pbSprite
            // 
            this.pbSprite.Location = new System.Drawing.Point(114, 8);
            this.pbSprite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(80, 60);
            this.pbSprite.TabIndex = 4;
            this.pbSprite.TabStop = false;
            this.pbSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint_and_Resize);
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.speciesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(108, 71);
            this.speciesComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(87, 21);
            this.speciesComboBox.TabIndex = 3;
            // 
            // textNickname
            // 
            this.textNickname.Location = new System.Drawing.Point(8, 8);
            this.textNickname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNickname.MaxLength = 12;
            this.textNickname.Name = "textNickname";
            this.textNickname.Size = new System.Drawing.Size(98, 20);
            this.textNickname.TabIndex = 0;
            // 
            // checkNicknamed
            // 
            this.checkNicknamed.AutoSize = true;
            this.checkNicknamed.Location = new System.Drawing.Point(30, 32);
            this.checkNicknamed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.itemComboBox.Location = new System.Drawing.Point(70, 185);
            this.itemComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(125, 21);
            this.itemComboBox.TabIndex = 10;
            // 
            // pbItemImage
            // 
            this.pbItemImage.Location = new System.Drawing.Point(17, 201);
            this.pbItemImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(49, 32);
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
            this.pokemonTabControl.Location = new System.Drawing.Point(200, 0);
            this.pokemonTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.pokemonTabControl.Multiline = true;
            this.pokemonTabControl.Name = "pokemonTabControl";
            this.pokemonTabControl.SelectedIndex = 0;
            this.pokemonTabControl.Size = new System.Drawing.Size(507, 494);
            this.pokemonTabControl.TabIndex = 12;
            // 
            // statsTabPage
            // 
            this.statsTabPage.Controls.Add(this.groupNature);
            this.statsTabPage.Controls.Add(this.groupEncryptionConstant);
            this.statsTabPage.Controls.Add(this.groupPID);
            this.statsTabPage.Controls.Add(this.tableLayoutStats);
            this.statsTabPage.Location = new System.Drawing.Point(4, 22);
            this.statsTabPage.Name = "statsTabPage";
            this.statsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.statsTabPage.Size = new System.Drawing.Size(499, 468);
            this.statsTabPage.TabIndex = 0;
            this.statsTabPage.Text = "Stats";
            this.statsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupNature
            // 
            this.groupNature.Controls.Add(this.comboNature);
            this.groupNature.Location = new System.Drawing.Point(6, 295);
            this.groupNature.Name = "groupNature";
            this.groupNature.Size = new System.Drawing.Size(188, 42);
            this.groupNature.TabIndex = 1;
            this.groupNature.TabStop = false;
            this.groupNature.Text = "Nature";
            // 
            // comboNature
            // 
            this.comboNature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboNature.FormattingEnabled = true;
            this.comboNature.Location = new System.Drawing.Point(3, 16);
            this.comboNature.Name = "comboNature";
            this.comboNature.Size = new System.Drawing.Size(182, 21);
            this.comboNature.TabIndex = 0;
            // 
            // groupEncryptionConstant
            // 
            this.groupEncryptionConstant.Controls.Add(this.numericEncryptionConstant);
            this.groupEncryptionConstant.Controls.Add(this.checkEncryptionConstantHex);
            this.groupEncryptionConstant.Location = new System.Drawing.Point(200, 343);
            this.groupEncryptionConstant.Name = "groupEncryptionConstant";
            this.groupEncryptionConstant.Size = new System.Drawing.Size(188, 45);
            this.groupEncryptionConstant.TabIndex = 3;
            this.groupEncryptionConstant.TabStop = false;
            this.groupEncryptionConstant.Text = "Encryption Constant";
            this.groupEncryptionConstant.Visible = false;
            // 
            // numericEncryptionConstant
            // 
            this.numericEncryptionConstant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericEncryptionConstant.Location = new System.Drawing.Point(6, 19);
            this.numericEncryptionConstant.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericEncryptionConstant.Name = "numericEncryptionConstant";
            this.numericEncryptionConstant.Size = new System.Drawing.Size(127, 20);
            this.numericEncryptionConstant.TabIndex = 0;
            // 
            // checkEncryptionConstantHex
            // 
            this.checkEncryptionConstantHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEncryptionConstantHex.AutoSize = true;
            this.checkEncryptionConstantHex.Location = new System.Drawing.Point(136, 22);
            this.checkEncryptionConstantHex.Name = "checkEncryptionConstantHex";
            this.checkEncryptionConstantHex.Size = new System.Drawing.Size(45, 17);
            this.checkEncryptionConstantHex.TabIndex = 1;
            this.checkEncryptionConstantHex.Text = "Hex";
            this.checkEncryptionConstantHex.UseVisualStyleBackColor = true;
            // 
            // groupPID
            // 
            this.groupPID.Controls.Add(this.numericPID);
            this.groupPID.Controls.Add(this.checkPIDHex);
            this.groupPID.Location = new System.Drawing.Point(6, 343);
            this.groupPID.Name = "groupPID";
            this.groupPID.Size = new System.Drawing.Size(188, 45);
            this.groupPID.TabIndex = 2;
            this.groupPID.TabStop = false;
            this.groupPID.Text = "Personality Value";
            // 
            // numericPID
            // 
            this.numericPID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericPID.Location = new System.Drawing.Point(6, 19);
            this.numericPID.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numericPID.Name = "numericPID";
            this.numericPID.Size = new System.Drawing.Size(127, 20);
            this.numericPID.TabIndex = 0;
            // 
            // checkPIDHex
            // 
            this.checkPIDHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkPIDHex.AutoSize = true;
            this.checkPIDHex.Location = new System.Drawing.Point(136, 22);
            this.checkPIDHex.Name = "checkPIDHex";
            this.checkPIDHex.Size = new System.Drawing.Size(45, 17);
            this.checkPIDHex.TabIndex = 1;
            this.checkPIDHex.Text = "Hex";
            this.checkPIDHex.UseVisualStyleBackColor = true;
            // 
            // tableLayoutStats
            // 
            this.tableLayoutStats.ColumnCount = 4;
            this.tableLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutStats.Controls.Add(this.labelIVs, 1, 0);
            this.tableLayoutStats.Controls.Add(this.labelEVs, 2, 0);
            this.tableLayoutStats.Controls.Add(this.labelCalcStats, 3, 0);
            this.tableLayoutStats.Controls.Add(this.labelHP, 0, 1);
            this.tableLayoutStats.Controls.Add(this.labelAttack, 0, 2);
            this.tableLayoutStats.Controls.Add(this.labelDefense, 0, 3);
            this.tableLayoutStats.Controls.Add(this.labelSpAtk, 0, 4);
            this.tableLayoutStats.Controls.Add(this.labelSpDef, 0, 5);
            this.tableLayoutStats.Controls.Add(this.labelSpeed, 0, 6);
            this.tableLayoutStats.Controls.Add(this.numHPIV, 1, 1);
            this.tableLayoutStats.Controls.Add(this.numAttackIV, 1, 2);
            this.tableLayoutStats.Controls.Add(this.numDefenseIV, 1, 3);
            this.tableLayoutStats.Controls.Add(this.numSpAtkIV, 1, 4);
            this.tableLayoutStats.Controls.Add(this.numSpDefIV, 1, 5);
            this.tableLayoutStats.Controls.Add(this.numSpeedIV, 1, 6);
            this.tableLayoutStats.Controls.Add(this.numHPEV, 2, 1);
            this.tableLayoutStats.Controls.Add(this.numAttackEV, 2, 2);
            this.tableLayoutStats.Controls.Add(this.numDefenseEV, 2, 3);
            this.tableLayoutStats.Controls.Add(this.numSpAtkEV, 2, 4);
            this.tableLayoutStats.Controls.Add(this.numSpDefEV, 2, 5);
            this.tableLayoutStats.Controls.Add(this.numSpeedEV, 2, 6);
            this.tableLayoutStats.Controls.Add(this.textHP, 3, 1);
            this.tableLayoutStats.Controls.Add(this.textAttack, 3, 2);
            this.tableLayoutStats.Controls.Add(this.textDefense, 3, 3);
            this.tableLayoutStats.Controls.Add(this.textSpAtk, 3, 4);
            this.tableLayoutStats.Controls.Add(this.textSpDef, 3, 5);
            this.tableLayoutStats.Controls.Add(this.textSpeed, 3, 6);
            this.tableLayoutStats.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutStats.Name = "tableLayoutStats";
            this.tableLayoutStats.RowCount = 7;
            this.tableLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutStats.Size = new System.Drawing.Size(382, 283);
            this.tableLayoutStats.TabIndex = 0;
            // 
            // labelIVs
            // 
            this.labelIVs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIVs.AutoSize = true;
            this.labelIVs.Location = new System.Drawing.Point(102, 13);
            this.labelIVs.Name = "labelIVs";
            this.labelIVs.Size = new System.Drawing.Size(22, 13);
            this.labelIVs.TabIndex = 0;
            this.labelIVs.Text = "IVs";
            // 
            // labelEVs
            // 
            this.labelEVs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEVs.AutoSize = true;
            this.labelEVs.Location = new System.Drawing.Point(207, 13);
            this.labelEVs.Name = "labelEVs";
            this.labelEVs.Size = new System.Drawing.Size(26, 13);
            this.labelEVs.TabIndex = 1;
            this.labelEVs.Text = "EVs";
            // 
            // labelCalcStats
            // 
            this.labelCalcStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCalcStats.AutoSize = true;
            this.labelCalcStats.Location = new System.Drawing.Point(286, 13);
            this.labelCalcStats.Name = "labelCalcStats";
            this.labelCalcStats.Size = new System.Drawing.Size(84, 13);
            this.labelCalcStats.TabIndex = 2;
            this.labelCalcStats.Text = "Calculated Stats";
            // 
            // labelHP
            // 
            this.labelHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(19, 53);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(22, 13);
            this.labelHP.TabIndex = 3;
            this.labelHP.Text = "HP";
            // 
            // labelAttack
            // 
            this.labelAttack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAttack.AutoSize = true;
            this.labelAttack.Location = new System.Drawing.Point(11, 93);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(38, 13);
            this.labelAttack.TabIndex = 7;
            this.labelAttack.Text = "Attack";
            // 
            // labelDefense
            // 
            this.labelDefense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDefense.AutoSize = true;
            this.labelDefense.Location = new System.Drawing.Point(6, 133);
            this.labelDefense.Name = "labelDefense";
            this.labelDefense.Size = new System.Drawing.Size(47, 13);
            this.labelDefense.TabIndex = 11;
            this.labelDefense.Text = "Defense";
            // 
            // labelSpAtk
            // 
            this.labelSpAtk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpAtk.AutoSize = true;
            this.labelSpAtk.Location = new System.Drawing.Point(10, 173);
            this.labelSpAtk.Name = "labelSpAtk";
            this.labelSpAtk.Size = new System.Drawing.Size(39, 13);
            this.labelSpAtk.TabIndex = 15;
            this.labelSpAtk.Text = "Sp Atk";
            // 
            // labelSpDef
            // 
            this.labelSpDef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpDef.AutoSize = true;
            this.labelSpDef.Location = new System.Drawing.Point(10, 213);
            this.labelSpDef.Name = "labelSpDef";
            this.labelSpDef.Size = new System.Drawing.Size(40, 13);
            this.labelSpDef.TabIndex = 19;
            this.labelSpDef.Text = "Sp Def";
            // 
            // labelSpeed
            // 
            this.labelSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(11, 255);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 13);
            this.labelSpeed.TabIndex = 23;
            this.labelSpeed.Text = "Speed";
            // 
            // numHPIV
            // 
            this.numHPIV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numHPIV.Location = new System.Drawing.Point(83, 50);
            this.numHPIV.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numHPIV.Name = "numHPIV";
            this.numHPIV.Size = new System.Drawing.Size(61, 20);
            this.numHPIV.TabIndex = 4;
            this.numHPIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numAttackIV
            // 
            this.numAttackIV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numAttackIV.Location = new System.Drawing.Point(83, 90);
            this.numAttackIV.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numAttackIV.Name = "numAttackIV";
            this.numAttackIV.Size = new System.Drawing.Size(61, 20);
            this.numAttackIV.TabIndex = 8;
            this.numAttackIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numDefenseIV
            // 
            this.numDefenseIV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numDefenseIV.Location = new System.Drawing.Point(83, 130);
            this.numDefenseIV.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDefenseIV.Name = "numDefenseIV";
            this.numDefenseIV.Size = new System.Drawing.Size(61, 20);
            this.numDefenseIV.TabIndex = 12;
            this.numDefenseIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSpAtkIV
            // 
            this.numSpAtkIV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSpAtkIV.Location = new System.Drawing.Point(83, 170);
            this.numSpAtkIV.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numSpAtkIV.Name = "numSpAtkIV";
            this.numSpAtkIV.Size = new System.Drawing.Size(61, 20);
            this.numSpAtkIV.TabIndex = 16;
            this.numSpAtkIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSpDefIV
            // 
            this.numSpDefIV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSpDefIV.Location = new System.Drawing.Point(83, 210);
            this.numSpDefIV.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numSpDefIV.Name = "numSpDefIV";
            this.numSpDefIV.Size = new System.Drawing.Size(61, 20);
            this.numSpDefIV.TabIndex = 20;
            this.numSpDefIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSpeedIV
            // 
            this.numSpeedIV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSpeedIV.Location = new System.Drawing.Point(83, 251);
            this.numSpeedIV.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numSpeedIV.Name = "numSpeedIV";
            this.numSpeedIV.Size = new System.Drawing.Size(61, 20);
            this.numSpeedIV.TabIndex = 24;
            this.numSpeedIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numHPEV
            // 
            this.numHPEV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numHPEV.Location = new System.Drawing.Point(190, 50);
            this.numHPEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numHPEV.Name = "numHPEV";
            this.numHPEV.Size = new System.Drawing.Size(61, 20);
            this.numHPEV.TabIndex = 5;
            this.numHPEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numAttackEV
            // 
            this.numAttackEV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numAttackEV.Location = new System.Drawing.Point(190, 90);
            this.numAttackEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAttackEV.Name = "numAttackEV";
            this.numAttackEV.Size = new System.Drawing.Size(61, 20);
            this.numAttackEV.TabIndex = 9;
            this.numAttackEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numDefenseEV
            // 
            this.numDefenseEV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numDefenseEV.Location = new System.Drawing.Point(190, 130);
            this.numDefenseEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numDefenseEV.Name = "numDefenseEV";
            this.numDefenseEV.Size = new System.Drawing.Size(61, 20);
            this.numDefenseEV.TabIndex = 13;
            this.numDefenseEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSpAtkEV
            // 
            this.numSpAtkEV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSpAtkEV.Location = new System.Drawing.Point(190, 170);
            this.numSpAtkEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSpAtkEV.Name = "numSpAtkEV";
            this.numSpAtkEV.Size = new System.Drawing.Size(61, 20);
            this.numSpAtkEV.TabIndex = 17;
            this.numSpAtkEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSpDefEV
            // 
            this.numSpDefEV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSpDefEV.Location = new System.Drawing.Point(190, 210);
            this.numSpDefEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSpDefEV.Name = "numSpDefEV";
            this.numSpDefEV.Size = new System.Drawing.Size(61, 20);
            this.numSpDefEV.TabIndex = 21;
            this.numSpDefEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSpeedEV
            // 
            this.numSpeedEV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSpeedEV.Location = new System.Drawing.Point(190, 251);
            this.numSpeedEV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSpeedEV.Name = "numSpeedEV";
            this.numSpeedEV.Size = new System.Drawing.Size(61, 20);
            this.numSpeedEV.TabIndex = 25;
            this.numSpeedEV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textHP
            // 
            this.textHP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textHP.Location = new System.Drawing.Point(298, 50);
            this.textHP.Name = "textHP";
            this.textHP.ReadOnly = true;
            this.textHP.Size = new System.Drawing.Size(60, 20);
            this.textHP.TabIndex = 6;
            this.textHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textAttack
            // 
            this.textAttack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAttack.Location = new System.Drawing.Point(298, 90);
            this.textAttack.Name = "textAttack";
            this.textAttack.ReadOnly = true;
            this.textAttack.Size = new System.Drawing.Size(60, 20);
            this.textAttack.TabIndex = 10;
            this.textAttack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDefense
            // 
            this.textDefense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDefense.Location = new System.Drawing.Point(298, 130);
            this.textDefense.Name = "textDefense";
            this.textDefense.ReadOnly = true;
            this.textDefense.Size = new System.Drawing.Size(60, 20);
            this.textDefense.TabIndex = 14;
            this.textDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSpAtk
            // 
            this.textSpAtk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSpAtk.Location = new System.Drawing.Point(298, 170);
            this.textSpAtk.Name = "textSpAtk";
            this.textSpAtk.ReadOnly = true;
            this.textSpAtk.Size = new System.Drawing.Size(60, 20);
            this.textSpAtk.TabIndex = 18;
            this.textSpAtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSpDef
            // 
            this.textSpDef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSpDef.Location = new System.Drawing.Point(298, 210);
            this.textSpDef.Name = "textSpDef";
            this.textSpDef.ReadOnly = true;
            this.textSpDef.Size = new System.Drawing.Size(60, 20);
            this.textSpDef.TabIndex = 22;
            this.textSpDef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSpeed
            // 
            this.textSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSpeed.Location = new System.Drawing.Point(298, 251);
            this.textSpeed.Name = "textSpeed";
            this.textSpeed.ReadOnly = true;
            this.textSpeed.Size = new System.Drawing.Size(60, 20);
            this.textSpeed.TabIndex = 26;
            this.textSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // movesTabPage
            // 
            this.movesTabPage.Controls.Add(this.groupRelearnableMoves);
            this.movesTabPage.Controls.Add(this.groupCurrentMoves);
            this.movesTabPage.Location = new System.Drawing.Point(4, 22);
            this.movesTabPage.Name = "movesTabPage";
            this.movesTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.movesTabPage.Size = new System.Drawing.Size(499, 468);
            this.movesTabPage.TabIndex = 1;
            this.movesTabPage.Text = "Moves";
            this.movesTabPage.UseVisualStyleBackColor = true;
            // 
            // groupRelearnableMoves
            // 
            this.groupRelearnableMoves.Controls.Add(this.labelRelearnableMoveFlavorText);
            this.groupRelearnableMoves.Controls.Add(this.dataGridRelearnableMoves);
            this.groupRelearnableMoves.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupRelearnableMoves.Location = new System.Drawing.Point(3, 236);
            this.groupRelearnableMoves.Name = "groupRelearnableMoves";
            this.groupRelearnableMoves.Size = new System.Drawing.Size(493, 229);
            this.groupRelearnableMoves.TabIndex = 3;
            this.groupRelearnableMoves.TabStop = false;
            this.groupRelearnableMoves.Text = "Relearnable Moves";
            // 
            // labelRelearnableMoveFlavorText
            // 
            this.labelRelearnableMoveFlavorText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelRelearnableMoveFlavorText.Location = new System.Drawing.Point(3, 151);
            this.labelRelearnableMoveFlavorText.Name = "labelRelearnableMoveFlavorText";
            this.labelRelearnableMoveFlavorText.Size = new System.Drawing.Size(487, 75);
            this.labelRelearnableMoveFlavorText.TabIndex = 1;
            this.labelRelearnableMoveFlavorText.Text = "Flavor Text";
            // 
            // dataGridRelearnableMoves
            // 
            this.dataGridRelearnableMoves.AllowUserToAddRows = false;
            this.dataGridRelearnableMoves.AllowUserToDeleteRows = false;
            this.dataGridRelearnableMoves.AllowUserToResizeColumns = false;
            this.dataGridRelearnableMoves.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridRelearnableMoves.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRelearnableMoves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridRelearnableMoves.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridRelearnableMoves.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRelearnableMoves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRelearnableMoves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRelearnableMoves.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRelearnableMoves.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridRelearnableMoves.Location = new System.Drawing.Point(3, 16);
            this.dataGridRelearnableMoves.Name = "dataGridRelearnableMoves";
            this.dataGridRelearnableMoves.RowHeadersVisible = false;
            this.dataGridRelearnableMoves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRelearnableMoves.Size = new System.Drawing.Size(487, 130);
            this.dataGridRelearnableMoves.TabIndex = 0;
            // 
            // groupCurrentMoves
            // 
            this.groupCurrentMoves.Controls.Add(this.labelMoveFlavorText);
            this.groupCurrentMoves.Controls.Add(this.dataGridMoves);
            this.groupCurrentMoves.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCurrentMoves.Location = new System.Drawing.Point(3, 3);
            this.groupCurrentMoves.Name = "groupCurrentMoves";
            this.groupCurrentMoves.Size = new System.Drawing.Size(493, 229);
            this.groupCurrentMoves.TabIndex = 2;
            this.groupCurrentMoves.TabStop = false;
            this.groupCurrentMoves.Text = "Current Moves";
            // 
            // labelMoveFlavorText
            // 
            this.labelMoveFlavorText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelMoveFlavorText.Location = new System.Drawing.Point(3, 151);
            this.labelMoveFlavorText.Name = "labelMoveFlavorText";
            this.labelMoveFlavorText.Size = new System.Drawing.Size(487, 75);
            this.labelMoveFlavorText.TabIndex = 1;
            this.labelMoveFlavorText.Text = "Flavor Text";
            // 
            // dataGridMoves
            // 
            this.dataGridMoves.AllowUserToAddRows = false;
            this.dataGridMoves.AllowUserToDeleteRows = false;
            this.dataGridMoves.AllowUserToResizeColumns = false;
            this.dataGridMoves.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridMoves.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMoves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridMoves.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridMoves.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMoves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridMoves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMoves.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridMoves.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridMoves.Location = new System.Drawing.Point(3, 16);
            this.dataGridMoves.Name = "dataGridMoves";
            this.dataGridMoves.RowHeadersVisible = false;
            this.dataGridMoves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMoves.Size = new System.Drawing.Size(487, 130);
            this.dataGridMoves.TabIndex = 0;
            // 
            // historyTabPage
            // 
            this.historyTabPage.Controls.Add(this.checkBoxEggMet);
            this.historyTabPage.Controls.Add(this.comboMetLocation);
            this.historyTabPage.Controls.Add(this.comboEggLocation);
            this.historyTabPage.Controls.Add(this.labelMetLocation);
            this.historyTabPage.Controls.Add(this.labelEggLocation);
            this.historyTabPage.Controls.Add(this.labelEggDate);
            this.historyTabPage.Controls.Add(this.dateTimeEggDate);
            this.historyTabPage.Controls.Add(this.labelMetDate);
            this.historyTabPage.Controls.Add(this.dateTimeMetDate);
            this.historyTabPage.Location = new System.Drawing.Point(4, 22);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Size = new System.Drawing.Size(499, 468);
            this.historyTabPage.TabIndex = 2;
            this.historyTabPage.Text = "History";
            this.historyTabPage.UseVisualStyleBackColor = true;
            // 
            // checkBoxEggMet
            // 
            this.checkBoxEggMet.AutoSize = true;
            this.checkBoxEggMet.Location = new System.Drawing.Point(33, 52);
            this.checkBoxEggMet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxEggMet.Name = "checkBoxEggMet";
            this.checkBoxEggMet.Size = new System.Drawing.Size(81, 17);
            this.checkBoxEggMet.TabIndex = 8;
            this.checkBoxEggMet.Text = "Met As Egg";
            this.checkBoxEggMet.UseVisualStyleBackColor = true;
            // 
            // comboMetLocation
            // 
            this.comboMetLocation.FormattingEnabled = true;
            this.comboMetLocation.Location = new System.Drawing.Point(107, 180);
            this.comboMetLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboMetLocation.Name = "comboMetLocation";
            this.comboMetLocation.Size = new System.Drawing.Size(148, 21);
            this.comboMetLocation.TabIndex = 7;
            // 
            // comboEggLocation
            // 
            this.comboEggLocation.FormattingEnabled = true;
            this.comboEggLocation.Location = new System.Drawing.Point(107, 94);
            this.comboEggLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboEggLocation.Name = "comboEggLocation";
            this.comboEggLocation.Size = new System.Drawing.Size(148, 21);
            this.comboEggLocation.TabIndex = 6;
            // 
            // labelMetLocation
            // 
            this.labelMetLocation.AutoSize = true;
            this.labelMetLocation.Location = new System.Drawing.Point(31, 182);
            this.labelMetLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMetLocation.Name = "labelMetLocation";
            this.labelMetLocation.Size = new System.Drawing.Size(39, 13);
            this.labelMetLocation.TabIndex = 5;
            this.labelMetLocation.Text = "Where";
            // 
            // labelEggLocation
            // 
            this.labelEggLocation.AutoSize = true;
            this.labelEggLocation.Location = new System.Drawing.Point(31, 97);
            this.labelEggLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEggLocation.Name = "labelEggLocation";
            this.labelEggLocation.Size = new System.Drawing.Size(30, 13);
            this.labelEggLocation.TabIndex = 4;
            this.labelEggLocation.Text = "From";
            // 
            // labelEggDate
            // 
            this.labelEggDate.AutoSize = true;
            this.labelEggDate.Location = new System.Drawing.Point(31, 74);
            this.labelEggDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEggDate.Name = "labelEggDate";
            this.labelEggDate.Size = new System.Drawing.Size(75, 13);
            this.labelEggDate.TabIndex = 3;
            this.labelEggDate.Text = "Egg Received";
            // 
            // dateTimeEggDate
            // 
            this.dateTimeEggDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEggDate.Location = new System.Drawing.Point(107, 73);
            this.dateTimeEggDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeEggDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimeEggDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeEggDate.Name = "dateTimeEggDate";
            this.dateTimeEggDate.Size = new System.Drawing.Size(101, 20);
            this.dateTimeEggDate.TabIndex = 2;
            // 
            // labelMetDate
            // 
            this.labelMetDate.AutoSize = true;
            this.labelMetDate.Location = new System.Drawing.Point(31, 158);
            this.labelMetDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMetDate.Name = "labelMetDate";
            this.labelMetDate.Size = new System.Drawing.Size(51, 13);
            this.labelMetDate.TabIndex = 1;
            this.labelMetDate.Text = "Met Date";
            // 
            // dateTimeMetDate
            // 
            this.dateTimeMetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeMetDate.Location = new System.Drawing.Point(107, 157);
            this.dateTimeMetDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeMetDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimeMetDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeMetDate.Name = "dateTimeMetDate";
            this.dateTimeMetDate.Size = new System.Drawing.Size(101, 20);
            this.dateTimeMetDate.TabIndex = 0;
            // 
            // contestTabPage
            // 
            this.contestTabPage.Location = new System.Drawing.Point(4, 22);
            this.contestTabPage.Name = "contestTabPage";
            this.contestTabPage.Size = new System.Drawing.Size(499, 468);
            this.contestTabPage.TabIndex = 4;
            this.contestTabPage.Text = "Contest";
            this.contestTabPage.UseVisualStyleBackColor = true;
            // 
            // ribbonsTabPage
            // 
            this.ribbonsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ribbonsTabPage.Name = "ribbonsTabPage";
            this.ribbonsTabPage.Size = new System.Drawing.Size(499, 468);
            this.ribbonsTabPage.TabIndex = 3;
            this.ribbonsTabPage.Text = "Ribbons";
            this.ribbonsTabPage.UseVisualStyleBackColor = true;
            // 
            // genderPictureBox
            // 
            this.genderPictureBox.Location = new System.Drawing.Point(184, 8);
            this.genderPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderPictureBox.Name = "genderPictureBox";
            this.genderPictureBox.Size = new System.Drawing.Size(10, 10);
            this.genderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.genderPictureBox.TabIndex = 7;
            this.genderPictureBox.TabStop = false;
            // 
            // markingsPanel
            // 
            this.markingsPanel.Location = new System.Drawing.Point(70, 139);
            this.markingsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.markingsPanel.Name = "markingsPanel";
            this.markingsPanel.Size = new System.Drawing.Size(124, 21);
            this.markingsPanel.TabIndex = 6;
            // 
            // numericLevel
            // 
            this.numericLevel.Location = new System.Drawing.Point(114, 164);
            this.numericLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLevel.Name = "numericLevel";
            this.numericLevel.Size = new System.Drawing.Size(81, 20);
            this.numericLevel.TabIndex = 8;
            this.numericLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelHeldItem
            // 
            this.labelHeldItem.Location = new System.Drawing.Point(14, 187);
            this.labelHeldItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeldItem.Name = "labelHeldItem";
            this.labelHeldItem.Size = new System.Drawing.Size(52, 13);
            this.labelHeldItem.TabIndex = 9;
            this.labelHeldItem.Text = "Held Item";
            this.labelHeldItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpecies
            // 
            this.labelSpecies.Location = new System.Drawing.Point(57, 71);
            this.labelSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(47, 18);
            this.labelSpecies.TabIndex = 2;
            this.labelSpecies.Text = "Species";
            this.labelSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLevel
            // 
            this.labelLevel.Location = new System.Drawing.Point(76, 164);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(34, 17);
            this.labelLevel.TabIndex = 7;
            this.labelLevel.Text = "Level";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picType1
            // 
            this.picType1.Location = new System.Drawing.Point(57, 116);
            this.picType1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picType1.Name = "picType1";
            this.picType1.Size = new System.Drawing.Size(67, 19);
            this.picType1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picType1.TabIndex = 11;
            this.picType1.TabStop = false;
            // 
            // picType2
            // 
            this.picType2.Location = new System.Drawing.Point(127, 116);
            this.picType2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picType2.Name = "picType2";
            this.picType2.Size = new System.Drawing.Size(67, 19);
            this.picType2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picType2.TabIndex = 12;
            this.picType2.TabStop = false;
            // 
            // formsComboBox
            // 
            this.formsComboBox.FormattingEnabled = true;
            this.formsComboBox.Location = new System.Drawing.Point(47, 94);
            this.formsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formsComboBox.Name = "formsComboBox";
            this.formsComboBox.Size = new System.Drawing.Size(149, 21);
            this.formsComboBox.TabIndex = 5;
            // 
            // labelForm
            // 
            this.labelForm.Location = new System.Drawing.Point(5, 93);
            this.labelForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(37, 18);
            this.labelForm.TabIndex = 4;
            this.labelForm.Text = "Form";
            this.labelForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPentagon
            // 
            this.pbPentagon.Location = new System.Drawing.Point(45, 140);
            this.pbPentagon.Name = "pbPentagon";
            this.pbPentagon.Size = new System.Drawing.Size(20, 20);
            this.pbPentagon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPentagon.TabIndex = 13;
            this.pbPentagon.TabStop = false;
            // 
            // textOTName
            // 
            this.textOTName.Location = new System.Drawing.Point(6, 19);
            this.textOTName.MaxLength = 12;
            this.textOTName.Name = "textOTName";
            this.textOTName.Size = new System.Drawing.Size(170, 20);
            this.textOTName.TabIndex = 0;
            // 
            // radioOTMale
            // 
            this.radioOTMale.AutoSize = true;
            this.radioOTMale.Location = new System.Drawing.Point(6, 45);
            this.radioOTMale.Name = "radioOTMale";
            this.radioOTMale.Size = new System.Drawing.Size(48, 17);
            this.radioOTMale.TabIndex = 1;
            this.radioOTMale.TabStop = true;
            this.radioOTMale.Text = "Male";
            this.radioOTMale.UseVisualStyleBackColor = true;
            // 
            // radioOTFemale
            // 
            this.radioOTFemale.AutoSize = true;
            this.radioOTFemale.Location = new System.Drawing.Point(60, 45);
            this.radioOTFemale.Name = "radioOTFemale";
            this.radioOTFemale.Size = new System.Drawing.Size(59, 17);
            this.radioOTFemale.TabIndex = 2;
            this.radioOTFemale.TabStop = true;
            this.radioOTFemale.Text = "Female";
            this.radioOTFemale.UseVisualStyleBackColor = true;
            // 
            // grouOT
            // 
            this.grouOT.Controls.Add(this.radioOTFemale);
            this.grouOT.Controls.Add(this.textOTName);
            this.grouOT.Controls.Add(this.radioOTMale);
            this.grouOT.Location = new System.Drawing.Point(12, 238);
            this.grouOT.Name = "grouOT";
            this.grouOT.Size = new System.Drawing.Size(182, 70);
            this.grouOT.TabIndex = 11;
            this.grouOT.TabStop = false;
            this.grouOT.Text = "Original Trainer";
            // 
            // Pokemon_Editor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(706, 525);
            this.Controls.Add(this.grouOT);
            this.Controls.Add(this.pbPentagon);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 405);
            this.Name = "Pokemon_Editor_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pokemon_Editor";
            this.Load += new System.EventHandler(this.Pokemon_Editor_Form_Load);
            this.tablelayoutButtons.ResumeLayout(false);
            this.tablelayoutButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.pokemonTabControl.ResumeLayout(false);
            this.statsTabPage.ResumeLayout(false);
            this.groupNature.ResumeLayout(false);
            this.groupEncryptionConstant.ResumeLayout(false);
            this.groupEncryptionConstant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEncryptionConstant)).EndInit();
            this.groupPID.ResumeLayout(false);
            this.groupPID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPID)).EndInit();
            this.tableLayoutStats.ResumeLayout(false);
            this.tableLayoutStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHPIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefenseIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAtkIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHPEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefenseEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpAtkEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpDefEV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedEV)).EndInit();
            this.movesTabPage.ResumeLayout(false);
            this.groupRelearnableMoves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelearnableMoves)).EndInit();
            this.groupCurrentMoves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoves)).EndInit();
            this.historyTabPage.ResumeLayout(false);
            this.historyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPentagon)).EndInit();
            this.grouOT.ResumeLayout(false);
            this.grouOT.PerformLayout();
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
        private System.Windows.Forms.PictureBox pbPentagon;
        private System.Windows.Forms.TextBox textOTName;
        private System.Windows.Forms.RadioButton radioOTMale;
        private System.Windows.Forms.RadioButton radioOTFemale;
        private System.Windows.Forms.GroupBox grouOT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutStats;
        private System.Windows.Forms.Label labelIVs;
        private System.Windows.Forms.Label labelEVs;
        private System.Windows.Forms.Label labelCalcStats;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.Label labelDefense;
        private System.Windows.Forms.Label labelSpAtk;
        private System.Windows.Forms.Label labelSpDef;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.NumericUpDown numHPIV;
        private System.Windows.Forms.NumericUpDown numAttackIV;
        private System.Windows.Forms.NumericUpDown numDefenseIV;
        private System.Windows.Forms.NumericUpDown numSpAtkIV;
        private System.Windows.Forms.NumericUpDown numSpDefIV;
        private System.Windows.Forms.NumericUpDown numSpeedIV;
        private System.Windows.Forms.NumericUpDown numHPEV;
        private System.Windows.Forms.NumericUpDown numAttackEV;
        private System.Windows.Forms.NumericUpDown numDefenseEV;
        private System.Windows.Forms.NumericUpDown numSpAtkEV;
        private System.Windows.Forms.NumericUpDown numSpDefEV;
        private System.Windows.Forms.NumericUpDown numSpeedEV;
        private System.Windows.Forms.TextBox textHP;
        private System.Windows.Forms.TextBox textAttack;
        private System.Windows.Forms.TextBox textDefense;
        private System.Windows.Forms.TextBox textSpAtk;
        private System.Windows.Forms.TextBox textSpDef;
        private System.Windows.Forms.TextBox textSpeed;
        private System.Windows.Forms.DataGridView dataGridMoves;
        private System.Windows.Forms.Label labelMoveFlavorText;
        private System.Windows.Forms.GroupBox groupRelearnableMoves;
        private System.Windows.Forms.Label labelRelearnableMoveFlavorText;
        private System.Windows.Forms.DataGridView dataGridRelearnableMoves;
        private System.Windows.Forms.GroupBox groupCurrentMoves;
        private System.Windows.Forms.CheckBox checkPIDHex;
        private System.Windows.Forms.NumericUpDown numericPID;
        private System.Windows.Forms.GroupBox groupPID;
        private System.Windows.Forms.GroupBox groupEncryptionConstant;
        private System.Windows.Forms.NumericUpDown numericEncryptionConstant;
        private System.Windows.Forms.CheckBox checkEncryptionConstantHex;
        private System.Windows.Forms.GroupBox groupNature;
        private System.Windows.Forms.ComboBox comboNature;
        private System.Windows.Forms.Label labelEggDate;
        private System.Windows.Forms.DateTimePicker dateTimeEggDate;
        private System.Windows.Forms.Label labelMetDate;
        private System.Windows.Forms.DateTimePicker dateTimeMetDate;
        private System.Windows.Forms.ComboBox comboMetLocation;
        private System.Windows.Forms.ComboBox comboEggLocation;
        private System.Windows.Forms.Label labelMetLocation;
        private System.Windows.Forms.Label labelEggLocation;
        private System.Windows.Forms.CheckBox checkBoxEggMet;
    }
}