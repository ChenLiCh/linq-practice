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

namespace prjPosDemo.Views
{
    public partial class FrmProductEditor : Form
    {
        public DialogResult isOk {  get; set; }
        private tProduct _product;
        public tProduct product
        {
            get
            {
                if (_product == null)
                {
                    _product = new tProduct();
                }
                _product.fId = Convert.ToInt32(fbId.fieldValue);
                _product.fName = fbName.fieldValue;
                _product.fQty = Convert.ToInt32(fbQty.fieldValue);
                _product.fPrice = Convert.ToDecimal(fbPrice.fieldValue);
                _product.fCost = Convert.ToDecimal(fbCost.fieldValue);
                _product.fMemo = fbMemo.fieldValue;
                return _product;
            }
            // 物件資料填進表格內
            set
            {
                _product = value;
                fbId.fieldValue = _product.fId.ToString();
                fbName.fieldValue = _product.fName;
                fbQty.fieldValue = _product.fQty.ToString();
                fbPrice.fieldValue = _product.fPrice.ToString();
                fbCost.fieldValue = _product.fCost.ToString();
                fbMemo.fieldValue = _product.fMemo;
                if (_product.fImage != null)
                {
                    try
                    {
                        Stream streamImage = new MemoryStream(_product.fImage);
                        pictureBox1.Image = Bitmap.FromStream(streamImage);
                    }
                    catch { }
                }
            }
        }
        public FrmProductEditor()
        {
            InitializeComponent();
        }

        // 確認按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            if (string.IsNullOrEmpty(fbName.fieldValue))
                message += "\r\n品名不可空白";
            if (string.IsNullOrEmpty(fbPrice.fieldValue))
                message += "\r\n價格不可空白";
            else
            {
                if (!isNumber(fbPrice.fieldValue))
                    message += "\r\n價格必須是數字";
            }

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            this.isOk = DialogResult.OK;
            Close();
        }

        private bool isNumber(string p)
        {
            try
            {
                double d = Convert.ToDouble(p);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            // 只有 *.png 或 *.jpg 的檔案可以被使用者看到並選取
            openFileDialog1.Filter = "商品照片|*.png|'商品照片|*.jpg";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            // 串流
            FileStream imgStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStream);
            this.product.fImage = reader.ReadBytes((int)imgStream.Length);
            reader.Close();
            imgStream.Close();
        }
    }
}
