using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 轻松记账
{
    class accessDB
    {
        static string connstr = @"Data Source=LAPTOP-8Q2UO77P\TEW_SQLEXPRESS;Initial Catalog=wallet;Integrated Security=True";
        public static Boolean Sql_cmd(string cmdStr)
        {//执行插入 删除
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(connstr);
                SqlCommand cm = new SqlCommand(cmdStr, con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("操作成功");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.  \n" + e.Message);
                return false;
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }




        }

        public static DataTable Sql_Inquire(string cmdStr)
        {//执行查询 返回一个datatable数据表
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connstr);
                //打开数据库连接
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmdStr, conn);
                DataTable dt = new DataTable();
                //使用 SqlDataAdapter 对象 sda 将查询结果填充到 DataSet 对象 dt 中
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败！" + ex.Message);
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    //关闭数据库连接
                    conn.Close();
                }
            }
        }











    }

}
