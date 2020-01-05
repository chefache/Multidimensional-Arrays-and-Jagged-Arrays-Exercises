using System;
using System.Linq;

namespace Sum_Matrix_Columns
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

            for (int row = 0; row < rows; row++)
            {
                var rowElement = Console.ReadLine()
                    .Split(" ");

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowElement[col]);
                }
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var colsSum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {                
                    colsSum += matrix[row, col];
                }
                Console.WriteLine(colsSum);
            }

        }
    }
}
