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
        private const string charizard = @"..\..\..\files\pk6\006 - Charizard - 853622BD286F.pk6";
        private const string jynx = @"..\..\..\files\pk6\124 - Jynx - 8028D005DE59.pk6";
        private const string mewtwo = @"..\..\..\files\pk6\150 - Mewtwo - 9AA4BEBE0B35.pk6";
        private const string xysavfile = @"..\..\..\files\sav\PokemonXYDecrypted.sav";
        private readonly BindingSource _bs = new BindingSource();
        private XYSav _sav;

        public PKMDS_Save_Editor()
        {
            InitializeComponent();
        }

        private void PKMDS_Save_Editor_Load(object sender, EventArgs e)
        {
            LoadSave(xysavfile);
            _bs.DataSource = _sav.PCStorageSystem.Boxes[5].Pokemon;
            dgData.DataSource = _bs;
        }

        private void LoadSave(string saveFileName)
        {
            _sav = StructUtils.RawDeserialize<XYSav>(saveFileName);
            foreach (var pokemon in _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon))
            {
                PokePRNG.DecryptPokemon(pokemon);
            }
        }
    }
}