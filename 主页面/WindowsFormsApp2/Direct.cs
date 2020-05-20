//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using basic_information;
//namespace basic_information
//{
//    public partial class Direct : Form
//    {
//        public Direct()
//        {
//            InitializeComponent();
//        }

//        private void btsupply_Click(object sender, EventArgs e)
//        {
//            dircet_Manufacturer ds1 = new dircet_Manufacturer();//实例化对象
//           ds1.TopLevel = false;//将此控件设置为非顶级
//            this.panel1.Controls.Add(ds1);//添加ds1的控件
//            ds1.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
//            ds1.Show();//显示w4窗体
//            ds1.BringToFront();//将w4置于顶层
          
//        }

//        private void btcar_Click(object sender, EventArgs e)
//        {
//            dircet_car dc1 = new dircet_car();//实例化对象
//            dc1.TopLevel = false;//将此控件设置为非顶级
//            this.panel1.Controls.Add(dc1);//添加dc1的控件
//            dc1.FormBorderStyle = FormBorderStyle.None;//将边框设置为无
//            dc1.Show();//显示w4窗体
//            dc1.BringToFront();//将w4置于顶层
//        }

      
//    }
//}
