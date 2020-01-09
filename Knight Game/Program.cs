using System;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardSize = int.Parse(Console.ReadLine());
            var chessBoard = new char[boardSize, boardSize];

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                var symbol = Console.ReadLine().ToCharArray();
               
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = symbol[col];
                }
            }
            
            int killerRow = 0;
            int killerCol = 0;
            int remuvedKnights = 0;

            while (true)
            {
                int maxAttaks = 0;

                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int currentKnightsAttaks = 0;

                        if (chessBoard[row, col] == 'K')
                        {
                            // row-2, col+1
                            if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                currentKnightsAttaks++;
                            }
                            // row-2, col-1
                            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                currentKnightsAttaks++;
                            }
                            // row-1, col+2
                            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                currentKnightsAttaks++;
                            }
                            // row-1, col-2
                            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                currentKnightsAttaks++;
                            }
                            // row+1, col+2
                            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'k')
                            {
                                currentKnightsAttaks++;
                            }
                            // row+1, col-2
                            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                currentKnightsAttaks++;
                            }
                            // row+2, col+1
                            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                currentKnightsAttaks++;
                            }
                            // row+2, col-1
                            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                currentKnightsAttaks++;
                            }
                        }
                        if (currentKnightsAttaks > maxAttaks)
                        {
                            maxAttaks = currentKnightsAttaks;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                }

                if (maxAttaks > 0)
                {
                    chessBoard[killerRow, killerCol] = '0';
                    remuvedKnights++;
                }
                else
                {
                    Console.WriteLine(remuvedKnights);
                    break;
                }
            }
        }

        private static bool IsInside(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) &&
                col >= 0 && col < chessBoard.GetLength(1);
        }
    }
}
