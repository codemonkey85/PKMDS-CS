using PKMDS_CS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKMDS_Save_Editor
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private ItemObject _item, _tempItem;
        public ItemObject Item
        {
            get
            {
                return _item;
            }
        }

        public void SetItem(ItemObject Item)
        {
            _item = Item;
            _tempItem = Item;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            _item.Value = Items.Master_Ball;
            _item.Quantity = 23;
        }
    }
}
