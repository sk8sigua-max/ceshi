namespace WindowsFormsApp2
{
    partial class PurchaseInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseInfo));
            this.dvManufacturer = new System.Windows.Forms.DataGridView();
            this.PurchaseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btsupply = new System.Windows.Forms.Button();
            this.txtsupply = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvManufacturer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvManufacturer
            // 
            this.dvManufacturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvManufacturer.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvManufacturer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvManufacturer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseNo,
            this.ProductionID,
            this.InPrice,
            this.InNum,
            this.UserNo,
            this.CarNo,
            this.Cancel});
            this.dvManufacturer.ContextMenuStrip = this.contextMenuStrip1;
            this.dvManufacturer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvManufacturer.Location = new System.Drawing.Point(0, 240);
            this.dvManufacturer.MultiSelect = false;
            this.dvManufacturer.Name = "dvManufacturer";
            this.dvManufacturer.RowHeadersVisible = false;
            this.dvManufacturer.RowTemplate.Height = 27;
            this.dvManufacturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvManufacturer.Size = new System.Drawing.Size(1450, 484);
            this.dvManufacturer.TabIndex = 16;
            // 
            // PurchaseNo
            // 
            this.PurchaseNo.DataPropertyName = "PurchaseNo";
            this.PurchaseNo.HeaderText = "采购编号";
            this.PurchaseNo.Name = "PurchaseNo";
            // 
            // ProductionID
            // 
            this.ProductionID.DataPropertyName = "ProductionID";
            this.ProductionID.HeaderText = "厂商编号";
            this.ProductionID.Name = "ProductionID";
            // 
            // InPrice
            // 
            this.InPrice.DataPropertyName = "InPrice";
            this.InPrice.HeaderText = "采购价格 ";
            this.InPrice.Name = "InPrice";
            // 
            // InNum
            // 
            this.InNum.DataPropertyName = "InNum";
            this.InNum.HeaderText = "采购数量";
            this.InNum.Name = "InNum";
            // 
            // UserNo
            // 
            this.UserNo.DataPropertyName = "UserNo";
            this.UserNo.HeaderText = "采购员编号";
            this.UserNo.Name = "UserNo";
            // 
            // CarNo
            // 
            this.CarNo.DataPropertyName = "CarNo";
            this.CarNo.HeaderText = "汽车编号";
            this.CarNo.Name = "CarNo";
            // 
            // Cancel
            // 
            this.Cancel.DataPropertyName = "Cancel";
            this.Cancel.HeaderText = "删除";
            this.Cancel.Name = "Cancel";
            this.Cancel.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.添加ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 76);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.删除ToolStripMenuItem.Text = "删除数据";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.修改ToolStripMenuItem.Text = "修改数据";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.添加ToolStripMenuItem.Text = "添加数据";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // btsupply
            // 
            this.btsupply.BackColor = System.Drawing.Color.AliceBlue;
            this.btsupply.Location = new System.Drawing.Point(724, 122);
            this.btsupply.Name = "btsupply";
            this.btsupply.Size = new System.Drawing.Size(118, 36);
            this.btsupply.TabIndex = 15;
            this.btsupply.Text = "汽车编号查询";
            this.btsupply.UseVisualStyleBackColor = false;
            this.btsupply.Click += new System.EventHandler(this.btsupply_Click);
            // 
            // txtsupply
            // 
            this.txtsupply.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtsupply.Location = new System.Drawing.Point(296, 122);
            this.txtsupply.Name = "txtsupply";
            this.txtsupply.Size = new System.Drawing.Size(395, 36);
            this.txtsupply.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1450, 27);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::WindowsFormsApp2.Properties.Resources.add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(63, 24);
            this.toolStripButton2.Text = "添加";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::WindowsFormsApp2.Properties.Resources.refresh;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(63, 24);
            this.toolStripButton3.Text = "更新";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::WindowsFormsApp2.Properties.Resources.save;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(63, 24);
            this.toolStripButton4.Text = "修改";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // PurchaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1450, 724);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dvManufacturer);
            this.Controls.Add(this.btsupply);
            this.Controls.Add(this.txtsupply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseInfo";
            this.Text = "PurchaseInfo";
            this.Load += new System.EventHandler(this.PurchaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvManufacturer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvManufacturer;
        private System.Windows.Forms.Button btsupply;
        private System.Windows.Forms.TextBox txtsupply;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}