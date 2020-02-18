using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using Data;

namespace EpuExam.admin
{
    public partial class CreExam : System.Web.UI.Page
    {
        static busSubject subj = new busSubject();
        static busExam ex = new busExam();

        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder option = new StringBuilder();
            ArrayList list = new ArrayList();
            list = subj.Group_GetAll();

            foreach (DbSubject item in list)
            {
                option.Append("<option value=\"" + item.idGroup + "\" >" + item.nameGroup);
                option.Append("</option>");
            }
            PlaceHolder2.Controls.Add(new Literal { Text = option.ToString() });
            
            StringBuilder option2 = new StringBuilder();
            ArrayList kythi = new ArrayList();
            kythi = ex.StageExam_GetAll();

            foreach (DbExam item in kythi)
            {
                option2.Append("<option value=\"" + item.idStageExam + "\" >" + item.nameStageExam);
                option2.Append("</option>");
            }
            PlaceHolder1.Controls.Add(new Literal { Text = option2.ToString() });
        }

        [WebMethod]
        public static ArrayList getSubjById(string id)
        {
            ArrayList list = new ArrayList();
            list = subj.Subject_GetById(id);
            return list;
        }

        [WebMethod]
        public static ArrayList getStageById(string id)
        {
            ArrayList list = new ArrayList();
            list = ex.getStageById(id);
            return list;
        }
        [WebMethod]
        public static bool addItem(string mkt, string mamon, string socau, string easy, string medium, string hard)
        {
            return ex.addExam(mkt, mamon, socau,easy,medium,hard);
        }
    }
}