using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Controller
{
    public class DBConnect
    {
        string connection = @"Data Source=DESKTOP-VPA25TJ;Initial Catalog=thiTracNghiem;Integrated Security=True";
        SqlConnection con;
        public DBConnect()
        {
            con = new SqlConnection(connection);
        }
        public SqlConnection getConnect()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con = new SqlConnection(connection);
                con.Open();
            }
            return con;
        }
    }
}