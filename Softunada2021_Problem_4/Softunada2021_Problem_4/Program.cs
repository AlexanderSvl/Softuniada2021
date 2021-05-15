using System;
using System.Linq;

namespace Softunada2021_Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int martixY = numbers[0];
            int matrixX = numbers[1];

            char[,] matrix = new char[martixY, matrixX];

            for (int i = 0; i < martixY; i++)
            {
                char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int j = 0; j < matrixX; j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            char charToSwitchTo = char.Parse(Console.ReadLine());

            int[] startingCoordinates = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int startY = startingCoordinates[0];
            int startX = startingCoordinates[1];

            char charToSearchFor = matrix[startY, startX];
            matrix[startY, startX] = charToSwitchTo;

            ChangeSymbols(matrix, charToSwitchTo, charToSearchFor, startY, startX);

            for (int i = 0; i < martixY; i++)
            {
                for (int j = 0; j < matrixX; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        static void ChangeSymbols(char[,] matrix, char charToSwitchTo, char charToSearchFor, int startY, int startX)
        {
            if (startY > 0)
            {
                if (matrix[startY - 1, startX] == charToSearchFor)
                {
                    matrix[startY - 1, startX] = charToSwitchTo;

                    int newY = startY - 1;
                    int newX = startX;

                    ChangeSymbols(matrix, charToSwitchTo, charToSearchFor, newY, newX);
                }
            }

            if (startY < matrix.GetLength(0) - 1)
            {
                if (matrix[startY + 1, startX] == charToSearchFor)
                {
                    matrix[startY + 1, startX] = charToSwitchTo;

                    int newY = startY + 1;
                    int newX = startX;

                    ChangeSymbols(matrix, charToSwitchTo, charToSearchFor, newY, newX);
                }
            }

            if (startX > 0)
            {
                if (matrix[startY, startX - 1] == charToSearchFor)
                {
                    matrix[startY, startX - 1] = charToSwitchTo;

                    int newY = startY;
                    int newX = startX - 1;

                    ChangeSymbols(matrix, charToSwitchTo, charToSearchFor, newY, newX);
                }
            }

            if (startX < matrix.GetLength(1) - 1)
            {
                if (matrix[startY, startX + 1] == charToSearchFor)
                {
                    matrix[startY, startX + 1] = charToSwitchTo;

                    int newY = startY;
                    int newX = startX + 1;

                    ChangeSymbols(matrix, charToSwitchTo, charToSearchFor, newY, newX);
                }
            }
        }
    }
}
