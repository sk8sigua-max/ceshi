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
    public partial class year4 : Form
    {
        public year4()
        {
            InitializeComponent();
        }

        private void year4_Load(object sender, EventArgs e)
        {
            //编写sql语句
            string sql = "select * from year";
            //纵向柱状统计图模式
            // 将数据库的year表绑定到“chart1-横向柱状统计表” 中
            chart4.DataSource = DBhelper.Cha(sql).Tables[0];
        }
    }
}
