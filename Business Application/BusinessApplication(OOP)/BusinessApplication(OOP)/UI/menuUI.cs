using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication_OOP_.UI
{
    internal class menuUI
    {
        public static int menu()
        {
            Display.header();
            int option;
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Manager");
            Console.WriteLine("3. CEO");
            Console.Write("Enter your option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
