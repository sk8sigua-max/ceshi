namespace Saff
{
    partial class StaffUpdateForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.txtSalay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(166, 241);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(172, 28);
            this.txtAddress.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 84;
            this.label2.Text = "地 址：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(1006, 241);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(172, 28);
            this.txtPhone.TabIndex = 83;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(903, 253);
            this.labPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(71, 18);
            this.labPhone.TabIndex = 82;
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
            this.combDept.Location = new System.Drawing.Point(586, 156);
            this.combDept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combDept.Name = "combDept";
            this.combDept.Size = new System.Drawing.Size(172, 26);
            this.combDept.TabIndex = 73;
            // 
            // combType
            // 
            this.combType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combType.FormattingEnabled = true;
            this.combType.Items.AddRange(new object[] {
            "1",
            "0"});
            this.combType.Location = new System.Drawing.Point(1006, 150);
            this.combType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(172, 26);
            this.combType.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(884, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "用户状态：";
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.Location = new System.Drawing.Point(493, 160);
            this.dept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(71, 18);
            this.dept.TabIndex = 67;
            this.dept.Text = "部 门：";
            // 
            // combSex
            // 
            this.combSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSex.FormattingEnabled = true;
            this.combSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.combSex.Location = new System.Drawing.Point(166, 155);
            this.combSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combSex.Name = "combSex";
            this.combSex.Size = new System.Drawing.Size(172, 26);
            this.combSex.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "性 别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(586, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 28);
            this.txtName.TabIndex = 61;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(484, 49);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(71, 18);
            this.name.TabIndex = 60;
            this.name.Text = "姓 名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(912, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 86;
            this.label3.Text = "年龄：";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(1006, 49);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(172, 28);
            this.txtAge.TabIndex = 87;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1341, 31);
            this.toolStrip1.TabIndex = 88;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::WindowsFormsApp2.Properties.Resources.save;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(70, 28);
            this.toolStripButton1.Text = "保存";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::WindowsFormsApp2.Properties.Resources.refresh;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(70, 28);
            this.toolStripButton3.Text = "刷新";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::WindowsFormsApp2.Properties.Resources.super_del;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(70, 28);
            this.toolStripButton2.Text = "取消";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // txtSalay
            // 
            this.txtSalay.Location = new System.Drawing.Point(586, 241);
            this.txtSalay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalay.Name = "txtSalay";
            this.txtSalay.Size = new System.Drawing.Size(172, 28);
            this.txtSalay.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 92;
            this.label5.Text = "工资：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(166, 49);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(172, 28);
            this.txtPwd.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 97;
            this.label7.Text = "密码：";
            // 
            // StaffUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 786);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSalay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
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
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息更新";
            this.Load += new System.EventHandler(this.UpdateForm_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox txtSalay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label7;
    }
}