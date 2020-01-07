using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];

            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var num = Console.ReadLine()
                    .Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(num[col]);
                }
            }

            var newMatrix = matrix.Cast<int>().ToArray();

            for (int i = 0; i < newMatrix.Length; i++)
            {
                if (i % (n + 1) == 0)
                {
                    primaryDiagonalSum += newMatrix[i];
                }
            }
            ;
            for (int i = n - 1; i < newMatrix.Length - (n - 1); i++)
            {
                if (i % (n - 1)  == 0)
                {
                    secondaryDiagonalSum += newMatrix[i];
                }
            }

            var difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(difference);
        }
    }
}
