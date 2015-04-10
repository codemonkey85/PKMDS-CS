using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKMDS_CS;
namespace PKMDS_Save_Editor
{
    public partial class PKMDS_Save_Editor : Form
    {
        public PKMDS_Save_Editor()
        {
            InitializeComponent();
        }
        string charizard = @"..\..\..\files\pk6\006 - Charizard - 853622BD286F.pk6";
        string jynx = @"..\..\..\files\pk6\124 - Jynx - 8028D005DE59.pk6";
        string mewtwo = @"..\..\..\files\pk6\150 - Mewtwo - 9AA4BEBE0B35.pk6";
        List<Pokemon> PokeList = new List<Pokemon>();
        BindingSource bs = new BindingSource();
        private void PKMDS_Save_Editor_Load(object sender, EventArgs e)
        {
            PokeList.Clear();
            PokeList.Add(StructUtils.RawDeserialize<Pokemon>(charizard));
            PokeList.Add(StructUtils.RawDeserialize<Pokemon>(jynx));
            PokeList.Add(StructUtils.RawDeserialize<Pokemon>(mewtwo));
            bs.DataSource = PokeList;
            dgData.DataSource = bs;
        }
    }
}
