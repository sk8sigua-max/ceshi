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
    public partial class StaffUpdateForm : Form
    {
        public StaffUpdateForm()
        {
            InitializeComponent();
        }
        private DataGridView sc;
        private StaffScoreForm scoreform;

        public StaffUpdateForm(DataGridView data, StaffScoreForm scoreForm)
        {
            InitializeComponent();
            sc = data;
            scoreform = scoreForm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void UpdateForm_Load_1(object sender, EventArgs e)
        { 
            //将选中的值显示在修改框里
            this.txtID.Text = sc.SelectedRows[0].Cells["StaffId"].Value.ToString();
            this.txtPwd.Text = sc.SelectedRows[0].Cells["StaffPwd"].Value.ToString();
            this.txtName.Text = sc.SelectedRows[0].Cells["StaffName"].Value.ToString();
            this.txtAge.Text = sc.SelectedRows[0].Cells["StaffAge"].Value.ToString();
            this.combSex.Text = sc.SelectedRows[0].Cells["StaffSex"].Value.ToString();
            this.combDept.Text = sc.SelectedRows[0].Cells["StaffDept"].Value.ToString();
            this.combType.Text = sc.SelectedRows[0].Cells["StafftType"].Value.ToString();
            this.txtAddress.Text = sc.SelectedRows[0].Cells["StaffAddressed"].Value.ToString();
            this.txtSalay.Text = sc.SelectedRows[0].Cells["StaffSalay"].Value.ToString();
            this.txtPhone.Text = sc.SelectedRows[0].Cells["StaffPhone"].Value.ToString();
            string sql = "select * from Staff";
            this.sc.DataSource = DBhelper.Cha(sql).Tables[0];
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string id=this.txtID.Text.ToString().Trim();//员工Id
            string pwd = this.txtPwd.Text.ToString().Trim();//员工密码
            string name = this.txtName.Text.ToString().Trim();//员工姓名
            string age = this.txtAge.Text.ToString().Trim();//员工年龄
            string sex = this.combSex.Text;//员工性别
            string dept = this.combDept.Text;//员工部门
            string type = this.combType.Text;//员工状态 离职or在职 1为离职 0为在职 默认在职
            string ddress = this.txtAddress.Text.ToString().Trim();//员工地址
            string salay = this.txtSalay.Text.ToString().Trim();//员工工资
            string phone = this.txtPhone.Text.ToString().Trim();//员工电话号
            //DialogResult re=MessageBox.Show("确定要更改吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            DialogResult x = MessageBox.Show("您确定要修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x==DialogResult.Yes)
            {
                MessageBox.Show(id);
                string sql = string.Format(@"update Staff set StaffName='{0}',StaffAge='{1}',StaffSex='{2}',StaffDept='{3}',StafftType='{4}',StaffAddressed='{5}',StaffSalay='{6}',StaffPhone='{7}' where StaffId='{8}'", name, age, sex, dept, type, ddress, salay, phone,id);
                bool r = DBhelper.BuCha(sql);
                if (r)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            UpdateForm_Load_1(sender, e);
        }


 





      
    }
}
