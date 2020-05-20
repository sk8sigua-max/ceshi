namespace WindowsFormsApp2
{
    partial class Forget_the_password
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAn1 = new System.Windows.Forms.TextBox();
            this.txtAn2 = new System.Windows.Forms.TextBox();
            this.txtAn3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQ1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQ2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQ3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "请设置答案1：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "请回答问题2：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "请回答问题3：";
            // 
            // txtAn1
            // 
            this.txtAn1.Location = new System.Drawing.Point(267, 77);
            this.txtAn1.Name = "txtAn1";
            this.txtAn1.Size = new System.Drawing.Size(415, 28);
            this.txtAn1.TabIndex = 3;
            // 
            // txtAn2
            // 
            this.txtAn2.Location = new System.Drawing.Point(267, 183);
            this.txtAn2.Name = "txtAn2";
            this.txtAn2.Size = new System.Drawing.Size(415, 28);
            this.txtAn2.TabIndex = 4;
            // 
            // txtAn3
            // 
            this.txtAn3.Location = new System.Drawing.Point(267, 289);
            this.txtAn3.Name = "txtAn3";
            this.txtAn3.Size = new System.Drawing.Size(415, 28);
            this.txtAn3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "请设置问题1：";
            // 
            // txtQ1
            // 
            this.txtQ1.Location = new System.Drawing.Point(267, 24);
            this.txtQ1.Multiline = true;
            this.txtQ1.Name = "txtQ1";
            this.txtQ1.Size = new System.Drawing.Size(415, 28);
            this.txtQ1.TabIndex = 8;
            this.txtQ1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "请设置问题2：";
            // 
            // txtQ2
            // 
            this.txtQ2.Location = new System.Drawing.Point(267, 130);
            this.txtQ2.Multiline = true;
            this.txtQ2.Name = "txtQ2";
            this.txtQ2.Size = new System.Drawing.Size(415, 28);
            this.txtQ2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "请设置问题3：";
            // 
            // txtQ3
            // 
            this.txtQ3.Location = new System.Drawing.Point(267, 236);
            this.txtQ3.Multiline = true;
            this.txtQ3.Name = "txtQ3";
            this.txtQ3.Size = new System.Drawing.Size(415, 28);
            this.txtQ3.TabIndex = 12;
            // 
            // Forget_the_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtQ3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQ2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQ1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAn3);
            this.Controls.Add(this.txtAn2);
            this.Controls.Add(this.txtAn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forget_the_password";
            this.Text = "密保";
            this.Load += new System.EventHandler(this.Forget_the_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAn1;
        private System.Windows.Forms.TextBox txtAn2;
        private System.Windows.Forms.TextBox txtAn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQ1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQ2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQ3;
    }
}