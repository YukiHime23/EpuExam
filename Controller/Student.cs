using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Controller
{
    public class Student: DBConnect
    {
        public ArrayList Student_GetAll()
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("select * from sinhVien", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Data.DbQuiz obj = new Data.DbQuiz();
                        obj.SanPham_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }

        public bool delStudent(string idQuiz)
        {
            using (SqlConnection conn = getConnect())
            {
                String query = String.Format("delStudent", idQuiz);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idQuiz", SqlDbType.VarChar, 10).Value = idQuiz;
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}