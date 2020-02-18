using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;

namespace BUS
{
    public class busSubject
    {
        private static Subject quiz = new Subject();

        public ArrayList Theme_GetById(string id)
        {
            return quiz.Theme_GetById(id);
        }

        public ArrayList Subject_GetById(string id)
        {
            return quiz.Subject_GetById(id);
        }

        public ArrayList Group_GetAll()
        {
            return quiz.Group_GetAll();
        }
    }
}