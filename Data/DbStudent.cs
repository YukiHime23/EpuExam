using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Data
{
    public class DbStudent
    {
        private string _idStudent;

        public string idStudent
        {
            get { return _idStudent; }
            set { _idStudent = value; }
        }

        private string _nameStudent;

        public string nameStudent
        {
            get { return _nameStudent; }
            set { _nameStudent = value; }
        }

        private string _passStudent;

        public string passStudent
        {
            get { return _passStudent; }
            set { _passStudent = value; }
        }

        private string _emailStudent;

        public string emailStudent
        {
            get { return _emailStudent; }
            set { _emailStudent = value; }
        }

        private string _classStudent;

        public string classStudent
        {
            get { return _classStudent; }
            set { _classStudent = value; }
        }

        private string _birthStudent;

        public string birthStudent
        {
            get { return _birthStudent; }
            set { _birthStudent = value; }
        }

        public void SanPham_IDataReader(SqlDataReader dr)
        {
            _idStudent = dr["ma"] is DBNull ? "" : dr["ma"].ToString();
            _nameStudent = dr["tensv"] is DBNull ? "" : dr["tensv"].ToString();
            _passStudent = dr["matkhau"] is DBNull ? "" : dr["matkhau"].ToString();
            _birthStudent = dr["ngaysinh"] is DBNull ? "" : ((DateTime)dr["ngaysinh"]).ToString("dd/MM/yyyy");
            _emailStudent = dr["email"] is DBNull ? "" : dr["email"].ToString();
            _classStudent = dr["lop"] is DBNull ? "" : dr["lop"].ToString();
        }
    }
}