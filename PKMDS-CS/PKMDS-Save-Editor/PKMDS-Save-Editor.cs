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
        List<Pokemon> PokeList = new List<Pokemon>();
        BindingSource bs = new BindingSource();
        private void PKMDS_Save_Editor_Load(object sender, EventArgs e)
        {
            PokeList.Clear();
            PokeList.Add(new Pokemon {HP_IV = 25 });
            bs.DataSource = PokeList;
            dgData.DataSource = bs;
        }
    }
}
