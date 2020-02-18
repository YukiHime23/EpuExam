using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Data
{
    public class DbQuiz
    {
        private string _idQuiz;

        public string idQuiz
        {
            get { return _idQuiz; }
            set { _idQuiz = value; }
        }

        private string _quiz;

        public string contentQuiz
        {
            get { return _quiz; }
            set { _quiz = value; }
        }

        private string _levelQuiz;

        public string levelQuiz
        {
            get { return _levelQuiz; }
            set { _levelQuiz = value; }
        }

        private string _dateCreate;

        public string dateCreate
        {
            get { return _dateCreate; }
            set { _dateCreate = value; }
        }

        private string _idThemeQuiz;

        public string idThemeQuiz
        {
            get { return _idThemeQuiz; }
            set { _idThemeQuiz = value; }
        }

        private string _idTeacher;

        public string idTeacher
        {
            get { return _idTeacher; }
            set { _idTeacher = value; }
        }

        private string _countUse;

        public string countUse
        {
            get { return _countUse; }
            set { _countUse = value; }
        }

        private string _ansA;

        public string ansA
        {
            get { return _ansA; }
            set { _ansA = value; }
        }

        private string _ansB;

        public string ansB
        {
            get { return _ansB; }
            set { _ansB = value; }
        }

        private string _ansC;

        public string ansC
        {
            get { return _ansC; }
            set { _ansC = value; }
        }

        private string _ansD;

        public string ansD
        {
            get { return _ansD; }
            set { _ansD = value; }
        }

        private string _ansCorrect;

        public string ansCorrect
        {
            get { return _ansCorrect; }
            set { _ansCorrect = value; }
        }

        public void SanPham_IDataReader(SqlDataReader dr)
        {
            _idQuiz = dr["mach"] is DBNull ? "" : dr["mach"].ToString();
            _quiz = dr["noidung"] is DBNull ? "" : dr["noidung"].ToString();
            _levelQuiz = dr["dokho"] is DBNull ? "" : dr["dokho"].ToString();
            _dateCreate = dr["ngaytao"] is DBNull ? "" : ((DateTime)dr["ngaytao"]).ToString("dd/MM/yyyy");
            _idThemeQuiz = dr["machude"] is DBNull ? "" : dr["machude"].ToString();
            _idTeacher = dr["magv"] is DBNull ? "" : dr["magv"].ToString();
            _countUse = dr["solanrade"] is DBNull ? "" : dr["solanrade"].ToString();
            _ansA = dr["a"] is DBNull ? "" : dr["a"].ToString();
            _ansB = dr["b"] is DBNull ? "" : dr["b"].ToString();
            _ansC = dr["c"] is DBNull ? "" : dr["c"].ToString();
            _ansD = dr["d"] is DBNull ? "" : dr["d"].ToString();
            _ansCorrect = dr["dapan"] is DBNull ? "" : dr["dapan"].ToString();
        }
    }
}