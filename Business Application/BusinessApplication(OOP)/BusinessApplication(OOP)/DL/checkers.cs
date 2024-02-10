using BusinessApplication_OOP_.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication_OOP_.DL
{
    internal class checkers
    {
        public static bool checkSpecialCharacters(string name)
        {
            bool flag = false;
            if (name != null)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == '@')
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }

        public static bool checkPhoneNumber(string phoneNumber)
        {
            bool flag = false;
            if (phoneNumber != null)
            {
                if(phoneNumber.Length == 11)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public static bool checkpassword(string password)
        {
            bool flag = false;
            if (password != null)
            {
                if(checkSpecialCharacters(password) && password.Length>=8)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public static void EnsureFileExists(string path)
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
            }
        }
    }
}
