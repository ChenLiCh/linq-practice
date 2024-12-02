namespace prjAdoDotNetDemo.Views {
    partial class FrmCustomerEditor {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fbPassword = new prjCustomerDemo.userControl.FieldBox();
            this.fbAddress = new prjCustomerDemo.userControl.FieldBox();
            this.fbEmail = new prjCustomerDemo.userControl.FieldBox();
            this.fbPhone = new prjCustomerDemo.userControl.FieldBox();
            this.fbName = new prjCustomerDemo.userControl.FieldBox();
            this.fbId = new prjCustomerDemo.userControl.FieldBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(373, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(254, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(30, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 2);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // fbPassword
            // 
            this.fbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbPassword.fieldName = "密碼";
            this.fbPassword.fieldValue = "";
            this.fbPassword.Location = new System.Drawing.Point(30, 358);
            this.fbPassword.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbPassword.Name = "fbPassword";
            this.fbPassword.Size = new System.Drawing.Size(438, 59);
            this.fbPassword.TabIndex = 5;
            // 
            // fbAddress
            // 
            this.fbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbAddress.fieldName = "地址";
            this.fbAddress.fieldValue = "";
            this.fbAddress.Location = new System.Drawing.Point(32, 283);
            this.fbAddress.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbAddress.Name = "fbAddress";
            this.fbAddress.Size = new System.Drawing.Size(438, 58);
            this.fbAddress.TabIndex = 4;
            // 
            // fbEmail
            // 
            this.fbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbEmail.fieldName = "電子郵件";
            this.fbEmail.fieldValue = "";
            this.fbEmail.Location = new System.Drawing.Point(32, 216);
            this.fbEmail.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbEmail.Name = "fbEmail";
            this.fbEmail.Size = new System.Drawing.Size(438, 59);
            this.fbEmail.TabIndex = 3;
            // 
            // fbPhone
            // 
            this.fbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbPhone.fieldName = "電話";
            this.fbPhone.fieldValue = "";
            this.fbPhone.Location = new System.Drawing.Point(32, 154);
            this.fbPhone.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbPhone.Name = "fbPhone";
            this.fbPhone.Size = new System.Drawing.Size(438, 58);
            this.fbPhone.TabIndex = 2;
            // 
            // fbName
            // 
            this.fbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbName.fieldName = "姓名";
            this.fbName.fieldValue = "";
            this.fbName.Location = new System.Drawing.Point(32, 90);
            this.fbName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbName.Name = "fbName";
            this.fbName.Size = new System.Drawing.Size(438, 60);
            this.fbName.TabIndex = 1;
            // 
            // fbId
            // 
            this.fbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbId.fieldName = "客戶編號";
            this.fbId.fieldValue = "0";
            this.fbId.Location = new System.Drawing.Point(32, 24);
            this.fbId.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.fbId.Name = "fbId";
            this.fbId.Size = new System.Drawing.Size(438, 62);
            this.fbId.TabIndex = 0;
            this.fbId.Visible = false;
            // 
            // FrmCustomerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fbPassword);
            this.Controls.Add(this.fbAddress);
            this.Controls.Add(this.fbEmail);
            this.Controls.Add(this.fbPhone);
            this.Controls.Add(this.fbName);
            this.Controls.Add(this.fbId);
            this.Name = "FrmCustomerEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomerEditor";
            this.Load += new System.EventHandler(this.FrmCustomerEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private prjCustomerDemo.userControl.FieldBox fbId;
        private prjCustomerDemo.userControl.FieldBox fbName;
        private prjCustomerDemo.userControl.FieldBox fbPhone;
        private prjCustomerDemo.userControl.FieldBox fbEmail;
        private prjCustomerDemo.userControl.FieldBox fbAddress;
        private prjCustomerDemo.userControl.FieldBox fbPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}