namespace Agoni
{
    partial class ChuKu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuKu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOutID = new System.Windows.Forms.TextBox();
            this.txtOutNum = new System.Windows.Forms.TextBox();
            this.txtOutAddress = new System.Windows.Forms.TextBox();
            this.txtOutPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtOutBrand = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "出库编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(495, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "出库品牌：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(495, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "出库数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(885, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "出库日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(885, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "出库价格：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(59, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "出库地址：";
            // 
            // txtOutID
            // 
            this.txtOutID.Location = new System.Drawing.Point(153, 38);
            this.txtOutID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutID.Name = "txtOutID";
            this.txtOutID.Size = new System.Drawing.Size(189, 25);
            this.txtOutID.TabIndex = 8;
            // 
            // txtOutNum
            // 
            this.txtOutNum.Location = new System.Drawing.Point(590, 38);
            this.txtOutNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutNum.Name = "txtOutNum";
            this.txtOutNum.Size = new System.Drawing.Size(189, 25);
            this.txtOutNum.TabIndex = 11;
            // 
            // txtOutAddress
            // 
            this.txtOutAddress.Location = new System.Drawing.Point(153, 118);
            this.txtOutAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutAddress.Name = "txtOutAddress";
            this.txtOutAddress.Size = new System.Drawing.Size(189, 25);
            this.txtOutAddress.TabIndex = 12;
            // 
            // txtOutPrice
            // 
            this.txtOutPrice.Location = new System.Drawing.Point(984, 129);
            this.txtOutPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutPrice.Name = "txtOutPrice";
            this.txtOutPrice.Size = new System.Drawing.Size(189, 25);
            this.txtOutPrice.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(1221, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutID,
            this.OutNum,
            this.OutDate,
            this.OutAddress,
            this.OutBrand,
            this.OutPrice});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 185);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1453, 526);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OutID
            // 
            this.OutID.DataPropertyName = "OutID";
            this.OutID.HeaderText = "出库编号";
            this.OutID.Name = "OutID";
            // 
            // OutNum
            // 
            this.OutNum.DataPropertyName = "OutNum";
            this.OutNum.HeaderText = "出库数量";
            this.OutNum.Name = "OutNum";
            // 
            // OutDate
            // 
            this.OutDate.DataPropertyName = "OutDate";
            this.OutDate.HeaderText = "出库日期";
            this.OutDate.Name = "OutDate";
            // 
            // OutAddress
            // 
            this.OutAddress.DataPropertyName = "OutAddress";
            this.OutAddress.HeaderText = "出库地址";
            this.OutAddress.Name = "OutAddress";
            // 
            // OutBrand
            // 
            this.OutBrand.DataPropertyName = "OutBrand";
            this.OutBrand.HeaderText = "出库品牌";
            this.OutBrand.Name = "OutBrand";
            // 
            // OutPrice
            // 
            this.OutPrice.DataPropertyName = "OutPrice";
            this.OutPrice.HeaderText = "出库价格";
            this.OutPrice.Name = "OutPrice";
            // 
            // OutDateTime
            // 
            this.OutDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OutDateTime.Location = new System.Drawing.Point(979, 34);
            this.OutDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.OutDateTime.Name = "OutDateTime";
            this.OutDateTime.ShowUpDown = true;
            this.OutDateTime.Size = new System.Drawing.Size(189, 25);
            this.OutDateTime.TabIndex = 22;
            // 
            // txtOutBrand
            // 
            this.txtOutBrand.Location = new System.Drawing.Point(590, 121);
            this.txtOutBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutBrand.Name = "txtOutBrand";
            this.txtOutBrand.Size = new System.Drawing.Size(189, 25);
            this.txtOutBrand.TabIndex = 23;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // ChuKu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1450, 724);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.txtOutBrand);
            this.Controls.Add(this.OutDateTime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOutPrice);
            this.Controls.Add(this.txtOutAddress);
            this.Controls.Add(this.txtOutNum);
            this.Controls.Add(this.txtOutID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChuKu";
            this.Text = "销售出库";
            this.Load += new System.EventHandler(this.ChuKu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOutID;
        private System.Windows.Forms.TextBox txtOutNum;
        private System.Windows.Forms.TextBox txtOutAddress;
        private System.Windows.Forms.TextBox txtOutPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker OutDateTime;
        private System.Windows.Forms.TextBox txtOutBrand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutPrice;
    }
}