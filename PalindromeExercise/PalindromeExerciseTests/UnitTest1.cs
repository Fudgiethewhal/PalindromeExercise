using System;
using System.Collections.Generic;
using PalindromeExercise;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here. 
        [InlineData("hello", false)]
        // For example [InlineData(“racecar”, true)]
        public void TestOne (string input, bool expected);
        //Arrange
        var test = new WordSmith();

        //Act
        var actual = test.IsAPalindrome(input);

        //Assert
        Assert.Equal(expected, actual);
    }
}
