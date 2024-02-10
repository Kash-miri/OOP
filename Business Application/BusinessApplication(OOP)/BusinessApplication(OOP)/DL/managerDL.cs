using BusinessApplication_OOP_.BL;
using BusinessApplication_OOP_.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessApplication_OOP_.DL
{
    internal class managerDL
    {
        public static List<Manager> managerList = new List<Manager>();


        public static void checkManagerOption(int option)
        {
            while(true)
            {
                if (option == 1)
                {
                    CarsDL.addCarIntoList(CarUI.TakeInputForCar());
                }
                else if (option == 2)
                {
                    CarsDL.removeCarFromList(CarUI.TakeInputToRemoveCar());
                }
                else if (option == 3)
                {
                    CarUI.viewAllCars();
                }
                else if (option == 4)
                {
                    MenuDL.chooseOption();
                }
                else
                {
                    break;
                }
                option = managerUI.managerMenu();
                Display.clearScreen();
            }

        }
        public static void addManagerIntoList(Manager manager)
        {
            if(manager != null)
            {
                managerList.Add(manager);
                Display.addedEntity(manager.managerName);
            }
        }

        public static void removeManagerFromList(string username)
        {
            if(username != null)
            {
                List<Manager> NewList = new List<Manager> ();
                NewList.AddRange(managerList);
                foreach(Manager manager in managerList)
                {
                    if(manager.username == username)
                    {
                        NewList.Remove(manager);
                        Display.removedEntity(manager.managerName);
                    }
                }
                managerList.Clear();
                managerList.AddRange(NewList);
            }
        }
        public static bool IsUsernameAvailable(string username)
        {
            bool flag = true;
            if (username != null)
            {
                foreach (Manager manager in managerList)
                {
                    if (manager.username == username)
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }

        public static void storeManagerrIntoFile(List<Manager> managers)
        {
            string path = @"C:\Users\kashm\OneDrive\Programming\OOP\BusinessApplication(OOP)\BusinessApplication(OOP)\ManagerList.txt";
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (Manager m in managers)
                {
                    string line = $"{m.managerName} {","} {m.gender} {","} {m.age} {","} {m.phoneNumber} {","} {m.managerEmail} {","} {m.address} {","} {m.username} {","} {m.password}";
                    writer.WriteLine(line);
                }
                writer.Flush();
                writer.Close();
            }
        }
        public static void LoadManagerListFromFile()
        {
            string path = @"C:\Users\kashm\OneDrive\Programming\OOP\BusinessApplication(OOP)\BusinessApplication(OOP)\ManagerList.txt";
            checkers.EnsureFileExists(path);
            string line;
            StreamReader reader = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] array = line.Split(',');
                    string name = array[0];
                    string gender = array[1];
                    int age = int.Parse(array[2]);
                    string contact = array[3];
                    string email = array[4];
                    string adress = array[5];
                    string username = array[6];
                    string password = array[7];
                    Manager manager = new Manager(name, gender, age, email, contact, adress, username, password);
                    managerList.Add(manager);
                }
                reader.Close();
            }
        }
    }
}
