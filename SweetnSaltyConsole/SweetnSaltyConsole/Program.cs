using System;

namespace SweetnSaltyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
        }

        static void PrintNumbers()
        {
            int sweet = 0;
            int salty = 0;
            int sweetnSalty = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("Sweet'nSalty ");
                    sweetnSalty++;
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Sweet ");
                    sweet++;
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Salty ");
                    salty++;
                }
                else
                {
                    Console.Write(i + " ");
                }

                if (i % 10 == 0)
                    Console.Write("\n");
                

            }

            Console.WriteLine($"There were {sweet} Sweets.");
            Console.WriteLine($"There were {salty} Salty's.");
            Console.WriteLine($"There were {sweetnSalty} Sweet'nSalty.");

        }
    }//End of Program
}//End of Class
