using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessApplication_OOP_.UI
{
    internal class Display
    {
        public static void header()
        {
            Console.WriteLine("##########################################################################");
            Console.WriteLine("#                           AHMAD CAR SHOWROOM                           #");
            Console.WriteLine("##########################################################################");
        }
        public static void animations()
        {
            Console.SetCursorPosition(10, 5);
            string rights = "All rights are reserved";
            string mention = "@aleenasheikh";
            for (int i = 0; i < rights.Length; i++)
            {
                Console.Write($"{rights[i]}");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.SetCursorPosition(10, 6);
            Console.WriteLine(mention);
            Thread.Sleep(1000);
        }
        public static void clearScreen()
        {
            Console.Write("Press any key to Continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void addedEntity(string name)
        {
            Console.WriteLine(name+ " added successfully!");
            clearScreen();
        }
        public static void removedEntity(string name)
        {
            Console.WriteLine(name + " removed successfully!");
            clearScreen();
        }
    }
}
