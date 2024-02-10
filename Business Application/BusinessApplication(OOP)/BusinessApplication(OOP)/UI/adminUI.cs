using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication_OOP_.UI
{
    internal class adminUI
    {
        public static int adminMenu()
        {
            int option;
            Display.header();
            Console.WriteLine("1. Add Manager");
            Console.WriteLine("2. Remove Manager");
            Console.WriteLine("3. Number of Cars Sold");
            Console.WriteLine("4. Available Cars");
            Console.WriteLine("5. Customer Details");
            Console.WriteLine("6. Manager Details");
            Console.WriteLine("7. Profit/Loss");
            Console.WriteLine("8. Previous Pgae");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
