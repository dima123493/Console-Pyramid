using System;

namespace Console_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("To see the pyramid guess a number from 1 to 10:");
            while (true)
            {
                int q = int.Parse(Console.ReadLine());

                if (q >= 1 && q < 3)
                {
                    Console.WriteLine("Freezing");
                    i++;
                    continue;
                }

                if (q >= 3 && q <= 5)
                {
                    Console.WriteLine("Cold");
                    i++;
                    continue;
                }

                if (q == 6)
                {
                    Console.WriteLine("Hot!");
                    i++;
                    continue;
                }

                if (q >= 8 && q <= 9)
                {
                    Console.WriteLine("Cold");
                    i++;
                    continue;
                }

                if (q == 10)
                {
                    Console.WriteLine("Freezing");
                    i++;
                    continue;
                }

                if (q > 10)
                {
                    Console.WriteLine("Invalid input. Be careful!");
                    i++;
                    continue;
                }

                else
                    Console.WriteLine("YOU WON!!!\nGood job!");
                break;

            }

            int a, b, c;
            for (a = 1; a <= 7; a++)
            {
                for (b = 6; b >= a; b--)
                {
                    Console.Write(" ");
                }
                for (c = 1; c <= (2 * a - 1); c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue...");
        }
    }
}