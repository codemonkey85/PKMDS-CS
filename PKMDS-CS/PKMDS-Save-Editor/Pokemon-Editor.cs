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
    /*

    Stats
    Moves
    History
    Ribbons

    Common:

    Species
    Nickname
    Gender
    Level
    Sprite
    Held Item
    Markings

    Page 1

    Type
    OT
    ID No.
    Exp. Points
    To Next Lv.

    HP
    Attack
    Defense
    Sp. Atk
    Sp. Def
    Speed

    Abilty Name
    Ability Flavor

    Page 2

    Moves

    Page 3

    Nature:
    Egg Received:
    From:
    Egg Hatched:
    Where:

    Page 4

    Ribbons
     */

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
        private readonly BindingSource _itemBindingSource = new BindingSource();
        private readonly BindingSource _moveBindingSource = new BindingSource();
        private CurrencyManager _itemCurrencyManger;
        private CurrencyManager _moveCurrencyManger;

        public void PopulateForm()
        {
            if (FormPopulated) return;

            List<SpeciesObject> SpeciesList = new List<SpeciesObject>();
            foreach (var species in Enum.GetValues(typeof(Species)).Cast<Species>().Where(s => s != Species.NoSpecies).ToArray<Species>())
            {
                SpeciesList.Add(new SpeciesObject(species));
            }
            speciesComboBox.DataSource = SpeciesList;
            speciesComboBox.ValueMember = "Value";
            speciesComboBox.DisplayMember = "Name";

            List<ItemObject> ItemList = new List<ItemObject>();
            foreach (var item in Enum.GetValues(typeof(Items)).Cast<Items>().ToArray<Items>())
            {
                ItemList.Add(new ItemObject(item));
            }
            _itemBindingSource.DataSource = ItemList;
            _itemCurrencyManger = _itemBindingSource.CurrencyManager;
            _itemCurrencyManger.Position = 0;

            itemComboBox.DataSource = ItemList;
            itemComboBox.ValueMember = "Value";
            itemComboBox.DisplayMember = "Name";

            radioOTMale.DataBindings.Add("Checked", _pokemonBindingSource, "OTGenderIsMale", false, DataSourceUpdateMode.OnPropertyChanged, false);
            radioOTFemale.DataBindings.Add("Checked", _pokemonBindingSource, "OTGenderIsFemale", false, DataSourceUpdateMode.OnPropertyChanged, false);

            textOTName.DataBindings.Add("Text", _pokemonBindingSource, "OTName", false, DataSourceUpdateMode.OnValidation, string.Empty);
            genderPictureBox.DataBindings.Add("Image", _pokemonBindingSource, "GenderIcon", true, DataSourceUpdateMode.Never, null);
            pbItemImage.DataBindings.Add("Image", _itemBindingSource, "Image", true, DataSourceUpdateMode.Never, null);
            pbSprite.DataBindings.Add("Image", _pokemonBindingSource, "BoxIcon", true, DataSourceUpdateMode.Never, null);
            speciesComboBox.DataBindings.Add("SelectedValue", tempPokemon, "Species", false, DataSourceUpdateMode.OnPropertyChanged, Species.NoSpecies);
            itemComboBox.DataBindings.Add("SelectedValue", tempPokemon, "HeldItem", false, DataSourceUpdateMode.OnPropertyChanged, Items.NoItem);
            textNickname.DataBindings.Add("Text", _pokemonBindingSource, "Nickname", false, DataSourceUpdateMode.OnValidation, "");
            checkNicknamed.DataBindings.Add("Checked", _pokemonBindingSource, "IsNicknamed", false, DataSourceUpdateMode.OnPropertyChanged, false);
            numericLevel.DataBindings.Add("Value", _pokemonBindingSource, "Level", true, DataSourceUpdateMode.OnPropertyChanged, 1);
            picType1.DataBindings.Add("Image", _pokemonBindingSource, "Type1.Image", true, DataSourceUpdateMode.Never, null);
            picType2.DataBindings.Add("Image", _pokemonBindingSource, "Type2.Image", true, DataSourceUpdateMode.Never, null);
            picType2.DataBindings[0].Format += Type_2_Image_Format;

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

            _moveBindingSource.DataSource = tempPokemon.Moves;
            _moveCurrencyManger = _moveBindingSource.CurrencyManager;
            _moveCurrencyManger.Position = 0;

            labelMoveFlavorText.DataBindings.Add("Text", _moveBindingSource, "FlavorText", false, DataSourceUpdateMode.Never, string.Empty);

            dataGridMoves.DataSource = _moveBindingSource;

            //for (int m = 0; m < 4; m++)
            //{
            //    if (dataGridMoves.Rows.Count > m)
            //    {
            //        dataGridMoves.Rows[m].HeaderCell.ValueType = typeof(string);
            //        dataGridMoves.Rows[m].HeaderCell.Value = string.Format("Move {0}", m + 1);
            //    }
            //}

            if (dataGridMoves.Columns.Contains("Value"))
                //dataGridMoves.Columns["Value"].Visible = false;
                if (dataGridMoves.Columns.Contains("Name"))
                    dataGridMoves.Columns["Name"].Visible = false;
                    if (dataGridMoves.Columns.Contains("Type"))
                dataGridMoves.Columns["Type"].Visible = false;
            if (dataGridMoves.Columns.Contains("TypeImage"))
                dataGridMoves.Columns["TypeImage"].HeaderText = "Type";
            if (dataGridMoves.Columns.Contains("CategoryImage"))
                dataGridMoves.Columns["CategoryImage"].HeaderText = "Category";
            if (dataGridMoves.Columns.Contains("FlavorText"))
            {
                dataGridMoves.Columns["FlavorText"].Visible = false;
                //dataGridMoves.Columns["FlavorText"].HeaderText = "Flavor Text";
                //dataGridMoves.Columns["FlavorText"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dataGridMoves.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            FormPopulated = true;
        }

        private void Type_2_Image_Format(object sender, ConvertEventArgs e)
        {
            var pb = (PictureBox)((System.Windows.Forms.Binding)sender).Control;
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
            PopulateForm();
            _pokemonBindingSource.DataSource = tempPokemon;
            FormSet = true;
        }

        private void buttonApply_Click(object sender, System.EventArgs e)
        {
            _pokemon.CloneFrom(tempPokemon);
        }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            _pokemon.CloneFrom(tempPokemon);
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
            if (itemComboBox.SelectedIndex == -1) return;
            if (itemComboBox.SelectedValue as ItemObject == Items.NoItem) return;
            var item = new ItemObject((Items)itemComboBox.SelectedValue);
            _itemCurrencyManger.Position = _itemCurrencyManger.List.IndexOf(item);
        }

        private List<PictureBox> MarkingsBoxes = new List<PictureBox>();

        private void Pokemon_Editor_Form_Load(object sender, EventArgs e)
        {
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
            MarkingsBoxes[(int)Markings.Circle].DataBindings.Add("Image", _pokemonBindingSource, "Circle", true, DataSourceUpdateMode.Never, Images.GetImageFromResource("m_00"));
            MarkingsBoxes[(int)Markings.Triangle].DataBindings.Add("Image", _pokemonBindingSource, "Triangle", true, DataSourceUpdateMode.Never, Images.GetImageFromResource("m_10"));
            MarkingsBoxes[(int)Markings.Square].DataBindings.Add("Image", _pokemonBindingSource, "Square", true, DataSourceUpdateMode.Never, Images.GetImageFromResource("m_20"));
            MarkingsBoxes[(int)Markings.Heart].DataBindings.Add("Image", _pokemonBindingSource, "Heart", true, DataSourceUpdateMode.Never, Images.GetImageFromResource("m_30"));
            MarkingsBoxes[(int)Markings.Star].DataBindings.Add("Image", _pokemonBindingSource, "Star", true, DataSourceUpdateMode.Never, Images.GetImageFromResource("m_40"));
            MarkingsBoxes[(int)Markings.Diamond].DataBindings.Add("Image", _pokemonBindingSource, "Diamond", true, DataSourceUpdateMode.Never, Images.GetImageFromResource("m_50"));

            foreach (PictureBox pb in MarkingsBoxes)
            {
                pb.DataBindings[0].Format += MarkingsImageFormat;
            }

            markingsPanel.Controls.Add(flp);
        }

        private void MarkingsImageFormat(object sender, ConvertEventArgs e)
        {
            var pb = (PictureBox)((System.Windows.Forms.Binding)sender).Control;
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

        private void dataGridMoves_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridMoves.Columns.Count == 0 || dataGridMoves.Rows.Count == 0 || dataGridMoves.SelectedRows.Count == 0) return;
            //MessageBox.Show(string.Format("{0}", dataGridMoves.SelectedRows[0].Index));
            _moveCurrencyManger.Position = dataGridMoves.SelectedRows[0].Index;
        }
    }
}