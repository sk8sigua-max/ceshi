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
    public partial class ProductionInfo_gai : Form
    {
        int p;
        public ProductionInfo_gai(int id)
        {
            InitializeComponent();
            this.p = id;
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            //获取text中的值
            string gai = txtgai.Text.ToString().Trim();

            //判断rbSID
            if (rbProductionBrand.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {
                    // 将text中的值进行数据类型转换
                    

                    // 编写sql语句
                    string sql = string.Format("update ProductionInfo set  ProductionBrand='{0}' where ProductionID=  '{1}'", gai, p);

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
            else if (rbproductionPhone.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {

                    // 编写sql语句
                    string sql = string.Format("update ProductionInfo set productionPhone='{0}' where ProductionID='{1}'", gai, p);

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
            else if (rbproductionAddress.Checked)
            {
                // 判断两个tetxt中的值是否为空
                if (gai != "")
                {

                    // 编写sql语句);
                    string sql = string.Format("update ProductionInfo set  productionAddress='{0}' where ProductionID='{1}'", gai, p);

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
