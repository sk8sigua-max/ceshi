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
using Agoni;
using Saff;
using basic_information;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

     

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.lbUserInfo.Text = "尊敬的用户："+((LoginForm)(this.Owner)).userName+ "欢迎您！";
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EmployeeManageForm emf = new EmployeeManageForm();
            //emf.Show();
            //this.dataGridView1.Visible = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lbUserInfo_Click(object sender, EventArgs e)
        {

        }

        private void 销售管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeManageForm emf = new EmployeeManageForm();
            emf.Show();
            //this.dataGridView1.Visible = true;
            //this.Hide();
        }

        private void 供商信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChuKu ck = new ChuKu();
            ck.Show();
            //this.dataGridView1.Visible = true;
            //this.Hide();
        }

        private void 豪车信息入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JHRuKu jh = new JHRuKu();
            jh.Show();
            //this.dataGridView1.Visible = true;
            //this.Hide();
        }

        private void 库存信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KuCun kc = new KuCun();
            kc.Show();
            //this.dataGridView1.Visible = true;
            //this.Hide();
        }

        private void 员工管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StaffMainForm sm = new StaffMainForm();
            sm.Show();
            //this.dataGridView1.Visible = true;
            //this.Hide();
        }
    }
}
