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
    public partial class subject : System.Web.UI.Page
    {
        static string id_get;
        StringBuilder table = new StringBuilder();
        busSubject subj = new busSubject();
        protected void Page_Load(object sender, EventArgs e)
        {
            string idsub = Request.QueryString["id"]; // value will be data1
            ArrayList list = new ArrayList();
            list = subj.Subject_GetById(idsub);

            foreach (DbSubject item in list)
            {
                table.Append("<tr>");
                table.Append("<td>" + item.idSubject + "</td>");
                table.Append("<td>" + item.nameGroup + "</td>");
                table.Append("<td>" + item.nameSubject + "</td>");
                table.Append("<td style='width:135px'>" +
                    "<button class='btn btn-warning' >" +
                    "<i class='fas fa-edit'></i></button>&nbsp;" +
                    "<button type=\"submit\" class='btn btn-danger' onclick=\"delGroup('" + item.idSubject + "')\">" +
                    "<i class='fas fa-trash-alt'></i></button>&nbsp;" +
                    "<button class='btn btn-primary' onclick=\"sendId('" + item.idSubject + "','" + HttpContext.Current.Request.Url.AbsolutePath + "')\">" +
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
            return "theme.aspx?id=" + id;
        }
    }
}