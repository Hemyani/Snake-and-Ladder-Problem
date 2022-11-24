using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder_Problem
{
    internal class UC7
    {
        int position = 0;
        int Dice()
        {
            //variables
            int currentposition = 0;
            int startposition = 0;
            int diecnt = 0;
            // constant
            const int Winning = 100;
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random random = new Random();
            while (position < Winning)
            {
                diecnt++;
                int ran = random.Next(1, 7);
                int opt = random.Next(0, 3);
                switch (opt)
                {
                    case NoPlay:
                        Console.WriteLine("No Play");
                        Console.WriteLine("--------------------------");
                        break;

                    case Ladder:
                        position = currentposition;
                        if (position < Winning)
                        {
                            currentposition += ran;
                            Console.WriteLine("Player Ladder By:" + ran);
                            if (currentposition > Winning)
                            {
                                currentposition = position;
                            }
                        }
                        int r = random.Next(1, 7);
                        if (position < Winning)
                        {
                            currentposition = currentposition + r;
                            Console.WriteLine("Player Ladder By:" + r);
                            if (currentposition > Winning)
                            {
                                currentposition = position;
                            }
                        }
                        Console.WriteLine("You're At:" + currentposition);
                        Console.WriteLine("--------------------------");
                        break;

                    case Snake:
                        if (currentposition > 0)
                        {
                            Console.WriteLine("Snake By:" + ran);
                            currentposition = currentposition - ran;
                        }
                        else if (currentposition <= 0)
                        {
                            currentposition = startposition;
                            currentposition = position;
                        }
                        Console.WriteLine("You are At:" + currentposition);
                        Console.WriteLine("--------------------------");
                        break;

                    default:
                        Console.WriteLine("You are At:" + position);
                        break;
                }
            }
            Console.WriteLine("Die Was Rolled For " + diecnt + " Times");
            Console.WriteLine("You are in the  Final Position Is:" + position);
            return diecnt;
        }
        public static void PlayerWon()
        {
            UC7 ob1 = new UC7();
            Console.WriteLine("******************For Player 1******************");
            int a = ob1.Dice();
            UC7 ob2 = new UC7();
            Console.WriteLine("******************For Player 2******************");
            int b = ob2.Dice();
            if (b < a)
            {
                Console.WriteLine("Player 2 Has Win");
            }
            else
            {
                Console.WriteLine("Player 1 Has Win");
            }
        }
    }
}
       