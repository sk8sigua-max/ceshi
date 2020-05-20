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
    public partial class car_gai : Form
    {
        int p;
        public car_gai(int id)
        {
            InitializeComponent();
            this.p = id;
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            //获取text中的值
            string gai = txtgai.Text.ToString().Trim();

            //判断rbSID
            if (rbCarBrand.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {
                    // 将text中的值进行数据类型转换

                    // 编写sql语句
                    string sql = string.Format("update CarInfo set  CarBrand='{0}' where CarNo='{1}'", gai, p);

                    // 执行sql命令
                    bool x = DBhelper.BuCha(sql);

                    //判断是否执行成功
                    if (x)
                    {
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！！！");
                    }
                }
                else
                {
                    MessageBox.Show("您输入的内容不能为空");
                }

            }

            //判断rbTrademark
            else if (rbCarInPrice.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {

                    // 编写sql语句
                    string sql = string.Format("update CarInfo set CarInPrice='{0}' where CarNo='{1}'", gai, p);

                    // 执行sql命令
                    bool x = DBhelper.BuCha(sql);

                    //判断是否执行成功
                    if (x)
                    {
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！！！");
                    }
                }
                else
                {
                    MessageBox.Show("您输入的内容不能为空");
                }

            }
            //判断rbREM
            else if (rbCarOutPrice.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {;

                    // 编写sql语句);
                    string sql = string.Format("update CarInfo set  CarOutPrice='{0}' where CarNo='{1}'", gai, p);

                    // 执行sql命令
                    bool x = DBhelper.BuCha(sql);

                    //判断是否执行成功
                    if (x)
                    {
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！！！");
                    }
                }
                else
                {
                    MessageBox.Show("您输入的内容不能为空");
                }
            }
            //判断rbMoney
            else if (rbCarStock.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {

                    // 编写sql语句
                    string sql = string.Format("update CarInfo set CarStock='{0}' where CarNo='{1}'", gai, p);

                    // 执行sql命令
                    bool x = DBhelper.BuCha(sql);

                    //判断是否执行成功
                    if (x)
                    {
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！！！");

                    }
                }
                else
                {
                    MessageBox.Show("您输入的内容不能为空");
                }
            }
            //判断rbDisplacement
            else if (rbCarDisplacement.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {

                    // 编写sql语句
                    string sql = string.Format("update CarInfo set CarDisplacement='{0}' where CarNo='{1}'", gai, p);

                    // 执行sql命令
                    bool x = DBhelper.BuCha(sql);

                    //判断是否执行成功
                    if (x)
                    {
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！！！");
                    }
                }
                else
                {
                    MessageBox.Show("您输入的内容不能为空");
                }
            }
            //判断rbDisplacement
            else if (rbCarSort.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {
                   
                    // 编写sql语句
                    string sql = string.Format("update CarInfo set CarSort='{0}' where CarNo='{1}'", gai, p);

                    // 执行sql命令
                    bool x = DBhelper.BuCha(sql);

                    //判断是否执行成功
                    if (x)
                    {
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！！！");
                    }
                }
                else
                {
                    MessageBox.Show("您输入的内容不能为空");
                }
            }
            //判断是否选择  rbGenre
            else if (rbProductionID.Checked)
            {
                // 判断两个txt中的值是否为空
                if (gai != "")
                {
                    // 将text中的值进行数据类型转换
                    int gui = int.Parse(txtgai.Text.ToString().Trim());

                    // 编写sql语句
                    string sql = string.Format("update CarInfo set   ProductionID='{0}' where CarNo='{1}'", gui, p);

                    // 执行sql命令
                    bool x = DBhelper.BuCha(sql);

                    //判断是否执行成功
                    if (x)
                    {
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！！！");
                    }
                }
                else
                {
                    MessageBox.Show("您输入的内容不能为空");
                }
            }
            else
            {

                MessageBox.Show("请先选择您要修改的内容！");

            }
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void car_gai_Load(object sender, EventArgs e)
        {

        }
    }
}
