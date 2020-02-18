using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;

namespace BUS
{
    public class busStudent
    {
        private static Student quiz = new Student();

        public ArrayList Student_GetAll()
        {
            return quiz.Student_GetAll();
        }
    }
}