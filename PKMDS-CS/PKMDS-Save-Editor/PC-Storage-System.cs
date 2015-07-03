#region Using

using PKMDS_CS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

#endregion Using

namespace PKMDS_Save_Editor
{
    public partial class PC_Storage_System_Form : Form
    {
        private const string veekundb = @"..\..\..\..\PKMDS-DB\veekun-pokedex.sqlite";
        private const string xysavfile = @"..\..\..\files\sav\PokemonXYDecrypted.sav";
        private static Pokemon_Editor_Form PokemonEditorForm = new Pokemon_Editor_Form();
        private static Form reportForm = new Form();
        private static DataGridView dgPokemon = new DataGridView();
        private static readonly Color SelectionColor = Color.Wheat;
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
                pbSlots[slot].DataBindings.Add("Image", _pokemonBindingSource[slot], "BoxIconEgg", true, DataSourceUpdateMode.Never, null);
                pbSlots[slot].DoubleClick += slot_DoubleClick;
                pbSlots[slot].MouseEnter += slot_MouseEnter;
                pbSlots[slot].MouseLeave += slot_MouseLeave;
                flpMain.Controls.Add(pbSlots[slot]);
            }
            panelBoxedPokemon.Controls.Add(flpMain);
            comboBoxes.DataSource = _boxenamesBindingSource;
            comboBoxes.DataBindings.Add("SelectedIndex", _sav, "CurrentBox", false, DataSourceUpdateMode.OnPropertyChanged, 0);
            textBoxName.DataBindings.Add("Text", _boxenamesBindingSource, "Name", false, DataSourceUpdateMode.OnValidation, "");
            SetReportForm();
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
                if (pokemon.Species == Species.NoSpecies) return;
                PokemonEditorForm.Pokemon = pokemon;
                PokemonEditorForm.SetForm();
                PokemonEditorForm.ShowDialog();
                RefreshBoxSlots(slot);
            }
        }

        private void LoadSave(string saveFileName)
        {
            _sav = StructUtils.RawDeserialize<XYSav>(saveFileName);
            //_sav = StructUtils.RawDeserialize<ORASSav>(saveFileName);
            _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon).ToList().ForEach(pokemon => PokePRNG.DecryptPokemon(pokemon));
            comboBoxes.Items.Clear();
            comboBoxes.DataBindings.Clear();
            textBoxName.DataBindings.Clear();
            dgPokemon.DataSource = _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon).Where(pokemon => pokemon.Species != Species.NoSpecies).ToArray();
        }

        private void SetReportForm()
        {
            // Types
            // Gender
            // Pokerus
            // Kalos marker
            // Markings
            // Ribbon count

            dgPokemon.Dock = DockStyle.Fill;
            dgPokemon.AutoGenerateColumns = false;
            dgPokemon.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgPokemon.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "IsEgg",
                HeaderText = "Is Egg",
                DataPropertyName = "IsEgg"
            });

            dgPokemon.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nickname",
                HeaderText = "Nickname",
                DataPropertyName = "Nickname",
                MaxInputLength = (int)Consts.NameMaxLength,
                ValueType = typeof(string)
            });

            dgPokemon.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "Species",
                HeaderText = "Species",
                DataSource = Lists.SpeciesList,
                DataPropertyName = "Species",
                ValueMember = "Value",
                DisplayMember = "Name",
                DropDownWidth = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            });

            dgPokemon.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Level",
                HeaderText = "Level",
                DataPropertyName = "Level",
                ValueType = typeof(int),
                Tag = "numeric"
            });

            dgPokemon.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "HeldItem",
                HeaderText = "Held Item",
                DataSource = Lists.ItemList,
                DataPropertyName = "HeldItem",
                ValueMember = "Value",
                DisplayMember = "Name",
                DropDownWidth = 120,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            });

            dgPokemon.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "Nature",
                HeaderText = "Nature",
                DataSource = Enum.GetValues(typeof(Natures)).Cast<Natures>().ToArray<Natures>(),
                DataPropertyName = "Nature",
                DropDownWidth = 70,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            });

            dgPokemon.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "Ability",
                HeaderText = "Ability",
                DataSource = Lists.AbilityList,
                DataPropertyName = "Ability",
                ValueMember = "Value",
                DisplayMember = "Name",
                DropDownWidth = 120,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            });

            dgPokemon.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "OTName",
                HeaderText = "Original Trainer",
                DataPropertyName = "OTName",
                MaxInputLength = (int)Consts.NameMaxLength,
                ValueType = typeof(string)
            });

            dgPokemon.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "OTID",
                HeaderText = "Trainer ID",
                DataPropertyName = "OTID",
                ValueType = typeof(int),
                MaxInputLength = 5,
                Tag = "numeric"
            });
            dgPokemon.Columns["OTID"].DefaultCellStyle.Format = "00000";

            dgPokemon.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "Move1",
                HeaderText = "Move 1",
                DataSource = Lists.MoveList,
                DataPropertyName = "Move1",
                ValueMember = "Value",
                DisplayMember = "Name",
                DropDownWidth = 120,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            });

            dgPokemon.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "Move2",
                HeaderText = "Move 2",
                DataSource = Lists.MoveList,
                DataPropertyName = "Move2",
                ValueMember = "Value",
                DisplayMember = "Name",
                DropDownWidth = 120,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            });

            dgPokemon.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "Move3",
                HeaderText = "Move 3",
                DataSource = Lists.MoveList,
                DataPropertyName = "Move3",
                ValueMember = "Value",
                DisplayMember = "Name",
                DropDownWidth = 120,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            });

            dgPokemon.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "Move4",
                HeaderText = "Move 4",
                DataSource = Lists.MoveList,
                DataPropertyName = "Move4",
                ValueMember = "Value",
                DisplayMember = "Name",
                DropDownWidth = 120,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            });

            dgPokemon.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "HP",
                HeaderText = "HP",
                DataPropertyName = "HP",
                ValueType = typeof(int),
                ReadOnly = true
            });

            dgPokemon.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Attack",
                HeaderText = "Attack",
                DataPropertyName = "Attack",
                ValueType = typeof(int),
                ReadOnly = true
            });

            dgPokemon.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Defense",
                HeaderText = "Defense",
                DataPropertyName = "Defense",
                ValueType = typeof(int),
                ReadOnly = true
            });

            dgPokemon.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "SpAttack",
                HeaderText = "Special Attack",
                DataPropertyName = "SpecialAttack",
                ValueType = typeof(int),
                ReadOnly = true
            });

            dgPokemon.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "SpDefense",
                HeaderText = "Special Defense",
                DataPropertyName = "SpecialDefense",
                ValueType = typeof(int),
                ReadOnly = true
            });

            dgPokemon.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Speed",
                HeaderText = "Speed",
                DataPropertyName = "Speed",
                ValueType = typeof(int),
                ReadOnly = true
            });

            foreach (DataGridViewColumn col in dgPokemon.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgPokemon.RowHeadersVisible = false;
            reportForm.StartPosition = FormStartPosition.CenterParent;
            reportForm.Size = new Size(800, 600);
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dgPokemon, new object[] { true });
            dgPokemon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPokemon.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgPokemon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dgPokemon.DefaultCellStyle.SelectionBackColor = SelectionColor;
            dgPokemon.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            dgPokemon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reportForm.Controls.Add(dgPokemon);
            reportForm.FormClosing += ReportForm_FormClosing;
            dgPokemon.DataError += DgPokemon_DataError;
            dgPokemon.CellMouseDoubleClick += dgPokemon_CellMouseDoubleClick;
            reportForm.Load += ReportForm_Load;
            dgPokemon.EditingControlShowing += DgPokemon_EditingControlShowing;
        }

        private void dgPokemon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Pokemon pokemon = ((dgPokemon.DataSource as Pokemon[])[e.RowIndex] as Pokemon);
            PokemonEditorForm.Pokemon = pokemon;
            PokemonEditorForm.SetForm();
            PokemonEditorForm.ShowDialog();
        }

        private void DgPokemon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(NumericColumn_KeyPress);
            if (dgPokemon.Columns[dgPokemon.CurrentCell.ColumnIndex].Tag != null &&
                dgPokemon.Columns[dgPokemon.CurrentCell.ColumnIndex].Tag.ToString() == "numeric") //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(NumericColumn_KeyPress);
                }
            }
        }

        private void NumericColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            dgPokemon.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void DgPokemon_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
                e.Cancel = !(MessageBox.Show(e.Exception.Message, "Data Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Cancel);
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgPokemon.EndEdit();
            RefreshBoxSlots();
        }

        private void WriteSave(string saveFileName)
        {
            _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon).ToList().ForEach(pokemon => PokePRNG.EncryptPokemon(pokemon));
            StructUtils.RawSerialize(_sav, saveFileName);
        }

        private void PKMDS_Save_Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                WriteSave(xysavfile);
                DBTools.CloseDB();
            }
            catch (Exception) { }
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
                pbSlots[Slot].DataBindings.Add("Image", _pokemonBindingSource[Slot], "BoxIconEgg", true, DataSourceUpdateMode.Never, null);
            }
            else
            {
                foreach (PictureBox pbSlot in pbSlots)
                {
                    pbSlot.DataBindings.Clear();
                }
                for (int slot = 0; slot < 30; slot++)
                {
                    pbSlots[slot].DataBindings.Add("Image", _pokemonBindingSource[slot], "BoxIconEgg", true, DataSourceUpdateMode.Never, null);
                }
            }
        }

        private void viewAllPokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportForm.ShowDialog();
        }

        private void sortPokémonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var allpokemon = _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon).ToList().Where(pokemon => pokemon.Species != PKMDS_CS.Species.NoSpecies).ToList();
            allpokemon.Sort();
            List<Pokemon> sortedList = new List<Pokemon>();
            for (int i = 0; i < allpokemon.Count; i++)
            {
                sortedList.Add(new Pokemon());
                sortedList[i].CloneFrom(allpokemon[i]);
            }
            int p = 0;
            Pokemon blank = new Pokemon();
            foreach (var pokemon in _sav.PCStorageSystem.Boxes.SelectMany(box => box.Pokemon).ToList())
            {
                if (p < allpokemon.Count)
                {
                    pokemon.CloneFrom(sortedList[p]);
                    p++;
                }
                else
                {
                    pokemon.CloneFrom(blank);
                }
            }
            RefreshBoxSlots();
        }
    }
}