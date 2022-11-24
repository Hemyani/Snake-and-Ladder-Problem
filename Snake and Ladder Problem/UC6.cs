using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder_Problem
{
    internal class UC6
    {
        public static void Report()
        {
            int position = 0;
            int current_position = 0;
            int start_position = 0;
            int diecnt = 0;
            const int Winning = 100;
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random random = new Random();
            while (position < Winning)
            {
                diecnt++;
                int ran = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NoPlay:
                        Console.WriteLine("No Play");
                        Console.WriteLine("--------------------------");
                        break;

                    case Ladder:
                        position = current_position;
                        if (position < Winning)
                        {
                            current_position = current_position + ran;
                            Console.WriteLine("Play" +
                                "" +
                                "" +
                                "" +
                                "" +
                                "" +
                                "Ladder By:" + ran);
                            if (current_position > Winning)
                            {
                                current_position = position;
                            }
                        }
                        int r = random.Next(1, 7);
                        Console.WriteLine("You are  At the :" + current_position);
                        Console.WriteLine("--------------------------");
                        break;

                    case Snake:
                        if (current_position > 0)
                        {
                            Console.WriteLine("Player Is Bitten By Snake By:" + ran);
                            current_position = current_position - ran;
                        }
                        else if (current_position <= 0)
                        {
                            current_position = start_position;
                            current_position = position;
                        }
                        Console.WriteLine("You are At the :" + current_position);
                        Console.WriteLine("--------------------------");
                        break;

                    default:
                        Console.WriteLine("You're At:" + position);
                        break;
                }
            }
            Console.WriteLine("Die Rolled For " + diecnt + " Times");
            Console.WriteLine("You're Final Position Is:" + position);
            Console.ReadLine();
        }
    }
}
