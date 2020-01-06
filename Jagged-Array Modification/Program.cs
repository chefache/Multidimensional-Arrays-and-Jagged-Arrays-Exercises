using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                arr[i] = row;
            }
  
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                var parts = command.Split(" ");
                var row = int.Parse(parts[1]);
                var col = int.Parse(parts[2]);
                var num = int.Parse(parts[3]);

                if (row < 0 || row > arr.Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (col < 0 || col > arr[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }


                if (command.StartsWith("Add"))
                {
                    arr[row][col] += num;
                }
                else if (command.StartsWith("Subtract"))
                {
                    arr[row][col] -= num;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
