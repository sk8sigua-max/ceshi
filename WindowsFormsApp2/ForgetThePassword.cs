﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Forget_the_password : Form
    {
        public Forget_the_password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = ((Register)(this.Owner)).employeeID;
            string Question1 = this.txtQ1.Text.ToString();
            string answer1 = this.txtAn1.Text.ToString();
            string Question2 = this.txtQ2.Text.ToString();
            string answer2= this.txtAn2.Text.ToString();
            string Question3 = this.txtQ3.Text.ToString();
            string answer3 = this.txtAn3.Text.ToString();
            if ((Question1 != "" && answer1 != "") || (Question2 != "" && answer2 != "") || (Question3 != "" && answer3 != ""))
            {
                string s = string.Format("update UserInfo set Question1='{0}',answer1='{1}',Question2='{2}',answer2='{3}',Question3='{4}',answer3='{5}' where UserNo='{6}'", Question1, answer1, Question2, answer2, Question3, answer3,id);
              //  string sql = string.Format("insert into UserInfo (Question1,answer1,Question2,answer2,Question3,answer3) values ('{0}','{1}','{2}','{3}','{4}','{5}')", Question1, answer1, Question2, answer2, Question3, answer3);
                bool r = DBhelper.BuCha(s);
                if (r)
                {
                    MessageBox.Show("密保设置成功！");
                }
                else
                {
                    MessageBox.Show("密保设置失败！");
                }
            }
            else
            {
                MessageBox.Show("输入框不能为空！");
            }
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void Forget_the_password_Load(object sender, EventArgs e)
        {
            string id = ((Register)(this.Owner)).employeeID;
           
        }
        private void lbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //LoginForm l = new LoginForm();
            //l.Show();
            //this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("");
        }

    }
}
