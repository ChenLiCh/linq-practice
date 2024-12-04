using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjShoppingApp
{
    public partial class FrmLogin : Form
    {
        private bool isClosed = true;

        public tCustomer loginUser { get; internal set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbDemoEntities db = new dbDemoEntities();
            tCustomer member = db.tCustomer.FirstOrDefault(c=>c.fEmail==txtAccount.Text&&
                c.fPassword==txtPassword.Text);
            if (member!=null)
            {
                isClosed = false;
                this.loginUser= member;
                Close();
            }
            else
                MessageBox.Show("帳號與密碼不符");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isClosed;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            isClosed = false;
            Application.Exit();
        }

        private void FrmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
