using System;
using Xunit;

namespace ProgramTests
{
    public class FindEmptyCellsTests
    {
        [Fact]
        public void findsCellTest1()
        {
            int[,] sudokuBoard = new int[9, 9] { { 0, 0, 0, 0, 0, 5, 4, 6, 9 },
                                                    { 0, 0, 0, 7, 0, 0, 3, 0, 5 },
                                                    { 0, 0, 0, 6, 2, 0, 1, 0, 0 },
                                                    { 0, 0, 3, 1, 0, 2, 6, 0, 0 },
                                                    { 0, 0, 0, 5, 0, 0, 0, 0, 7 },
                                                    { 9, 0, 0, 0, 3, 0, 2, 0, 0 },
                                                    { 0, 0, 0, 0, 6, 0, 7, 0, 0 },
                                                    { 0, 0, 0, 0, 0, 0, 9, 4, 0 },
                                                    { 0, 0, 6, 3, 0, 1, 0, 0, 0 }}; 
            
            int[] expected_position = {0, 0};
            int[] position = Program.findsEmptyCell(sudokuBoard);
            
            Assert.Equal(expected_position[0], position[0]);
            Assert.Equal(expected_position[1], position[1]);
        }

        [Fact]
        public void findsCellTest2()
        {
            int[,] sudokuBoard = new int[9, 9] { { 1, 2, 3, 4, 5, 5, 4, 6, 9 },
                                                    { 1, 1, 1, 7, 1, 1, 3, 1, 5 },
                                                    { 1, 1, 1, 6, 2, 1, 1, 1, 1 },
                                                    { 1, 1, 3, 1, 1, 2, 6, 1, 1 },
                                                    { 1, 1, 1, 5, 1, 1, 1, 1, 7 },
                                                    { 9, 1, 1, 1, 3, 1, 2, 1, 1 },
                                                    { 1, 1, 1, 1, 6, 1, 7, 1, 1 },
                                                    { 1, 1, 1, 1, 1, 1, 9, 4, 1 },
                                                    { 1, 1, 6, 3, 1, 1, 1, 1, 0 }}; 
            
            int[] expected_position = {8, 8};
            int[] position = Program.findsEmptyCell(sudokuBoard);
            
            Assert.Equal(expected_position[0], position[0]);
            Assert.Equal(expected_position[1], position[1]);
        }

        [Fact]
        public void findsCellTest3()
        {
            int[,] sudokuBoard = new int[9, 9] { { 1, 2, 3, 4, 5, 5, 4, 6, 9 },
                                                    { 1, 1, 1, 7, 1, 1, 3, 1, 5 },
                                                    { 1, 1, 1, 6, 2, 1, 1, 1, 1 },
                                                    { 1, 1, 3, 1, 1, 2, 6, 1, 1 },
                                                    { 1, 1, 1, 5, 1, 1, 1, 1, 7 },
                                                    { 9, 1, 1, 1, 3, 1, 2, 1, 1 },
                                                    { 1, 1, 1, 1, 6, 1, 7, 1, 1 },
                                                    { 1, 1, 1, 1, 1, 1, 9, 4, 1 },
                                                    { 1, 1, 6, 3, 1, 1, 1, 1, 1 }}; 
            
            int[] expected_position = {-1, -1};
            int[] position = Program.findsEmptyCell(sudokuBoard);
            
            Assert.Equal(expected_position[0], position[0]);
            Assert.Equal(expected_position[1], position[1]);
        }
    }

}
