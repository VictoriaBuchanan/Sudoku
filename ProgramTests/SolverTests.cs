using System;
using Xunit;

namespace ProgramTests
{
    public class SolverTests
    {
        [Fact]
        public void SolverTest1()
        {       
            int[,] sudokuBoard = new int[9, 9]    { { 6, 5, 4, 9, 3, 8, 1, 7, 4 },
                                                    { 3, 7, 2, 6, 4, 1, 5, 8, 9 },
                                                    { 1, 8, 9, 5, 2, 7, 3, 6, 4 },
                                                    { 7, 3, 1, 4, 9, 6, 8, 2, 5 },
                                                    { 9, 6, 5, 8, 7, 2, 4, 3, 1 },
                                                    { 2, 4, 8, 1, 5, 3, 6, 9, 7 },
                                                    { 5, 9, 6, 7, 8, 4, 2, 1, 3 },
                                                    { 4, 1, 3, 2, 6, 9, 7, 5, 8 },
                                                    { 8, 2, 7, 3, 1, 5, 9, 4, 6 }};

            Assert.True(Program.solver(sudokuBoard));  
            
        }

        [Fact]
        public void SolverTest2()
        {       
            int[,] sudokuBoard = new int[9, 9]    { { 6, 0, 4, 0, 3, 8, 0, 0, 0 },
                                                    { 0, 7, 0, 0, 0, 0, 5, 8, 0 },
                                                    { 0, 0, 0, 0, 0, 0, 0, 0, 4 },
                                                    { 7, 3, 0, 0, 0, 0, 0, 0, 5 },
                                                    { 0, 0, 0, 0, 0, 2, 4, 0, 1 },
                                                    { 0, 0, 8, 1, 5, 0, 0, 0, 7 },
                                                    { 0, 9, 0, 7, 0, 0, 2, 0, 0 },
                                                    { 0, 0, 0, 0, 6, 0, 0, 0, 0 },
                                                    { 8, 2, 0, 0, 0, 0, 9, 4, 0 }};

            Assert.True(Program.solver(sudokuBoard));  
            
        }

    }

}