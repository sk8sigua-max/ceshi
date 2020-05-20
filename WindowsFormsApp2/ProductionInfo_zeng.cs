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
    public partial class ProductionInfo_zeng : Form
    {
        public ProductionInfo_zeng()
        {
            InitializeComponent();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {


            //获取品牌颜色
            string txtProductionBrand = this.txtProductionBrand.Text.ToString().Trim();
            //获取厂家电话
            string txtproductionPhone = this.txtproductionPhone.Text.ToString().Trim();
            //获取厂家地址
            string txtproductionAddress = this.txtproductionAddress.Text.ToString().Trim();
               //判断以上8个内容中的值是否为空
            if ( txtProductionBrand != "" && txtproductionPhone != "" && txtproductionAddress != "")
            {
                //编写sql插入语句
                string sql = string.Format("insert into ProductionInfo values ('{0}','{1}','{2}','1')",  txtProductionBrand, txtproductionPhone, txtproductionAddress);

                //执行SQL语句
                bool x =DBhelper.BuCha(sql);

                //判断是否执行成功
                if (x)
                {
                    MessageBox.Show("数据添加成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("数据添加失败！");
                }
            }
            else
            {
                MessageBox.Show("您输入的内容不能为空！");
            }

        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}
