
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAdoDotNetDemo.Views {
    public partial class FrmCustomerEditor : Form {
        //private CCustomer _customer;

        // DialogResult 是一個枚舉類型，通常用於表示視窗或對話框 (Dialog) 關閉時的結果。當使用 MessageBox 或自定義的對話框時，DialogResult 可以用來判斷使用者選擇的動作，如按下的按鈕（確定、取消、是、否等）。
        // DialogResult 的常用值包括：
        // DialogResult.OK：表示使用者按下了「確定」或「接受」按鈕。
        // DialogResult.Cancel：表示使用者按下了「取消」按鈕。
        // DialogResult.Yes：表示使用者按下了「是」按鈕。
        // DialogResult.No：表示使用者按下了「否」按鈕。
        // DialogResult.None：表示沒有選擇任何結果。
        public DialogResult isOk { get; set; }

        public FrmCustomerEditor() {
            InitializeComponent();
        }

        //public CCustomer customer {
        //    get {
        //        if (_customer == null) _customer = new CCustomer();
        //        // 把在 Editor 頁面的欄位值存到 _customer 物件中
        //        _customer.fId = Convert.ToInt32(fbId.fieldValue);
        //        _customer.fName = fbName.fieldValue;
        //        _customer.fPhone = fbPhone.fieldValue;
        //        _customer.fEmail = fbEmail.fieldValue;
        //        _customer.fAddress = fbAddress.fieldValue;
        //        _customer.fPassword = fbPassword.fieldValue;
        //        return _customer;
        //    }
        //    set {
        //        _customer = value;
        //        // 把在 _customer 物件中的值取出，填入 Editor 頁面的欄位 
        //        fbId.fieldValue = _customer.fId.ToString();
        //        fbName.fieldValue = _customer.fName;
        //        fbPhone.fieldValue = _customer.fPhone;
        //        fbEmail.fieldValue = _customer.fEmail;
        //        fbAddress.fieldValue = _customer.fAddress;
        //        fbPassword.fieldValue = _customer.fPassword;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e) {
            this.isOk = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void FrmCustomerEditor_Load(object sender, EventArgs e) {

        }  
    }
}
