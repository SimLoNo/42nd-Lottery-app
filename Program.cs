using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42nd_Lottery_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNumbers numbers = new GetNumbers();
            MainMenu menu = new MainMenu();
            Console.CursorVisible = false;
            menu.Menu();
        }
    }
}
