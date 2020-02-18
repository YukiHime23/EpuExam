using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Data
{
    public class DbExam
    {
        private string _idExam;

        public string idExam
        {
            get { return _idExam; }
            set { _idExam = value; }
        }

        private string _idStageExam; 

        public string idStageExam
        {
            get { return _idStageExam; }
            set { _idStageExam = value; }
        }

        private string _idSubject;

        public string idSubject
        {
            get { return _idSubject; }
            set { _idSubject = value; }
        }

        private string _numQuiz;

        public string numQuiz
        {
            get { return _numQuiz; }
            set { _numQuiz = value; }
        }

        private string _nameStageExam;

        public string nameStageExam
        {
            get { return _nameStageExam; }
            set { _nameStageExam = value; }
        }

        private string _timeDoExam;

        public string timeDoExam
        {
            get { return _timeDoExam; }
            set { _timeDoExam = value; }
        }

        private string _rankExam;

        public string rankExam
        {
            get { return _rankExam; }
            set { _rankExam = value; }
        }

        private string _trainingSys;

        public string trainingSys
        {
            get { return _trainingSys; }
            set { _trainingSys = value; }
        }

        private string _idQuiz;

        public string idQuiz
        {
            get { return _idQuiz; }
            set { _idQuiz = value; }
        }

        private string _nameSubject;

        public string nameSubject
        {
            get { return _nameSubject; }
            set { _nameSubject = value; }
        }

        private string _dateCreate;

        public string dateCreate
        {
            get { return _dateCreate; }
            set { _dateCreate = value; }
        }


        public void stageExamAll_IDataReader(SqlDataReader dr)
        {
            _idStageExam = dr["makythi"] is DBNull ? "" : dr["makythi"].ToString();
            _nameStageExam = dr["tenkythi"] is DBNull ? "" : dr["tenkythi"].ToString();
            _timeDoExam = dr["thoigianlam"] is DBNull ? "" : dr["thoigianlam"].ToString();
            _rankExam = dr["trinhdo"] is DBNull ? "" : dr["trinhdo"].ToString();
            _trainingSys = dr["hedaotao"] is DBNull ? "" : dr["hedaotao"].ToString();
        }

        public void ExamAll_IDataReader(SqlDataReader dr)
        {
            _idExam = dr["madethi"] is DBNull ? "" : dr["madethi"].ToString();
            _idStageExam = dr["makythi"] is DBNull ? "" : dr["makythi"].ToString();
            _nameStageExam = dr["tenkythi"] is DBNull ? "" : dr["tenkythi"].ToString();
            _timeDoExam = dr["thoigianlam"] is DBNull ? "" : dr["thoigianlam"].ToString();
            _rankExam = dr["trinhdo"] is DBNull ? "" : dr["trinhdo"].ToString();
            _trainingSys = dr["hedaotao"] is DBNull ? "" : dr["hedaotao"].ToString();
            _nameSubject = dr["tenmon"] is DBNull ? "" : dr["tenmon"].ToString();
            _numQuiz = dr["socau"] is DBNull ? "" : dr["socau"].ToString();
            _dateCreate = dr["ngaytao"] is DBNull ? "" : ((DateTime)dr["ngaytao"]).ToString("dd/MM/yyyy");
        }

        public void detailExam_IDataReader(SqlDataReader dr)
        {
            _idExam = dr["madethi"] is DBNull ? "" : dr["madethi"].ToString();
            _idQuiz = dr["mach"] is DBNull ? "" : dr["mach"].ToString();
        }
    }
}


