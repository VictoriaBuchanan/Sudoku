using System;
using Xunit;

namespace ProgramTests
{
    public class ValidAnswerTests
    {
        [Fact]
        public void validAnswerTest1()
        {       
            // Checks if 3 is a valid number when all other cells are filled
            int[,] sudokuBoard = new int[9, 9] { { 4, 2, 8, 5, 9, 3, 6, 7, 1 },
                                                    { 7, 0, 9, 8, 6, 1, 5, 2, 4 },
                                                    { 5, 6, 1, 4, 7, 2, 9, 8, 3 },
                                                    { 1, 8, 3, 2, 4, 6, 7, 5, 9 },
                                                    { 9, 4, 6, 1, 5, 7, 2, 3, 8 },
                                                    { 2, 5, 7, 9, 3, 8, 1, 4, 6 },
                                                    { 3, 1, 5, 6, 2, 4, 8, 9, 7 },
                                                    { 8, 9, 4, 7, 1, 5, 3, 6, 2 },
                                                    { 6, 7, 2, 3, 8, 9, 4, 1, 5 }};

            Assert.True(Program.validAnswer(3, 1, 1, sudokuBoard));  
            
        }

        [Fact]
        public void validAnswerTest2()
        {       
            // Isolates the check for the row
            int[,] sudokuBoard = new int[9, 9] { { 4, 2, 8, 5, 9, 3, 6, 7, 1 },
                                                    { 7, 0, 9, 8, 6, 1, 5, 2, 4 },
                                                    { 0, 6, 1, 4, 7, 2, 9, 8, 3 },
                                                    { 1, 8, 3, 2, 4, 6, 7, 5, 9 },
                                                    { 9, 4, 6, 1, 5, 7, 2, 3, 8 },
                                                    { 2, 0, 7, 9, 3, 8, 1, 4, 6 },
                                                    { 3, 1, 5, 6, 2, 4, 8, 9, 7 },
                                                    { 8, 9, 4, 7, 1, 5, 3, 6, 2 },
                                                    { 6, 7, 2, 3, 8, 9, 4, 1, 5 }};

            Assert.False(Program.validAnswer(5, 1, 1, sudokuBoard));  
            
        }

        [Fact]
        public void validAnswerTest3()
        {       
            // Isolates the check for the column
            int[,] sudokuBoard = new int[9, 9] { { 4, 2, 8, 5, 9, 3, 6, 7, 1 },
                                                    { 7, 3, 9, 8, 6, 1, 5, 2, 4 },
                                                    { 5, 6, 1, 4, 7, 2, 9, 8, 3 },
                                                    { 1, 8, 3, 2, 4, 6, 7, 5, 9 },
                                                    { 9, 4, 6, 1, 0, 7, 2, 3, 0 },
                                                    { 2, 5, 7, 9, 3, 0, 1, 4, 6 },
                                                    { 3, 1, 5, 6, 2, 4, 8, 9, 7 },
                                                    { 8, 9, 4, 7, 1, 5, 3, 6, 2 },
                                                    { 6, 7, 2, 3, 8, 9, 4, 1, 5 }};

            Assert.False(Program.validAnswer(8, 4, 4, sudokuBoard));  
            
        }

        [Fact]
        public void validAnswerTest4()
        {       
            // Checks if 3 is a valid number when all other cells are filled
            int[,] sudokuBoard = new int[9, 9] { { 4, 2, 8, 5, 9, 3, 6, 7, 1 },
                                                    { 7, 3, 9, 8, 6, 1, 5, 2, 4 },
                                                    { 5, 6, 1, 4, 7, 2, 9, 8, 3 },
                                                    { 1, 8, 3, 2, 4, 6, 7, 0, 9 },
                                                    { 9, 4, 6, 1, 5, 7, 2, 3, 8 },
                                                    { 2, 5, 7, 9, 3, 8, 1, 4, 6 },
                                                    { 3, 1, 5, 6, 2, 4, 8, 9, 7 },
                                                    { 8, 9, 4, 7, 1, 0, 3, 0, 2 },
                                                    { 6, 7, 2, 3, 8, 9, 4, 1, 5 }};

            Assert.False(Program.validAnswer(5, 7, 7, sudokuBoard));  
            
        }

    }

}