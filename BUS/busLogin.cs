using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Controller;

namespace BUS
{
    public class busLogin
    {
        private static Account log = new Account();

        public int checkLoginSv(string username, string password)
        {
            return log.checkLoginSv(username, password);
        }
        public int checkLoginGv(string username, string password)
        {
            return log.checkLoginGv(username, password);
        }
    }
}