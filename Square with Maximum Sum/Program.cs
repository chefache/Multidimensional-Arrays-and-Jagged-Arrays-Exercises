using System;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(", ");
            var rows = int.Parse(matrixSize[0]);
            var cols = int.Parse(matrixSize[1]);

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var rowElement = Console.ReadLine()
                    .Split(", ");

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowElement[col]);
                }
            }

            int subMatrixRows = 2;
            int subMatrixCols = 2;

            if (matrix.GetLength(0) < subMatrixRows || matrix.GetLength(1) < subMatrixCols)
            {
                Console.WriteLine("No solution !");
            }

            int maxSum = int.MinValue;

            int maxSumRow = -1;
            int maxSumCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - subMatrixRows + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - subMatrixCols + 1; col++)
                {
                    var sum2x2matrix = 0;

                    for (int subRow = 0; subRow < subMatrixRows; subRow++)
                    {
                        for (int subCol = 0; subCol < subMatrixCols; subCol++)
                        {
                            sum2x2matrix += matrix[row + subRow, col + subCol];
                        }
                    }

                    if (sum2x2matrix > maxSum)
                    {
                        maxSum = sum2x2matrix;

                        maxSumRow = row;
                        maxSumCol = col;
                    }

                }
            }
            for (int row = 0; row < subMatrixRows; row++)
            {
                for (int col = 0; col < subMatrixCols; col++)
                {
                    Console.Write(matrix[maxSumRow + row, maxSumCol + col] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine(maxSum);

        }
    }
}
