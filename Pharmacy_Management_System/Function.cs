using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    internal class Function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-FPETS92\\SQLEXPRESS; database=pharmacy; integrated security=True";
            return con;
        }
        public DataSet getData( string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }

        public void setData(string query, String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText= query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg,"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
