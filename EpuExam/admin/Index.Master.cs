using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpuExam
{
    public partial class Index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("/login.aspx");
            }
            else
            {
                userSesion.InnerText = Session["UserId"].ToString();
            }
        }

        protected void BtnLogOut_Click(object sender, EventArgs e)
        {
            Session["UserId"] = null;
            Response.Redirect("/login.aspx");
        }
    }
}