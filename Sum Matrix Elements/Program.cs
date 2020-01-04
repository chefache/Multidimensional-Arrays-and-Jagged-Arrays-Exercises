using System;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixDimensions = Console.ReadLine()
                 .Split(", ");

            var rows = int.Parse(matrixDimensions[0]);
            var cols = int.Parse(matrixDimensions[1]);

            var matrix = new int[rows, cols];

            int matrixSum = 0;

            for (int row = 0; row < rows; row++)
            {
                var rowElement = Console.ReadLine()
                    .Split(", ");

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowElement[col]);
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrixSum += matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(matrixSum);
        }
    }
}
