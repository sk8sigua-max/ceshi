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
            if (textBox1.Text == "" || textBox4.Text == "" || dateTimePicker1.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("你有必填项未填写，请填写完整！！");
            }
            else
            {
                string sqlstr = string.Format("insert [Stock] values('{0}','{1}','{2}','{3}','{4}','{5}')", textBox1.Text, textBox4.Text, dateTimePicker1.Text, textBox2.Text, textBox3.Text, comboBox1.Text);
                if (DBhelper.BuCha(sqlstr))
                {
                    string sql = string.Format("select CarNo,ProductionID,InNum,Storename,Pay,UserName,Indate from Stock");
                    this.dataGridView1.DataSource = DBhelper.Cha(sql);
                    MessageBox.Show("成功！");

                }
                else
                {
                    MessageBox.Show("失败！");
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
            string sqlstr = string.Format("select CarNo,ProductionID,InNum,Storename,Pay,UserName,Indate from Stock");
            this.dataGridView1.DataSource = DBhelper.Cha(sqlstr);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
