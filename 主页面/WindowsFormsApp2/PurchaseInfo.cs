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
    public partial class PurchaseInfo : Form
    {
        public PurchaseInfo()
        {
            InitializeComponent();
        }

      

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PurchaseInfo_Load(object sender, EventArgs e)
        {
            //编写sql语句
            string sql = "select PurchaseNo,ProductionID,InPrice,InNum,UserNo,CarNo,Cancel from PurchaseInfo where Cancel=1";
            //导入 dvManufacturer
            dvManufacturer.DataSource = DBhelper.Cha(sql).Tables[0];

        }

        private void btsupply_Click(object sender, EventArgs e)
        {
            //获取txtsupply中的内容
             string x=this.txtsupply.Text.ToString().Trim();
             //编写sql语句
             string sql =string .Format( "select PurchaseNo,ProductionID,InPrice,InNum,UserNo,CarNo,Cancel from PurchaseInfo where CarNo like '%{0}%'",x);
             //导入 dvManufacturer
             dvManufacturer.DataSource = DBhelper.Cha(sql).Tables[0];
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PurchaseInfo_zeng z = new PurchaseInfo_zeng();
            z.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            z.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取ID
            int i = int.Parse(this.dvManufacturer.SelectedRows[0].Cells["PurchaseNo"].Value.ToString());
            
            //询问·是否删除
            DialogResult x = MessageBox.Show("您确定要删除吗？", "提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // 判断点击的按钮
            if (x == DialogResult.Yes)
            {
                //编写sql语句
                string sql = string.Format("update PurchaseInfo set  Cancel='0' where PurchaseNo= '{0}'", i);
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
            //获取dvManufacturer中的ID值
            int id=int.Parse(this.dvManufacturer.SelectedRows[0].Cells["PurchaseNo"].Value.ToString());
         //   实例化对象
            PurchaseInfo_gai g = new PurchaseInfo_gai(id);
            g.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            //弹出窗体
            g.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //直接调用修改事件
            修改ToolStripMenuItem_Click(sender, e);
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton2_Click( sender,e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            PurchaseInfo_Load(sender, e);
        }
    }
}
