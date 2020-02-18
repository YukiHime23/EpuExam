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
    public class Quiz: DBConnect
    {
        public ArrayList Quiz_GetAll()
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("select * from cauHoi", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DbQuiz obj = new DbQuiz();
                        obj.SanPham_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }

        public ArrayList getQuizByTheme( string id)
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("select * from cauHoi where machude = '" + id+ " and cauHoi.machude = chuDe.machude '", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DbQuiz obj = new DbQuiz();
                        obj.SanPham_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }

        public ArrayList getQuizById(string id)
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("select * from cauHoi where mach = '" + id + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DbQuiz obj = new DbQuiz();
                        obj.SanPham_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }

        public bool delQuiz(string idQuiz)
        {
            using (SqlConnection conn = getConnect())
            {
                String query = String.Format("delQuiz", idQuiz);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idQuiz", SqlDbType.VarChar, 10).Value = idQuiz;
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool addQuiz(string nd,string dk, string ngt, string macd, string magv, string a, string b, string c, string d, string dapan)
        {
            using (SqlConnection conn = getConnect())
            {
                String query = String.Format("addQuiz", nd,dk,ngt,macd,magv,a,b,c,d,dapan);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nd", SqlDbType.NVarChar, 1000).Value = nd;
                cmd.Parameters.Add("@level", SqlDbType.NVarChar, 10).Value = dk;
                cmd.Parameters.Add("@dateCre", SqlDbType.Date).Value = ngt;
                cmd.Parameters.Add("@idThem", SqlDbType.Int).Value = macd;
                cmd.Parameters.Add("@idTeach", SqlDbType.VarChar, 20).Value = magv;
                cmd.Parameters.Add("@a", SqlDbType.VarChar, 100).Value = a;
                cmd.Parameters.Add("@b", SqlDbType.VarChar, 100).Value = b;
                cmd.Parameters.Add("@c", SqlDbType.VarChar, 100).Value = c;
                cmd.Parameters.Add("@d", SqlDbType.VarChar, 100).Value = d;
                cmd.Parameters.Add("@dapan", SqlDbType.VarChar, 100).Value = dapan;
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}