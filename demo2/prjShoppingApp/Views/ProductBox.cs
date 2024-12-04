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
        private tProduct _product;
        public ProductBox()
        {
            InitializeComponent();
        }
        public tProduct product
        {
            get { return _product; }
            set
            {
                _product = value;
                lblMemo.Text = _product.fMemo;
                lblName.Text = _product.fName;
                lblPrice.Text = _product.fPrice.ToString();
                Stream s = new MemoryStream(_product.fImage);
                pictureBox1.Image = Bitmap.FromStream(s);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (addToCart != null)
                addToCart(this._product);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if (addToCart != null)
                addToCart(this._product);
        }

        private void lblMemo_Click(object sender, EventArgs e)
        {
            if (addToCart != null)
                addToCart(this._product);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            if (addToCart != null)
                addToCart(this._product);
        }

    }
}
