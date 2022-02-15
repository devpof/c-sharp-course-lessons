using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

/*
 * My own tests
 */
namespace MathLibrary.Tests
{
    public class MathOperationsTests
    {
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(0, 1, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(0.00, 0.00, 0.00)]
        [InlineData(1.1, 1.1, 2.2)]
        [InlineData(1.12, 1.1, 2.22)]
        [InlineData(1.99, 2.99, 4.98)]
        [InlineData(-4, -6, -10.00)]
        [InlineData(-4, 10, 6)]
        public void AdditionShouldReturnExpectedValue(
            double firstNumber,
            double secondNumber,
            double expected)
        {
            // Arrange
            MathOperations operation = new MathOperations();

            //Act
            double actual = operation.Add(firstNumber, secondNumber);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(1, -1, 2)]
        [InlineData(4.9, 5.3, -0.4)]
        [InlineData(-10, 5, -15)]
        [InlineData(10, 5, 5)]
        [InlineData(-10, -5, -5)]
        [InlineData(-10.98, 5.63, -16.61)]
        [InlineData(10.98, 5.63, 5.35)]
        public void SubtractionShouldReturnExpectedValue(
            double minuend,
            double subtrahend,
            double expected)
        {
            // Arrange
            MathOperations operation = new MathOperations();

            //Act
            double actual = operation.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(1, -1, -1)]
        [InlineData(4.9, 5.3, 25.97)]
        [InlineData(-10, 5, -50)]
        [InlineData(10, 5, 50)]
        [InlineData(-10, -5, 50)]
        [InlineData(-10.98, 5.63, -61.82)]
        [InlineData(10.98, 5.63, 61.82)]
        public void MultiplicationShouldReturnExpectedValue(
            double multiplicand,
            double multiplier,
            double expected)
        {
            // Arrange
            MathOperations operation = new MathOperations();

            //Act
            double actual = operation.Multiply(multiplicand, multiplier);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(5, 5, 1)]
        [InlineData(10, 2, 5)]
        [InlineData(10, 3, 3.33)]
        [InlineData(4.93, 5.62, 0.88)]
        [InlineData(-9, 3, -3)]
        [InlineData(-9, -3, 3)]

        public void DivisionShouldReturnExpectedValue(
            double dividend,
            double divisor,
            double expected)
        {
            // Arrange
            MathOperations operation = new MathOperations();

            //Act
            double actual = operation.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
