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

        private void displayAllCustomers() {
            // linq 查詢顯示所有 customers

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

            // 點擊 ok 後，要新增資料到資料庫

            // 先宣告資料庫實體

            // 新增資料

            // 把資料存到資料庫

            // 顯示全部資料

        }

        // 刪除按鈕
        private void btnDelete_Click(object sender, EventArgs e) {

        }

        // 修改按鈕
        private void toolStripButton4_Click(object sender, EventArgs e) {

        }

        // 查詢按鈕
        private void toolStripButton1_Click(object sender, EventArgs e) {

        }

        
    }
}
