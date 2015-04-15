#region Using

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using PKMDS_CS;

#endregion

namespace PKMDS_Save_Editor
{
    public partial class PKMDS_Save_Editor : Form
    {
        private BindingSource bs = new BindingSource();
        private string charizard = @"..\..\..\files\pk6\006 - Charizard - 853622BD286F.pk6";
        private string jynx = @"..\..\..\files\pk6\124 - Jynx - 8028D005DE59.pk6";
        private string mewtwo = @"..\..\..\files\pk6\150 - Mewtwo - 9AA4BEBE0B35.pk6";
        private string xysavfile = @"..\..\..\files\sav\PokemonXYDecrypted.sav";
            XYSav sav;
        public PKMDS_Save_Editor()
        {
            InitializeComponent();
        }

        private void PKMDS_Save_Editor_Load(object sender, EventArgs e)
        {
            sav = StructUtils.RawDeserialize<XYSav>(xysavfile);
            for (int box = 0; box < 31; box++ )
            {
                for (int slot = 0; slot < 30; slot++) 
                {
                    Pokemon pokemon = sav.PCStorageSystem[box][slot];
                    PokePRNG.DecryptPokemon(ref pokemon);
                    sav.PCStorageSystem[box][slot] = pokemon;
                }
            }
            bs.DataSource = sav.PCStorageSystem.Boxes[0].Pokemon;
            dgData.DataSource = bs;
        }

        private void dgData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("");
        }
    }
}