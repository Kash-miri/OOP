using BusinessApplication_OOP_.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication_OOP_.BL;
using System.Runtime.ConstrainedExecution;
using System.IO;

namespace BusinessApplication_OOP_.DL
{
    internal class customerDL
    {
        public static List<customer> customerList = new List<customer>();
        
        public static void checkCustumerOption(int option)
        {
            while (true)
            {
                /*if (option == 1)
                {

                }*/
                if (option == 2)
                {
                    Cars car;
                    car =  CarUI.checkAvailabilityOfCar(customerUI.takeInputForCarFromCustomer());
                    if(car == null)
                    {
                        Console.Write("If you wanna buy another car press '1' otherwise press '0': ");
                        int opt = int.Parse(Console.ReadLine());
                        if(opt == 1)
                        {
                            car = CarUI.checkAvailabilityOfCar(customerUI.takeInputForCarFromCustomer());
                        }
                        else
                        {
                            Console.Clear();
                            Display.header();
                            Console.SetCursorPosition(10, 5);
                            Console.Write("Thank you for visiting our car-showroom.");
                        }
                    }
                    customerUI.CarConfirmation(car);
                }
                else if (option == 3)
                {
                    MenuDL.chooseOption();
                }
                option = customerUI.customerMenu();
                Display.clearScreen();
            }
        }
        public static void storeCustomerIntoFile(List<customer> customers)
        {
            string path = @"C:\Users\kashm\OneDrive\Programming\OOP\BusinessApplication(OOP)\BusinessApplication(OOP)\CustomerList.txt";
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (customer c in customers)
                {
                    string line = $"{c.CustomerName} {","} {c.CustomerPhone} {","} {c.CustomerEmail} {","} {c.CustomerAdress} {","} {c.code} {","} {c.payment}";
                    writer.WriteLine(line);
                }
                writer.Flush();
                writer.Close();
            }
        }
        public static void LoadCustomerListFromFile()
        {
            string path = @"C:\Users\kashm\OneDrive\Programming\OOP\BusinessApplication(OOP)\BusinessApplication(OOP)\CustomerList.txt";
            checkers.EnsureFileExists(path);
            string line;
            StreamReader reader = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] array = line.Split(',');
                    string customerName = array[0];
                    string customerPhone = array[1];
                    string customerEmail = array[2];
                    string customerAdress = array[3];
                    int code = int.Parse(array[4]);
                    double payment = double.Parse(array[5]);
                    customer car = new customer(customerName, customerPhone, customerEmail, customerAdress, payment, code);
                    customerList.Add(car);
                }
                reader.Close();
            }
        }
    }
}
