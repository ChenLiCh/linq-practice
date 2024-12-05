namespace DeliveryPlatform.Views {
    partial class FormCustomerEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.fbCustomerPassword = new prjCustomerDemo.userControl.FieldBox();
            this.fbCustomerAddress = new prjCustomerDemo.userControl.FieldBox();
            this.fbCustomerEmail = new prjCustomerDemo.userControl.FieldBox();
            this.fbCustomerPhone = new prjCustomerDemo.userControl.FieldBox();
            this.fbCustomerName = new prjCustomerDemo.userControl.FieldBox();
            this.fbCustomerId = new prjCustomerDemo.userControl.FieldBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(232, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(346, 462);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(97, 40);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // fbCustomerPassword
            // 
            this.fbCustomerPassword.fieldName = "密碼";
            this.fbCustomerPassword.fieldValue = "";
            this.fbCustomerPassword.Location = new System.Drawing.Point(21, 355);
            this.fbCustomerPassword.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbCustomerPassword.Name = "fbCustomerPassword";
            this.fbCustomerPassword.passwordMask = '\0';
            this.fbCustomerPassword.Size = new System.Drawing.Size(420, 59);
            this.fbCustomerPassword.TabIndex = 14;
            // 
            // fbCustomerAddress
            // 
            this.fbCustomerAddress.fieldName = "地址";
            this.fbCustomerAddress.fieldValue = "";
            this.fbCustomerAddress.Location = new System.Drawing.Point(23, 280);
            this.fbCustomerAddress.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbCustomerAddress.Name = "fbCustomerAddress";
            this.fbCustomerAddress.passwordMask = '\0';
            this.fbCustomerAddress.Size = new System.Drawing.Size(420, 58);
            this.fbCustomerAddress.TabIndex = 13;
            // 
            // fbCustomerEmail
            // 
            this.fbCustomerEmail.fieldName = "電子郵件";
            this.fbCustomerEmail.fieldValue = "";
            this.fbCustomerEmail.Location = new System.Drawing.Point(23, 213);
            this.fbCustomerEmail.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbCustomerEmail.Name = "fbCustomerEmail";
            this.fbCustomerEmail.passwordMask = '\0';
            this.fbCustomerEmail.Size = new System.Drawing.Size(420, 59);
            this.fbCustomerEmail.TabIndex = 12;
            // 
            // fbCustomerPhone
            // 
            this.fbCustomerPhone.fieldName = "電話";
            this.fbCustomerPhone.fieldValue = "";
            this.fbCustomerPhone.Location = new System.Drawing.Point(23, 151);
            this.fbCustomerPhone.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbCustomerPhone.Name = "fbCustomerPhone";
            this.fbCustomerPhone.passwordMask = '\0';
            this.fbCustomerPhone.Size = new System.Drawing.Size(420, 58);
            this.fbCustomerPhone.TabIndex = 11;
            // 
            // fbCustomerName
            // 
            this.fbCustomerName.fieldName = "姓名";
            this.fbCustomerName.fieldValue = "";
            this.fbCustomerName.Location = new System.Drawing.Point(23, 87);
            this.fbCustomerName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbCustomerName.Name = "fbCustomerName";
            this.fbCustomerName.passwordMask = '\0';
            this.fbCustomerName.Size = new System.Drawing.Size(420, 60);
            this.fbCustomerName.TabIndex = 10;
            // 
            // fbCustomerId
            // 
            this.fbCustomerId.fieldName = "客戶編號";
            this.fbCustomerId.fieldValue = "0";
            this.fbCustomerId.Location = new System.Drawing.Point(23, 21);
            this.fbCustomerId.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbCustomerId.Name = "fbCustomerId";
            this.fbCustomerId.passwordMask = '\0';
            this.fbCustomerId.Size = new System.Drawing.Size(420, 62);
            this.fbCustomerId.TabIndex = 9;
            this.fbCustomerId.Visible = false;
            // 
            // FormCustomerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 514);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.fbCustomerPassword);
            this.Controls.Add(this.fbCustomerAddress);
            this.Controls.Add(this.fbCustomerEmail);
            this.Controls.Add(this.fbCustomerPhone);
            this.Controls.Add(this.fbCustomerName);
            this.Controls.Add(this.fbCustomerId);
            this.Name = "FormCustomerEditor";
            this.Text = "FormCustomerEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private prjCustomerDemo.userControl.FieldBox fbCustomerPassword;
        private prjCustomerDemo.userControl.FieldBox fbCustomerAddress;
        private prjCustomerDemo.userControl.FieldBox fbCustomerEmail;
        private prjCustomerDemo.userControl.FieldBox fbCustomerPhone;
        private prjCustomerDemo.userControl.FieldBox fbCustomerName;
        private prjCustomerDemo.userControl.FieldBox fbCustomerId;
    }
}