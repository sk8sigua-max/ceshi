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
    public partial class Car_zeng : Form
    {
        public Car_zeng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              //获取textbox中的内容

      

            //2获取汽车品牌中的值
            string txtCarBrand = this.txtCarBrand.Text.ToString().Trim();

            //3获取进货价中的值
            string txtCarInPrice = this.txtCarInPrice.Text.ToString().Trim();

            //4获取买出价格中的值
            string txtCarOutPrice = this.txtCarOutPrice.Text.ToString().Trim();

            //5获取库存数量中的值
            string txtCarStock = this.txtCarStock.Text.ToString().Trim();

            //6获取汽车排量中的值
            string txtCarDisplacement = this.txtCarDisplacement.Text.ToString().Trim();
            //7汽车种类
              string txtCarSort = this.txtCarSort.Text.ToString().Trim();
            //8生产商
           string txtProductionID = this.txtProductionID.Text.ToString().Trim();

            //判断以上8个内容中的值是否为空
            if ( txtCarBrand != "" && txtCarInPrice != "" && txtCarOutPrice  != "" && txtCarStock != ""&& txtCarDisplacement != ""&& txtCarSort  != ""&& txtProductionID != "")
            {
                //编写sql插入语句
                string sql = string.Format("insert into CarInfo values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','1')",  txtCarBrand, txtCarInPrice, txtCarOutPrice, txtCarStock,txtCarDisplacement,txtCarSort,txtProductionID);

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Car_zeng_Load(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

