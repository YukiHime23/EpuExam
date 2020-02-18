using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Data
{
    public class DbAccount
    {
        private string _username;

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public void Log_IDataReader(SqlDataReader dr)
        {
            _username = dr["ma"] is DBNull ? "" : dr["ma"].ToString();
            _password = dr["matkhau"] is DBNull ? "" : dr["matkhau"].ToString();
            _email = dr["email"] is DBNull ? "" : dr["email"].ToString();
        }
    }
}