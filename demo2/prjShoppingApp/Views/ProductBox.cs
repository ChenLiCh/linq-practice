using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjShoppingApp.Views
{
    public delegate void DProductClick(tProduct p);
    public partial class ProductBox : UserControl
    {
        public event DProductClick addToCart;
        private tProduct _room;
        public ProductBox()
        {
            InitializeComponent();
        }
        public tProduct product
        {
            get { return _room; }
            set
            {
                _room = value;
                lblMemo.Text = _room.fMemo;
                lblName.Text = _room.fName;
                lblPrice.Text = _room.fPrice.ToString();
                Stream s = new MemoryStream(_room.fImage);
                pictureBox1.Image = Bitmap.FromStream(s);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (addToCart != null)
                addToCart(this._room);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if (addToCart != null)
                addToCart(this._room);
        }

        private void lblMemo_Click(object sender, EventArgs e)
        {
            if (addToCart != null)
                addToCart(this._room);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            if (addToCart != null)
                addToCart(this._room);
        }

    }
}
