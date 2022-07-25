using System;
using Xunit;
using UnitTestingExercise; 

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, -4, 3, 0)]
        [InlineData(5, 6, 0, 11)]
        [InlineData(0, 0, 0, 0)]
        //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual); 
        }

        [Theory]
        [InlineData(10, 1, 9)]//Add test data <-------
        [InlineData(-5, 1, -6)]
        [InlineData(4, 3, 1)]
        [InlineData(0, 7, -7)]
        [InlineData(3, -6, 9)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(-1, 2, -2)]
        [InlineData(4, 1, 4)]
        [InlineData(98, 1, 98)]
        [InlineData(1, 0, 0)]//Add test data <-------
        public void MultiplyTest(int number1, int number2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(number1, number2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 1, 10)]
        [InlineData(9, 2, 4)]
        [InlineData(8, 1, 8)]
        [InlineData(1, 1, 1)]
        //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
