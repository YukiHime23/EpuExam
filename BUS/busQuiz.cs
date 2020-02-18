using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;

namespace BUS
{
    public class busQuiz
    {
        private static Quiz quiz = new Quiz();

        public ArrayList Quiz_GetAll()
        {
            return quiz.Quiz_GetAll();
        }

        public ArrayList getQuizByTheme(string id)
        {
            return quiz.getQuizByTheme(id);
        }

        public ArrayList getQuizById(string id)
        {
            return quiz.getQuizById(id);
        }

        public bool delQuiz(string idQuiz)
        {
            return quiz.delQuiz(idQuiz);
        }

        public bool addQuiz(string nd, string dk, string ngt, string macd, string magv, string a, string b, string c, string d, string dapan)
        {
            return quiz.addQuiz(nd, dk, ngt, macd, magv, a, b, c, d, dapan);
        }
    }
}