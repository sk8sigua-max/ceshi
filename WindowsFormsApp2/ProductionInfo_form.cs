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
    public partial class ProductionInfo_form : Form
    {
        public ProductionInfo_form()
        {
            InitializeComponent();
        }

        private void ProductionInfo_form_Load(object sender, EventArgs e)
        {
            //编写sql语句
            string sql = "select * from ProductionInfo where Cancel=1";
            //导入DataGridView
            dvProductionInfo.DataSource = DBhelper.Cha(sql).Tables[0];

            
        }

        private void btsupply_Click(object sender, EventArgs e)
        {
            //获取文本框中的值
            string cha = this.txtcha.Text.ToString().Trim();
            //编写sql语句
            string sql = string.Format("select * from ProductionInfo where Cancel=1 and ProductionBrand like '%{0}%'", cha);
            //导入DataGridView
            dvProductionInfo.DataSource = DBhelper.Cha(sql).Tables[0];
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //实例化对象
            ProductionInfo_zeng z = new ProductionInfo_zeng();
            z.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            //弹出窗口
            z.ShowDialog();
            //加载LOad事件实现自动刷新
            ProductionInfo_form_Load(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dvProductionInfo.SelectedRows[0].Cells["ProductionID"].Value.ToString());

           //实例化窗口
            ProductionInfo_gai g = new ProductionInfo_gai(id);
            g.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            g.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ProductionInfo_form_Load(sender,e);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取ID
            int i = int.Parse(this.dvProductionInfo.SelectedRows[0].Cells["ProductionID"].Value.ToString());
           //询问·是否删除
            DialogResult x= MessageBox.Show("您确定要删除吗？","提示：",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           // 判断点击的按钮
            if (x==DialogResult.Yes)
            {
                //编写sql语句
                string sql = string.Format("update ProductionInfo set  Cancel='0' where ProductionID=  '{0}'", i);
                //执行
                bool s = DBhelper.BuCha(sql);
                //判断是否执行成功
                if (s)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            else
            {

            }
          
           

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //直接调用toolStrip1中的修改
            toolStripButton4_Click(sender,e);
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //直接调用toolStrip1中的添加
            toolStripButton2_Click(sender,e);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
