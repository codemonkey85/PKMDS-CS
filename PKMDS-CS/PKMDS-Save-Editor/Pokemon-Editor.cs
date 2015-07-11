#region Using

using PKMDS_CS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

#endregion Using

namespace PKMDS_Save_Editor
{
    public partial class Pokemon_Editor_Form : Form
    {
        public Pokemon_Editor_Form()
        {
            InitializeComponent();
        }

        private List<NumericUpDown> numIVs = new List<NumericUpDown>();
        private List<NumericUpDown> numEVs = new List<NumericUpDown>();

        private bool FormSet = false;
        private bool FormPopulated = false;
        private Pokemon _pokemon;
        private Pokemon tempPokemon = new Pokemon();

        public Pokemon Pokemon { get { return _pokemon; } set { _pokemon = value; tempPokemon.CloneFrom(_pokemon); } }

        private readonly BindingSource _pokemonBindingSource = new BindingSource();
        private readonly BindingSource _moveBindingSource = new BindingSource();
        private readonly BindingSource _relearnableMoveBindingSource = new BindingSource();

        private LocationObject[] metList = new LocationObject[Lists.LocationList.Count];
        private LocationObject[] eggList = new LocationObject[Lists.LocationList.Count];

        public void PopulateForm()
        {
            if (FormPopulated) return;

            speciesComboBox.DataSource = Lists.SpeciesList;
            speciesComboBox.ValueMember = "Value";
            speciesComboBox.DisplayMember = "Name";

            itemComboBox.DataSource = Lists.ItemList;
            itemComboBox.ValueMember = "Value";
            itemComboBox.DisplayMember = "Name";

            Lists.LocationList.CopyTo(metList);
            Lists.LocationList.CopyTo(eggList);

            comboMetLocation.DataSource = metList;
            comboMetLocation.ValueMember = "Value";
            comboMetLocation.DisplayMember = "Name";

            comboEggLocation.DataSource = eggList;
            comboEggLocation.ValueMember = "Value";
            comboEggLocation.DisplayMember = "Name";

            comboMetLocation.SelectedValue = tempPokemon.MetLocation;
            comboEggLocation.SelectedValue = tempPokemon.EggLocation;

            dateTimeMetDate.DataBindings.Add("Value", _pokemonBindingSource, "MetDate", true, DataSourceUpdateMode.OnValidation, DateTime.MinValue);
            dateTimeEggDate.DataBindings.Add("Value", _pokemonBindingSource, "EggDate", true, DataSourceUpdateMode.OnValidation, DateTime.MinValue);

            comboEggLocation.DataBindings.Add("Enabled", checkBoxEggMet, "Checked", false, DataSourceUpdateMode.OnPropertyChanged, false);
            dateTimeEggDate.DataBindings.Add("Enabled", checkBoxEggMet, "Checked", false, DataSourceUpdateMode.OnPropertyChanged, false);

            radioOTMale.DataBindings.Add("Checked", _pokemonBindingSource, "OTGenderIsMale", false, DataSourceUpdateMode.OnPropertyChanged, false);
            radioOTFemale.DataBindings.Add("Checked", _pokemonBindingSource, "OTGenderIsFemale", false, DataSourceUpdateMode.OnPropertyChanged, false);

            textOTName.DataBindings.Add("Text", _pokemonBindingSource, "OTName", false, DataSourceUpdateMode.OnValidation, string.Empty);
            genderPictureBox.DataBindings.Add("Image", _pokemonBindingSource, "GenderIcon", true, DataSourceUpdateMode.Never, null);
            pbItemImage.DataBindings.Add("Image", itemComboBox, "SelectedItem.Image", true, DataSourceUpdateMode.Never, null);
            pbSprite.DataBindings.Add("Image", _pokemonBindingSource, "BoxIconEgg", true, DataSourceUpdateMode.Never, null);
            speciesComboBox.DataBindings.Add("SelectedValue", _pokemonBindingSource, "Species", false, DataSourceUpdateMode.OnPropertyChanged, Species.NoSpecies);
            itemComboBox.DataBindings.Add("SelectedValue", _pokemonBindingSource, "HeldItem", false, DataSourceUpdateMode.OnPropertyChanged, Items.NoItem);
            textNickname.DataBindings.Add("Text", _pokemonBindingSource, "Nickname", false, DataSourceUpdateMode.OnValidation, "");
            checkNicknamed.DataBindings.Add("Checked", _pokemonBindingSource, "IsNicknamed", false, DataSourceUpdateMode.OnPropertyChanged, false);
            numericLevel.DataBindings.Add("Value", _pokemonBindingSource, "Level", true, DataSourceUpdateMode.OnPropertyChanged, 1);
            picType1.DataBindings.Add("Image", _pokemonBindingSource, "Type1.Image", true, DataSourceUpdateMode.Never, null);
            picType2.DataBindings.Add("Image", _pokemonBindingSource, "Type2.Image", true, DataSourceUpdateMode.Never, null);
            picType2.DataBindings[0].Format += Type_2_Image_Format;
            comboNature.DataSource = Enum.GetValues(typeof(Natures)).Cast<Natures>().ToArray<Natures>();
            comboNature.DataBindings.Add("SelectedItem", _pokemonBindingSource, "Nature", true, DataSourceUpdateMode.OnPropertyChanged, -1);

            DBTools.GetPokemonForms();

            numHPIV.DataBindings.Add("Value", _pokemonBindingSource, "HP_IV", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);
            numAttackIV.DataBindings.Add("Value", _pokemonBindingSource, "Attack_IV", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);
            numDefenseIV.DataBindings.Add("Value", _pokemonBindingSource, "Defense_IV", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);
            numSpAtkIV.DataBindings.Add("Value", _pokemonBindingSource, "SpecialAttack_IV", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);
            numSpDefIV.DataBindings.Add("Value", _pokemonBindingSource, "SpecialDefense_IV", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);
            numSpeedIV.DataBindings.Add("Value", _pokemonBindingSource, "Speed_IV", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);

            numHPEV.DataBindings.Add("Value", _pokemonBindingSource, "HPEffortValue", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);
            numAttackEV.DataBindings.Add("Value", _pokemonBindingSource, "AttackEffortValue", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);
            numDefenseEV.DataBindings.Add("Value", _pokemonBindingSource, "DefenseEffortValue", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);
            numSpAtkEV.DataBindings.Add("Value", _pokemonBindingSource, "SpAttackEffortValue", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);
            numSpDefEV.DataBindings.Add("Value", _pokemonBindingSource, "SpDefenseEffortValue", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);
            numSpeedEV.DataBindings.Add("Value", _pokemonBindingSource, "SpeedEffortValue", true, DataSourceUpdateMode.OnPropertyChanged, 0.0);

            textHP.DataBindings.Add("Text", _pokemonBindingSource, "HP", true, DataSourceUpdateMode.Never, string.Empty);
            textAttack.DataBindings.Add("Text", _pokemonBindingSource, "Attack", true, DataSourceUpdateMode.Never, string.Empty);
            textDefense.DataBindings.Add("Text", _pokemonBindingSource, "Defense", true, DataSourceUpdateMode.Never, string.Empty);
            textSpAtk.DataBindings.Add("Text", _pokemonBindingSource, "SpecialAttack", true, DataSourceUpdateMode.Never, string.Empty);
            textSpDef.DataBindings.Add("Text", _pokemonBindingSource, "SpecialDefense", true, DataSourceUpdateMode.Never, string.Empty);
            textSpeed.DataBindings.Add("Text", _pokemonBindingSource, "Speed", true, DataSourceUpdateMode.Never, string.Empty);

            labelMoveFlavorText.DataBindings.Add("Text", _moveBindingSource, "FlavorText", false, DataSourceUpdateMode.Never, string.Empty);
            labelRelearnableMoveFlavorText.DataBindings.Add("Text", _relearnableMoveBindingSource, "FlavorText", false, DataSourceUpdateMode.Never, string.Empty);

            dataGridMoves.DataSource = _moveBindingSource;
            dataGridRelearnableMoves.DataSource = _relearnableMoveBindingSource;

            if (dataGridMoves.Columns.Contains("Name"))
                dataGridMoves.Columns["Name"].Visible = false;
            if (dataGridMoves.Columns.Contains("Type"))
                dataGridMoves.Columns["Type"].Visible = false;
            if (dataGridMoves.Columns.Contains("BasePP"))
                dataGridMoves.Columns["BasePP"].Visible = false;
            if (dataGridMoves.Columns.Contains("FlavorText"))
                dataGridMoves.Columns["FlavorText"].Visible = false;

            DataGridViewComboBoxColumn clmnppup = new DataGridViewComboBoxColumn();
            clmnppup.Name = "PPUps";
            clmnppup.HeaderText = "PP Ups";
            clmnppup.DataSource = new byte[] { 0, 1, 2, 3 };
            clmnppup.DataPropertyName = "PPUps";
            clmnppup.DisplayIndex = dataGridMoves.Columns["PPUps"].DisplayIndex;
            clmnppup.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridMoves.Columns.Remove("PPUps");
            dataGridMoves.Columns.Add(clmnppup);

            if (dataGridRelearnableMoves.Columns.Contains("Name"))
                dataGridRelearnableMoves.Columns["Name"].Visible = false;
            if (dataGridRelearnableMoves.Columns.Contains("Type"))
                dataGridRelearnableMoves.Columns["Type"].Visible = false;
            if (dataGridRelearnableMoves.Columns.Contains("FlavorText"))
                dataGridRelearnableMoves.Columns["FlavorText"].Visible = false;
            if (dataGridRelearnableMoves.Columns.Contains("CurrentPP"))
                dataGridRelearnableMoves.Columns["CurrentPP"].Visible = false;
            if (dataGridRelearnableMoves.Columns.Contains("PPUps"))
                dataGridRelearnableMoves.Columns["PPUps"].Visible = false;
            if (dataGridRelearnableMoves.Columns.Contains("MaxPP"))
                dataGridRelearnableMoves.Columns["MaxPP"].Visible = false;

            dataGridMoves.Columns.Remove("Value");
            DataGridViewComboBoxColumn clmn = new DataGridViewComboBoxColumn();
            clmn.Name = "Value";
            clmn.HeaderText = "Move";
            clmn.DataSource = Lists.MoveList;
            clmn.DataPropertyName = "Value";
            clmn.ValueMember = "Value";
            clmn.DisplayMember = "Name";
            clmn.DisplayIndex = 0;
            clmn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridMoves.Columns.Add(clmn);

            dataGridRelearnableMoves.Columns.Remove("Value");
            DataGridViewComboBoxColumn rclmn = new DataGridViewComboBoxColumn();
            rclmn.Name = "Value";
            rclmn.HeaderText = "Move";
            rclmn.DataSource = Lists.MoveList;
            rclmn.DataPropertyName = "Value";
            rclmn.ValueMember = "Value";
            rclmn.DisplayMember = "Name";
            rclmn.DisplayIndex = 0;
            rclmn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridRelearnableMoves.Columns.Add(rclmn);

            foreach (DataGridViewColumn col in dataGridMoves.Columns)
            {
                if (col is DataGridViewImageColumn)
                    (col as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn col in dataGridRelearnableMoves.Columns)
            {
                if (col is DataGridViewImageColumn)
                    (col as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            numericPID.DataBindings.Add("Value", _pokemonBindingSource, "PID", true, DataSourceUpdateMode.OnPropertyChanged, 0);
            numericPID.DataBindings.Add("Hexadecimal", checkPIDHex, "Checked", false, DataSourceUpdateMode.OnPropertyChanged, false);

            //numericEncryptionConstant.DataBindings.Add("Value", _pokemonBindingSource, "EncryptionKey", true, DataSourceUpdateMode.OnPropertyChanged, 0);
            numericEncryptionConstant.DataBindings.Add("Hexadecimal", checkEncryptionConstantHex, "Checked", false, DataSourceUpdateMode.OnPropertyChanged, false);

            FormPopulated = true;
        }

        private void Type_2_Image_Format(object sender, ConvertEventArgs e)
        {
            var pb = (PictureBox)((Binding)sender).Control;
            if (!tempPokemon.Type2.HasValue) e.Value = null;
            if (tempPokemon.Type1.HasValue && tempPokemon.Type2.HasValue)
            {
                if (tempPokemon.Type1.Value.Value == tempPokemon.Type2.Value.Value)
                {
                    e.Value = null;
                }
            }
        }

        public void SetForm()
        {
            FormSet = false;
            _pokemonBindingSource.DataSource = tempPokemon;
            _moveBindingSource.DataSource = (_pokemonBindingSource.Current as Pokemon).Moves;
            _relearnableMoveBindingSource.DataSource = (_pokemonBindingSource.Current as Pokemon).RelearnableMoves;
            PopulateForm();
            FormSet = true;
            checkBoxEggMet.Checked = (tempPokemon.IsEgg || tempPokemon.EggDate.HasValue || tempPokemon.EggLocation != Locations.Mystery_Zone);
        }

        private void SavePokemon()
        {
            if (!checkBoxEggMet.Checked)
            {
                tempPokemon.EggLocation = Locations.Mystery_Zone;
                tempPokemon.EggDate = null;
            }

            tempPokemon.Moves = _moveBindingSource.DataSource as List<MovesObject>;
            tempPokemon.RelearnableMoves = _relearnableMoveBindingSource.DataSource as List<MovesObject>;

            _pokemon.CloneFrom(tempPokemon);
        }

        private void buttonApply_Click(object sender, System.EventArgs e)
        {
            try
            {
                SavePokemon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            try
            {
                SavePokemon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void PictureBox_Paint_and_Resize(object sender, PaintEventArgs e)
        {
            PictureBox picbox = (PictureBox)sender;
            if (picbox.Image == null) return;
            Graphics g = e.Graphics;
            g.Clear(picbox.BackColor);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.DrawImage(picbox.Image, new Rectangle(new Point(0, 0), picbox.Size));
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pbItemImage.DataBindings.Count == 0) return;
            if (itemComboBox.SelectedIndex == -1) return;
            pbItemImage.DataBindings[0].ReadValue();
        }

        private List<PictureBox> MarkingsBoxes = new List<PictureBox>();

        private void Pokemon_Editor_Form_Load(object sender, EventArgs e)
        {
            _pokemonBindingSource.ResetBindings(false);
            _moveBindingSource.ResetBindings(false);
            _relearnableMoveBindingSource.ResetBindings(false);
            if (markingsPanel.Controls.Count != 0) return;
            FlowLayoutPanel flp = new FlowLayoutPanel();
            for (int i = 0; i < 6; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Name = string.Format("pb{0}", (Markings)i);
                pb.Tag = (Markings)i;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Size = new Size(10, 10);
                pb.Click += pbMarkings_Click;
                flp.Controls.Add(pb);
                MarkingsBoxes.Add(pb);
            }
            MarkingsBoxes[(int)Markings.Circle].DataBindings.Add("Image", _pokemonBindingSource, "Circle", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Circle, false));
            MarkingsBoxes[(int)Markings.Triangle].DataBindings.Add("Image", _pokemonBindingSource, "Triangle", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Triangle, false));
            MarkingsBoxes[(int)Markings.Square].DataBindings.Add("Image", _pokemonBindingSource, "Square", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Square, false));
            MarkingsBoxes[(int)Markings.Heart].DataBindings.Add("Image", _pokemonBindingSource, "Heart", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Heart, false));
            MarkingsBoxes[(int)Markings.Star].DataBindings.Add("Image", _pokemonBindingSource, "Star", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Star, false));
            MarkingsBoxes[(int)Markings.Diamond].DataBindings.Add("Image", _pokemonBindingSource, "Diamond", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Diamond, false));

