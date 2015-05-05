#region Using

using PKMDS_CS;
using System;
using System.Linq;
using System.Windows.Forms;

#endregion Using

namespace PKMDS_Save_Editor
{
    public partial class Pokemon_Editor : Form
    {
        public Pokemon_Editor()
        {
            InitializeComponent();
        }

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
                    .Where(p => p != Species.NoSpecies)
                    .ToArray<Species>();
            pbSprite.DataBindings.Add("Image", _pokemonBindingSource, "BoxIcon", false, DataSourceUpdateMode.Never, null);
            speciesComboBox.DataBindings.Add("SelectedItem", tempPokemon, "Species", false, DataSourceUpdateMode.OnPropertyChanged, Species.NoSpecies);
            FormPopulated = true;
        }

        public void SetForm()
        {
            PopulateForm();
            _pokemonBindingSource.DataSource = tempPokemon;
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