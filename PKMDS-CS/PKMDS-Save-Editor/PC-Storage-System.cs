#region Using

using System;
using System.Linq;
using System.Windows.Forms;
using PKMDS_CS;
using System.Drawing;
using System.Data;
using System.Collections.Generic;

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
        private readonly BindingSource _pokemonBindingSource = new BindingSource();
        private CurrencyManager _boxesCurrencyManager;
        private XYSav _sav;
        //private ORASSav _sav;

        public PKMDS_Save_Editor()
        {
            InitializeComponent();
        }

        List<PictureBox> pbSlots = new List<PictureBox>();
        private void PKMDS_Save_Editor_Load(object sender, EventArgs e)
        {
            DBTools.OpenDB(veekundb);
            LoadSave(xysavfile);
            _boxesCurrencyManager = _boxesBindingSource.CurrencyManager;
            _boxesBindingSource.DataSource = _sav.PCStorageSystem.Boxes;
            _pokemonBindingSource.DataSource = _boxesCurrencyManager.Current;
            _pokemonBindingSource.DataMember = "Pokemon";
            FlowLayoutPanel flpMain = new FlowLayoutPanel();
            flpMain.Name = "flpMain";
            flpMain.Size = new Size(6 * 40, 5 * 30);
            flpMain.Location = new Point(0, 0);
            pbSlots.Clear();
            for (int slot = 0; slot < 30; slot++)
            {
                pbSlots.Add(new PictureBox { Name = string.Format("pbSlot{00}", slot), Tag = string.Format("{0}", slot), Size = new Size(40, 30), Margin = new Padding(0, 0, 0, 0), SizeMode = PictureBoxSizeMode.CenterImage, BorderStyle = BorderStyle.FixedSingle });
                pbSlots[slot].DataBindings.Add("Image", _pokemonBindingSource[slot], "BoxIcon", true, DataSourceUpdateMode.Never, null);
                pbSlots[slot].DoubleClick += PKMDS_Save_Editor_DoubleClick;
                flpMain.Controls.Add(pbSlots[slot]);
                comboBoxes.Items.Add(string.Format("Box {0}", slot + 1));
            }
            comboBoxes.Items.Add(string.Format("Box {0}", 31));
            this.Controls.Add(flpMain);
            comboBoxes.SelectedIndex = 0;
        }

        void PKMDS_Save_Editor_DoubleClick(object sender, EventArgs e)
        {
            int slot = 0;
            if (int.TryParse(((PictureBox)sender).Tag.ToString(), out slot))
            {
                MessageBox.Show(_pokemonBindingSource[slot].ToString());
            }
        }

        private void LoadSave(string saveFileName)
        {
            _sav = StructUtils.RawDeserialize<XYSav>(saveFileName);
            //_sav = StructUtils.RawDeserialize<ORASSav>(saveFileName);
            ushort species = 0;
            foreach (var pokemon in _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon))
            {
                PokePRNG.DecryptPokemon(pokemon);
                if (pokemon.Species != Species.NoSpecies) 
                {
                    pokemon.Species = (Species)(++species);
                }
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

        private void PKMDS_Save_Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBTools.CloseDB();
        }

        private void comboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxes.SelectedIndex == -1) return;
            try
            {
                foreach (PictureBox pbSlot in pbSlots)
                {
                    pbSlot.DataBindings.Clear();
                }
                _boxesCurrencyManager.Position = comboBoxes.SelectedIndex;
                _pokemonBindingSource.DataSource = _boxesCurrencyManager.Current;
                for (int slot = 0; slot < 30; slot++)
                {
                    pbSlots[slot].DataBindings.Add("Image", _pokemonBindingSource[slot], "BoxIcon", true, DataSourceUpdateMode.Never, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error with databinding: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}