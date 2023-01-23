using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(0, 1, 1, 2)]
        [InlineData(-1, -1, -1, -3)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-2, 1, 1, 0)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var c = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = c.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(3, 2, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 1, -2)]
        [InlineData(-1, -1, 0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var s = new Calculator();

            //Act
            var actual = s.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(-1, -1, 1)]
        [InlineData(-1, 0, 0)]
        [InlineData(2, 6, 12)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var m = new Calculator();
            //Act
            var actual = m.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(10, -5, -2)]
        [InlineData(6, 2, 3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var d = new Calculator();
            //Act
            var actual = d.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
