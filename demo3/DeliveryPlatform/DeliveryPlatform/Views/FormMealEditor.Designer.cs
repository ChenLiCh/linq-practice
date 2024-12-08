namespace DeliveryPlatform.Views {
    partial class FormMealEditor {
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fbMealPrice = new prjCustomerDemo.userControl.FieldBox();
            this.fbMealMemo = new prjCustomerDemo.userControl.FieldBox();
            this.fbMealCost = new prjCustomerDemo.userControl.FieldBox();
            this.fbMealQty = new prjCustomerDemo.userControl.FieldBox();
            this.fbMealName = new prjCustomerDemo.userControl.FieldBox();
            this.fbMealId = new prjCustomerDemo.userControl.FieldBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(624, 395);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 30);
            this.btnConfirm.TabIndex = 40;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "* 表示必須填寫";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(542, 395);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 30);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(528, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "點兩下可選圖";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(466, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(416, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(416, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "*";
            // 
            // fbMealPrice
            // 
            this.fbMealPrice.fieldName = "價格";
            this.fbMealPrice.fieldValue = "1";
            this.fbMealPrice.Location = new System.Drawing.Point(224, 236);
            this.fbMealPrice.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbMealPrice.Name = "fbMealPrice";
            this.fbMealPrice.passwordMask = '\0';
            this.fbMealPrice.Size = new System.Drawing.Size(189, 54);
            this.fbMealPrice.TabIndex = 33;
            // 
            // fbMealMemo
            // 
            this.fbMealMemo.fieldName = "說明";
            this.fbMealMemo.fieldValue = "";
            this.fbMealMemo.Location = new System.Drawing.Point(18, 304);
            this.fbMealMemo.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbMealMemo.Name = "fbMealMemo";
            this.fbMealMemo.passwordMask = '\0';
            this.fbMealMemo.Size = new System.Drawing.Size(395, 54);
            this.fbMealMemo.TabIndex = 32;
            // 
            // fbMealCost
            // 
            this.fbMealCost.fieldName = "成本";
            this.fbMealCost.fieldValue = "1";
            this.fbMealCost.Location = new System.Drawing.Point(18, 236);
            this.fbMealCost.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbMealCost.Name = "fbMealCost";
            this.fbMealCost.passwordMask = '\0';
            this.fbMealCost.Size = new System.Drawing.Size(189, 54);
            this.fbMealCost.TabIndex = 31;
            // 
            // fbMealQty
            // 
            this.fbMealQty.fieldName = "數量";
            this.fbMealQty.fieldValue = "1";
            this.fbMealQty.Location = new System.Drawing.Point(18, 165);
            this.fbMealQty.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbMealQty.Name = "fbMealQty";
            this.fbMealQty.passwordMask = '\0';
            this.fbMealQty.Size = new System.Drawing.Size(395, 55);
            this.fbMealQty.TabIndex = 30;
            // 
            // fbMealName
            // 
            this.fbMealName.fieldName = "品名";
            this.fbMealName.fieldValue = "";
            this.fbMealName.Location = new System.Drawing.Point(18, 90);
            this.fbMealName.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbMealName.Name = "fbMealName";
            this.fbMealName.passwordMask = '\0';
            this.fbMealName.Size = new System.Drawing.Size(395, 54);
            this.fbMealName.TabIndex = 29;
            // 
            // fbMealId
            // 
            this.fbMealId.fieldName = "編號";
            this.fbMealId.fieldValue = "0";
            this.fbMealId.Location = new System.Drawing.Point(18, 20);
            this.fbMealId.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbMealId.Name = "fbMealId";
            this.fbMealId.passwordMask = '\0';
            this.fbMealId.Size = new System.Drawing.Size(395, 54);
            this.fbMealId.TabIndex = 28;
            this.fbMealId.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMealEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 443);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fbMealPrice);
            this.Controls.Add(this.fbMealMemo);
            this.Controls.Add(this.fbMealCost);
            this.Controls.Add(this.fbMealQty);
            this.Controls.Add(this.fbMealName);
            this.Controls.Add(this.fbMealId);
            this.Name = "FormMealEditor";
            this.Text = "FormMealEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private prjCustomerDemo.userControl.FieldBox fbMealPrice;
        private prjCustomerDemo.userControl.FieldBox fbMealMemo;
        private prjCustomerDemo.userControl.FieldBox fbMealCost;
        private prjCustomerDemo.userControl.FieldBox fbMealQty;
        private prjCustomerDemo.userControl.FieldBox fbMealName;
        private prjCustomerDemo.userControl.FieldBox fbMealId;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}