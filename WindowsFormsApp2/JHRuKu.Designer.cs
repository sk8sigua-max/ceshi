namespace Agoni
{
    partial class JHRuKu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JHRuKu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.txtboxInAddress = new System.Windows.Forms.TextBox();
            this.txtboxNum = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.InDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtboxInBrand = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtboxInPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "进货编码：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(315, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "进货数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(593, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "进货日期：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(39, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "进货地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(320, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "进货品牌：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(593, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "进货价格：";
            // 
            // txtboxID
            // 
            this.txtboxID.Location = new System.Drawing.Point(101, 34);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(136, 21);
            this.txtboxID.TabIndex = 9;
            this.txtboxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxInAddress
            // 
            this.txtboxInAddress.Location = new System.Drawing.Point(101, 96);
            this.txtboxInAddress.Name = "txtboxInAddress";
            this.txtboxInAddress.Size = new System.Drawing.Size(136, 21);
            this.txtboxInAddress.TabIndex = 10;
            this.txtboxInAddress.TextChanged += new System.EventHandler(this.txtboxInAddress_TextChanged);
            // 
            // txtboxNum
            // 
            this.txtboxNum.Location = new System.Drawing.Point(388, 34);
            this.txtboxNum.Name = "txtboxNum";
            this.txtboxNum.Size = new System.Drawing.Size(136, 21);
            this.txtboxNum.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InID,
            this.InNum,
            this.InDate,
            this.InAddress,
            this.InBrand,
            this.InPrice});
            this.dataGridView1.Location = new System.Drawing.Point(0, 158);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 443);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InID
            // 
            this.InID.DataPropertyName = "InID";
            this.InID.HeaderText = "进货编号";
            this.InID.Name = "InID";
            // 
            // InNum
            // 
            this.InNum.DataPropertyName = "InNum";
            this.InNum.HeaderText = "进货数量";
            this.InNum.Name = "InNum";
            // 
            // InDate
            // 
            this.InDate.DataPropertyName = "InDate";
            this.InDate.HeaderText = "进货日期";
            this.InDate.Name = "InDate";
            // 
            // InAddress
            // 
            this.InAddress.DataPropertyName = "InAddress";
            this.InAddress.HeaderText = "进货地址";
            this.InAddress.Name = "InAddress";
            // 
            // InBrand
            // 
            this.InBrand.DataPropertyName = "InBrand";
            this.InBrand.HeaderText = "进货品牌";
            this.InBrand.Name = "InBrand";
            // 
            // InPrice
            // 
            this.InPrice.DataPropertyName = "InPrice";
            this.InPrice.HeaderText = "进货价格";
            this.InPrice.Name = "InPrice";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(916, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InDateTime
            // 
            this.InDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InDateTime.Location = new System.Drawing.Point(660, 34);
            this.InDateTime.Name = "InDateTime";
            this.InDateTime.ShowUpDown = true;
            this.InDateTime.Size = new System.Drawing.Size(158, 21);
            this.InDateTime.TabIndex = 22;
            this.InDateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtboxInBrand
            // 
            this.txtboxInBrand.Location = new System.Drawing.Point(388, 96);
            this.txtboxInBrand.Name = "txtboxInBrand";
            this.txtboxInBrand.Size = new System.Drawing.Size(136, 21);
            this.txtboxInBrand.TabIndex = 23;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // txtboxInPrice
            // 
            this.txtboxInPrice.Location = new System.Drawing.Point(660, 91);
            this.txtboxInPrice.Name = "txtboxInPrice";
            this.txtboxInPrice.Size = new System.Drawing.Size(157, 21);
            this.txtboxInPrice.TabIndex = 24;
            // 
            // JHRuKu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 579);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.txtboxInPrice);
            this.Controls.Add(this.txtboxInBrand);
            this.Controls.Add(this.InDateTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtboxNum);
            this.Controls.Add(this.txtboxInAddress);
            this.Controls.Add(this.txtboxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "JHRuKu";
            this.Text = "进货入库";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.JHRuKu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.TextBox txtboxInAddress;
        private System.Windows.Forms.TextBox txtboxNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker InDateTime;
        private System.Windows.Forms.TextBox txtboxInBrand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtboxInPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn InBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn InPrice;
    }
}