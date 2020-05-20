namespace WindowsFormsApp2
{
    partial class car_gai
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtgai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCarSort = new System.Windows.Forms.RadioButton();
            this.rbProductionID = new System.Windows.Forms.RadioButton();
            this.rbCarDisplacement = new System.Windows.Forms.RadioButton();
            this.rbCarOutPrice = new System.Windows.Forms.RadioButton();
            this.rbCarStock = new System.Windows.Forms.RadioButton();
            this.rbCarBrand = new System.Windows.Forms.RadioButton();
            this.rbCarInPrice = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.btnyes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtgai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rbCarSort);
            this.panel2.Controls.Add(this.rbProductionID);
            this.panel2.Controls.Add(this.rbCarDisplacement);
            this.panel2.Controls.Add(this.rbCarOutPrice);
            this.panel2.Controls.Add(this.rbCarStock);
            this.panel2.Controls.Add(this.rbCarBrand);
            this.panel2.Controls.Add(this.rbCarInPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(425, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 376);
            this.panel2.TabIndex = 2;
            // 
            // txtgai
            // 
            this.txtgai.Location = new System.Drawing.Point(36, 319);
            this.txtgai.Name = "txtgai";
            this.txtgai.Size = new System.Drawing.Size(255, 25);
            this.txtgai.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "请输入要修改的值：";
            // 
            // rbCarSort
            // 
            this.rbCarSort.AutoSize = true;
            this.rbCarSort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarSort.Location = new System.Drawing.Point(190, 173);
            this.rbCarSort.Name = "rbCarSort";
            this.rbCarSort.Size = new System.Drawing.Size(88, 19);
            this.rbCarSort.TabIndex = 50;
            this.rbCarSort.TabStop = true;
            this.rbCarSort.Text = "汽车种类";
            this.rbCarSort.UseVisualStyleBackColor = true;
            // 
            // rbProductionID
            // 
            this.rbProductionID.AutoSize = true;
            this.rbProductionID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbProductionID.Location = new System.Drawing.Point(36, 219);
            this.rbProductionID.Name = "rbProductionID";
            this.rbProductionID.Size = new System.Drawing.Size(103, 19);
            this.rbProductionID.TabIndex = 49;
            this.rbProductionID.TabStop = true;
            this.rbProductionID.Text = "生产商编号";
            this.rbProductionID.UseVisualStyleBackColor = true;
            // 
            // rbCarDisplacement
            // 
            this.rbCarDisplacement.AutoSize = true;
            this.rbCarDisplacement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarDisplacement.Location = new System.Drawing.Point(36, 169);
            this.rbCarDisplacement.Name = "rbCarDisplacement";
            this.rbCarDisplacement.Size = new System.Drawing.Size(88, 19);
            this.rbCarDisplacement.TabIndex = 48;
            this.rbCarDisplacement.TabStop = true;
            this.rbCarDisplacement.Text = "汽车排量";
            this.rbCarDisplacement.UseVisualStyleBackColor = true;
            // 
            // rbCarOutPrice
            // 
            this.rbCarOutPrice.AutoSize = true;
            this.rbCarOutPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarOutPrice.Location = new System.Drawing.Point(36, 119);
            this.rbCarOutPrice.Name = "rbCarOutPrice";
            this.rbCarOutPrice.Size = new System.Drawing.Size(88, 19);
            this.rbCarOutPrice.TabIndex = 47;
            this.rbCarOutPrice.TabStop = true;
            this.rbCarOutPrice.Text = "买出价格";
            this.rbCarOutPrice.UseVisualStyleBackColor = true;
            // 
            // rbCarStock
            // 
            this.rbCarStock.AutoSize = true;
            this.rbCarStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarStock.Location = new System.Drawing.Point(190, 121);
            this.rbCarStock.Name = "rbCarStock";
            this.rbCarStock.Size = new System.Drawing.Size(88, 19);
            this.rbCarStock.TabIndex = 46;
            this.rbCarStock.TabStop = true;
            this.rbCarStock.Text = "库存数量";
            this.rbCarStock.UseVisualStyleBackColor = true;
            // 
            // rbCarBrand
            // 
            this.rbCarBrand.AutoSize = true;
            this.rbCarBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarBrand.Location = new System.Drawing.Point(36, 69);
            this.rbCarBrand.Name = "rbCarBrand";
            this.rbCarBrand.Size = new System.Drawing.Size(88, 19);
            this.rbCarBrand.TabIndex = 45;
            this.rbCarBrand.TabStop = true;
            this.rbCarBrand.Text = "汽车品牌";
            this.rbCarBrand.UseVisualStyleBackColor = true;
            // 
            // rbCarInPrice
            // 
            this.rbCarInPrice.AutoSize = true;
            this.rbCarInPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarInPrice.Location = new System.Drawing.Point(190, 69);
            this.rbCarInPrice.Name = "rbCarInPrice";
            this.rbCarInPrice.Size = new System.Drawing.Size(73, 19);
            this.rbCarInPrice.TabIndex = 44;
            this.rbCarInPrice.TabStop = true;
            this.rbCarInPrice.Text = "进货价";
            this.rbCarInPrice.UseVisualStyleBackColor = true;
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
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(635, 407);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(98, 43);
            this.btnno.TabIndex = 38;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(461, 407);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(98, 43);
            this.btnyes.TabIndex = 37;
            this.btnyes.Text = "确定";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
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
            // car_gai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(789, 489);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "car_gai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "car_gai";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCarSort;
        private System.Windows.Forms.RadioButton rbProductionID;
        private System.Windows.Forms.RadioButton rbCarDisplacement;
        private System.Windows.Forms.RadioButton rbCarOutPrice;
        private System.Windows.Forms.RadioButton rbCarStock;
        private System.Windows.Forms.RadioButton rbCarBrand;
        private System.Windows.Forms.RadioButton rbCarInPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgai;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnyes;
    }
}