using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42nd_Lottery_Console
{
    class MainMenu
    {
        public void Menu() 
        {
            GetNumbers numbers = new GetNumbers();
            GenerateWinner getWinner = new GenerateWinner();
            WriteWinner ourWinner = new WriteWinner();
            string location = null;
            do
            {
                Console.WriteLine("Welcome to the 42nd 'Black Watch' regiment of foots lottery bowl.\nPlease select from the list below, what you want to do.");
                Console.WriteLine("1: Select file location\n2: Generate a winner \n3: Close application");

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        location = InsertLocation();
                        break;
                    case ConsoleKey.D2:
                        if (location == null)
                        {
                            location = InsertLocation();
                        }
                        string[] lotteryNumbers = numbers.SaveNumbers(location);
                        string winner = getWinner.Winner(lotteryNumbers);
                        ourWinner.ShowWinner(winner);
                        continue;
                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
                Console.Clear();
            } while (true);
            
        }
        public string InsertLocation() 
        {
            Console.Clear();
            Console.WriteLine("Paste the location of the participant text document\nin the following format: \nD:\\42nd_Lottery\\42ndReactions.txt\nit is not case sensitive.");
            Console.CursorVisible = true;
            string location = Console.ReadLine();
            Console.CursorVisible = false;
            return location;
        }
    }
}
