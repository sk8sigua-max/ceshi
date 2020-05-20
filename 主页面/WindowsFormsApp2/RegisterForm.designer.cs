namespace WindowsFormsApp2
{
    partial class Register
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.EmployeeID = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.userPwd = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.Label();
            this.IdentifyingCode = new System.Windows.Forms.Label();
            this.textEmployeeID = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textuserPwd = new System.Windows.Forms.TextBox();
            this.textPassWord = new System.Windows.Forms.TextBox();
            this.txtVali = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancle = new System.Windows.Forms.Button();
            this.verification = new System.Windows.Forms.Label();
            this.txtValidation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.BackColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeeID.Location = new System.Drawing.Point(589, 140);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(98, 18);
            this.EmployeeID.TabIndex = 1;
            this.EmployeeID.Text = "员工编号：";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.SystemColors.ControlText;
            this.Phone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Phone.Location = new System.Drawing.Point(589, 197);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(98, 18);
            this.Phone.TabIndex = 2;
            this.Phone.Text = "电话号码：";
            // 
            // userPwd
            // 
            this.userPwd.AutoSize = true;
            this.userPwd.BackColor = System.Drawing.SystemColors.ControlText;
            this.userPwd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.userPwd.Location = new System.Drawing.Point(607, 254);
            this.userPwd.Name = "userPwd";
            this.userPwd.Size = new System.Drawing.Size(80, 18);
            this.userPwd.TabIndex = 3;
            this.userPwd.Text = "新密码：";
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.BackColor = System.Drawing.SystemColors.ControlText;
            this.PassWord.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PassWord.Location = new System.Drawing.Point(589, 311);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(98, 18);
            this.PassWord.TabIndex = 4;
            this.PassWord.Text = "确认密码：";
            // 
            // IdentifyingCode
            // 
            this.IdentifyingCode.AutoSize = true;
            this.IdentifyingCode.BackColor = System.Drawing.SystemColors.ControlText;
            this.IdentifyingCode.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.IdentifyingCode.Location = new System.Drawing.Point(607, 413);
            this.IdentifyingCode.Name = "IdentifyingCode";
            this.IdentifyingCode.Size = new System.Drawing.Size(80, 18);
            this.IdentifyingCode.TabIndex = 5;
            this.IdentifyingCode.Text = "验证码：";
            // 
            // textEmployeeID
            // 
            this.textEmployeeID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEmployeeID.Location = new System.Drawing.Point(732, 137);
            this.textEmployeeID.Name = "textEmployeeID";
            this.textEmployeeID.Size = new System.Drawing.Size(142, 28);
            this.textEmployeeID.TabIndex = 7;
            // 
            // textPhone
            // 
            this.textPhone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textPhone.Location = new System.Drawing.Point(732, 197);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(142, 28);
            this.textPhone.TabIndex = 8;
            // 
            // textuserPwd
            // 
            this.textuserPwd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textuserPwd.Location = new System.Drawing.Point(732, 251);
            this.textuserPwd.Name = "textuserPwd";
            this.textuserPwd.Size = new System.Drawing.Size(142, 28);
            this.textuserPwd.TabIndex = 9;
            // 
            // textPassWord
            // 
            this.textPassWord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textPassWord.Location = new System.Drawing.Point(732, 308);
            this.textPassWord.Name = "textPassWord";
            this.textPassWord.Size = new System.Drawing.Size(142, 28);
            this.textPassWord.TabIndex = 10;
            // 
            // txtVali
            // 
            this.txtVali.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtVali.Location = new System.Drawing.Point(732, 409);
            this.txtVali.Name = "txtVali";
            this.txtVali.Size = new System.Drawing.Size(142, 28);
            this.txtVali.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(629, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCancle.Location = new System.Drawing.Point(770, 475);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(81, 29);
            this.btnCancle.TabIndex = 13;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // verification
            // 
            this.verification.AutoSize = true;
            this.verification.BackColor = System.Drawing.SystemColors.ControlText;
            this.verification.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.verification.Location = new System.Drawing.Point(571, 360);
            this.verification.Name = "verification";
            this.verification.Size = new System.Drawing.Size(116, 18);
            this.verification.TabIndex = 14;
            this.verification.Text = "更换验证码：";
            this.verification.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValidation
            // 
            this.txtValidation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValidation.Location = new System.Drawing.Point(732, 360);
            this.txtValidation.Name = "txtValidation";
            this.txtValidation.ReadOnly = true;
            this.txtValidation.Size = new System.Drawing.Size(142, 28);
            this.txtValidation.TabIndex = 15;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(908, 601);
            this.Controls.Add(this.txtValidation);
            this.Controls.Add(this.verification);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVali);
            this.Controls.Add(this.textPassWord);
            this.Controls.Add(this.textuserPwd);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEmployeeID);
            this.Controls.Add(this.IdentifyingCode);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.userPwd);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.EmployeeID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label userPwd;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.Label IdentifyingCode;
        private System.Windows.Forms.TextBox textEmployeeID;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textuserPwd;
        private System.Windows.Forms.TextBox textPassWord;
        private System.Windows.Forms.TextBox txtVali;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label verification;
        private System.Windows.Forms.TextBox txtValidation;
    }
}

