﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_sheet_stat_roller
{
    class Class1
    {
        //int state = 0;
        enum States
        {
            RunState,
            AskState,
            ExitState,
        }

        States state = States.RunState;
        

        public Class1()
        {
            string answer; 

            while (state==States.RunState)
            {
                Roll6();

                state = States.AskState;
                while(state==States.AskState)
                {
                    Console.WriteLine("Reroll (y or n)?");
                    answer = Console.ReadLine();
                    reroll(answer);
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public void reroll(string answer)
        {
            if (answer.Equals("y"))
            {
                Console.WriteLine("New rolls:");
                state = States.RunState;
            }
            else if (answer.Equals("n"))
            {
                state = States.ExitState;
            }
            else
            {
                Console.WriteLine("Invalid input");
                state = States.AskState;
            }
        }

        public void Roll6()
        {
            Random rng = new Random();
            System.Threading.Thread.Sleep(1000);//for loops iterates too fast, causes same seed for 'rng'

            for (int i = 0; i < 6; i++)
            {
                int[] rolls = new int[4];
                int[] bestRolls = new int[3];
                int lowestValuePos = 7;
                int lowestValue = 7;
                int offsetInsert = 0;

                for (int m = 0; m < 4; m++)
                {
                    int i_aRoll = rng.Next(1, 7);
                    rolls[m] = i_aRoll;
                    Console.WriteLine("Rolls: " + i_aRoll);
                }

                for (int n = 0; n < 4; n++)
                {
                    if (lowestValue > rolls[n])
                    {
                        lowestValue = rolls[n];
                        lowestValuePos = n;
                    }
                }

                for (int f = 0; f < 4; f++)//populate the smaller array with 3 highest rolls
                {
                    if (f == lowestValuePos)
                    {
                        if (f == 0 || f == 1)
                        {
                            offsetInsert = 1;
                            bestRolls[f] = rolls[f + offsetInsert];
                        }
                    }

                    else
                    {
                        if (f == 3) //to prevent out of bounds exception, also handles f==2
                        {
                            offsetInsert = 1;
                            bestRolls[f - offsetInsert] = rolls[f];
                        }
                        else { bestRolls[f] = rolls[f + offsetInsert]; }
                    }
                }

                for (int n = 0; n < 3; n++) { Console.WriteLine("High roll #" + (n + 1) + ": " + bestRolls[n]); }
                int sum = bestRolls.Sum();
                Console.WriteLine("Total: " + sum);
                Console.WriteLine(" ");//new line between roll sets
            }
        }

        
    }


    
}
