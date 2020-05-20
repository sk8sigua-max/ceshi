using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agoni;

namespace WindowsFormsApp2
{
    public partial class EmployeeManageForm : Form
    {
        public EmployeeManageForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text.ToString();
            string sql = "select u.UserNo,o.OrderNo,u.UserName,o.OrderNum,o.OrderDate from UserInfo u left join OrderInfo o on u.UserNo=o.UserNo";
             this.dataGridView1.DataSource= DBhelper.Cha(sql).Tables[0];
        }

        private void EmployeeManageForm_Load(object sender, EventArgs e)
        {
            string sql = "select u.UserNo,o.OrderNo,u.UserName,o.OrderNum,o.OrderDate from UserInfo u left join OrderInfo o on u.UserNo=o.UserNo";
            this.dataGridView1.DataSource = DBhelper.Cha(sql).Tables[0];
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.SelectedRows[0].Cells["UserNo"].Value.ToString();

            string sql = "delete from UserInfo where UserNo=" + id;
            bool r = DBhelper.BuCha(sql);
            if (r)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
    }
}
