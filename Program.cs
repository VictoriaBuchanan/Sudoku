using System;

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
    public int [,] sudokuBoard2 = new int[9, 9] { { 6, 3, 1, 4, 7, 5, 9, 8, 2 },
                                                 { 4, 8, 7, 9, 2, 3, 5, 6, 1 },
                                                 { 5, 9, 2, 1, 8, 6, 3, 7, 4 },
                                                 { 3, 1, 9, 8, 5, 4, 6, 2, 7 },
                                                 { 2, 6, 8, 7, 3, 9, 4, 1, 5 },
                                                 { 7, 4, 5, 2, 6, 1, 8, 9, 3 },
                                                 { 1, 2, 4, 5, 9, 8, 7, 3, 6},
                                                 { 9, 7, 6, 3, 4, 2, 1, 5, 8 },
                                                 { 8, 5, 3, 6, 1, 7, 2, 4, 9 }};
        
    static void Main(string[] args)
    {
        Program board = new Program();
            
        Program.printBoard(board.sudokuBoard);
        Console.WriteLine(Program.validAnswer(8, 1, 2, board.sudokuBoard2));
        
        

    }

    static void printBoard(int[,] sudokuBoard){
        Console.WriteLine("-------------------------------------------------------");
        for(int i =0; i<9; i++){
            Console.WriteLine("|{0, -5}|{1, -5}|{2, -5}|{3, -5}|{4, -5}|{5, -5}|{6, -5}|{7, -5}|{8, -5}|", sudokuBoard[i,0], sudokuBoard[i, 1], sudokuBoard[i, 2], sudokuBoard[i, 3], sudokuBoard[i, 4], sudokuBoard[i, 5], sudokuBoard[i, 6], sudokuBoard[i, 7], sudokuBoard[i, 8]);
            Console.WriteLine("-------------------------------------------------------");
        }          
    }

    public static int[] findsEmptyCell(int[,] sudokuBoard){
        int[] position = {-1, -1};
        // Loops through all the rows
        for(int i = 0; i<9; i++){
            // Loops through all the columns
            for(int j =0; j<9 ; j++){
                if (sudokuBoard[i, j] == 0){
                    position[0] = i;
                    position[1] = j;
                    return position;
                }
            }
        }
        return position;
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
}
