using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    class DBhelper
    {
        //创建连接数据库对象
       // public static string s = "server=127.0.0.1;database=CarManagementSystem;uid=sa;pwd=123456;";
        public static string s = "Data Source=.;Initial Catalog=CarManagementSystem;Integrated Security=True";
        public static bool BuCha(string sql)
        {
            //数据库连接对象
            SqlConnection conn = new SqlConnection(s);
            //打开数据连接
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int r=cmd.ExecuteNonQuery();
            //关闭数据库连接
            conn.Close();
            return r > 0;
        }
        // 断开式连接查询数据
        public static DataSet Cha(string sql)
        {
            //创建数据集对象
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(s);
            conn.Open();
            //数据适配器对象
            SqlDataAdapter sa = new SqlDataAdapter(sql, conn);
            //填充数据
            sa.Fill(ds);
            conn.Close();
            sa.Dispose();
            return ds;

        }
        //查询聚合函数
        public static Object GetExecuteScalar(string sql)
        {
            SqlConnection conn = new SqlConnection(s);
            //打开数据连接
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object result =  cmd.ExecuteScalar();
            return result;
        }
    }
}
