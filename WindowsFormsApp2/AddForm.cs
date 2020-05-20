using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Saff
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text.ToString().Trim();//员工编号
            string pwd = this.txtPwd.Text.ToString().Trim();//员工密码
            string name = this.txtName.Text.ToString().Trim();//员工姓名
            string age = this.txtAge.Text.ToString().Trim();//员工年龄
            string sex = this.combSex.Text;//员工性别
            string dept = this.combDept.Text;//员工部门
            string type = this.combType.Text;//员工状态 离职or在职 1为离职 0为在职 默认在职
            string ddress = this.txtAddress.Text.ToString().Trim();//员工地址
            string salay = this.txtSalay.Text.ToString().Trim();//员工工资
            string phone = this.txtPhone.Text.ToString().Trim();//员工电话号
            if (id!=""&&pwd!=""&&name != "" && age != "" && sex != "" && dept != "" && type != "" && ddress != "" && salay != "" && phone!="")
            {
                string sql = string.Format("insert into Staff (StaffId,StaffPwd,StaffName,StaffAge,StaffSex,StaffDept,StafftType,StaffAddressed,StaffSalay,StaffPhone ) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", id, pwd, name, age, sex, dept, type, ddress, salay, phone);
                bool r = DBhelper.BuCha(sql);
                if (r)
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            else
            {
                MessageBox.Show("输入值不能为空！");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
