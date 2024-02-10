using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication_OOP_.DL;
using BusinessApplication_OOP_.BL;

namespace BusinessApplication_OOP_.UI
{
    internal class SignIn
    {
        public static bool getSignInCredentials()
        {
            string username;
            string password;
            bool flag = false;
            Console.Write("Enter User-Name: ");
            username = Console.ReadLine();
            Console.Write("Enter Password: ");
            password = Console.ReadLine();
            if(username == adminDL.username || password == adminDL.password)
            {
                flag = true;
                return flag;
            }
            else
            {
                flag = SignInDL.checkCredentials(username, password);
            }

            if(!flag)
            {
                Console.WriteLine("ERROR DETECTD! 'WRONG USERNAME/PASSWORD'");
            }
            return flag;
        }
    }
}
