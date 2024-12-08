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
    public partial class FormCustomerEditor : Form {

        public DialogResult isOk;

        private tCustomer _customer;

        public FormCustomerEditor() {
            InitializeComponent();
        }

        public tCustomer customer {
            get {
                if (_customer == null) _customer = new tCustomer();
                _customer.fCustomerId = Convert.ToInt32(fbCustomerId.fieldValue);
                _customer.fCustomerName = fbCustomerName.fieldValue;
                _customer.fCustomerPhone = fbCustomerPhone.fieldValue;
                _customer.fCustomerEmail = fbCustomerEmail.fieldValue;
                _customer.fCustomerAddress = fbCustomerAddress.fieldValue;
                _customer.fCustomerPassword = fbCustomerPassword.fieldValue;
                return _customer;
            }
            set {
                _customer = value;
                fbCustomerId.fieldValue = _customer.fCustomerId.ToString();
                fbCustomerName.fieldValue = _customer.fCustomerName;
                fbCustomerPhone.fieldValue = _customer.fCustomerPhone;
                fbCustomerEmail.fieldValue = _customer.fCustomerEmail;
                fbCustomerAddress.fieldValue = _customer.fCustomerAddress;
                fbCustomerPassword.fieldValue = _customer.fCustomerPassword;
            }
        }

        // 確定按鈕
        private void btnConfirm_Click(object sender, EventArgs e) {
            this.isOk = DialogResult.OK;
            Close();
        }

        // 取消按鈕
        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
