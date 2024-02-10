using BusinessApplication_OOP_.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication_OOP_.DL
{
    internal class adminDL
    {
        public static string username = "aleena";
        public static string password = "1234567@";
        public static void checkAdminOption(int option)
        {
            while (true)
            {
                if (option == 1)
                {
                    managerDL.addManagerIntoList(managerUI.TakeInputForManager());
                }
                else if (option == 2)
                {
                    managerDL.removeManagerFromList(managerUI.TakeInputToRemoveManager());
                }
                else if (option == 3)
                {
                    CarUI.viewSoldCars();
                }
                else if (option == 4)
                {
                    CarUI.viewAllCars();
                }
                else if (option == 5)
                {
                    customerUI.customerDetails();
                }
                else if (option == 6)
                {
                    managerUI.managerDetails();
                }
                else if(option == 7)
                {
                    profitDL.calculateProfit(CarsDL.SoldList);
                }
                else if(option == 8)
                {
                    MenuDL.chooseOption();
                }
                else
                {
                    break;
                }
                option = adminUI.adminMenu();
                Display.clearScreen();
            }
        }
    }
}
