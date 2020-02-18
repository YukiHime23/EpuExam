using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace EpuExam
{
    public partial class login : System.Web.UI.Page
    {
        private busLogin log = new busLogin();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UserId"] = null;
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string user_id = user.Value;
            string user_pass = password.Value;

            if (!checkNull(user_id, user_pass))
            {
                lbError.Text = "Vui long nhap day du thong tin";
            }
            else if (user_id.Contains("SV") && log.checkLoginSv(user_id, user_pass) == 1)
            {
                lbError.Text = "Dang nhap vao tai khoan sinh vien";

            }
            else if (user_id.Contains("GV") && log.checkLoginGv(user_id, user_pass) == 1)
            {
                Session["UserId"] = user_id;
                Response.Redirect("/admin/dashboard.aspx");
            }
            else
            {
                lbError.Text = "Login failed!";
            }
        }
        private bool checkNull(string user_id, string user_pass)
        {
            if (user_id == "" || user_pass == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}