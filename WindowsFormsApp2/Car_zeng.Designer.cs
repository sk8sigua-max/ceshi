namespace WindowsFormsApp2
{
    partial class Car_zeng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_zeng));
            this.txtCarDisplacement = new System.Windows.Forms.ComboBox();
            this.txtCarOutPrice = new System.Windows.Forms.TextBox();
            this.txtCarInPrice = new System.Windows.Forms.TextBox();
            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCarSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCarStock = new System.Windows.Forms.TextBox();
            this.txtProductionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCarDisplacement
            // 
            this.txtCarDisplacement.FormattingEnabled = true;
            this.txtCarDisplacement.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txtCarDisplacement.Location = new System.Drawing.Point(592, 300);
            this.txtCarDisplacement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarDisplacement.Name = "txtCarDisplacement";
            this.txtCarDisplacement.Size = new System.Drawing.Size(232, 26);
            this.txtCarDisplacement.TabIndex = 31;
            // 
            // txtCarOutPrice
            // 
            this.txtCarOutPrice.Location = new System.Drawing.Point(592, 185);
            this.txtCarOutPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarOutPrice.Name = "txtCarOutPrice";
            this.txtCarOutPrice.Size = new System.Drawing.Size(232, 28);
            this.txtCarOutPrice.TabIndex = 30;
            // 
            // txtCarInPrice
            // 
            this.txtCarInPrice.Location = new System.Drawing.Point(592, 126);
            this.txtCarInPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarInPrice.Name = "txtCarInPrice";
            this.txtCarInPrice.Size = new System.Drawing.Size(232, 28);
            this.txtCarInPrice.TabIndex = 29;
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Location = new System.Drawing.Point(592, 67);
            this.txtCarBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(232, 28);
            this.txtCarBrand.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(486, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "汽车排量：";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(486, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "售卖价格：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(486, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "库存数量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(486, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "采购价格：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(727, 470);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 52);
            this.button2.TabIndex = 36;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 470);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 52);
            this.button1.TabIndex = 35;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCarSort
            // 
            this.txtCarSort.FormattingEnabled = true;
            this.txtCarSort.Items.AddRange(new object[] {
            "轿车",
            "豪华轿车",
            "跑车",
            "超级跑车",
            "越野车",
            "面包车"});
            this.txtCarSort.Location = new System.Drawing.Point(592, 356);
            this.txtCarSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarSort.Name = "txtCarSort";
            this.txtCarSort.Size = new System.Drawing.Size(232, 26);
            this.txtCarSort.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(486, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "汽车种类：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(477, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "生产商编号:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtCarStock
            // 
            this.txtCarStock.Location = new System.Drawing.Point(592, 242);
            this.txtCarStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarStock.Name = "txtCarStock";
            this.txtCarStock.Size = new System.Drawing.Size(232, 28);
            this.txtCarStock.TabIndex = 41;
            // 
            // txtProductionID
            // 
            this.txtProductionID.Location = new System.Drawing.Point(592, 419);
            this.txtProductionID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductionID.Name = "txtProductionID";
            this.txtProductionID.Size = new System.Drawing.Size(232, 28);
            this.txtProductionID.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(484, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "汽车品牌：";
            // 
            // Car_zeng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductionID);
            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.txtCarOutPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCarDisplacement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCarInPrice);
            this.Controls.Add(this.txtCarSort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Car_zeng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加数据";
            this.Load += new System.EventHandler(this.Car_zeng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtCarDisplacement;
        private System.Windows.Forms.TextBox txtCarOutPrice;
        private System.Windows.Forms.TextBox txtCarInPrice;
        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtCarSort;
        private System.Windows.Forms.TextBox txtCarStock;
        private System.Windows.Forms.TextBox txtProductionID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}