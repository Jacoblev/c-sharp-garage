using System;
using System.Collections.Generic;
using Garage.GeneralLogic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            GarageManage.TestObject();
            Menu menu = new Menu();
            menu.GarageMenu();

            Console.ReadKey();
        }
    }
}
