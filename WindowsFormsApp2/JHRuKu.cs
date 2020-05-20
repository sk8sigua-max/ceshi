using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Agoni
{
    public partial class JHRuKu : Form
    {
        public JHRuKu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.txtboxID.Text.ToString().Trim();
            string num = this.txtboxNum.Text.ToString().Trim();
            string datetime = this.InDateTime.Text.ToString();
            string address = this.txtboxInAddress.Text.ToString().Trim();
            string brand = this.txtboxInBrand.Text.ToString().Trim();
            string price = this.txtboxInPrice.Text.ToString().Trim();            
            if (txtboxID.Text == "" || txtboxNum.Text == "" || InDateTime.Text == "" || txtboxInAddress.Text == "" || txtboxInBrand.Text == "" || txtboxInPrice.Text == "")
            {
                MessageBox.Show("你有必填项未填写，请填写完整！！");
            }
            else
            {
                string sql = string.Format("insert into InStock(InNum,InDate,InAddress,InBrand,InPrice) values('{0}','{1}','{2}','{3}','{4}')",num, datetime, address, brand, price);
                if (DBhelper.BuCha(sql))
                {
                    string sql1 = string.Format("select InID,InNum,InDate,InAddress,InBrand,InPrice from InStock");
                    this.dataGridView1.DataSource = DBhelper.Cha(sql1).Tables[0];
                    MessageBox.Show("添加成功！");
                    string sql2 = string.Format("update Stock set Stocknum= where Storename='天子仓'");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void JHRuKu_Load(object sender, EventArgs e)
        {
            string sqlstr = string.Format("select InID,InNum,InDate,InAddress,InBrand,InPrice from InStock");
            this.dataGridView1.DataSource = DBhelper.Cha(sqlstr).Tables[0];
            //JHRuKu_Load(sender, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.SelectedRows[0].Cells["InID"].Value.ToString();

            string sql = "delete from InStock where InID=" + id;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtboxInAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
