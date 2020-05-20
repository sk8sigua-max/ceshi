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
            //窗体切换
            StaffScoreForm w2 = new StaffScoreForm();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
          
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //窗体切换
            AddForm w2 = new AddForm();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
         
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender, e);
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
