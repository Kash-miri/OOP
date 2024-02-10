using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication_OOP_.BL;
using BusinessApplication_OOP_.DL;

namespace BusinessApplication_OOP_.UI
{
    internal class customerUI
    {
        public static int customerMenu()
        {
            Display.header();
            int option;
            Console.WriteLine("1. Review a Car");
            Console.WriteLine("2. Buy a Car");
            Console.WriteLine("3. Previous Page");
            Console.Write("Enter your option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        public static Cars takeInputForCarFromCustomer()
        {
            Display.header();
            string carName;
            string brand;
            int model;
            string color;
            int code = 10000;
            Console.Write("Enter Car Brand: ");
            brand = Console.ReadLine();
            Console.Write("Enter Car NAME: ");
            carName = Console.ReadLine();
            Console.Write("Enter Car Model: ");
            model = int.Parse(Console.ReadLine());
            Console.Write("Enter Car Color: ");
            color = Console.ReadLine();
            code = code++;
            Cars car = new Cars(brand, carName, model, color,code);
            return car;
        }

        public static void CarConfirmation(Cars car)
        {
            if(car != null)
            {
                int option;
                Console.Write("If you wanna buy this car press '1' otherwise press '0': ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    customer customer = customerUI.takeInputForCustomer(car);
                    customerDL.customerList.Add(customer);
                    customerDL.storeCustomerIntoFile(customerDL.customerList);
                    CarsDL.SoldList.Add(car);
                    CarsDL.storeCarListIntoFile(CarsDL.SoldList, MenuDL.SoldPath);
                    CarsDL.CarsList.Remove(car);
                    CarsDL.storeCarListIntoFile(CarsDL.CarsList, MenuDL.CarPath);
                }
                else
                {
                    Console.Write("Thank you for visiting our car showroom.");
                }
            } 
        }

        public static customer takeInputForCustomer(Cars car)
        {
            string customerName;
            string customerPhone;
            string customerEmail;
            string customerAdress;
            double payment;
            int code = 10000;
            Console.Write("Enter your name: ");
            customerName = Console.ReadLine();
            PhoneNumber:
            Console.Write("Enter your phone number: ");
            customerPhone = Console.ReadLine();
            if (!checkers.checkPhoneNumber(customerPhone))
            {
                Console.WriteLine("InValid Number");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                goto PhoneNumber;
            }
            Email:
            Console.Write("Enter your email address: ");
            customerEmail = Console.ReadLine();
            if(!checkers.checkSpecialCharacters(customerEmail))
            {
                Console.WriteLine("InValid Email");
                Console.ReadKey();
                goto Email;
            }
            Console.Write("Enter your address: ");
            customerAdress = Console.ReadLine();
            Payment:
            Console.Write("Enter your paid amount: ");
            payment = double.Parse(Console.ReadLine());
            if (payment < car.price)
            {
                Console.WriteLine("OOPS! INSUFFICIENT AMOUNT DETECTED.");
                goto Payment;
            }
            else if (payment > car.price)
            {
                Console.WriteLine("OOPS! MORE AMOUNT THAN THE PRICE DETECTED");
                goto Payment;
            }
            else
            {
                Console.WriteLine("HURRAY! YOUR CAR HAS BEEN BOOKED.");
                Console.WriteLine("Amount Paid: " + payment);
                code = code++;
            }
            customer customer = new customer(customerName, customerPhone, customerEmail, customerAdress, payment, code);
            return customer;
        }

        public static void customerDetails()
        {
            Display.header();
            Console.WriteLine("CUSTOMER NAME \t CUSTOMER CONTACT \t CUSTOMER EMAIL \t CUSTOMER ADRESS \t CAR BRAND \t CAR NAME \t CAR MODEL \t CAR COLOR \t CAR NUMBER \t CAR PRICE \t PAYMENT");
            foreach (customer customer in customerDL.customerList)
            {
                foreach(Cars car in CarsDL.CarsList)
                {
                    if(car.code == customer.code)
                    {
                        Console.WriteLine($"{customer.CustomerName} {"\t"} {customer.CustomerPhone} {"\t"} {customer.CustomerEmail} {"\t"} {customer.CustomerAdress} {"\t"} {car.brand} {"\t\t"} {car.carName} {"\t"} {car.model} {"\t\t"} {car.carNumber} {"\t\t"} {car.color} {"\t\t"} {car.price} {"\t\t"} {customer.payment}");
                    }
                }
            }
            Display.clearScreen();
        }
    }
}
