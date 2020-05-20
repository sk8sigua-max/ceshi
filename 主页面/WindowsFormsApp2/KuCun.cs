using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string sql = "select SID,CarNo,Storename,Stocknum from Stock";
            this.dataGridView1.DataSource = DBhelper.Cha(sql);

            //this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
            //Sunisoft.IrisSkin.SkinEngine se = null;
            //se = new Sunisoft.IrisSkin.SkinEngine();
            //se.SkinAllForm = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
