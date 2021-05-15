using System;
using System.Collections.Generic;

namespace Softuniada2021_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                for (int j = 1; j <= number - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }

                for (int l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }

                Console.Write("\n");
            }
        }
    }
}