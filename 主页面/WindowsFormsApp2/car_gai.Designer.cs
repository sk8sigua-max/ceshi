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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(car_gai));
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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
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
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(480, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 451);
            this.panel2.TabIndex = 2;
            // 
            // txtgai
            // 
            this.txtgai.BackColor = System.Drawing.Color.GhostWhite;
            this.txtgai.Location = new System.Drawing.Point(67, 390);
            this.txtgai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgai.Name = "txtgai";
            this.txtgai.Size = new System.Drawing.Size(286, 31);
            this.txtgai.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "请输入要修改的值：";
            // 
            // rbCarSort
            // 
            this.rbCarSort.AutoSize = true;
            this.rbCarSort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarSort.Location = new System.Drawing.Point(239, 213);
            this.rbCarSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCarSort.Name = "rbCarSort";
            this.rbCarSort.Size = new System.Drawing.Size(107, 28);
            this.rbCarSort.TabIndex = 50;
            this.rbCarSort.TabStop = true;
            this.rbCarSort.Text = "汽车种类";
            this.rbCarSort.UseVisualStyleBackColor = true;
            // 
            // rbProductionID
            // 
            this.rbProductionID.AutoSize = true;
            this.rbProductionID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbProductionID.Location = new System.Drawing.Point(65, 268);
            this.rbProductionID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbProductionID.Name = "rbProductionID";
            this.rbProductionID.Size = new System.Drawing.Size(125, 28);
            this.rbProductionID.TabIndex = 49;
            this.rbProductionID.TabStop = true;
            this.rbProductionID.Text = "生产商编号";
            this.rbProductionID.UseVisualStyleBackColor = true;
            // 
            // rbCarDisplacement
            // 
            this.rbCarDisplacement.AutoSize = true;
            this.rbCarDisplacement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarDisplacement.Location = new System.Drawing.Point(65, 208);
            this.rbCarDisplacement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCarDisplacement.Name = "rbCarDisplacement";
            this.rbCarDisplacement.Size = new System.Drawing.Size(107, 28);
            this.rbCarDisplacement.TabIndex = 48;
            this.rbCarDisplacement.TabStop = true;
            this.rbCarDisplacement.Text = "汽车排量";
            this.rbCarDisplacement.UseVisualStyleBackColor = true;
            // 
            // rbCarOutPrice
            // 
            this.rbCarOutPrice.AutoSize = true;
            this.rbCarOutPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarOutPrice.Location = new System.Drawing.Point(65, 148);
            this.rbCarOutPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCarOutPrice.Name = "rbCarOutPrice";
            this.rbCarOutPrice.Size = new System.Drawing.Size(107, 28);
            this.rbCarOutPrice.TabIndex = 47;
            this.rbCarOutPrice.TabStop = true;
            this.rbCarOutPrice.Text = "买出价格";
            this.rbCarOutPrice.UseVisualStyleBackColor = true;
            // 
            // rbCarStock
            // 
            this.rbCarStock.AutoSize = true;
            this.rbCarStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarStock.Location = new System.Drawing.Point(239, 150);
            this.rbCarStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCarStock.Name = "rbCarStock";
            this.rbCarStock.Size = new System.Drawing.Size(107, 28);
            this.rbCarStock.TabIndex = 46;
            this.rbCarStock.TabStop = true;
            this.rbCarStock.Text = "库存数量";
            this.rbCarStock.UseVisualStyleBackColor = true;
            // 
            // rbCarBrand
            // 
            this.rbCarBrand.AutoSize = true;
            this.rbCarBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarBrand.Location = new System.Drawing.Point(65, 88);
            this.rbCarBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCarBrand.Name = "rbCarBrand";
            this.rbCarBrand.Size = new System.Drawing.Size(107, 28);
            this.rbCarBrand.TabIndex = 45;
            this.rbCarBrand.TabStop = true;
            this.rbCarBrand.Text = "汽车品牌";
            this.rbCarBrand.UseVisualStyleBackColor = true;
            // 
            // rbCarInPrice
            // 
            this.rbCarInPrice.AutoSize = true;
            this.rbCarInPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCarInPrice.Location = new System.Drawing.Point(239, 88);
            this.rbCarInPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCarInPrice.Name = "rbCarInPrice";
            this.rbCarInPrice.Size = new System.Drawing.Size(89, 28);
            this.rbCarInPrice.TabIndex = 44;
            this.rbCarInPrice.TabStop = true;
            this.rbCarInPrice.Text = "进货价";
            this.rbCarInPrice.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(63, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "请选择要修改的选项：";
            // 
            // btnno
            // 
            this.btnno.BackColor = System.Drawing.Color.Transparent;
            this.btnno.ForeColor = System.Drawing.Color.Black;
            this.btnno.Location = new System.Drawing.Point(719, 502);
            this.btnno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(89, 38);
            this.btnno.TabIndex = 38;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = false;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnyes
            // 
            this.btnyes.BackColor = System.Drawing.Color.Transparent;
            this.btnyes.ForeColor = System.Drawing.Color.Black;
            this.btnyes.Location = new System.Drawing.Point(544, 502);
            this.btnyes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(85, 38);
            this.btnyes.TabIndex = 37;
            this.btnyes.Text = "确定";
            this.btnyes.UseVisualStyleBackColor = false;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // car_gai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 587);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "car_gai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "car_gai";
            this.Load += new System.EventHandler(this.car_gai_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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