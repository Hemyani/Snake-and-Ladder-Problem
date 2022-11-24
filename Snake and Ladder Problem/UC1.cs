using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder_Problem
{
    internal class UC1
    {
        public static void Position()
        {
            int position = 0;
            Random r = new Random();
            int dice = r.Next(0, 2);
            //If Dice Value Is Zero Than You Can Start Game Otherwise Not Using Random
            if (dice == 0)
            {
                Console.WriteLine("You're Ready To Play Because Dice Value Is:" + dice);
                Console.WriteLine("You're Position Is:" + position);
            }
            else
            {
                Console.WriteLine("You're Not Ready To Play Because Dice Value Is:" + dice);
            }
        }
    }
}
