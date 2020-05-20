namespace WindowsFormsApp2
{
    partial class Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            this.dvcar = new System.Windows.Forms.DataGridView();
            this.CarNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarInPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarOutPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarDisplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btcar = new System.Windows.Forms.Button();
            this.txtcar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvcar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvcar
            // 
            this.dvcar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvcar.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvcar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvcar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarNo,
            this.CarBrand,
            this.CarInPrice,
            this.CarOutPrice,
            this.CarStock,
            this.CarDisplacement,
            this.Cancel,
            this.CarSort,
            this.ProductionID});
            this.dvcar.ContextMenuStrip = this.contextMenuStrip1;
            this.dvcar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvcar.Location = new System.Drawing.Point(0, 194);
            this.dvcar.MultiSelect = false;
            this.dvcar.Name = "dvcar";
            this.dvcar.RowHeadersVisible = false;
            this.dvcar.RowTemplate.Height = 27;
            this.dvcar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvcar.Size = new System.Drawing.Size(1432, 483);
            this.dvcar.TabIndex = 15;
            // 
            // CarNo
            // 
            this.CarNo.DataPropertyName = "CarNo";
            this.CarNo.HeaderText = "汽车编号";
            this.CarNo.Name = "CarNo";
            // 
            // CarBrand
            // 
            this.CarBrand.DataPropertyName = "CarBrand";
            this.CarBrand.HeaderText = "汽车品牌";
            this.CarBrand.Name = "CarBrand";
            // 
            // CarInPrice
            // 
            this.CarInPrice.DataPropertyName = "CarInPrice";
            this.CarInPrice.HeaderText = "进货价格";
            this.CarInPrice.Name = "CarInPrice";
            // 
            // CarOutPrice
            // 
            this.CarOutPrice.DataPropertyName = "CarOutPrice";
            this.CarOutPrice.HeaderText = "出售价格";
            this.CarOutPrice.Name = "CarOutPrice";
            // 
            // CarStock
            // 
            this.CarStock.DataPropertyName = "CarStock";
            this.CarStock.HeaderText = "库存余量";
            this.CarStock.Name = "CarStock";
            // 
            // CarDisplacement
            // 
            this.CarDisplacement.DataPropertyName = "CarDisplacement";
            this.CarDisplacement.HeaderText = "汽车排量";
            this.CarDisplacement.Name = "CarDisplacement";
            // 
            // Cancel
            // 
            this.Cancel.DataPropertyName = "Cancel";
            this.Cancel.HeaderText = "删除";
            this.Cancel.Name = "Cancel";
            this.Cancel.Visible = false;
            // 
            // CarSort
            // 
            this.CarSort.DataPropertyName = "CarSort";
            this.CarSort.HeaderText = "汽车类型";
            this.CarSort.Name = "CarSort";
            // 
            // ProductionID
            // 
            this.ProductionID.DataPropertyName = "ProductionID";
            this.ProductionID.HeaderText = "生产商";
            this.ProductionID.Name = "ProductionID";
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
            // btcar
            // 
            this.btcar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btcar.Location = new System.Drawing.Point(735, 139);
            this.btcar.Name = "btcar";
            this.btcar.Size = new System.Drawing.Size(118, 36);
            this.btcar.TabIndex = 14;
            this.btcar.Text = "品牌查询";
            this.btcar.UseVisualStyleBackColor = false;
            this.btcar.Click += new System.EventHandler(this.btcar_Click);
            // 
            // txtcar
            // 
            this.txtcar.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcar.Location = new System.Drawing.Point(307, 139);
            this.txtcar.Name = "txtcar";
            this.txtcar.Size = new System.Drawing.Size(395, 36);
            this.txtcar.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1432, 27);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
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
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1432, 677);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dvcar);
            this.Controls.Add(this.btcar);
            this.Controls.Add(this.txtcar);
            this.Name = "Car";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvcar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvcar;
        private System.Windows.Forms.Button btcar;
        private System.Windows.Forms.TextBox txtcar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarInPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarOutPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarDisplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionID;
    }
}