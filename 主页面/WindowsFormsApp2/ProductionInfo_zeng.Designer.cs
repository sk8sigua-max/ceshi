namespace WindowsFormsApp2
{
    partial class ProductionInfo_zeng
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
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.btnyes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtproductionAddress = new System.Windows.Forms.TextBox();
            this.txtproductionPhone = new System.Windows.Forms.TextBox();
            this.txtProductionBrand = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(431, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 49;
            this.label8.Text = "公司地址:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(431, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "公司电话：";
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(636, 343);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(98, 43);
            this.btnno.TabIndex = 46;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(446, 343);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(98, 43);
            this.btnyes.TabIndex = 45;
            this.btnyes.Text = "确定";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(431, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "汽车品牌：";
            // 
            // txtproductionAddress
            // 
            this.txtproductionAddress.Location = new System.Drawing.Point(527, 260);
            this.txtproductionAddress.Name = "txtproductionAddress";
            this.txtproductionAddress.Size = new System.Drawing.Size(207, 25);
            this.txtproductionAddress.TabIndex = 52;
            // 
            // txtproductionPhone
            // 
            this.txtproductionPhone.Location = new System.Drawing.Point(527, 177);
            this.txtproductionPhone.Name = "txtproductionPhone";
            this.txtproductionPhone.Size = new System.Drawing.Size(207, 25);
            this.txtproductionPhone.TabIndex = 51;
            // 
            // txtProductionBrand
            // 
            this.txtProductionBrand.Location = new System.Drawing.Point(527, 81);
            this.txtProductionBrand.Name = "txtProductionBrand";
            this.txtProductionBrand.Size = new System.Drawing.Size(207, 25);
            this.txtProductionBrand.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._6b2a8cadb490b887752fdfac017518db;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 457);
            this.panel1.TabIndex = 1;
            // 
            // ProductionInfo_zeng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(789, 489);
            this.Controls.Add(this.txtproductionAddress);
            this.Controls.Add(this.txtproductionPhone);
            this.Controls.Add(this.txtProductionBrand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ProductionInfo_zeng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionInfo_zeng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtproductionAddress;
        private System.Windows.Forms.TextBox txtproductionPhone;
        private System.Windows.Forms.TextBox txtProductionBrand;
    }
}