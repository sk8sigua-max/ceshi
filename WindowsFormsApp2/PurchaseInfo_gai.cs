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
    public partial class PurchaseInfo_gai : Form
    {
        int p;
        public PurchaseInfo_gai(int id)
        {
            InitializeComponent();
            this.p=id;
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            //获取text中的值
            string gai = txtgai.Text.ToString().Trim();


            //判断rbSID
            if (rbProductionID.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {
                    // 将text中的值进行数据类型转换


                    // 编写sql语句
                    string sql = string.Format("update PurchaseInfo set  ProductionID='{0}' where PurchaseNo=  '{1}'", gai, p);

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
            else if (rbInPrice.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {

                    // 编写sql语句
                    string sql = string.Format("update PurchaseInfo set InPrice='{0}' where PurchaseNo='{1}'", gai, p);

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
            else if (rbInNum.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {

                    // 编写sql语句);
                    string sql = string.Format("update PurchaseInfo set InNum='{0}' where PurchaseNo='{1}'", gai, p);

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
            else if (rbUserNo.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {

                    // 编写sql语句);
                    string sql = string.Format("update PurchaseInfo set  UserNo='{0}' where PurchaseNo='{1}'", gai, p);

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
            else if (rbCarNo.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {

                    // 编写sql语句);
                    string sql = string.Format("update PurchaseInfo set  CarNo='{0}' where PurchaseNo='{1}'", gai, p);

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
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
