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

        private bool FormSet = false;
        private bool FormPopulated = false;
        private Pokemon _pokemon;
        private Pokemon tempPokemon = new Pokemon();

        public Pokemon Pokemon { get { return _pokemon; } set { _pokemon = value; tempPokemon.CloneFrom(_pokemon); } }

        private readonly BindingSource _pokemonBindingSource = new BindingSource();

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
            itemComboBox.DataSource = ItemList;
            itemComboBox.ValueMember = "Value";
            itemComboBox.DisplayMember = "Name";

            pbSprite.DataBindings.Add("Image", _pokemonBindingSource, "BoxIcon", false, DataSourceUpdateMode.Never, null);
            speciesComboBox.DataBindings.Add("SelectedValue", tempPokemon, "Species", false, DataSourceUpdateMode.OnPropertyChanged, Species.NoSpecies);
            itemComboBox.DataBindings.Add("SelectedValue", tempPokemon, "HeldItem", false, DataSourceUpdateMode.OnPropertyChanged, Items.NoItem);
            textNickname.DataBindings.Add("Text", _pokemonBindingSource, "Nickname", false, DataSourceUpdateMode.OnValidation, "");
            checkNicknamed.DataBindings.Add("Checked", _pokemonBindingSource, "IsNicknamed", false, DataSourceUpdateMode.OnPropertyChanged, false);
            FormPopulated = true;
        }

        public void SetForm()
        {
            FormSet = false;
            PopulateForm();
            _pokemonBindingSource.DataSource = tempPokemon;
            FormSet = true;

            //tempPokemon.HeldItem = Items.Acro_Bike;

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

        private void pbSprite_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            PictureBox picbox = (PictureBox)sender;
            g.Clear(picbox.BackColor);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.DrawImage(picbox.Image, new Rectangle(new Point(0, 0), picbox.Size));
        }
    }
}