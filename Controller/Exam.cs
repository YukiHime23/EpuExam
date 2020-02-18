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
    public class Exam: DBConnect
    {
    	public ArrayList StageExam_GetAll()
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                //SqlCommand cmd = new SqlCommand("select * " +
                //    "from dethi, kyThi, monHoc " +
                //    "where dethi.makythi = kyThi.makythi " +
                //    "and dethi.mamon = monHoc.mamon", conn);
                SqlCommand cmd = new SqlCommand("select * from kyThi", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DbExam obj = new DbExam();
                        obj.stageExamAll_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }

        public ArrayList Exam_GetAll()
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("select * " +
                    "from dethi, kyThi, monHoc " +
                    "where dethi.makythi = kyThi.makythi " +
                    "and dethi.mamon = monHoc.mamon", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DbExam obj = new DbExam();
                        obj.ExamAll_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }

        public ArrayList getStageById(string id)
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("select * from kyThi where makythi = '" + id + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DbExam obj = new DbExam();
                        obj.stageExamAll_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public ArrayList getExamDetailById(string id)
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("select * from ctdethi where madethi= '" + id + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DbExam obj = new DbExam();
                        obj.detailExam_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public bool addExam(string mkt, string mamon, string socau)
        {
            using (SqlConnection conn = getConnect())
            {
                String query = String.Format("addExam", mkt, mamon, socau);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mkt", SqlDbType.Int).Value = mkt;
                cmd.Parameters.Add("@mamon", SqlDbType.VarChar, 15).Value = mamon;
                cmd.Parameters.Add("@socau", SqlDbType.Int).Value = socau;
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool addExamDetai(string socau, string easy, string medium, string hard)
        {
            using (SqlConnection conn = getConnect())
            {

                String query = "insert into ctdethi(mach,madethi) " +
                    "select top "+ socau + " mach,(SELECT TOP 1 madethi FROM dethi ORDER BY madethi DESC) " +
                    "from cauHoi " +
                    "where mach in (select top "+easy+" mach from cauHoi where dokho = 'easy' order by newid()) " +
                    "or mach in (select top "+medium+" mach from cauHoi where dokho = 'medium' order by newid()) " +
                    "or mach in (select top "+hard+" mach from cauHoi where dokho = 'hard' order by newid())";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}