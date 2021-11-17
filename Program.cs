using System;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sudokuBoard = new int[9, 9] { { 6, 0, 0, 3, 0, 5, 8, 7, 0 },
                                                 { 0, 8, 0, 0, 2, 0, 0, 0, 0 },
                                                 { 0, 0, 7, 8, 9, 0, 0, 5, 6 },
                                                 { 0, 6, 0, 0, 7, 0, 1, 0, 0 },
                                                 { 4, 0, 3, 1, 6, 2, 0, 0, 8 },
                                                 { 9, 0, 1, 0, 3, 0, 7, 6, 4 },
                                                 { 0, 0, 0, 0, 0, 3, 0, 0, 7 },
                                                 { 2, 3, 0, 6, 0, 0, 9, 0, 0 },
                                                 { 7, 1, 0, 0, 5, 4, 0, 0, 3 }};

            Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, -5} {4, -5} {5, -5} {6, -5} {7, -5} {8, -5}", sudokuBoard[0,0], sudokuBoard[0, 1], sudokuBoard[0, 2], sudokuBoard[0, 3], sudokuBoard[0, 4], sudokuBoard[0, 5], sudokuBoard[0, 6], sudokuBoard[0, 7], sudokuBoard[0, 8]);
            Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, -5} {4, -5} {5, -5} {6, -5} {7, -5} {8, -5}", sudokuBoard[1,0], sudokuBoard[1, 1], sudokuBoard[1, 2], sudokuBoard[1, 3], sudokuBoard[1, 4], sudokuBoard[1, 5], sudokuBoard[1, 6], sudokuBoard[1, 7], sudokuBoard[1, 8]);
            Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, -5} {4, -5} {5, -5} {6, -5} {7, -5} {8, -5}", sudokuBoard[2,0], sudokuBoard[2, 1], sudokuBoard[2, 2], sudokuBoard[2, 3], sudokuBoard[2, 4], sudokuBoard[2, 5], sudokuBoard[2, 6], sudokuBoard[2, 7], sudokuBoard[2, 8]);
            Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, -5} {4, -5} {5, -5} {6, -5} {7, -5} {8, -5}", sudokuBoard[3,0], sudokuBoard[3, 1], sudokuBoard[3, 2], sudokuBoard[3, 3], sudokuBoard[3, 4], sudokuBoard[3, 5], sudokuBoard[3, 6], sudokuBoard[3, 7], sudokuBoard[3, 8]);
            Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, -5} {4, -5} {5, -5} {6, -5} {7, -5} {8, -5}", sudokuBoard[4,0], sudokuBoard[4, 1], sudokuBoard[4, 2], sudokuBoard[4, 3], sudokuBoard[4, 4], sudokuBoard[4, 5], sudokuBoard[4, 6], sudokuBoard[4, 7], sudokuBoard[4, 8]);
            Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, -5} {4, -5} {5, -5} {6, -5} {7, -5} {8, -5}", sudokuBoard[5,0], sudokuBoard[5, 1], sudokuBoard[5, 2], sudokuBoard[5, 3], sudokuBoard[5, 4], sudokuBoard[5, 5], sudokuBoard[5, 6], sudokuBoard[5, 7], sudokuBoard[5, 8]);
            Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, -5} {4, -5} {5, -5} {6, -5} {7, -5} {8, -5}", sudokuBoard[6,0], sudokuBoard[6, 1], sudokuBoard[6, 2], sudokuBoard[6, 3], sudokuBoard[6, 4], sudokuBoard[6, 5], sudokuBoard[6, 6], sudokuBoard[6, 7], sudokuBoard[6, 8]);
            Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, -5} {4, -5} {5, -5} {6, -5} {7, -5} {8, -5}", sudokuBoard[7,0], sudokuBoard[7, 1], sudokuBoard[7, 2], sudokuBoard[7, 3], sudokuBoard[7, 4], sudokuBoard[7, 5], sudokuBoard[7, 6], sudokuBoard[7, 7], sudokuBoard[7, 8]);
            Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, -5} {4, -5} {5, -5} {6, -5} {7, -5} {8, -5}", sudokuBoard[8,0], sudokuBoard[8, 1], sudokuBoard[8, 2], sudokuBoard[8, 3], sudokuBoard[8, 4], sudokuBoard[8, 5], sudokuBoard[8, 6], sudokuBoard[8, 7], sudokuBoard[8, 8]);
        }
    }
}
