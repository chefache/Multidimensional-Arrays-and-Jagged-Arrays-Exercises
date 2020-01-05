using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            var sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var num = Console.ReadLine()
                    .Split(" ");

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(num[col]);
                }
            }

           var secondMatrix =  matrix.Cast<int>().ToArray();

            for (int i = 0; i < secondMatrix.Length; i++)
            {
                if (i % (matrixSize + 1) == 0)
                {
                    sum += secondMatrix[i];
                }            
            }
            Console.WriteLine(sum);
        }
    }
}
