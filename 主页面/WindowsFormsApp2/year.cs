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
    public partial class year : Form
    {
        public year()
        {
            InitializeComponent();
        }

        private void year_Load(object sender, EventArgs e)
        {

            //纵向柱状统计图
            //编写sql语句
            string sql = "select * from year";
            // 将数据库的year表绑定到“chart1-横向柱状统计表” 中
            chart1.DataSource = DBhelper.Cha(sql).Tables[0];

            //横向柱状统计图
            // 将数据库的year表绑定到“chart1-横向柱状统计表” 中
            chart2.DataSource = DBhelper.Cha(sql).Tables[0];

            //圆盘统计图
            // 将数据库的year表绑定到“chart1-横向柱状统计表” 中
            chart3.DataSource = DBhelper.Cha(sql).Tables[0];

            //雷达图模式
            // 将数据库的year表绑定到“chart1-横向柱状统计表” 中
            chart4.DataSource = DBhelper.Cha(sql).Tables[0];
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

       

    

      
    }
}
