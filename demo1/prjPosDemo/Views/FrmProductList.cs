using prjAdoDotNetDemo.Views;
using prjPosDemo.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPosDemo.Views
{
    public partial class FrmProductList : Form
    {
        //private int _pageCount = 3;
        int _position = -1;
        private List<CProductWrap> _list;
        public FrmProductList()
        {
            InitializeComponent();
        }

        private void FrmProductList_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            displayProducts();
        }

        private void displayProducts()
        {
            dbDemoEntities3 db = new dbDemoEntities3();
            var datas = from c in db.tProduct
                        select c;

            _list = new List<CProductWrap>();
            foreach (var p in datas) _list.Add(new CProductWrap(p));

            dataGridView1.DataSource = _list;
            resetGridStyle();
        }

        private void resetGridStyle()
        {
            // 設定各欄位寬度
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;

            if (dataGridView1.Columns.Count > 2)
            {
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[4].Width = 200;
            }

            //dataGridView1.Columns[6].Width = 200;
            // RowHeadersWidth: 第一個欄位(只有箭頭)的寬度
            //dataGridView1.Columns[5].Width = dataGridView1.Width - 50 - 400 - 100 * 3 - 200 - dataGridView1.RowHeadersWidth;

            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;

                // 各列的字體和大小
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.DefaultCellStyle.BackColor = Color.WhiteSmoke;

                // 各列的顏色交替變換
                if (isColorChanged) r.DefaultCellStyle.BackColor = Color.FromArgb(238, 238, 242);
            }
        }

        // 新增按鈕
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmProductEditor f = new FrmProductEditor();
            f.ShowDialog();

            if (f.isOk == DialogResult.OK)
            {
                dbDemoEntities3 db = new dbDemoEntities3();
                db.tProduct.Add(f.product);
                db.SaveChanges();
                displayProducts();
            }
        }

        // 刪除按鈕
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 第一個參數: "確定要刪除嗎?" 是對話框中顯示的訊息，表示詢問使用者是否確定要刪除。
            // 第二個參數: "確認" 是對話框的標題，表示該對話框的用途。
            // 第三個參數: MessageBoxButtons.YesNo 是按鈕選項，表示該對話框會有「是(Yes)」和「否(No)」兩個選擇。
            if (MessageBox.Show("確定要刪除嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No) return;

            CProductWrap uiProduct = _list[_position]; // 畫面上的資料
            dbDemoEntities3 db = new dbDemoEntities3();

            // FirstOrDefault 是 C# LINQ（Language Integrated Query）的一個方法，用於從集合中檢索符合條件的第一個元素。
            // 如果找不到符合條件的元素，會返回集合的默認值（對於參考型別是 null，對於數值型別是該數值型別的默認值，例如 0）

            // 把 db.tCustomer 這個集合中的每一筆資料依序代入 t，如果符合後面的條件，就會返回第一筆符合的資料，
            // 如果找不到符合條件的資料，會返回 db.tCustomer 的默認值
            tProduct dbProduct = db.tProduct.FirstOrDefault(t => t.fId == uiProduct.fId); // 真正存在資料庫裡的資料

            if (dbProduct == null) return;
            db.tProduct.Remove(dbProduct);
            db.SaveChanges();

            // 全域變數 _list 裡面的資料也要跟著刪除
            _list.RemoveAt(_position);

            displayProducts();
        }

        // 編輯按鈕
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            editProductSelected();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editProductSelected();
        }

        private void editProductSelected()
        {
            if (_position < 0) return;

            // 顯示舊資料
            CProductWrap uiProduct = _list[_position];
            FrmProductEditor f = new FrmProductEditor();
            f.product = uiProduct.product; // f.customer = uiCustomer = _list[_position] 這 3 個其中一個資料改變，會影響到其他兩個的資料
            f.ShowDialog();

            // 按下確定後，把修改後的資料存進資料庫
            if (f.isOk == DialogResult.OK)
            {
                dbDemoEntities3 db = new dbDemoEntities3();
                tProduct dbProduct = db.tProduct.FirstOrDefault(t => t.fId == f.product.fId);
                if (dbProduct == null) return;
                dbProduct.fName = f.product.fName;
                dbProduct.fQty = f.product.fQty;
                dbProduct.fPrice = f.product.fPrice;
                dbProduct.fCost = f.product.fCost;
                dbProduct.fMemo = f.product.fMemo;
                dbProduct.fImage = f.product.fImage;
                db.SaveChanges();
                //MessageBox.Show(_list[_position].fName);
                displayProducts();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        // 搜尋按鈕
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dbDemoEntities3 db = new dbDemoEntities3();

            // 原本的語法==================================================
            //var x = from c in db.tProduct
            //        where c.fName.Contains(txtKeyword.Text) || c.fMemo.Contains(txtKeyword.Text)
            //        select c;
            //_list = x.ToList();
            //dataGridView1.DataSource = _list;
            // ============================================================

            // 第 2 種寫法
            // _list = db.tProduct.Where(c => c.fName.Contains(txtKeyword.Text) || c.fMemo.Contains(txtKeyword.Text)).ToList();
            // dataGridView1.DataSource = _list;
            // ============================================================

            // 第 3 種寫法
            // 這個語法也可以直接用在 list 物件上
            // 這邊有另外加入無視大小寫的設定
            dataGridView1.DataSource = _list.Where(c => c.fName.ToLower().Contains(txtKeyword.Text.ToLower()) || c.fMemo.ToLower().Contains(txtKeyword.Text.ToLower())).ToList();
            // ============================================================

            resetGridStyle();
        }
    }
}
