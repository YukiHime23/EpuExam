using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Data
{
    public class DbSubject
    {
        private string _idSubject;

        public string idSubject
        {
            get { return _idSubject; }
            set { _idSubject = value; }
        }

        private string _idGroup;

        public string idGroup
        {
            get { return _idGroup; }
            set { _idGroup = value; }
        }

        private string _nameSubject;

        public string nameSubject
        {
            get { return _nameSubject; }
            set { _nameSubject = value; }
        }

        private string _nameGroup;

        public string nameGroup
        {
            get { return _nameGroup; }
            set { _nameGroup = value; }
        }

        private string _idTheme;

        public string idTheme
        {
            get { return _idTheme; }
            set { _idTheme = value; }
        }

        private string _nameTheme;

        public string nameTheme
        {
            get { return _nameTheme; }
            set { _nameTheme = value; }
        }

        public void Group_IDataReader(SqlDataReader dr)
        {
            _idGroup = dr["makhoa"] is DBNull ? "" : dr["makhoa"].ToString();
            _nameGroup = dr["tenkhoa"] is DBNull ? "" : dr["tenkhoa"].ToString();
        }

        public void Subject_IDataReader(SqlDataReader dr)
        {
            _idSubject = dr["mamon"] is DBNull ? "" : dr["mamon"].ToString();
            _idGroup = dr["makhoa"] is DBNull ? "" : dr["makhoa"].ToString();
            _nameGroup = dr["tenkhoa"] is DBNull ? "" : dr["tenkhoa"].ToString();
            _nameSubject = dr["tenmon"] is DBNull ? "" : dr["tenmon"].ToString();
        }

        public void Theme_IDataReader(SqlDataReader dr)
        {
            _idTheme = dr["machude"] is DBNull ? "" : dr["machude"].ToString();
            _nameSubject = dr["tenmon"] is DBNull ? "" : dr["tenmon"].ToString();
            _nameTheme = dr["tenchude"] is DBNull ? "" : dr["tenchude"].ToString();
        }
    }
}