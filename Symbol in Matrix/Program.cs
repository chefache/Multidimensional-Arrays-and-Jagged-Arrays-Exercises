using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            var matrix = new char[matrixSize, matrixSize];

            for (int rows = 0; rows < matrixSize; rows++)
            {
                char[] row = Console.ReadLine()
                    .ToCharArray();

                for (int cols = 0; cols < matrixSize; cols++)
                {
                    matrix[rows, cols] = row[cols];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            if (!matrix.Cast<char>().ToArray().Contains(symbol))
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                    }
                }
            }
        }
    }
}
