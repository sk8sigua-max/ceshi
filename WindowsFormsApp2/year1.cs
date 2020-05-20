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
    public partial class year1 : Form
    {
        public year1()
        {
            InitializeComponent();
        }

        private void year1_Load(object sender, EventArgs e)
        {
            string sql = "select * from year";
            // 将数据库的year表绑定到“chart1-横向柱状统计表” 中
            chart1.DataSource = DBhelper.Cha(sql).Tables[0];
        }

      
    }
}
