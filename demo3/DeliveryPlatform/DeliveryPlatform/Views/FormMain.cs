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
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        // 客戶管理按鈕
        private void toolStripButton4_Click(object sender, EventArgs e) {
            FormCustomerList f = new FormCustomerList();
            f.MdiParent = this;
            f.Show();
        }

        // 餐點管理按鈕
        private void toolStripButton3_Click(object sender, EventArgs e) {
            FormMealList f = new FormMealList();
            f.MdiParent = this;
            f.Show();
        }

        // 結束按鈕
        private void toolStripButton2_Click(object sender, EventArgs e) {

        }

        // 關閉按鈕
        private void toolStripButton1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
