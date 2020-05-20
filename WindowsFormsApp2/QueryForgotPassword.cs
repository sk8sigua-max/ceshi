using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class QueryForgotPassword : Form
    {
        public QueryForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer1 = this.textBox3.Text.ToString();
            string answer2 = this.textBox5.Text.ToString();
            string answer3 = this.textBox7.Text.ToString();
            if (answer1 != "" || answer2 != "" ||  answer3 != "")
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=CarManagementSystem;Integrated Security=True");
                string sql = string.Format("select answer1,answer2,answer3 from UserInfo where UserNo='{0}'", ((LoginForm)(this.Owner)).userName);
                SqlDataReader reader = DBhelper.GetReader(sql);
                string a1 = "";//答案1
                string a2 = "";//答案2
                string a3 = "";//答案3
                while (reader.Read())
                {
                    a1 = reader["answer1"].ToString();
                    a2 = reader["answer2"].ToString();
                    a3 = reader["answer3"].ToString();
                }
                reader.Close();
                conn.Close();
                if (answer1==a1&& answer2==a2&&answer3==a3)
                {
                    string s = string.Format("update UserInfo set UserPwd='123456' where UserNo='{0}'", ((LoginForm)(this.Owner)).userName);
                    bool r =  DBhelper.BuCha(s);
                    if (r)
                    {
                        MessageBox.Show("您的登陆密码已重置为：123456");
                        LoginForm lf = new LoginForm();
                        lf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("重置密码失败！");
                    }
                    
                }
                else
                {
                    MessageBox.Show("密保答案不正确！");
                }
            }
            else
            {
                MessageBox.Show("答案不能为空！");
            }
        }

        private void QueryForgotPassword_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=CarManagementSystem;Integrated Security=True");
            string userNo= ((LoginForm)(this.Owner)).userName;
            textBox1.Text = userNo;
            string sql = string.Format("select Question1,answer1,Question2,answer2,Question3,answer3 from UserInfo where UserNo='{0}'",userNo);
            SqlDataReader reader =  DBhelper.GetReader(sql);
            string q1 = ""; //问题1
            string a1 = "";//答案1
            string q2 = ""; //问题2
            string a2 = "";//答案2
            string q3 = ""; //问题3
            string a3 = "";//答案3
            while (reader.Read())
            {
                q1 = reader["Question1"].ToString();
                q2 = reader["Question2"].ToString();
                q3 = reader["Question3"].ToString();
                a1 = reader["answer1"].ToString();
                a2 = reader["answer2"].ToString();
                a3 = reader["answer3"].ToString();
            }
            reader.Close();
            conn.Close();
            textBox2.Text = q1;
            textBox4.Text = q2;
            textBox6.Text = q3;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm w3 = new LoginForm();
            w3.ShowDialog();
        }
    }
}
