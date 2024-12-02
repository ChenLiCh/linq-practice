using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPosDemo.Views {
    public partial class FrmCustomerList : Form {
        public FrmCustomerList() {
            InitializeComponent();
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            displayCustomers();
        }

        private void displayCustomers()
        {
            dbDemoEntities3 db=new dbDemoEntities3();
            var x=from c in db.tCustomer
                select c;
            dataGridView1.DataSource = x.ToList();
            resetGridStyle();

            cboCustomerName.Items.Clear();
            foreach(var t in x)
            {
                cboCustomerName.Items.Add(t.fName);
            }
        }

        private void resetGridStyle()
        {
            // 設定各欄位寬度
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
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

        private void FrmCustomerList_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dbDemoEntities3 db= new dbDemoEntities3();
            var x = from c in db.tCustomer
                    where c.fEmail.Contains("@gmail.com") && c.fAddress == "Taipei"
                    select c;
            dataGridView1.DataSource = x.ToList();
            resetGridStyle();
        }

        private void cboCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboCustomerName.Text)) return;
            MessageBox.Show(cboCustomerName.Text);
        }
    }
}
