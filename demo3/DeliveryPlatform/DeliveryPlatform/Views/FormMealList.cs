using DeliveryPlatform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryPlatform.Views {
    public partial class FormMealList : Form {

        int _position = -1;
        private List<CMealWrap> _list;
        public FormMealList() {
            InitializeComponent();
        }

        private void FormMealList_Load(object sender, EventArgs e) {
            displayMeals();
        }

        private void displayMeals() {
            dbDeliveryEntities db = new dbDeliveryEntities();
            var x = from meal in db.tMeal
                    select meal;
            _list = new List<CMealWrap>();
            foreach (var p in x) _list.Add(new CMealWrap(p));
            dataGridView1.DataSource = _list;
            resetGridStyle();
        }

        private void FormMealList_Paint(object sender, PaintEventArgs e) {
            resetGridStyle();
        }

        private void resetGridStyle() {
            // 設定各欄位寬度
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;

            if (dataGridView1.Columns.Count > 2) {
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[4].Width = 200;
            }

            //dataGridView1.Columns[6].Width = 200;
            // RowHeadersWidth: 第一個欄位(只有箭頭)的寬度
            //dataGridView1.Columns[5].Width = dataGridView1.Width - 50 - 400 - 100 * 3 - 200 - dataGridView1.RowHeadersWidth;

            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows) {
                isColorChanged = !isColorChanged;

                // 各列的字體和大小
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.DefaultCellStyle.BackColor = Color.WhiteSmoke;

                // 各列的顏色交替變換
                if (isColorChanged) r.DefaultCellStyle.BackColor = Color.FromArgb(238, 238, 242);
            }
        }

        // 新增按鈕
        private void btnInsert_Click(object sender, EventArgs e) {
            FormMealEditor f = new FormMealEditor();
            f.ShowDialog();
            if (f.isOk == DialogResult.OK) {
                dbDeliveryEntities db = new dbDeliveryEntities();
                db.tMeal.Add(f.meal);
                db.SaveChanges();
                displayMeals();
            }
        }

        // 刪除按鈕
        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("確定要刪除嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No) return;

            CMealWrap uiMeal = _list[_position];
            dbDeliveryEntities db = new dbDeliveryEntities();
            tMeal dbMeal = db.tMeal.FirstOrDefault(data => data.fMealId == uiMeal.fId);

            if (dbMeal == null) return;
            db.tMeal.Remove(dbMeal);
            db.SaveChanges();

            _list.RemoveAt(_position);

            displayMeals();
        }

        // 修改按鈕
        private void toolStripButton4_Click(object sender, EventArgs e) {
            editMealSelected();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            editMealSelected();
        }

        private void editMealSelected() {
            if (_position < 0) return;

            FormMealEditor f = new FormMealEditor();
            f.meal = _list[_position].meal;
            f.ShowDialog();

            if (f.isOk == DialogResult.OK) {
                dbDeliveryEntities db = new dbDeliveryEntities();
                tMeal dbMeal = db.tMeal.FirstOrDefault(data => data.fMealId == f.meal.fMealId);
                if (dbMeal == null) return;
                dbMeal.fMealName = f.meal.fMealName;
                dbMeal.fMealQuantity = f.meal.fMealQuantity;
                dbMeal.fMealCost = f.meal.fMealCost;
                dbMeal.fMealCost = f.meal.fMealCost;
                dbMeal.fMealMemo = f.meal.fMealMemo;
                db.SaveChanges();
                displayMeals();
            }
        }

        // 查詢按鈕
        private void toolStripButton1_Click(object sender, EventArgs e) {
            dbDeliveryEntities db = new dbDeliveryEntities();

            //var x = from c in db.tMeal
            //        where c.fMealName.Contains(txtKeyword.Text) || c.fMealMemo.Contains(txtKeyword.Text)
            //        select c;
            //dataGridView1.DataSource = x.ToList();

            dataGridView1.DataSource = db.tMeal.Where(data => data.fMealName.Contains(txtKeyword.Text) || data.fMealMemo.Contains(txtKeyword.Text)).ToList();

            //dataGridView1.DataSource = _list.Where(data => data.fName.ToLower().Contains(txtKeyword.Text.ToLower()) || data.fMemo.ToLower().Contains(txtKeyword.Text.ToLower())).ToList();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e) {
            _position = e.RowIndex;
        }
    }
}
