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

namespace Agoni
{
    public partial class ChuKu : Form
    {
        public ChuKu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox7.Text == "销售员")
            //{
            string id = this.txtOutID.Text.ToString().Trim();
            string num = this.txtOutNum.Text.ToString().Trim();
            string date = this.OutDateTime.Text.ToString();
            string address = this.txtOutAddress.Text.ToString().Trim();
            string brand = this.txtOutBrand.Text.ToString().Trim();
            string price = this.txtOutPrice.Text.ToString().Trim();
            //编写sql将此数据更新到year表以此来同步更新年度报表数据
            string sqlx = string.Format("insert into year values ('{0}','{1}','{2}')", brand, num ,id);
            //执行sql命令
            bool x = DBhelper.BuCha(sqlx);
            if (x)
            {
                MessageBox.Show("年度报表按钮数据已实时更新！");
            }
            else
            {
                MessageBox.Show("年度报表数据更新失败！请联系开发者人员进行维护");
            }


            string SqlStr = string.Format("insert into OutStock(OutNum,OutDate,OutAddress,OutBrand,OutPrice) values('{0}','{1}','{2}','{3}','{4}')", num, date, address, brand, price);
                if (DBhelper.BuCha(SqlStr))
                {
                    MessageBox.Show("添加成功！");
                    SqlStr = "select OutID,OutNum,OutDate,OutAddress,OutBrand,OutPrice from OutStock;";
                    this.dataGridView1.DataSource = DBhelper.Cha(SqlStr).Tables[0];
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
            //}
            //if (textBox7.Text == "后勤员")
            //{
            //    string SqlStr = string.Format("insert [Stock]values('{0}','{1}','{2}','{3}','{4}','{5}'，'{6}','{7}')", txtOutID.Text, textBox2.Text, 3, OutDateTime.Text, txtOutNum.Text, textBox7.Text, txtOutAddress.Text, txtOutBrand.Text, txtOutPrice.Text);
            //    if (DBhelper.BuCha(SqlStr))
            //    {
            //        MessageBox.Show("添加成功！");
            //        SqlStr = "select CarNo,OutNum,Storename,SID,Prices,productionAddress,Indate,UserName from Stock";
            //    }
            //    else
            //    {
            //        MessageBox.Show("添加失败!");
            //    }
            //}
            //if (textBox7.Text == "管理员")
            //{
            //    string SqlStr = string.Format("insert [Stock]values('{0}','{1}','{2}','{3}','{4}','{5}'，'{6}','{7}')", txtOutID.Text, textBox2.Text, 2, OutDateTime.Text, txtOutNum.Text, textBox7.Text, txtOutAddress.Text, txtOutBrand.Text, txtOutPrice.Text);
            //    if (DBhelper.BuCha(SqlStr))
            //    {
            //        MessageBox.Show("添加成功！");
            //        SqlStr = "select CarNo,OutNum,Storename,SID,Prices,productionAddress,Indate,UserName from Stock";
            //    }
            //    else
            //    {
            //        MessageBox.Show("添加失败!");
            //    }
            //}
        }

        private void ChuKu_Load(object sender, EventArgs e)
        {
            string SqlStr = "select OutID,OutNum,OutDate,OutAddress,OutBrand,OutPrice from OutStock;";
            this.dataGridView1.DataSource = DBhelper.Cha(SqlStr).Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.SelectedRows[0].Cells["OutID"].Value.ToString();

            string sql = "delete from OutStock where OutID=" + id;
            bool r = DBhelper.BuCha(sql);
            if (r)
            {
                MessageBox.Show("删除成功！");
                string Sql2 = "select OutID,OutNum,OutDate,OutAddress,OutBrand,OutPrice from OutStock;";
                this.dataGridView1.DataSource = DBhelper.Cha(Sql2).Tables[0];
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
