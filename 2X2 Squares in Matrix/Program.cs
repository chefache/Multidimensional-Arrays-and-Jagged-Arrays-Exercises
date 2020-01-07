using System;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixDimensions = Console.ReadLine()
                .Split(" ");

            int rows = int.Parse(matrixDimensions[0]);
            int cols = int.Parse(matrixDimensions[1]);

            var matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowsAsChars = Console.ReadLine();
                var currentChar = rowsAsChars.Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(currentChar[col]);
                }
            }

            var counter = 0;
          
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row, col] == matrix [row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
