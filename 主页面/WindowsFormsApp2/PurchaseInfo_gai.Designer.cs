namespace WindowsFormsApp2
{
    partial class PurchaseInfo_gai
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtgai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCarNo = new System.Windows.Forms.RadioButton();
            this.rbInNum = new System.Windows.Forms.RadioButton();
            this.rbUserNo = new System.Windows.Forms.RadioButton();
            this.rbProductionID = new System.Windows.Forms.RadioButton();
            this.rbInPrice = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(635, 380);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(98, 43);
            this.btnno.TabIndex = 42;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(461, 380);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(98, 43);
            this.btnyes.TabIndex = 41;
            this.btnyes.Text = "确定";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtgai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rbCarNo);
            this.panel2.Controls.Add(this.rbInNum);
            this.panel2.Controls.Add(this.rbUserNo);
            this.panel2.Controls.Add(this.rbProductionID);
            this.panel2.Controls.Add(this.rbInPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(425, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 333);
            this.panel2.TabIndex = 40;
            // 
            // txtgai
            // 
            this.txtgai.Location = new System.Drawing.Point(36, 277);
            this.txtgai.Name = "txtgai";
            this.txtgai.Size = new System.Drawing.Size(255, 25);
            this.txtgai.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "请输入要修改的值：";
            // 
            // rbCarNo
            // 
            this.rbCarNo.AutoSize = true;
            this.rbCarNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarNo.Location = new System.Drawing.Point(36, 169);
            this.rbCarNo.Name = "rbCarNo";
            this.rbCarNo.Size = new System.Drawing.Size(88, 19);
            this.rbCarNo.TabIndex = 48;
            this.rbCarNo.TabStop = true;
            this.rbCarNo.Text = "汽车编号";
            this.rbCarNo.UseVisualStyleBackColor = true;
            // 
            // rbInNum
            // 
            this.rbInNum.AutoSize = true;
            this.rbInNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbInNum.Location = new System.Drawing.Point(36, 119);
            this.rbInNum.Name = "rbInNum";
            this.rbInNum.Size = new System.Drawing.Size(96, 19);
            this.rbInNum.TabIndex = 47;
            this.rbInNum.TabStop = true;
            this.rbInNum.Text = "采购数量 ";
            this.rbInNum.UseVisualStyleBackColor = true;
            // 
            // rbUserNo
            // 
            this.rbUserNo.AutoSize = true;
            this.rbUserNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbUserNo.Location = new System.Drawing.Point(190, 121);
            this.rbUserNo.Name = "rbUserNo";
            this.rbUserNo.Size = new System.Drawing.Size(103, 19);
            this.rbUserNo.TabIndex = 46;
            this.rbUserNo.TabStop = true;
            this.rbUserNo.Text = "采购员编号";
            this.rbUserNo.UseVisualStyleBackColor = true;
            // 
            // rbProductionID
            // 
            this.rbProductionID.AutoSize = true;
            this.rbProductionID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbProductionID.Location = new System.Drawing.Point(36, 69);
            this.rbProductionID.Name = "rbProductionID";
            this.rbProductionID.Size = new System.Drawing.Size(96, 19);
            this.rbProductionID.TabIndex = 45;
            this.rbProductionID.TabStop = true;
            this.rbProductionID.Text = " 厂商编号";
            this.rbProductionID.UseVisualStyleBackColor = true;
            // 
            // rbInPrice
            // 
            this.rbInPrice.AutoSize = true;
            this.rbInPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbInPrice.Location = new System.Drawing.Point(190, 69);
            this.rbInPrice.Name = "rbInPrice";
            this.rbInPrice.Size = new System.Drawing.Size(88, 19);
            this.rbInPrice.TabIndex = 44;
            this.rbInPrice.TabStop = true;
            this.rbInPrice.Text = "采购价格";
            this.rbInPrice.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "请选择要修改的选项：";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._6b2a8cadb490b887752fdfac017518db;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 457);
            this.panel1.TabIndex = 39;
            // 
            // PurchaseInfo_gai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(789, 489);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseInfo_gai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseInfo_gai";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtgai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCarNo;
        private System.Windows.Forms.RadioButton rbInNum;
        private System.Windows.Forms.RadioButton rbUserNo;
        private System.Windows.Forms.RadioButton rbProductionID;
        private System.Windows.Forms.RadioButton rbInPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}