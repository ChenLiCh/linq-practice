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
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        // 客戶管理按鈕
        private void toolStripButton4_Click(object sender, EventArgs e) {
            FrmCustomerList f =new FrmCustomerList();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        // 商品管理按鈕
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmProductList f = new FrmProductList();
            f.MdiParent = this;
            f.WindowState=FormWindowState.Maximized;
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {

        }

        private void toolStripButton1_Click(object sender, EventArgs e) {

        }
    }
}
