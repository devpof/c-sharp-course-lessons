using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

// 3 steps to Unit Testing: Arrange, Act, Assert
// expected and the actual variable names for the expected value and actual value

// Another part of TDD is: Red, Green, Refactor
// First you write a test that turns red, then you do whatever you need to turn the test
// to green and then refactor the code. By refactor, it means making the code inside the method
// better

namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        // blue icon with (!) in it will show before the 0 references
        // to tell you that this is a new test and it has not been ran.
        // Fact means that the value should be the same. This is a feature of xUnit
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Go to bed Steve";

            // Act
            string actual = messages.Greeting("Steve", 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good afternoon Steve";

            // Act
            string actual = messages.Greeting("Steve", 12);

            // Assert
            Assert.Equal(expected, actual);
        }

        // another feature of xUnit
        // Theory is like a fact except for that it has parameters that it passes data into
        [Theory]
        // with xUnit you can have InlineData or Data coming from something else.
        // pass the 3 parameters
        [InlineData("Steve", 0, "Go to bed Steve")]
        [InlineData("Steve", 5, "Good morning Steve")]

        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfTheDay,
            string expected)
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();

            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
