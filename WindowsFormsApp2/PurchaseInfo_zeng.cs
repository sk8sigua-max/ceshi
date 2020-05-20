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
    public partial class PurchaseInfo_zeng : Form
    {
        public PurchaseInfo_zeng()
        {
            InitializeComponent();
        }

        private void PurchaseInfo_zeng_Load(object sender, EventArgs e)
        {

        }

        private void btnyes_Click(object sender, EventArgs e)
        {

            //获取厂商编号
            string txtProductionID = this.txtProductionID.Text.ToString().Trim();
            //获取采购价格
            string txtInPrice = this.txtInPrice.Text.ToString().Trim();
            //获取 采购数量
            string txtInNum = this.txtInNum.Text.ToString().Trim();
            //获取采购员编号
            string txtUserNo = this.txtUserNo.Text.ToString().Trim();
            //获取汽车编号
            string txtCarNo = this.txtCarNo.Text.ToString().Trim();

                //判断以上8个内容中的值是否为空
            if (txtProductionID!= "" && txtInPrice != "" && txtInNum!= "" && txtUserNo!= "" && txtCarNo!= "")
            {
                //编写sql插入语句
                string sql = string.Format("insert into PurchaseInfo values ('{0}','{1}','{2}','{3}','{4}','1')", txtProductionID, txtInPrice, txtInNum, txtUserNo, txtCarNo);
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

