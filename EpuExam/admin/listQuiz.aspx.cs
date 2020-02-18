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
    public partial class listQuiz : System.Web.UI.Page
    {
    	StringBuilder table = new StringBuilder();
    	static busQuiz lquiz = new busQuiz();
        static busSubject subj = new busSubject();
        protected void Page_Load(object sender, EventArgs e)
        {
			ArrayList list = new ArrayList();
            list = lquiz.Quiz_GetAll();
            foreach (DbQuiz item in list)
            {
                table.Append("<tr>");
                table.Append("<td>" + item.idQuiz + "</td>");
                table.Append("<td>" + item.contentQuiz + "</td>");
                table.Append("<td>" + item.levelQuiz + "</td>");
                table.Append("<td>" + item.dateCreate + "</td>");
                table.Append("<td style='width:125px'>" +
                    "<button class='btn btn-success' data-toggle=\"modal\" data-target=\".infoQuiz\" onclick=\"infoRow('"+item.idQuiz+"')\">" +
                    "<i class='fas fa-info'></i></button>&nbsp;" +

                    "<button type=\"submit\" class='btn btn-danger' onclick=\"delRow('" + item.idQuiz + "','"+ HttpContext.Current.Request.Url.AbsolutePath + "')\">" +
                    "<i class='fas fa-trash-alt'></i></button>" +
                    "</td>\n");
                table.Append("</tr>");
            }

            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });

            //StringBuilder option = new StringBuilder();
            //ArrayList opt = new ArrayList();
            //opt = subj.Theme_GetById(idQuiz);

            //foreach (DbSubject item in opt)
            //{
            //    option.Append("<option value=\"" + item.idGroup + "\" >" + item.nameGroup);
            //    option.Append("</option>");
            //}
            //PlaceHolder2.Controls.Add(new Literal { Text = option.ToString() });

        }

        [WebMethod]
        public static bool delRow(string idQuiz)
        {
            /*You can do database operations here if required*/
            return lquiz.delQuiz(idQuiz);
        }

        [WebMethod]
        public static ArrayList infoRow(string idQuiz)
        {
            /*You can do database operations here if required*/

            return lquiz.getQuizById(idQuiz);
        }
    }
}