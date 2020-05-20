using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp2;


namespace Saff
{
    public partial class StaffScoreForm : Form
    {
        public StaffScoreForm()
        {
            InitializeComponent();
            
        }

        private void ScoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            string sql = "select * from Staff";
            this.dataGridView1.DataSource = DBhelper.Cha(sql).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text.ToString().Trim();
            string sql = "select * from Staff where StaffId like '%"+id+"%'";
            this.dataGridView1.DataSource = DBhelper.Cha(sql).Tables[0];
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult re= MessageBox.Show("确定要删除吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           if (re == DialogResult.Yes)
           {
               string id = this.dataGridView1.SelectedRows[0].Cells["StaffId"].Value.ToString();
               string sql = "delete from Staff where StaffId=" + id;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string a = dataGridView1.SelectedRows[0].Cells["StaffId"].Value.ToString();
            MessageBox.Show(a);
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffUpdateForm uf = new StaffUpdateForm(this.dataGridView1, this);
            uf.Show();
        }
    }
}

