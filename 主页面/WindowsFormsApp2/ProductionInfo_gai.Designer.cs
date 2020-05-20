namespace WindowsFormsApp2
{
    partial class ProductionInfo_gai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnno = new System.Windows.Forms.Button();
            this.btnyes = new System.Windows.Forms.Button();
            this.txtgai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbproductionAddress = new System.Windows.Forms.RadioButton();
            this.rbProductionBrand = new System.Windows.Forms.RadioButton();
            this.rbproductionPhone = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._6b2a8cadb490b887752fdfac017518db;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 457);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnno);
            this.panel2.Controls.Add(this.btnyes);
            this.panel2.Controls.Add(this.txtgai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rbproductionAddress);
            this.panel2.Controls.Add(this.rbProductionBrand);
            this.panel2.Controls.Add(this.rbproductionPhone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(425, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 376);
            this.panel2.TabIndex = 3;
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(210, 299);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(98, 43);
            this.btnno.TabIndex = 54;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(36, 299);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(98, 43);
            this.btnyes.TabIndex = 53;
            this.btnyes.Text = "确定";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // txtgai
            // 
            this.txtgai.Location = new System.Drawing.Point(36, 211);
            this.txtgai.Name = "txtgai";
            this.txtgai.Size = new System.Drawing.Size(255, 25);
            this.txtgai.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "请输入要修改的值：";
            // 
            // rbproductionAddress
            // 
            this.rbproductionAddress.AutoSize = true;
            this.rbproductionAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbproductionAddress.Location = new System.Drawing.Point(36, 119);
            this.rbproductionAddress.Name = "rbproductionAddress";
            this.rbproductionAddress.Size = new System.Drawing.Size(88, 19);
            this.rbproductionAddress.TabIndex = 47;
            this.rbproductionAddress.TabStop = true;
            this.rbproductionAddress.Text = "厂商地址";
            this.rbproductionAddress.UseVisualStyleBackColor = true;
            // 
            // rbProductionBrand
            // 
            this.rbProductionBrand.AutoSize = true;
            this.rbProductionBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbProductionBrand.Location = new System.Drawing.Point(36, 69);
            this.rbProductionBrand.Name = "rbProductionBrand";
            this.rbProductionBrand.Size = new System.Drawing.Size(88, 19);
            this.rbProductionBrand.TabIndex = 45;
            this.rbProductionBrand.TabStop = true;
            this.rbProductionBrand.Text = "汽车品牌";
            this.rbProductionBrand.UseVisualStyleBackColor = true;
            // 
            // rbproductionPhone
            // 
            this.rbproductionPhone.AutoSize = true;
            this.rbproductionPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbproductionPhone.Location = new System.Drawing.Point(190, 69);
            this.rbproductionPhone.Name = "rbproductionPhone";
            this.rbproductionPhone.Size = new System.Drawing.Size(88, 19);
            this.rbproductionPhone.TabIndex = 44;
            this.rbproductionPhone.TabStop = true;
            this.rbproductionPhone.Text = "厂商电话";
            this.rbproductionPhone.UseVisualStyleBackColor = true;
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
            // ProductionInfo_gai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(789, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ProductionInfo_gai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionInfo_gai";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtgai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbproductionAddress;
        private System.Windows.Forms.RadioButton rbproductionPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.RadioButton rbProductionBrand;
    }
}