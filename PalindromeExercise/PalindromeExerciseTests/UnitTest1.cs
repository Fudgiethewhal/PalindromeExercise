using System;
using PalindromeExercise;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here. 
        [InlineData("hello", false)]
        [InlineData("Radar", true)]
        public void FirstTest(string input, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            bool actual = test.IsAPalindrome(input);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
