using System;

namespace Miner
{
    class Program
    {
        static char[,] matrix;
        static int minerRow;
        static int minerCol;
        static int coals;
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine()
                .Split(" ");
            matrix = new char[fieldSize, fieldSize];

            PopulateMatrix();

            foreach (var currentDirection in directions)
            {
                switch (currentDirection)
                {
                    case "left":
                        Move(0, -1);
                        break;
                    case "right":
                        Move(0, 1);
                        break;
                    case "up":
                        Move(-1, 0);
                        break;
                    case "down":
                        Move(1, 0);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{coals} coals left. ({minerRow}, {minerCol})");
        }

        private static void Move(int row, int col)
        {
            if (IsInside(minerRow + row, minerCol + col))
            {
                minerRow += row;
                minerCol += col;

                if (matrix[minerRow, minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    Environment.Exit(0);
                }
                if (matrix[minerRow, minerCol] == 'c')
                {
                    coals--;
                    matrix[minerRow, minerCol] = '*';

                    if (coals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                    }
                }
                
            }
        }

        private static void PopulateMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentChar = Console.ReadLine()
                    .Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(currentChar[col]);

                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }

                    if (matrix[row, col] == 'c')
                    {
                        coals++;
                    }
                }
            }
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix.GetLength(1);
        }
    }
}
