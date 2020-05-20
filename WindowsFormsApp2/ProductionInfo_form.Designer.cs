namespace WindowsFormsApp2
{
    partial class ProductionInfo_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionInfo_form));
            this.dvProductionInfo = new System.Windows.Forms.DataGridView();
            this.ProductionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btsupply = new System.Windows.Forms.Button();
            this.txtcha = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvProductionInfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvProductionInfo
            // 
            this.dvProductionInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvProductionInfo.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvProductionInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvProductionInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvProductionInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductionID,
            this.ProductionBrand,
            this.productionPhone,
            this.productionAddress,
            this.Cancel});
            this.dvProductionInfo.ContextMenuStrip = this.contextMenuStrip1;
            this.dvProductionInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvProductionInfo.Location = new System.Drawing.Point(0, 143);
            this.dvProductionInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvProductionInfo.MultiSelect = false;
            this.dvProductionInfo.Name = "dvProductionInfo";
            this.dvProductionInfo.RowHeadersVisible = false;
            this.dvProductionInfo.RowTemplate.Height = 27;
            this.dvProductionInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvProductionInfo.Size = new System.Drawing.Size(1074, 399);
            this.dvProductionInfo.TabIndex = 16;
            // 
            // ProductionID
            // 
            this.ProductionID.DataPropertyName = "ProductionID";
            this.ProductionID.HeaderText = "厂家编号";
            this.ProductionID.Name = "ProductionID";
            this.ProductionID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ProductionBrand
            // 
            this.ProductionBrand.DataPropertyName = "ProductionBrand";
            this.ProductionBrand.HeaderText = "汽车品牌";
            this.ProductionBrand.Name = "ProductionBrand";
            // 
            // productionPhone
            // 
            this.productionPhone.DataPropertyName = "productionPhone";
            this.productionPhone.HeaderText = "公司电话";
            this.productionPhone.Name = "productionPhone";
            // 
            // productionAddress
            // 
            this.productionAddress.DataPropertyName = "productionAddress";
            this.productionAddress.HeaderText = "公司地址";
            this.productionAddress.Name = "productionAddress";
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除ToolStripMenuItem.Text = "删除数据";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改ToolStripMenuItem.Text = "修改数据";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加ToolStripMenuItem.Text = "添加数据";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // btsupply
            // 
            this.btsupply.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btsupply.Location = new System.Drawing.Point(649, 105);
            this.btsupply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btsupply.Name = "btsupply";
            this.btsupply.Size = new System.Drawing.Size(88, 29);
            this.btsupply.TabIndex = 15;
            this.btsupply.Text = "品牌查询";
            this.btsupply.UseVisualStyleBackColor = false;
            this.btsupply.Click += new System.EventHandler(this.btsupply_Click);
            // 
            // txtcha
            // 
            this.txtcha.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcha.Location = new System.Drawing.Point(328, 105);
            this.txtcha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcha.Name = "txtcha";
            this.txtcha.Size = new System.Drawing.Size(297, 30);
            this.txtcha.TabIndex = 14;
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
            this.toolStrip1.Size = new System.Drawing.Size(1074, 27);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::WindowsFormsApp2.Properties.Resources.add;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(56, 24);
            this.toolStripButton2.Text = "添加";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::WindowsFormsApp2.Properties.Resources.refresh;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(56, 24);
            this.toolStripButton3.Text = "更新";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::WindowsFormsApp2.Properties.Resources.save;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(56, 24);
            this.toolStripButton4.Text = "修改";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(245, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "汽车品牌：";
            // 
            // ProductionInfo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dvProductionInfo);
            this.Controls.Add(this.btsupply);
            this.Controls.Add(this.txtcha);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductionInfo_form";
            this.Text = "ProductionInfo";
            this.Load += new System.EventHandler(this.ProductionInfo_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvProductionInfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvProductionInfo;
        private System.Windows.Forms.Button btsupply;
        private System.Windows.Forms.TextBox txtcha;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancel;
        private System.Windows.Forms.Label label1;
    }
}