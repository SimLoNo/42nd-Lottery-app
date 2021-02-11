using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42nd_Lottery_Console
{
    class WriteWinner
    {
        public void ShowWinner(string winner)
        {
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth /2 - (winner.Length /2), Console.WindowHeight /2);
            Console.Write(winner);
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}
