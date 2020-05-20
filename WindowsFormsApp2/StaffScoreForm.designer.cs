namespace Saff
{
    partial class StaffScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffScoreForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StafftType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffAddressed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffSalay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(340, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户编号：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(476, 156);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(241, 25);
            this.txtID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(775, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.修改ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 80);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffId,
            this.StaffPwd,
            this.StaffName,
            this.StaffAge,
            this.StaffSex,
            this.StaffDept,
            this.StafftType,
            this.StaffAddressed,
            this.StaffSalay,
            this.StaffPhone});
            this.dataGridView1.Location = new System.Drawing.Point(0, 223);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1439, 457);
            this.dataGridView1.TabIndex = 90;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StaffId
            // 
            this.StaffId.DataPropertyName = "StaffId";
            this.StaffId.HeaderText = "用户编号";
            this.StaffId.Name = "StaffId";
            // 
            // StaffPwd
            // 
            this.StaffPwd.DataPropertyName = "StaffPwd";
            this.StaffPwd.HeaderText = "员工密码";
            this.StaffPwd.Name = "StaffPwd";
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "用户姓名";
            this.StaffName.Name = "StaffName";
            // 
            // StaffAge
            // 
            this.StaffAge.DataPropertyName = "StaffAge";
            this.StaffAge.HeaderText = "用户年龄";
            this.StaffAge.Name = "StaffAge";
            // 
            // StaffSex
            // 
            this.StaffSex.DataPropertyName = "StaffSex";
            this.StaffSex.HeaderText = "用户性别";
            this.StaffSex.Name = "StaffSex";
            // 
            // StaffDept
            // 
            this.StaffDept.DataPropertyName = "StaffDept";
            this.StaffDept.HeaderText = "员工部门";
            this.StaffDept.Name = "StaffDept";
            // 
            // StafftType
            // 
            this.StafftType.DataPropertyName = "StafftType";
            this.StafftType.HeaderText = "用户状态";
            this.StafftType.Name = "StafftType";
            // 
            // StaffAddressed
            // 
            this.StaffAddressed.DataPropertyName = "StaffAddressed";
            this.StaffAddressed.HeaderText = "用户地址";
            this.StaffAddressed.Name = "StaffAddressed";
            // 
            // StaffSalay
            // 
            this.StaffSalay.DataPropertyName = "StaffSalay";
            this.StaffSalay.HeaderText = "员工工资";
            this.StaffSalay.Name = "StaffSalay";
            // 
            // StaffPhone
            // 
            this.StaffPhone.DataPropertyName = "StaffPhone";
            this.StaffPhone.HeaderText = "员工电话";
            this.StaffPhone.Name = "StaffPhone";
            // 
            // StaffScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1432, 678);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询员工信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScoreForm_FormClosing);
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn StafftType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffAddressed;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffSalay;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPhone;
    }
}