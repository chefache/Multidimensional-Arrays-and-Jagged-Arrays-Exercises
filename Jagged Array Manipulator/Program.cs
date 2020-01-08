using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());

            var jaggArr = new int[numRows][];

            for (int row = 0; row < numRows; row++)
            {
                jaggArr[row] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }

            Analyze(jaggArr);

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandInfo = command.Split();

                int targetRow = int.Parse(commandInfo[1]);
                int targetCol = int.Parse(commandInfo[2]);
                int value = int.Parse(commandInfo[3]);

                if (!isInside(jaggArr, targetRow, targetCol))
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (commandInfo[0] == "Add")
                {
                    jaggArr[targetRow][targetCol] += value;
                }
                else
                {
                    jaggArr[targetRow][targetCol] -= value;
                }

                command = Console.ReadLine();
            }

            foreach (var row in jaggArr)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }

        private static bool isInside(int[][] jaggArr, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < jaggArr.Length && targetCol >= 0 &&
                targetCol < jaggArr[targetRow].Length;
        }

        private static void Analyze(int[][] jaggArr)
        {
            for (int row = 0; row < jaggArr.Length - 1; row++)
            {
                if (jaggArr[row].Length == jaggArr[row + 1].Length)
                {
                    for (int col = 0; col < jaggArr[row].Length; col++)
                    {
                        jaggArr[row][col] *= 2;
                        jaggArr[row + 1][col] *= 2;
                    }

                }
                else
                {
                    for (int col = 0; col < jaggArr[row].Length; col++)
                    {
                        jaggArr[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggArr[row + 1].Length; col++)
                    {
                        jaggArr[row + 1][col] /= 2;
                    }
                }
            }
        }
    }
}
