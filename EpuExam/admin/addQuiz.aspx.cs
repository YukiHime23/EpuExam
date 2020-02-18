using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using Data;

namespace EpuExam.admin
{
    public partial class addQuiz : System.Web.UI.Page
    {
    	
        static busSubject subj = new busSubject();
        static busQuiz qui = new busQuiz();
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
            PlaceHolder1.Controls.Add(new Literal { Text = option.ToString() });
        }

        [WebMethod]
        public static ArrayList getSubjById(string id)
        {
            ArrayList list = new ArrayList();
            list = subj.Subject_GetById(id);
            return list;
        }

        [WebMethod]
        public static ArrayList getThemeById(string id)
        {
            ArrayList list = new ArrayList();
            list = subj.Theme_GetById(id);
            return list;
        }

        [WebMethod]
        public static bool addItem(string nd, string dk, string ngt, string macd, string magv, string a, string b, string c, string d, string dapan)
        {
            return qui.addQuiz(nd,dk,ngt,macd,magv,a,b,c,d,dapan);
        }
    }
    
}