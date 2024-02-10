using BusinessApplication_OOP_.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication_OOP_.BL;

namespace BusinessApplication_OOP_.DL
{
    internal class MenuDL
    {
        public static string CarPath = @"C:\Users\kashm\OneDrive\Programming\OOP\BusinessApplication(OOP)\BusinessApplication(OOP)\CarsList.txt";
        public static string SoldPath = @"C:\Users\kashm\OneDrive\Programming\OOP\BusinessApplication(OOP)\BusinessApplication(OOP)\SoldCarList.txt";
        public static void chooseOption()
        {
            
            CarsDL.LoadCarListFromFile(CarsDL.CarsList,CarPath);
            CarsDL.LoadCarListFromFile(CarsDL.SoldList, SoldPath);
            customerDL.LoadCustomerListFromFile();
            managerDL.LoadManagerListFromFile();
            int option = menuUI.menu();
            do
            {
                if (option == 1)
                {
                    int customerOption = customerUI.customerMenu();
                    Display.clearScreen();
                    customerDL.checkCustumerOption(customerOption);
                }
                else if (option == 2)
                {
                    bool flag = SignIn.getSignInCredentials();
                    if(flag)
                    {
                        int managerOption = managerUI.managerMenu();
                        Display.clearScreen();
                        managerDL.checkManagerOption(managerOption);
                    }
                }
                else if (option == 3)
                {
                    bool flag = SignIn.getSignInCredentials();
                    if (flag)
                    {
                        Display.clearScreen();
                        int CEOoption = adminUI.adminMenu();
                        Display.clearScreen();
                        adminDL.checkAdminOption(CEOoption);
                    }
                }
                else
                {
                    Console.WriteLine("InValid Option: ");
                    option = menuUI.menu();
                }
            }
            while (option != 5);
        }
    }
}
