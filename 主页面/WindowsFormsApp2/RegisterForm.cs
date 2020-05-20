using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public string employeeID
        {
            get { return textEmployeeID.Text; }
        }

        //public static string connString = "server=127.0.0.1;database=CarManagementSystem;uid=sa;pwd=123456;";
        public static string connString = "Data Source=.;Initial Catalog=CarManagementSystem;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connString);
        StringBuilder sb = new StringBuilder();
        //验证码的初始字符串
        string validation = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.txtVali.Text.ToString().Trim()!="") ||
                (this.txtVali.Text.ToString()==this.txtValidation.Text.ToString()))
            {
                if ((this.textPassWord.Text.ToString().Trim()!="")&& 
                    (this.textuserPwd.Text.ToString().Trim() != "")
                    && (this.textuserPwd.Text.ToString() == this.textPassWord.Text.ToString())
                    )
                {
                    if (this.textEmployeeID.Text.ToString().Trim()!="")
                    {
                        if (this.textEmployeeID.Text.ToString().Trim().StartsWith("1")||
                            this.textEmployeeID.Text.ToString().Trim().StartsWith("2")||
                            this.textEmployeeID.Text.ToString().Trim().StartsWith("3"))
                        {
                            if (this.textPhone.Text.ToString().Trim()!="")
                            {
                                string empNo = this.textEmployeeID.Text.ToString();
                                string phone = this.textPhone.Text.ToString();
                                string pwd = this.textuserPwd.Text.ToString();
                                try
                                {
                                    conn.Open();
                                    string sql = "select count(UserNo) from UserInfo where UserNo = '" + empNo + "'";
                                    SqlCommand cmd = new SqlCommand(sql, conn);
                                    int isExsit = int.Parse(cmd.ExecuteScalar().ToString());
                                    if (isExsit == 0)
                                    {
                                        sql = string.Format("insert into [UserInfo] (UserNo,UserPwd,UserPhone) values ('{0}','{1}','{2}')", empNo, pwd, phone);
                                        SqlCommand c = new SqlCommand(sql, conn);
                                        int result = c.ExecuteNonQuery();
                                        if (result != 0)
                                        {
                                            MessageBox.Show("注册成功！");
                                            Forget_the_password ftp = new Forget_the_password();
                                            this.Hide();
                                            ftp.Owner = this;
                                            ftp.ShowDialog();
                                        }
                                        else
                                        {
                                            MessageBox.Show("注册失败！");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("此员工已经存在！");
                                    }
                                    
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                                finally {
                                    conn.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("电话号码不能为空！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("员工编号不符合规范！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("员工编号不能为空，请输入员工编号！");
                    }
                }
                else
                {
                    MessageBox.Show("密码和新密码不相符合！");
                }
            }
            else
            {
                MessageBox.Show("请输入正确的验证码！");
            }
            //if (userName.Text=="")
            //{
            //    MessageBox.Show("用户名不能为空！");
            //}
            //if (userPwd.Text == "")
            //{
            //    MessageBox.Show("密码不能为空！");
            //}
            
            //if (PassWord.Text!=userPwd.Text)
            //{
            //    MessageBox.Show("密码和新密码不相符合！");
            //    userPwd.Text = "";
            //    PassWord.Text = "";
            //}
            //try
            //{
            //    string sql = string.Format("select count(*)from user_info where userName='{0}'", userName.Text);
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    conn.Open();
            //    //返回一个值，看用户是否存在
            //    int a = (int)cmd.ExecuteScalar();
            //    StringBuilder strsql = new StringBuilder();
            //    if (a == 0)
            //    {

            //        strsql.Append("insert into user_info(userName,userPwd)");
            //        strsql.Append("values(");
            //        strsql.Append("'" + userName.Text.Trim().ToString() + "',");
            //        strsql.Append("'" + userPwd.Text.Trim().ToString() + "'");
            //        strsql.Append(")");
            //        SqlCommand cmd2 = new SqlCommand(strsql.ToString(),conn);
            //        if (cmd2.ExecuteNonQuery()>0)
            //        {
            //            MessageBox.Show("注册成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        }
            //        else
            //        {
            //            MessageBox.Show("注册失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        //using (SqlCommand cmd2 = new SqlCommand(strsql.ToString(),conn));
            //        //{
            //        //    cmd2.ExecuteNonQuery();
            //        //}
            //    }
            //    else
            //    {
            //        MessageBox.Show("用户已存在！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.ToString());
            //    Application.Exit();
            //}
            //finally
            //{
            //    conn.Close();
            //   conn.Dispose();
            //}
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private string CreateValiCode()
        {
           
            char[] Pattern = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string result = "";
            int n = Pattern.Length;
            System.Random random = new Random(~unchecked((int)DateTime.Now.Ticks));
            for (int i = 0; i < 4; i++)
            {
                int rnd = random.Next(0, n);
                result += Pattern[rnd];
            }
            return result;
        }


        private void Register_Load(object sender, EventArgs e)
        {

           // MessageBox.Show(new Random().Next(62).ToString());
            this.txtValidation.Text = CreateValiCode();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (verification.Text == "")
            {
                MessageBox.Show("验证码不能为空！");
            }
           // if (userPwd.Text == "")
           // {
              //  MessageBox.Show("密码不能为空！");
           // }
            if (verification.Text != IdentifyingCode.Text)
            {
                verification.Text = "";
                IdentifyingCode.Text = "";
                MessageBox.Show("验证码和新验证码不相符合！");
                
            }
            this.txtValidation.Text = CreateValiCode();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
