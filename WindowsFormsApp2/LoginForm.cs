using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string userName
        {
            get { return txtUserName.Text; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = this.txtUserName.Text;
            string EmpPwd = this.txtUserPassWord.Text;
            if (name!=""&&EmpPwd!="")
            {
                //string sql = string.Format("insert into CarManagementSystem values('{0}','{1}')", name, EmpPwd);
                string s = string.Format("select Count(UserNo) from UserInfo where UserNo = '"+name+"' and UserPwd = '"+EmpPwd+"'");

               int result =  int.Parse(DBhelper.GetExecuteScalar(s).ToString());
                if (result==1)
                {
                    MessageBox.Show("登陆成功！");
                    MainForm mf = new MainForm();
                    mf.Owner = this;
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登陆失败！");
                }
            }
            else
            {
                MessageBox.Show("账号和密码不能为空！");
            }
        }

        private void lbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = Application.StartupPath + "//MSN.ssk";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QueryForgotPassword qfp = new QueryForgotPassword();
            qfp.Owner = this;
            qfp.Show();
            this.Hide();
        }
    }
}
