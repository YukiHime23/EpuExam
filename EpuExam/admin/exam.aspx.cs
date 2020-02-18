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
    public partial class exam : System.Web.UI.Page
    {
        StringBuilder qui = new StringBuilder();
        busQuiz qu = new busQuiz();
        busExam ex = new busExam();
        string[] ansCor;
        protected void Page_Load(object sender, EventArgs e)
        {
            string idexam = Request.QueryString["id"]; // value will be data1
            ArrayList list = new ArrayList();
            list = ex.getExamDetaiById(idexam);

            int i = 1;
            foreach (DbExam em in list)
            {
                ArrayList q = new ArrayList();
                q = qu.getQuizById(em.idQuiz);
                foreach (DbQuiz item in q)
                {
                    qui.Append("<form id=\"Quiz" + i + "\" class=\"form-group\" style=\"border-bottom:dotted 1px; \"> ");
                    qui.Append("<div><b>Câu " + i + ": " + item.contentQuiz + "?</b></div>");
                    qui.Append("<div><input type = \"radio\" name = \"cau" + i + "\" onclick=\"answerQuiz(" + i + ",'" + item.ansA + "')\" /><span>" + item.ansA + "</span></div> ");
                    qui.Append("<div><input type = \"radio\" name = \"cau" + i + "\" onclick=\"answerQuiz(" + i + ",'" + item.ansB + "')\" /><span>" + item.ansB + "</span></div> ");
                    qui.Append("<div><input type = \"radio\" name = \"cau" + i + "\" onclick=\"answerQuiz(" + i + ",'" + item.ansC + "')\" /><span>" + item.ansC + "</span></div> ");
                    qui.Append("<div><input type = \"radio\" name = \"cau" + i + "\" onclick=\"answerQuiz(" + i + ",'" + item.ansD + "')\" /><span>" + item.ansD + "</span></div> ");
                    qui.Append("<div class=\"dapan\" hidden>" + item.ansCorrect + "</div>");
                    qui.Append("</form>");
                    i++;
                }
            }

            PlaceHolder1.Controls.Add(new Literal { Text = qui.ToString() });
        }

        [WebMethod]
        public static void calExamScores(string lis)
        {

        }
    }
}