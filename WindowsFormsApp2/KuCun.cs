using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Agoni
{
    public partial class KuCun : Form
    {
        public KuCun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KuCun_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select KuCID,KuCBrand,KuCName,KuCNum from Stock");        
            this.dataGridView1.DataSource = DBhelper.Cha(sql).Tables[0];
          
            //this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
            //Sunisoft.IrisSkin.SkinEngine se = null;
            //se = new Sunisoft.IrisSkin.SkinEngine();
            //se.SkinAllForm = true;

        }


        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.SelectedRows[0].Cells["KuCID"].Value.ToString();
            string sql = "delete from Stock where KuCID=" + id;
            bool r = DBhelper.BuCha(sql);
            if (r)
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
    }
}
