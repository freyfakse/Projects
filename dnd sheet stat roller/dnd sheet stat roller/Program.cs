using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_sheet_stat_roller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Roll6();
            Console.ReadKey();
        }

        private static void Roll6()
        {
            Random rng = new Random();
            System.Threading.Thread.Sleep(250);//for loops iterate too fast, causes same seed for 'rng'

            for (int i=0; i<6;i++)
            {
                int[] arr_Rolls = new int[4];
                int[] arr_BestRolls = new int[3];
                int i_lowestValuePos = 7;
                int i_lowestValue = 7;
                int i_offsetInsert = 0;

                for (int m = 0; m < 4; m++)
                {
                    int i_aRoll = rng.Next(1, 7);
                    arr_Rolls[m] = i_aRoll;
                    Console.WriteLine("rolls :" + i_aRoll);
                }

                for (int n = 0; n < 4; n++)
                {
                    if (i_lowestValue > arr_Rolls[n])
                    {
                        i_lowestValue = arr_Rolls[n];
                        i_lowestValuePos = n;
                    }
                }

                for (int f = 0; f < 4; f++)//populate the smaller array with 3 highest rolls
                {
                    if (f == i_lowestValuePos)
                    {
                        if (f == 0 || f == 1)
                        {
                            i_offsetInsert = 1;
                            arr_BestRolls[f] = arr_Rolls[f + i_offsetInsert];
                        }
                    }

                    else
                    {
                        if (f == 3) //to prevent out of bounds exception, also handles f==2
                        {
                            i_offsetInsert = 1;
                            arr_BestRolls[f - i_offsetInsert] = arr_Rolls[f];
                        }
                        else { arr_BestRolls[f] = arr_Rolls[f+i_offsetInsert]; }
                    }
                }

                for (int n = 0; n < 3; n++){ Console.WriteLine(n + ": " + arr_BestRolls[n]); }
                int i_sum = arr_BestRolls.Sum();
                Console.WriteLine("Total: " +i_sum);
            }
        }
    }
}
