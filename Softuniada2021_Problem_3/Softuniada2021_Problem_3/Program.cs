using System;
using System.Collections.Generic;
using System.Linq;

namespace Softuniada2021_Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bonusesSum = 0;

            string command = Console.ReadLine();

            while (command != "stop")
            {
                string name = command;
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                decimal currentSum = Multiplication(numbers);

                Console.WriteLine($"{name} has a bonus of {currentSum} lv.");
                bonusesSum += currentSum;

                command = Console.ReadLine();
            }

            Console.WriteLine($"The amount of all bonuses is {bonusesSum} lv.");
        }

        static decimal Multiplication(int[] numbers)
        {
            decimal result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = 1;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j)
                    {
                        temp *= numbers[j];
                    }
                }

                result += temp;
            }

            return result;
        }
    }
}
