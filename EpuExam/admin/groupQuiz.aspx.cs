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
    public partial class groupQuiz : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        busQuiz qu = new busQuiz();
        protected void Page_Load(object sender, EventArgs e)
        {
            string idtheme = Request.QueryString["id"]; // value will be data1
            ArrayList list = new ArrayList();
            list = qu.getQuizByTheme(idtheme);

            foreach (DbQuiz item in list)
            {
                table.Append("<tr>");
                table.Append("<td>" + item.idQuiz + "</td>");
                table.Append("<td>" + item.contentQuiz + "</td>");
                table.Append("<td>" + item.levelQuiz + "</td>");
                table.Append("<td>" + item.dateCreate + "</td>");
                table.Append("<td style='width:125px'>" +
                    "<button class='btn btn-success' name='" + item.idQuiz + "' onclick=\"document.getElementById('id01').style.display = 'block'\" style=\"width: auto; \" runat=\"server\">" +
                    "<i class='fas fa-info'></i></button>&nbsp;" +
                    "<button class='btn btn-warning' name='" + item.idQuiz + "'  runat=\"server\">" +
                    "<i class='fas fa-edit'></i></button>&nbsp;" +
                    "<button type=\"submit\" class='btn btn-danger' onclick=\"delQuiz('" + item.idQuiz + "','" + HttpContext.Current.Request.Url.AbsolutePath + "')\">" +
                    "<i class='fas fa-trash-alt'></i></button>" +
                    "</td>\n");
                table.Append("</tr>");
            }

            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
        }
    }
}