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
            if (textBox7.Text == "销售员")
            {
                string SqlStr = string.Format("insert [Purchase]values('{0}','{1}','{2}','{3}','{4}','{5}')", textBox1.Text, textBox2.Text, 1, dateTimePicker1.Text, textBox4.Text, textBox7.Text, textBox5.Text);
                if (DBhelper.BuCha(SqlStr))
                {
                    MessageBox.Show("添加成功！");
                    SqlStr = "select CarNo,OutNum,Storename,SID,Prices,Storename,productionAddress,Indate,UserName from Stock;";
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
            }
            if (textBox7.Text == "后勤员")
            {
                string SqlStr = string.Format("insert [Stock]values('{0}','{1}','{2}','{3}','{4}','{5}')", textBox1.Text, textBox2.Text, 3, dateTimePicker1.Text, textBox4.Text, textBox7.Text, textBox5.Text);
                if (DBhelper.BuCha(SqlStr))
                {
                    MessageBox.Show("添加成功！");
                    SqlStr = "select CarNo,OutNum,Storename,SID,Prices,Storename,productionAddress,Indate,UserName from Stock";
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
            }
            if (textBox7.Text == "管理员")
            {
                string SqlStr = string.Format("insert [Stock]values('{0}','{1}','{2}','{3}','{4}','{5}')", textBox1.Text, textBox2.Text, 2, dateTimePicker1.Text, textBox4.Text, textBox7.Text, textBox5.Text);
                if (DBhelper.BuCha(SqlStr))
                {
                    MessageBox.Show("添加成功！");
                    SqlStr = "select CarNo,OutNum,Storename,SID,Prices,Storename,productionAddress,Indate,UserName from Stock";
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
            }
        }

        private void ChuKu_Load(object sender, EventArgs e)
        {
            string SqlStr = "select CarNo,OutNum,Storename,SID,Prices,Storename,productionAddress,Indate,UserName from Stock";
            this.dataGridView1.DataSource = DBhelper.Cha(SqlStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