            foreach (PictureBox pb in MarkingsBoxes)
            {
                pb.DataBindings[0].Format += MarkingsImageFormat;
            }

            markingsPanel.Controls.Add(flp);
        }

        private void MarkingsImageFormat(object sender, ConvertEventArgs e)
        {
            var pb = (PictureBox)((Binding)sender).Control;
            Markings mark = new Markings();
            Enum.TryParse<Markings>(pb.Tag.ToString(), out mark);
            e.Value = Images.GetMarkingImage(mark, (bool)e.Value);
        }

        private void pbMarkings_Click(object sender, EventArgs e)
        {
            var pb = (PictureBox)sender;
            switch ((Markings)((pb).Tag))
            {
                case Markings.Circle:
                    tempPokemon.Circle = !tempPokemon.Circle;
                    break;

                case Markings.Triangle:
                    tempPokemon.Triangle = !tempPokemon.Triangle;
                    break;

                case Markings.Square:
                    tempPokemon.Square = !tempPokemon.Square;
                    break;

                case Markings.Heart:
                    tempPokemon.Heart = !tempPokemon.Heart;
                    break;

                case Markings.Star:
                    tempPokemon.Star = !tempPokemon.Star;
                    break;

                case Markings.Diamond:
                    tempPokemon.Diamond = !tempPokemon.Diamond;
                    break;
            }
            pb.DataBindings[0].ReadValue();
        }

