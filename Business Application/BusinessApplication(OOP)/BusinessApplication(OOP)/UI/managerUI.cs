using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication_OOP_.BL;
using BusinessApplication_OOP_.DL;

namespace BusinessApplication_OOP_.UI
{
    internal class managerUI
    {
        public static int managerMenu()
        {
            int option;
            Display.header();
            Console.WriteLine("1. Add a Car");
            Console.WriteLine("2. Remove a Car");
            Console.WriteLine("3. Available Cars");
            Console.WriteLine("4. Previous Page");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public static Manager TakeInputForManager()
        {
            Display.header();
            string managerName;
            string gender;
            int age;
            string managerEmail;
            string phoneNumber;
            string address;
            string username;
            string password;
            Console.Write("Enter Manager's Name: ");
            managerName = Console.ReadLine();
            Console.Write("Enter Manager's Gender: ");
            gender = Console.ReadLine();
            Console.Write("Enter Manager's Age: ");
            age = int.Parse((Console.ReadLine()));
            Email:
            Console.Write("Enter Manager's Email: ");
            managerEmail = Console.ReadLine();
            bool email = checkers.checkSpecialCharacters(managerEmail);
            if (!email)
            {
                Console.WriteLine("InValid Email");
                Console.WriteLine("Use Special Characters with your User-Name");
                Console.ReadKey();
                goto Email;
            }
            PhoneNumber:
            Console.Write("Enter Manager's Phone-No: ");
            phoneNumber = Console.ReadLine();
            bool phone = checkers.checkPhoneNumber(phoneNumber);
            if(!phone)
            {
                Console.WriteLine("InValid Number");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                goto PhoneNumber;
            }
            Console.Write("Enter Manager's Address: ");
            address = Console.ReadLine();
            UserName:
            Console.Write("Enter Manager's User-Name: ");
            username = Console.ReadLine();
            bool available = managerDL.IsUsernameAvailable(username);
            if(!available)
            {
                Console.WriteLine("Choose Another User-Nmae.");
                Console.ReadKey();
                goto UserName;
            }
            Password:
            Console.Write("Enter Manager's Password: ");
            password = Console.ReadLine();
            bool pass = checkers.checkpassword(password);
            if (!pass)
            {
                Console.WriteLine("Use Special Characters in your Password");
                Console.ReadKey();
                goto Password;
            }
            Manager manager = new Manager(managerName,gender,age,managerEmail,phoneNumber,address,username,password);
            return manager;
        }
        public static string TakeInputToRemoveManager()
        {
            string username;
            Console.Write("Enter Manager's User-Name: ");
            username= Console.ReadLine();
            return username;
        }

        public static void managerDetails()
        {
            Display.header();
            List<Manager> SortedList = new List<Manager>();
            SortedList = managerDL.managerList.OrderBy(x => x.managerName).ToList();
            Console.WriteLine(" NAME \t\t GENDER \t\t AGE \t\t CONTACT \t\t EMAIL ID \t\t ADDRESS \t\t USERNAME \t\t PASSWORD");
            foreach (Manager manager in SortedList)
            {
                Console.WriteLine($"{" "}{manager.managerName} {"\t\t"} {manager.gender} {"\t\t\t"} {manager.age} {"\t\t"} {manager.phoneNumber} {"\t\t"} {manager.managerEmail} {"\t\t"} {manager.address} {"\t\t"} {manager.username} {"\t\t"} {manager.password}");
            }
            Display.clearScreen();
        }
    }
}
