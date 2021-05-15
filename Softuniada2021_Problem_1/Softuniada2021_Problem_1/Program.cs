using System;

namespace Softuniada_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeNumberCount = 0;

            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                    primeNumberCount++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The total number of prime numbers between {startNum} to {endNum} is {primeNumberCount}");
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
