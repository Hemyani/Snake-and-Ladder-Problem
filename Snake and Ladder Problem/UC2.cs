using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder_Problem
{
    internal class UC2
    {
        public static void rollsthedie()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("Roll The Dice: ");
            Console.WriteLine("Dice Roll: " + dice);
        }
    }
}
