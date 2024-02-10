using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication_OOP_.BL
{
    internal class Manager
    {
        public Manager(string managerName, string gender, int age, string managerEmail,  string phoneNumber, string address, string username, string password)
        {
            this.managerName = managerName;
            this.gender = gender;
            this.age = age;
            this.managerEmail = managerEmail;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.username = username;
            this.password = password;
        }
        public string managerName;
        public string gender;
        public int age;
        public string managerEmail;
        public string phoneNumber;
        public string address;
        public string username;
        public string password;
    }
}
