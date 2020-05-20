namespace Saff
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.txtSalay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.combDept = new System.Windows.Forms.ComboBox();
            this.combType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.Label();
            this.combSex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1138, 31);
            this.toolStrip1.TabIndex = 104;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::WindowsFormsApp2.Properties.Resources.add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(70, 28);
            this.toolStripButton1.Text = "添加";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::WindowsFormsApp2.Properties.Resources.super_del;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(70, 28);
            this.toolStripButton2.Text = "退出";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // txtSalay
            // 
            this.txtSalay.Location = new System.Drawing.Point(186, 476);
            this.txtSalay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalay.Name = "txtSalay";
            this.txtSalay.Size = new System.Drawing.Size(153, 31);
            this.txtSalay.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(103, 479);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 119;
            this.label5.Text = "工资：";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(186, 245);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(153, 31);
            this.txtAge.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(103, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 117;
            this.label3.Text = "年龄：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(535, 362);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(153, 31);
            this.txtAddress.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(433, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 115;
            this.label2.Text = "地 址：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(866, 364);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(153, 31);
            this.txtPhone.TabIndex = 114;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.BackColor = System.Drawing.Color.Transparent;
            this.labPhone.Location = new System.Drawing.Point(783, 364);
            this.labPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(69, 24);
            this.labPhone.TabIndex = 113;
            this.labPhone.Text = "手 机：";
            // 
            // combDept
            // 
            this.combDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combDept.FormattingEnabled = true;
            this.combDept.Items.AddRange(new object[] {
            "销售部",
            "技术部",
            "采购部",
            "人事部"});
            this.combDept.Location = new System.Drawing.Point(866, 237);
            this.combDept.Margin = new System.Windows.Forms.Padding(4);
            this.combDept.Name = "combDept";
            this.combDept.Size = new System.Drawing.Size(153, 32);
            this.combDept.TabIndex = 112;
            // 
            // combType
            // 
            this.combType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combType.FormattingEnabled = true;
            this.combType.Items.AddRange(new object[] {
            "1",
            "0"});
            this.combType.Location = new System.Drawing.Point(186, 361);
            this.combType.Margin = new System.Windows.Forms.Padding(4);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(153, 32);
            this.combType.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(78, 364);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 110;
            this.label1.Text = "用户状态：";
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.BackColor = System.Drawing.Color.Transparent;
            this.dept.Location = new System.Drawing.Point(783, 246);
            this.dept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(69, 24);
            this.dept.TabIndex = 109;
            this.dept.Text = "部 门：";
            // 
            // combSex
            // 
            this.combSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSex.FormattingEnabled = true;
            this.combSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.combSex.Location = new System.Drawing.Point(535, 242);
            this.combSex.Margin = new System.Windows.Forms.Padding(4);
            this.combSex.Name = "combSex";
            this.combSex.Size = new System.Drawing.Size(153, 32);
            this.combSex.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(433, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 107;
            this.label4.Text = "性 别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(866, 113);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 31);
            this.txtName.TabIndex = 106;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(783, 117);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(69, 24);
            this.name.TabIndex = 105;
            this.name.Text = "姓 名：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(535, 113);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(153, 31);
            this.txtPwd.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(452, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 121;
            this.label6.Text = "密码：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(186, 113);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(153, 31);
            this.txtID.TabIndex = 124;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(81, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 123;
            this.label7.Text = "员工编号：";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 591);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSalay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.combDept);
            this.Controls.Add(this.combType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.combSex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加员工信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox txtSalay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.ComboBox combDept;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dept;
        private System.Windows.Forms.ComboBox combSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;

    }
}