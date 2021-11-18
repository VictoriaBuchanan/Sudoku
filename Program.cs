using System;

public class Program
{
    // VARIABLES
    public static int[,] sudokuBoard = new int[9, 9] { { 6, 0, 0, 3, 0, 5, 8, 7, 0 },
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
           
        Console.WriteLine("UNSOLVED SUDOKU\n");
        Program.printBoard(sudokuBoard);
        Console.WriteLine("\nSOLUTION\n");
        if(solver())
        {
            Program.printBoard(sudokuBoard);
        }
        else 
        {
            Console.WriteLine("There are no solutions to the Sudoku");
        }

    }

    // METHODS
    public static int[] findsEmptyCell(int[,] sudokuBoard){
        /// <summary>
        /// Checkks a sudoku board for the first cell equal to zero.
        /// </summary>
        /// <param name="sudokuBoard">A 9x9 matrix representing a sudoku board</param>
        /// <returns>An array with the position of the first 0 cell. If no cells equal 0 it returns an array equal to {-1, -1}</returns>
        
        int[] position = {-1, -1};
        // Loops through all the rows
        for(int i = 0; i<9; i++){
            // Loops through all the columns
            for(int j =0; j<9 ; j++){
                // Checks to see if a cell is equal to 0
                if (sudokuBoard[i, j] == 0){
                    position[0] = i;
                    position[1] = j;
                    return position;
                }
            }
        }
        return position;
    }
    public static int getBoxCoordinate(int coordinate)
    {
        int remainder = coordinate/3;
        
        if(remainder == 0)
        {
            return 0;
        }
        else if (remainder == 1)
        {
            return 3;
        }
        else 
        {
            return 6;
        }
    }
    static void printBoard(int[,] sudokuBoard){
        Console.WriteLine("-------------------------------------------------------");
        for(int i =0; i<9; i++){
            Console.WriteLine("|{0, -5}|{1, -5}|{2, -5}|{3, -5}|{4, -5}|{5, -5}|{6, -5}|{7, -5}|{8, -5}|", sudokuBoard[i,0], sudokuBoard[i, 1], sudokuBoard[i, 2], sudokuBoard[i, 3], sudokuBoard[i, 4], sudokuBoard[i, 5], sudokuBoard[i, 6], sudokuBoard[i, 7], sudokuBoard[i, 8]);
            Console.WriteLine("-------------------------------------------------------");
        }          
    }



    public static bool validAnswer(int answer, int row, int col, int[,] sudokuBoard)
    {
        // Checks to see if the row contains the answer
        for(int i = 0; i <9; i++)
        {
            if(sudokuBoard[i, col] == answer)
            {
                return false;
            }
        }

        // Checks to see if the column contains the answer
        for(int i = 0; i <9; i++)
        {
            if(sudokuBoard[row, i] == answer)
            {
                return false;
            }
        }

        // Checks the 3 x 3 box
        int boxRow = getBoxCoordinate(row);
        int boxCol = getBoxCoordinate(col);

        for(int i = boxRow; i < (boxRow + 3); i++)
        {
            for(int j = boxRow; j < (boxRow + 3); j++)
            {
                if(sudokuBoard[i,j] == answer)
                {
                    return false;
                }
            }
        }

        // Returns true if the number passes all the tests
        return true;
    }

    public static bool solver()
    {
        int[] first_empty_cell = Program.findsEmptyCell(sudokuBoard);

        if(first_empty_cell[0] == -1)
        {
            Program.printBoard(sudokuBoard);
            return true;
        }
        
        for(int i = 1; i < 10 ; i++)
        {
            if(validAnswer(i, first_empty_cell[0], first_empty_cell[1], sudokuBoard))
            {
                sudokuBoard[first_empty_cell[0],first_empty_cell[1]] = i;

                if (solver())
                {
                    Program.printBoard(sudokuBoard);
                    return true;
                } 
                else 
                {
                   sudokuBoard[first_empty_cell[0],first_empty_cell[1]] = 0; 
                }
            }
        }

        // Returns false if nothing yields an acceptable answer
        return false;
    }
}
