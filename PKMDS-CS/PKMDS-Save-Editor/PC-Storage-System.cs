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
        private List<Pokemon> Box = new List<Pokemon>();
        //private PCBox Box = new PCBox();
        public PKMDS_Save_Editor()
        {
            InitializeComponent();
        }

        private void PKMDS_Save_Editor_Load(object sender, EventArgs e)
        {
            // PokeList.Clear();

            MessageBox.Show(string.Format("Size of PC Box: {0}", System.Runtime.InteropServices.Marshal.SizeOf(typeof(PCBox)).ToString("X")));

            //XYSav sav = StructUtils.RawDeserialize<XYSav>(xysavfile);
            //PCStorageSystem pcstorage = StructUtils.RawDeserialize<PCStorageSystem>(xysavfile, 0x27A00);
            //PCBox box = StructUtils.RawDeserialize<PCBox>(xysavfile, 0x27A00);


            Box.Add(StructUtils.RawDeserialize<Pokemon>(charizard));
            Box.Add(StructUtils.RawDeserialize<Pokemon>(jynx));
            Box.Add(StructUtils.RawDeserialize<Pokemon>(mewtwo));

            //PokeList.Add(StructUtils.RawDeserialize<Pokemon>(charizard));
            //PokeList.Add(StructUtils.RawDeserialize<Pokemon>(jynx));
            //PokeList.Add(StructUtils.RawDeserialize<Pokemon>(mewtwo));

            //PokeList[0].Species = Species.Farfetchd;



            Pokemon pkm = new Pokemon { Species = Species.Nidoran_m };
            Debug.WriteLine(pkm.ToString());

            //foreach (Pokemon pokemon in PokeList)
            //{
            //    Debug.WriteLine(pokemon.Species.EnumToString());
            //}

            bs.DataSource = Box;
            dgData.DataSource = bs;
        }
    }
}