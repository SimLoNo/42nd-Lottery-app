using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42nd_Lottery_Console
{
    class GetNumbers
    {
        public string[] SaveNumbers(string location) 
        {
            string[] lines = System.IO.File.ReadAllLines(location);
            // string[] lines = System.IO.File.ReadAllLines(@"D:\42nd_Lottery\42ndReactions.txt");
            return lines;
        }
    }
}