        private void speciesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempPokemon.FormID = 0;
            if (formsComboBox.DataBindings.Count != 0)
                formsComboBox.DataBindings.RemoveAt(0);
            formsComboBox.DataSource = null;
            if (DBTools.GetPokemonForms().Keys.Contains(tempPokemon.Species))
            {
                formsComboBox.DataSource = DBTools.GetPokemonForms()[tempPokemon.Species];
                formsComboBox.DataBindings.Add("SelectedIndex", _pokemonBindingSource, "FormID", false, DataSourceUpdateMode.OnPropertyChanged, -1);
                formsComboBox.Enabled = true;
            }
            else
            {
                formsComboBox.Enabled = false;
            }
            if (picType1.DataBindings.Count != 0)
                picType1.DataBindings[0].ReadValue();
            if (picType2.DataBindings.Count != 0)
                picType2.DataBindings[0].ReadValue();
        }

        private void dataGridMoves_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == dataGridMoves.Columns["CurrentPP"].Index && (e.Exception.TargetSite.DeclaringType.FullName) == "System.Windows.Forms.Formatter")
            {
                e.Cancel = !(MessageBox.Show("Current PP must be between 0 and 255.", "Invalid PP", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel);
                return;
            }
            e.Cancel = !(MessageBox.Show(e.Exception.Message, "Data Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel);
        }

        private void comboEggLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FormSet) return;
            tempPokemon.EggLocation = (Locations)comboEggLocation.SelectedValue;
        }

        private void comboMetLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FormSet) return;
            tempPokemon.MetLocation = (Locations)comboMetLocation.SelectedValue;
        }
    }
}