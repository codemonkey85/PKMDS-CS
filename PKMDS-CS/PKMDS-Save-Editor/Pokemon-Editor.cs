#region Using

using PKMDS_CS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#endregion Using

namespace PKMDS_Save_Editor
{
    public partial class Pokemon_Editor_Form : Form
    {
        private Pokemon _pokemon;
        private Pokemon _tempPokemon = new Pokemon();
        private List<PictureBox> _markingsBoxes = new List<PictureBox>();
        private readonly BindingSource _pokemonBindingSource = new BindingSource();
        private bool _dataBindingsSet = false;

        public Pokemon Pokemon { get { return _pokemon; } set { _pokemon = value; _tempPokemon.CloneFrom(_pokemon); } }

        public Pokemon_Editor_Form()
        {
            InitializeComponent();
        }

        public void SetForm()
        {
            if (_dataBindingsSet) return;
            speciesComboBox.DataSource = Lists.SpeciesList;
            speciesComboBox.DataBindings.Add("SelectedItem", _pokemonBindingSource, "Species", false, DataSourceUpdateMode.OnPropertyChanged);
            pbSprite.DataBindings.Add("Image", _pokemonBindingSource, "BoxIconEgg", true, DataSourceUpdateMode.Never, null);
            _pokemonBindingSource.DataSource = _tempPokemon;
            _dataBindingsSet = true;
        }

        private void SavePokemon()
        {
            if (!checkBoxEggMet.Checked)
            {
                _tempPokemon.EggLocation = Locations.Mystery_Zone;
                _tempPokemon.EggDate = null;
            }

            _pokemon.CloneFrom(_tempPokemon);
        }

        private void buttonApply_Click(object sender, System.EventArgs e)
        {
            try
            {
                SavePokemon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {
            try
            {
                SavePokemon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void PictureBox_Paint_and_Resize(object sender, PaintEventArgs e)
        {
            PictureBox picbox = (PictureBox)sender;
            if (picbox.Image == null) return;
            Graphics g = e.Graphics;
            g.Clear(picbox.BackColor);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.DrawImage(picbox.Image, new Rectangle(new Point(0, 0), picbox.Size));
        }

        private void Pokemon_Editor_Form_Load(object sender, EventArgs e)
        {
            _pokemonBindingSource.ResetBindings(false);
            if (markingsPanel.Controls.Count != 0) return;
            FlowLayoutPanel flp = new FlowLayoutPanel();
            for (int i = 0; i < 6; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Name = string.Format("pb{0}", (Markings)i);
                pb.Tag = (Markings)i;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Size = new Size(10, 10);
                pb.Click += pbMarkings_Click;
                flp.Controls.Add(pb);
                _markingsBoxes.Add(pb);
            }
            _markingsBoxes[(int)Markings.Circle].DataBindings.Add("Image", _pokemonBindingSource, "Circle", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Circle, false));
            _markingsBoxes[(int)Markings.Triangle].DataBindings.Add("Image", _pokemonBindingSource, "Triangle", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Triangle, false));
            _markingsBoxes[(int)Markings.Square].DataBindings.Add("Image", _pokemonBindingSource, "Square", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Square, false));
            _markingsBoxes[(int)Markings.Heart].DataBindings.Add("Image", _pokemonBindingSource, "Heart", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Heart, false));
            _markingsBoxes[(int)Markings.Star].DataBindings.Add("Image", _pokemonBindingSource, "Star", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Star, false));
            _markingsBoxes[(int)Markings.Diamond].DataBindings.Add("Image", _pokemonBindingSource, "Diamond", true, DataSourceUpdateMode.Never, Images.GetMarkingImage(Markings.Diamond, false));

            foreach (PictureBox pb in _markingsBoxes)
            {
                pb.DataBindings[0].Format += MarkingsImageFormat;
            }

            markingsPanel.Controls.Add(flp);
        }

        private void MarkingsImageFormat(object sender, ConvertEventArgs e)
        {
            var pb = (PictureBox)((Binding)sender).Control;
            Markings mark = new Markings();
            Enum.TryParse<Markings>(pb.Tag.ToString(), out mark);
            e.Value = Images.GetMarkingImage(mark, (bool)e.Value);
        }

        private void pbMarkings_Click(object sender, EventArgs e)
        {
            var pb = (PictureBox)sender;
            switch ((Markings)((pb).Tag))
            {
                case Markings.Circle:
                    _tempPokemon.Circle = !_tempPokemon.Circle;
                    break;

                case Markings.Triangle:
                    _tempPokemon.Triangle = !_tempPokemon.Triangle;
                    break;

                case Markings.Square:
                    _tempPokemon.Square = !_tempPokemon.Square;
                    break;

                case Markings.Heart:
                    _tempPokemon.Heart = !_tempPokemon.Heart;
                    break;

                case Markings.Star:
                    _tempPokemon.Star = !_tempPokemon.Star;
                    break;

                case Markings.Diamond:
                    _tempPokemon.Diamond = !_tempPokemon.Diamond;
                    break;
            }
            pb.DataBindings[0].ReadValue();
        }
    }
}