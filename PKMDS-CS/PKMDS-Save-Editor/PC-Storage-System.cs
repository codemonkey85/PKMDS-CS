#region Using

using System;
using System.Linq;
using System.Windows.Forms;
using PKMDS_CS;

#endregion

namespace PKMDS_Save_Editor
{
    public partial class PKMDS_Save_Editor : Form
    {
        private const string veekundb = @"..\..\..\..\PKMDS-DB\veekun-pokedex.sqlite";
        private const string yellowstone = @"..\..\..\files\pk6\Yellowstone - C9A14631.pk6";
        private const string charizard = @"..\..\..\files\pk6\006 - Charizard - 853622BD286F.pk6";
        private const string jynx = @"..\..\..\files\pk6\124 - Jynx - 8028D005DE59.pk6";
        private const string mewtwo = @"..\..\..\files\pk6\150 - Mewtwo - 9AA4BEBE0B35.pk6";
        private const string xysavfile = @"..\..\..\files\sav\PokemonXYDecrypted.sav";
        private const string main = @"..\..\..\files\secret\main.sav";
        private const string main1 = @"..\..\..\files\secret\main1.sav";
        private const string main25 = @"..\..\..\files\secret\main25.sav";
        private const string main37 = @"..\..\..\files\secret\main37.sav";
        private const string ramsav = @"..\..\..\files\secret\ramsav.bin";
        private const string ramsav2 = @"..\..\..\files\secret\ramsav2.bin";
        private const string ramsav_combined = @"..\..\..\files\secret\ramsav_combined.bin";
        private readonly BindingSource _boxesBindingSource = new BindingSource();
        private CurrencyManager _boxesCurrencyManager;
        private XYSav _sav;
        //private ORASSav _sav;

        public PKMDS_Save_Editor()
        {
            InitializeComponent();
        }

        private void PKMDS_Save_Editor_Load(object sender, EventArgs e)
        {

            Pokemon pkm = StructUtils.RawDeserialize<Pokemon>(yellowstone);
            pkm.PokeRusDays = 11;
            pkm.PokeRusStrain = 11;
            System.Diagnostics.Debug.WriteLine(pkm.ToString());

            LoadSave(xysavfile);
            _boxesCurrencyManager = _boxesBindingSource.CurrencyManager;
            _boxesBindingSource.DataSource = _sav.PCStorageSystem.Boxes;
            // .Where(box => box.Pokemon.Any(pokemon => pokemon.Species == Species.Charmander));
            dgData.DataSource = _boxesBindingSource;
            dgData.DataMember = "Pokemon";
            boxesComboBox.SelectedIndex = 0;
            DBTools.OpenDB(veekundb);
        }

        private void LoadSave(string saveFileName)
        {
            _sav = StructUtils.RawDeserialize<XYSav>(saveFileName);
            //_sav = StructUtils.RawDeserialize<ORASSav>(saveFileName);
            foreach (var pokemon in _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon))
            {
                PokePRNG.DecryptPokemon(pokemon);
            }
        }

        private void WriteSave(string saveFileName)
        {
            foreach (var pokemon in _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon))
            {
                PokePRNG.EncryptPokemon(pokemon);
            }
            StructUtils.RawSerialize(_sav, saveFileName);
        }

        private void boxesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxesComboBox.SelectedIndex == -1) return;
            _boxesCurrencyManager.Position = boxesComboBox.SelectedIndex;
        }

        private void PKMDS_Save_Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBTools.CloseDB();
            //StructUtils.RawSerialize(_sav.PCStorageSystem[0][0], @"C:\Users\Mike\Downloads\test.pk6");
        }
    }
}