#region Using

using PKMDS_CS;
using System;
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
            speciesComboBox.DataSource = Enum.GetValues(typeof(Species))
                    .Cast<Species>()
                    .Where(s => s != Species.NoSpecies)
                    .ToArray<Species>();

            itemComboBox.DataSource = Enum.GetValues(typeof(Items))
                    .Cast<Items>()
                    .ToArray<Items>();

            pbSprite.DataBindings.Add("Image", _pokemonBindingSource, "BoxIcon", false, DataSourceUpdateMode.Never, null);
            speciesComboBox.DataBindings.Add("SelectedItem", tempPokemon, "Species", false, DataSourceUpdateMode.OnPropertyChanged, Species.NoSpecies);
            itemComboBox.DataBindings.Add("SelectedItem", tempPokemon, "HeldItem", false, DataSourceUpdateMode.OnPropertyChanged, Items.NoItem);
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
    }
}