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

        private void toolStripButton4_Click(object sender, EventArgs e) {
            FrmCustomerList f =new FrmCustomerList();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
