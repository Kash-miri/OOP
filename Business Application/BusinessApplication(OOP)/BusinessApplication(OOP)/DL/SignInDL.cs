using BusinessApplication_OOP_.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication_OOP_.DL
{
    internal class SignInDL
    {
        public static bool checkCredentials(string username, string password)
        {
            bool flag = false;
            foreach (Manager manager in managerDL.managerList)
            {
                if ((manager.username == username) && (manager.password == password))
                {
                    flag = true;
                    return flag;
                }
            }
            return flag;
        }
    }
}
