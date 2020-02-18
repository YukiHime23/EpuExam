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
    public partial class fillter : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        busSubject group = new busSubject();
        static string id_get;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = group.Group_GetAll();

            foreach (DbSubject item in list)
            {
                table.Append("<tr>");
                table.Append("<td>" + item.idGroup + "</td>");
                table.Append("<td>" + item.nameGroup + "</td>");
                table.Append("<td style='width:135px'>" +
                    "<button class='btn btn-warning' >" +
                    "<i class='fas fa-edit'></i></button>&nbsp;" +
                    "<button type=\"submit\" class='btn btn-danger' onclick=\"delGroup('" + item.idGroup + "')\">" +
                    "<i class='fas fa-trash-alt'></i></button>&nbsp;" +
                    "<button class='btn btn-primary' onclick=\"sendId('" + item.idGroup + "','"+ HttpContext.Current.Request.Url.AbsolutePath + "')\">" +
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
            return "subject.aspx?id="+id;
        }
        
    }
}