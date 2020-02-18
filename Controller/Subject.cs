using Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Controller
{
    public class Subject: DBConnect
    {
        public ArrayList Theme_GetById(string id)
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("select * from monHoc, chuDe where monHoc.mamon = chuDe.mamon and chuDe.mamon = "+id, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DbSubject obj = new DbSubject();
                        obj.Theme_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }
        public ArrayList Subject_GetById(string id)
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("select * from monHoc,khoa where monHoc.makhoa=khoa.makhoa and monHoc.makhoa ='"+id+"'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DbSubject obj = new DbSubject();
                        obj.Subject_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }

        public ArrayList Group_GetAll()
        {
            ArrayList lst = new ArrayList();

            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("select * from khoa", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DbSubject obj = new DbSubject();
                        obj.Group_IDataReader(dr);
                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }
    }
}