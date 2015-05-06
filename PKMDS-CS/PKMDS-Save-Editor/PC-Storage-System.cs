#region Using

using PKMDS_CS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#endregion Using

namespace PKMDS_Save_Editor
{
    public partial class PC_Storage_System_Form : Form
    {
        private const string veekundb = @"..\..\..\..\PKMDS-DB\veekun-pokedex.sqlite";
        private const string xysavfile = @"..\..\..\files\sav\PokemonXYDecrypted.sav";
        private static Pokemon_Editor_Form PokemonEditorForm = new Pokemon_Editor_Form();
        private static readonly Color SelectionColor = System.Drawing.Color.FromArgb(127, 255, 165, 0);
        private readonly BindingSource _boxesBindingSource = new BindingSource();
        private readonly BindingSource _pokemonBindingSource = new BindingSource();
        private CurrencyManager _boxesCurrencyManager;

        private readonly BindingSource _boxenamesBindingSource = new BindingSource();
        private CurrencyManager _boxenamesCurrencyManager;

        private XYSav _sav;
        //private ORASSav _sav;

        public PC_Storage_System_Form()
        {
            InitializeComponent();
        }

        private List<PictureBox> pbSlots = new List<PictureBox>();

        private void PKMDS_Save_Editor_Load(object sender, EventArgs e)
        {
            DBTools.OpenDB(veekundb);
            LoadSave(xysavfile);
            _boxenamesCurrencyManager = _boxenamesBindingSource.CurrencyManager;
            _boxenamesBindingSource.DataSource = _sav.PCStorageBoxNames.Boxes;

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
                pbSlots.Add(new PictureBox
                {
                    Name = string.Format("pbSlot{00}", slot),
                    Tag = string.Format("{0}", slot),
                    Size = new Size(40, 30),
                    Margin = new Padding(0, 0, 0, 0),
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    BorderStyle = BorderStyle.None
                });
                pbSlots[slot].DataBindings.Add("Image", _pokemonBindingSource[slot], "BoxIcon", true, DataSourceUpdateMode.Never, null);
                pbSlots[slot].DoubleClick += slot_DoubleClick;
                pbSlots[slot].MouseEnter += slot_MouseEnter;
                pbSlots[slot].MouseLeave += slot_MouseLeave;
                flpMain.Controls.Add(pbSlots[slot]);
                //comboBoxes.Items.Add(string.Format("Box {0}", slot + 1));
            }
            //comboBoxes.Items.Add(string.Format("Box {0}", 31));
            panelBoxedPokemon.Controls.Add(flpMain);
            comboBoxes.SelectedIndex = 0;
        }

        private void slot_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = System.Drawing.SystemColors.Control;
        }

        private void slot_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = SelectionColor;
        }

        private void slot_DoubleClick(object sender, EventArgs e)
        {
            int slot = 0;
            if (int.TryParse(((PictureBox)sender).Tag.ToString(), out slot))
            {
                Pokemon pokemon = (Pokemon)_pokemonBindingSource[slot];
                PokemonEditorForm.Pokemon = pokemon;
                PokemonEditorForm.SetForm();
                PokemonEditorForm.ShowDialog();
                RefreshBoxSlots();
            }
        }

        private void LoadSave(string saveFileName)
        {
            _sav = StructUtils.RawDeserialize<XYSav>(saveFileName);
            //_sav = StructUtils.RawDeserialize<ORASSav>(saveFileName);
            foreach (var pokemon in _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon))
            {
                //pokemon.Decrypt();
                PokePRNG.DecryptPokemon(pokemon);
            }
            comboBoxes.Items.Clear();
            comboBoxes.DataSource = _boxenamesBindingSource;
            textBoxName.DataBindings.Clear();
            textBoxName.DataBindings.Add("Text", _boxenamesBindingSource, null, false, DataSourceUpdateMode.OnValidation, "");
        }

        private void WriteSave(string saveFileName)
        {
            foreach (var pokemon in _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon))
            {
                //pokemon.Encrypt();
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
                _boxesCurrencyManager.Position = comboBoxes.SelectedIndex;
                _boxenamesCurrencyManager.Position = comboBoxes.SelectedIndex;
                _pokemonBindingSource.DataSource = _boxesCurrencyManager.Current;
                RefreshBoxSlots();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error with databinding: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshBoxSlots(int Slot = 0)
        {
            if (Slot != 0)
            {
                pbSlots[Slot].DataBindings.Clear();
                pbSlots[Slot].DataBindings.Add("Image", _pokemonBindingSource[Slot], "BoxIcon", true, DataSourceUpdateMode.Never, null);
            }
            else
            {
                foreach (PictureBox pbSlot in pbSlots)
                {
                    pbSlot.DataBindings.Clear();
                }
                for (int slot = 0; slot < 30; slot++)
                {
                    pbSlots[slot].DataBindings.Add("Image", _pokemonBindingSource[slot], "BoxIcon", true, DataSourceUpdateMode.Never, null);
                }
            }
        }
    }
}