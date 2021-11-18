using System;
using Xunit;

namespace ProgramTests
{
    public class GetBoxCoordinateTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void getBoxCoordinateTest1(int coordinate)
        {       
            Assert.Equal(0, Program.getBoxCoordinate(coordinate));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void getBoxCoordinateTest2(int coordinate)
        {       
            Assert.Equal(3, Program.getBoxCoordinate(coordinate));
        }

        [Theory]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void getBoxCoordinateTest3(int coordinate)
        {       
            Assert.Equal(6, Program.getBoxCoordinate(coordinate));
        }

    }

}
