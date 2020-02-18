using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;

namespace BUS
{
    public class busExam
    {
    	private static Exam exam = new Exam();

        public ArrayList StageExam_GetAll()
        {
            return exam.StageExam_GetAll();
        }
        public ArrayList Exam_GetAll()
        {
            return exam.Exam_GetAll();
        }
        public ArrayList getStageById(string id)
        {
            return exam.getStageById(id);
        }
        public ArrayList getExamDetaiById(string id)
        {
            return exam.getExamDetailById(id);
        }
        public bool addExam(string mkt,string mamon, string socau, string easy, string medium, string hard)
        {
            bool ck = exam.addExam(mkt, mamon, socau);
            exam.addExamDetai(socau, easy, medium, hard);
            return ck;
        }
    }
}