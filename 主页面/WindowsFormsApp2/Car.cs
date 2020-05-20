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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void Car_Load(object sender, EventArgs e)
        {
            string slq = string.Format("select * from CarInfo where Cancel= 1");
            dvcar.DataSource = DBhelper.Cha(slq).Tables[0];
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //直接调用toolStrip1的添加事件
            toolStripButton2_Click(sender,e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string a = this.txtcar.Text.ToString();
            string slq = string.Format("select * from CarInfo where Cancel= 1 and CarBrand='{0}' ",a);
        }

        private void btcar_Click(object sender, EventArgs e)
        {
            string cha = txtcar.Text.ToString().Trim();
            string slq = string.Format("select * from CarInfo where Cancel= 1 and CarBrand like '%{0}%'",cha);
            dvcar.DataSource = DBhelper.Cha(slq).Tables[0];

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int id=int.Parse(this.dvcar.SelectedRows[0].Cells["CarNo"].Value.ToString());
            car_gai cg = new car_gai(id);
            cg.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            cg.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Car_Load(sender, e);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Car_zeng z = new Car_zeng();
            z.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
            z.ShowDialog();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取ID
            int i = int.Parse(this.dvcar.SelectedRows[0].Cells["CarNo"].Value.ToString());
            //询问·是否删除
            DialogResult x = MessageBox.Show("您确定要删除吗？", "提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // 判断点击的按钮
            if (x == DialogResult.Yes)
            {
                //编写sql语句
                string sql = string.Format("update CarInfo set  Cancel='0' where ProductionID=  '{1}'", i);
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
            toolStripButton4_Click(sender, e);
           
        }
    }
}
