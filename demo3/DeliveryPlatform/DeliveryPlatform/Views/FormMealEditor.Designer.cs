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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fbPrice = new prjCustomerDemo.userControl.FieldBox();
            this.fbMemo = new prjCustomerDemo.userControl.FieldBox();
            this.fbCost = new prjCustomerDemo.userControl.FieldBox();
            this.fbQty = new prjCustomerDemo.userControl.FieldBox();
            this.fbName = new prjCustomerDemo.userControl.FieldBox();
            this.fbMealId = new prjCustomerDemo.userControl.FieldBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(624, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 30);
            this.button1.TabIndex = 40;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(542, 395);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 30);
            this.button2.TabIndex = 38;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
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
            // fbPrice
            // 
            this.fbPrice.fieldName = "價格";
            this.fbPrice.fieldValue = "1";
            this.fbPrice.Location = new System.Drawing.Point(224, 236);
            this.fbPrice.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbPrice.Name = "fbPrice";
            this.fbPrice.passwordMask = '\0';
            this.fbPrice.Size = new System.Drawing.Size(189, 54);
            this.fbPrice.TabIndex = 33;
            // 
            // fbMemo
            // 
            this.fbMemo.fieldName = "說明";
            this.fbMemo.fieldValue = "";
            this.fbMemo.Location = new System.Drawing.Point(18, 304);
            this.fbMemo.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbMemo.Name = "fbMemo";
            this.fbMemo.passwordMask = '\0';
            this.fbMemo.Size = new System.Drawing.Size(395, 54);
            this.fbMemo.TabIndex = 32;
            // 
            // fbCost
            // 
            this.fbCost.fieldName = "成本";
            this.fbCost.fieldValue = "1";
            this.fbCost.Location = new System.Drawing.Point(18, 236);
            this.fbCost.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbCost.Name = "fbCost";
            this.fbCost.passwordMask = '\0';
            this.fbCost.Size = new System.Drawing.Size(189, 54);
            this.fbCost.TabIndex = 31;
            // 
            // fbQty
            // 
            this.fbQty.fieldName = "數量";
            this.fbQty.fieldValue = "1";
            this.fbQty.Location = new System.Drawing.Point(18, 165);
            this.fbQty.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbQty.Name = "fbQty";
            this.fbQty.passwordMask = '\0';
            this.fbQty.Size = new System.Drawing.Size(395, 55);
            this.fbQty.TabIndex = 30;
            // 
            // fbName
            // 
            this.fbName.fieldName = "品名";
            this.fbName.fieldValue = "";
            this.fbName.Location = new System.Drawing.Point(18, 90);
            this.fbName.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.fbName.Name = "fbName";
            this.fbName.passwordMask = '\0';
            this.fbName.Size = new System.Drawing.Size(395, 54);
            this.fbName.TabIndex = 29;
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fbPrice);
            this.Controls.Add(this.fbMemo);
            this.Controls.Add(this.fbCost);
            this.Controls.Add(this.fbQty);
            this.Controls.Add(this.fbName);
            this.Controls.Add(this.fbMealId);
            this.Name = "FormMealEditor";
            this.Text = "FormMealEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private prjCustomerDemo.userControl.FieldBox fbPrice;
        private prjCustomerDemo.userControl.FieldBox fbMemo;
        private prjCustomerDemo.userControl.FieldBox fbCost;
        private prjCustomerDemo.userControl.FieldBox fbQty;
        private prjCustomerDemo.userControl.FieldBox fbName;
        private prjCustomerDemo.userControl.FieldBox fbMealId;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}