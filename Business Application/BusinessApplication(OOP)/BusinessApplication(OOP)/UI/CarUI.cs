using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication_OOP_.BL;
using BusinessApplication_OOP_.DL;

namespace BusinessApplication_OOP_.UI
{
    internal class CarUI
    {
        public static Cars TakeInputForCar()
        {
            string brand;
            string carName;
            int model;
            string color;
            string carNumber;
            double price;
            Display.header();
            Console.Write("Enter Car Brand: ");
            brand = Console.ReadLine();
            Console.Write("Enter Car Name: ");
            carName = Console.ReadLine();
            Console.Write("Enter Car Model: ");
            model = int.Parse(Console.ReadLine());
            Console.Write("Enter Car Color: ");
            color = Console.ReadLine();
            CarNumber:
            Console.Write("Enter Car Number: ");
            carNumber = Console.ReadLine();
            bool flag = CarsDL.IsCarNumberAvailable(brand,carNumber);
            if (flag == false)
            {
                Console.WriteLine("Choose Another Car Number!!!");
                Console.ReadKey();
                goto CarNumber;
            }
            Console.Write("Enter Car Price: ");
            price = double.Parse(Console.ReadLine());
            Cars car = new Cars(brand,carName,model,color,carNumber,price);
            return car;
        }

        public static Cars TakeInputToRemoveCar()
        {
            string brand;
            string carNumber;
            Display.header();
            Console.Write("Enter Car Brand: ");
            brand = Console.ReadLine();
            Console.Write("Enter Car Number: ");
            carNumber = Console.ReadLine();
            Cars car = new Cars(brand, carNumber);
            return car;
        }

        public static void viewAllCars()
        {
            Display.header();
            List<Cars> SortedList = new List<Cars>();
            SortedList = CarsDL.CarsList.OrderBy(x => x.brand).ToList();
            Console.WriteLine("CAR BRAND \t CAR NAME \t CAR MODEL \t CAR NUMBER \t CAR COLOR \t CAR PRICE");
            foreach(Cars car in SortedList)
            {
                Console.WriteLine($"{car.brand} {"\t\t"} {car.carName} {"\t"} {car.model} {"\t\t"} {car.carNumber} {"\t\t"} {car.color} {"\t\t"} {car.price}");
            }
            Display.clearScreen();
        }

        public static void viewSoldCars()
        {
            Display.header();
            List<Cars> SortedList = new List<Cars>();
            SortedList = CarsDL.SoldList.OrderBy(x => x.brand).ToList();
            Console.WriteLine("CAR BRAND \t CAR NAME \t CAR MODEL \t CAR NUMBER \t CAR COLOR \t CAR PRICE");
            foreach (Cars car in SortedList)
            {
                Console.WriteLine($"{car.brand} {"\t\t"} {car.carName} {"\t"} {car.model} {"\t\t"} {car.carNumber} {"\t\t"} {car.color} {"\t\t"} {car.price}");
            }
            Display.clearScreen();
        }

        public static Cars checkAvailabilityOfCar(Cars car)
        {
            if (car != null)
            {
                foreach (Cars cars in CarsDL.CarsList)
                {
                    if ((car.brand == cars.brand) && (car.carName == cars.carName) && (car.model == cars.model) && (car.color == cars.color))
                    {
                        Console.WriteLine("HURRAY! YOUR REQUIRED CAR IS AVAILABLE.");
                        return cars;
                    }
                    else
                    {
                        Console.WriteLine("SORRY! YOUR REQUIRED CAR IS NOT AVAILABLE YET.");
                        return null;
                    }
                }
            }
            return null;
        }
    }
}
