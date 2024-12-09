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
    public partial class FormCustomerList : Form {

        private int _pageCount = 5;
        int _position = -1;
        private List<tCustomer> _list;

        public FormCustomerList() {
            InitializeComponent();
        }

        // 最初載入畫面
        private void FormCustomerList_Load(object sender, EventArgs e) {
            // 顯示全部資料的 func
            displayAllCustomers();
        }

        // 顯示所有資料
        private void displayAllCustomers() {
            // linq 查詢顯示所有 customers
            dbDeliveryEntities db = new dbDeliveryEntities();

            var x = from c in db.tCustomer
                    select c;

            _list = x.ToList();
            dataGridView1.DataSource = _list;

            resetGridStyle();
        }

        private void FormCustomerList_Paint(object sender, PaintEventArgs e) {
            resetGridStyle();
        }

        // 設定 dataGridView style
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
            // 顯示 customer editor 的畫面
            FormCustomerEditor f = new FormCustomerEditor();
            f.ShowDialog();

            // 點擊 ok 後，要新增資料到資料庫
            if (f.isOk == DialogResult.OK) {
                // 先宣告資料庫實體
                dbDeliveryEntities db = new dbDeliveryEntities();

                // 新增資料
                db.tCustomer.Add(f.customer);

                // 把資料存到資料庫
                db.SaveChanges();

                // 顯示全部資料
                displayAllCustomers();
            }
        }

        // 刪除按鈕
        private void btnDelete_Click(object sender, EventArgs e) {
            if (_position < 0) return;

            if (MessageBox.Show("確定要刪除嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No) return;

            tCustomer uiCustomer = _list[_position];

            dbDeliveryEntities db = new dbDeliveryEntities();

            tCustomer dbCustomer = db.tCustomer.FirstOrDefault(data => data.fCustomerId == uiCustomer.fCustomerId);

            if (dbCustomer == null) return;
            db.tCustomer.Remove(dbCustomer);
            db.SaveChanges();

            _list.RemoveAt(_position);
            displayAllCustomers();
        }

        // 修改按鈕
        private void toolStripButton4_Click(object sender, EventArgs e) {
            editCustomerSelected();
        }

        private void editCustomerSelected() {
            if (_position < 0) return;

            // 顯示舊資料
            FormCustomerEditor f = new FormCustomerEditor();
            tCustomer uiCustomer = _list[_position];
            f.customer = uiCustomer;
            f.ShowDialog();

            // 按下確定後，把修改後的資料存進資料庫
            if (f.isOk == DialogResult.OK) {
                dbDeliveryEntities db = new dbDeliveryEntities();
                tCustomer dbCustomer = db.tCustomer.FirstOrDefault(data => data.fCustomerId == f.customer.fCustomerId);

                if (dbCustomer == null) return;
                dbCustomer.fCustomerId = f.customer.fCustomerId;
                dbCustomer.fCustomerName = f.customer.fCustomerName;
                dbCustomer.fCustomerPhone = f.customer.fCustomerPhone;
                dbCustomer.fCustomerEmail = f.customer.fCustomerEmail;
                dbCustomer.fCustomerAddress = f.customer.fCustomerAddress;
                dbCustomer.fCustomerPassword = f.customer.fCustomerPassword;

                db.SaveChanges();
                displayAllCustomers();
            }
        }

        // 查詢按鈕
        private void toolStripButton1_Click(object sender, EventArgs e) {
            dbDeliveryEntities db = new dbDeliveryEntities();

            var x = from c in db.tCustomer
                    where c.fCustomerName.Contains(txtKeyword.Text) || c.fCustomerPhone.Contains(txtKeyword.Text) || c.fCustomerEmail.Contains(txtKeyword.Text) || c.fCustomerAddress.Contains(txtKeyword.Text)
                    select c;

            _list.Clear();
            _list = x.ToList();
            dataGridView1.DataSource = _list;
            resetGridStyle();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e) {
            _position = e.RowIndex;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            editCustomerSelected();
        }
    }
}