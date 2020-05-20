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
            this.lbUserInfo.Text = "尊敬的用户：" + ((LoginForm)(this.Owner)).userName + "欢迎您！";
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            this.skinEngine1.SkinFile = Application.StartupPath + "//MSN.ssk";
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
            //窗体切换
            EmployeeManageForm w1 = new EmployeeManageForm();//实例化对象
            w1.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w1);//添加w1的控件
            w1.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w1.Show();//显示w4窗体
            w1.BringToFront();//将w4置于顶层  
         
           
        }

        private void 供商信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //窗体切换
            ChuKu w1 = new ChuKu();//实例化对象
            w1.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w1);//添加w1的控件
            w1.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w1.Show();//显示w4窗体
            w1.BringToFront();//将w4置于顶层  
            //ChuKu ck = new ChuKu();
            //ck.Show();
            ////this.dataGridView1.Visible = true;
            ////this.Hide();
        }

        private void 豪车信息入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //窗体切换
            JHRuKu w1 = new JHRuKu();//实例化对象
            w1.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w1);//添加w1的控件
            w1.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w1.Show();//显示w4窗体
            w1.BringToFront();//将w4置于顶层  

            //this.dataGridView1.Visible = true;
            //this.Hide();
        }

        private void 库存信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //窗体切换
            KuCun w2 = new KuCun();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
        }

        private void 员工管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //窗体切换
            StaffMainForm w2 = new StaffMainForm();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
          
        }

        private void 其他信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //窗体切换
            Car w2 = new Car();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
        }

        private void 厂商管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //窗体切换
            ProductionInfo_form w2 = new ProductionInfo_form();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
        }

        private void 厂商管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //窗体切换
            Car w2 = new Car();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
        }

        private void 采购管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //窗体切换
            PurchaseInfo w2 = new PurchaseInfo();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
        }

        private void 年度报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 多图模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //窗体切换
            year w2 = new year();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          DialogResult x=  MessageBox.Show("您确定要关闭吗？", "提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (x==DialogResult.Yes)
          {
              Environment.Exit(0);
          }
          else
          {
              e.Cancel = true;
          }
        }

        private void 横向柱状统计图模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //窗体切换
            year1 w2 = new year1();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
        }

        private void 纵向柱状统计图模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //窗体切换
            year4 w2 = new year4();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
        }

        private void 雷达表模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //窗体切换
            year3 w2 = new year3();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
        }

        private void 扇形统计图模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //窗体切换
            year2cs w2 = new year2cs();//实例化对象
            w2.TopLevel = false;//将此控件设置为非顶级
            this.panel1.Controls.Add(w2);//添加w1的控件
            w2.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            w2.Show();//显示w4窗体
            w2.BringToFront();//将w4置于顶层 
        }

        private void lbUserInfo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
