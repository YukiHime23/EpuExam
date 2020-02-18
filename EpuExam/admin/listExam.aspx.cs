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
    public partial class listExam : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        static busExam ex = new busExam();
        static string id_get;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = ex.Exam_GetAll();

            foreach (DbExam item in list)
            {
                table.Append("<tr>");
                table.Append("<td>" + item.idExam + "</td>");
                table.Append("<td>" + item.nameSubject + "</td>");
                table.Append("<td>" + item.nameStageExam + "</td>");
                table.Append("<td>" + item.numQuiz + "</td>");
                table.Append("<td>" + item.rankExam + "</td>");
                table.Append("<td>" + item.trainingSys + "</td>");
                table.Append("<td>" + item.timeDoExam + "</td>");
                table.Append("<td>" + item.dateCreate + "</td>");
                table.Append("<td style='width:125px'>" +
                    "<button class='btn btn-success' data-toggle=\"modal\" >" +
                    "<i class='fas fa-info'></i></button>&nbsp;" +
                    "<button class='btn btn-warning' name='" + item.idExam + "' >" +
                    "<i class='fas fa-edit'></i></button>&nbsp;" +
                    "<button type=\"submit\" class='btn btn-primary' onclick=\"sendId('" + item.idExam + "','" + HttpContext.Current.Request.Url.AbsolutePath + "')\">" +
                    "<i class='fas fa-arrow-alt-circle-right'></i></button>" +
                    "</td>\n");
                table.Append("</tr>");
            }

            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
        }

        [WebMethod]
        public static string sendId(string id)
        {
            id_get = id;
            return "exam.aspx?id=" + id;
        }
    }
}