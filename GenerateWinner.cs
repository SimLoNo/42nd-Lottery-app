using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42nd_Lottery_Console
{
    class GenerateWinner
    {
        public string Winner(string[] list)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(0, list.Length);
            string winner = list[rndNumber];
            return winner;

        }
    }
}
