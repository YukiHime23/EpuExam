using Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Controller
{
    public class Account: DBConnect
    {
        public int checkLoginSv(string user, string pass)
        {
            using (SqlConnection con = getConnect())
            {
                string query = string.Format("checkLoginSv", user, pass);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = user;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = pass;
                int ketqua = (int)cmd.ExecuteScalar();
                return ketqua;
            }
        }
        public int checkLoginGv(string user, string pass)
        {
            using (SqlConnection con = getConnect())
            {
                string query = string.Format("checkLoginGv", user, pass);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = user;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = pass;
                int ketqua = (int)cmd.ExecuteScalar();
                return ketqua;
            }
        }
    }
}