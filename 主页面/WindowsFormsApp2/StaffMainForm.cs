using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saff
{
    public partial class StaffMainForm : Form
    {
        public StaffMainForm()
        {
            InitializeComponent();
        }
        //private void 员工信息更新ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           
        //}


      
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result=MessageBox.Show("您确定要退出吗？","温馨提示：",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }
   
      
        private void 更新员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////窗口切换出来
            //UpdateForm uf = new UpdateForm();
            ////uf.TopLevel = false;
            ////this.panel1.Controls.Add(uf);
            ////uf.FormBorderStyle = FormBorderStyle.None;
            //uf.Show();
            ////uf.BringToFront();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StaffScoreForm wl = new StaffScoreForm();
            wl.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //UpdateForm uf = new UpdateForm();
            //uf.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要退出吗？", "温馨提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
