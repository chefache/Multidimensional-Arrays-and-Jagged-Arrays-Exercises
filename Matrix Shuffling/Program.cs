using System;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split();

            var rows = int.Parse(matrixSize[0]);
            var cols = int.Parse(matrixSize[1]);

            var matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                string[] singleInput = input.Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = singleInput[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }
                else if (command[0] == "swap")
                {
                    var firstRow = int.Parse(command[1]);
                    var firstCol = int.Parse(command[2]);

                    var secondRow = int.Parse(command[3]);
                    var secondCol = int.Parse(command[4]);

                    if (firstRow <= matrix.GetLength(0) && firstRow <= matrix.GetLength(1) &&
                        firstCol <= matrix.GetLength(0) && firstCol <= matrix.GetLength(1) &&
                        secondRow <= matrix.GetLength(0) && secondRow <= matrix.GetLength(1) &&
                        secondCol <= matrix.GetLength(0) && secondCol <= matrix.GetLength(1)) 
                    {
                        var numToPlace = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = numToPlace;

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }


                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
        }
    }
}
