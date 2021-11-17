using System;

namespace Sudoku
{
    class Program
    {
        // VARIABLES
        public int[,] sudokuBoard = new int[9, 9] { { 6, 0, 0, 3, 0, 5, 8, 7, 0 },
                                                 { 0, 8, 0, 0, 2, 0, 0, 0, 0 },
                                                 { 0, 0, 7, 8, 9, 0, 0, 5, 6 },
                                                 { 0, 6, 0, 0, 7, 0, 1, 0, 0 },
                                                 { 4, 0, 3, 1, 6, 2, 0, 0, 8 },
                                                 { 9, 0, 1, 0, 3, 0, 7, 6, 4 },
                                                 { 0, 0, 0, 0, 0, 3, 0, 0, 7 },
                                                 { 2, 3, 0, 6, 0, 0, 9, 0, 0 },
                                                 { 7, 1, 0, 0, 5, 4, 0, 0, 3 }};
        
        static void Main(string[] args)
        {
            Program board = new Program();
            
            Program.printBoard(board.sudokuBoard);

        }

        static void printBoard(int[,] sudokuBoard){
            Console.WriteLine("-------------------------------------------------------");
            for(int i =0; i<9; i++){
                Console.WriteLine("|{0, -5}|{1, -5}|{2, -5}|{3, -5}|{4, -5}|{5, -5}|{6, -5}|{7, -5}|{8, -5}|", sudokuBoard[i,0], sudokuBoard[i, 1], sudokuBoard[i, 2], sudokuBoard[i, 3], sudokuBoard[i, 4], sudokuBoard[i, 5], sudokuBoard[i, 6], sudokuBoard[i, 7], sudokuBoard[i, 8]);
                Console.WriteLine("-------------------------------------------------------");
            }          
        }

        static int[] findsEmptyCell(int[,] sudokuBoard){
            int[] position = {-1, -1};
            // Loops through all the rows
            for(int i = 0; i<9; i++){
                // Loops through all the columns
                for(int j =0; j<9 ; j++){
                    if (sudokuBoard[i, j] == 0){
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
            return position;
        }
    }
}
