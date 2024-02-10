using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication_OOP_.BL;
using BusinessApplication_OOP_.UI;
using BusinessApplication_OOP_.DL;

namespace BusinessApplication_OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display.header();
            Display.animations();
            Console.SetCursorPosition(0, 8);
            Display.clearScreen();
            MenuDL.chooseOption();
        }
    }
}
