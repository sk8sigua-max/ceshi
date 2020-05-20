namespace WindowsFormsApp2
{
    partial class PurchaseInfo_zeng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnno = new System.Windows.Forms.Button();
            this.btnyes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInPrice = new System.Windows.Forms.TextBox();
            this.txtProductionID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInNum = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.txtCarNo = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(219, 312);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(98, 43);
            this.btnno.TabIndex = 56;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(29, 312);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(98, 43);
            this.btnyes.TabIndex = 55;
            this.btnyes.Text = "确定";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 69;
            this.label2.Text = "汽车编号：";
            // 
            // txtInPrice
            // 
            this.txtInPrice.Location = new System.Drawing.Point(110, 82);
            this.txtInPrice.Name = "txtInPrice";
            this.txtInPrice.Size = new System.Drawing.Size(207, 25);
            this.txtInPrice.TabIndex = 64;
            // 
            // txtProductionID
            // 
            this.txtProductionID.Location = new System.Drawing.Point(110, 28);
            this.txtProductionID.Name = "txtProductionID";
            this.txtProductionID.Size = new System.Drawing.Size(207, 25);
            this.txtProductionID.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 61;
            this.label7.Text = "采购员编号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "采购价格：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 59;
            this.label5.Text = "采购数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "厂商编号:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._6b2a8cadb490b887752fdfac017518db;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(33, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 457);
            this.panel1.TabIndex = 53;
            // 
            // txtInNum
            // 
            this.txtInNum.Location = new System.Drawing.Point(110, 135);
            this.txtInNum.Name = "txtInNum";
            this.txtInNum.Size = new System.Drawing.Size(207, 25);
            this.txtInNum.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtCarNo);
            this.panel2.Controls.Add(this.txtUserNo);
            this.panel2.Controls.Add(this.txtInNum);
            this.panel2.Controls.Add(this.txtProductionID);
            this.panel2.Controls.Add(this.btnyes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnno);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtInPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(432, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 411);
            this.panel2.TabIndex = 72;
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(110, 184);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(207, 25);
            this.txtUserNo.TabIndex = 72;
            // 
            // txtCarNo
            // 
            this.txtCarNo.Location = new System.Drawing.Point(110, 236);
            this.txtCarNo.Name = "txtCarNo";
            this.txtCarNo.Size = new System.Drawing.Size(207, 25);
            this.txtCarNo.TabIndex = 73;
            // 
            // PurchaseInfo_zeng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(789, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseInfo_zeng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加数据";
            this.Load += new System.EventHandler(this.PurchaseInfo_zeng_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInPrice;
        private System.Windows.Forms.TextBox txtProductionID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.TextBox txtCarNo;
    }
}