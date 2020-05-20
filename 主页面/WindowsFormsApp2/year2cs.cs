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
    public partial class year2cs : Form
    {
        public year2cs()
        {
            InitializeComponent();
        }

        private void year2cs_Load(object sender, EventArgs e)
        {
            //编写sql语句
            string sql = "select * from year";
            //横向圆盘统计图
            // 将数据库的year表绑定到“chart1-横向柱状统计表” 中
            chart2.DataSource = DBhelper.Cha(sql).Tables[0];
        }
    }
}
