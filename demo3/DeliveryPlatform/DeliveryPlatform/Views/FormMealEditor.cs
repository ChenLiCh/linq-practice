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

namespace DeliveryPlatform.Views {
    public partial class FormMealEditor : Form {
        public DialogResult isOk { get; set; }
        public FormMealEditor() {
            InitializeComponent();
        }

        private tMeal _meal;
        public tMeal meal {
            get {
                if (_meal == null) _meal = new tMeal();
                _meal.fMealId = Convert.ToInt32(fbMealId.fieldValue);
                _meal.fMealName = fbMealName.fieldValue;
                _meal.fMealQuantity = Convert.ToInt32(fbMealQty.fieldValue);
                _meal.fMealPrice = Convert.ToDecimal(fbMealPrice.fieldValue);
                _meal.fMealCost = Convert.ToDecimal(fbMealCost.fieldValue);
                _meal.fMealMemo = fbMealMemo.fieldValue;
                return _meal;
            }
            set {
                _meal = value;
                fbMealId.fieldValue = _meal.fMealId.ToString();
                fbMealName.fieldValue = _meal.fMealName;
                fbMealQty.fieldValue = _meal.fMealQuantity.ToString();
                fbMealPrice.fieldValue = _meal.fMealPrice.ToString();
                fbMealCost.fieldValue = _meal.fMealCost.ToString();
                fbMealMemo.fieldValue = _meal.fMealMemo;
                if (_meal.fMealImage != null) {
                    try {
                        Stream streamImage = new MemoryStream(_meal.fMealImage);
                        pictureBox1.Image = Bitmap.FromStream(streamImage);
                    }
                    catch { }
                }
            }
        }

        private bool isNumber(string p) {
            try {
                double d = Convert.ToDouble(p);
                return true;
            }
            catch {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        // 確認按鈕
        private void btnConfirm_Click(object sender, EventArgs e) {
            string message = "";
            if (string.IsNullOrEmpty(fbMealName.fieldValue))
                message += "\r\n餐點名稱不可空白";
            if (string.IsNullOrEmpty(fbMealPrice.fieldValue))
                message += "\r\n價格不可空白";
            else {
                if (!isNumber(fbMealPrice.fieldValue))
                    message += "\r\n價格必須是數字";
            }

            if (!string.IsNullOrEmpty(message)) {
                MessageBox.Show(message);
                return;
            }

            this.isOk=DialogResult.OK;
            Close();
        }

        // 取消按鈕
        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void pictureBox1_DoubleClick_1(object sender, EventArgs e) {
            // 只有 *.png 或 *.jpg 的檔案可以被使用者看到並選取
            openFileDialog1.Filter = "商品照片|*.png|'商品照片|*.jpg";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);

            // 串流
            FileStream imgStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStream);
            this.meal.fMealImage = reader.ReadBytes((int)imgStream.Length);
            reader.Close();
            imgStream.Close();
        }
    }
}
