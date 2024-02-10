using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication_OOP_.BL;
using BusinessApplication_OOP_.UI;

namespace BusinessApplication_OOP_.DL
{
    internal class CarsDL
    {
        public static List<Cars> CarsList = new List<Cars>();
        public static List<Cars> SoldList = new List<Cars>();
        public static void addCarIntoList(Cars car)
        {
            if(car != null)
            {
                CarsList.Add(car);
                storeCarListIntoFile(CarsList,MenuDL.CarPath);
                Display.addedEntity(car.carName);
            }
        }

        public static void removeCarFromList(Cars car)
        {
            if(car != null)
            {
                List<Cars> NewList = new List<Cars>();
                NewList.AddRange(CarsList);
                foreach(Cars cars in CarsList)
                {
                    if((car.brand == cars.brand) && (car.carNumber == cars.carNumber))
                    {
                        NewList.Remove (cars);
                        Display.removedEntity(cars.carName);
                    }
                }
                CarsList.Clear ();
                CarsList.AddRange(NewList);
            }
        }

        public static bool IsCarNumberAvailable(string brand, string carNumber)
        {
            bool flag = true;
            if (carNumber != null && brand != null)
            {
                foreach (Cars car in CarsList)
                {
                    if (car.carNumber == carNumber && car.brand == brand)
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }
        public static void storeCarListIntoFile(List<Cars> cars, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach(Cars car in cars)
                {
                    string line = $"{car.brand} {","} {car.carName} {","} {car.model} {","} {car.carNumber} {","} {car.color} {","} {car.price}";
                    writer.WriteLine(line);
                }
                writer.Flush();
                writer.Close();
            }
        }
        public static void LoadCarListFromFile(List<Cars> cars, string path)
        {
            checkers.EnsureFileExists(path);
            string line;
            StreamReader reader = new StreamReader(path);
            if(File.Exists(path))
            {
                while((line = reader.ReadLine()) != null)
                {
                    string[] array = line.Split(',');
                    string brand = array[0];
                    string carName = array[1];
                    int model =int.Parse(array[2]);
                    string carNumber = array[3];
                    string color = array[4];
                    double price = double.Parse(array[5]);
                    Cars car = new Cars(brand, carName, model, carNumber, color, price);
                    cars.Add(car);
                }
                reader.Close();
            }
        }
    }
}
