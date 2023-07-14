using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("3racecar", false)]
        [InlineData("panama", false)]
        [InlineData("A3 man, a plan, a canal - Panam3a!", true)]
        public void PalindromeTest(string word, bool expected)
        {
            //Arrange, Act, Assert
            //Program prog = new Program();

            bool actual = WordSmith.IsPalindrome(word);
            
            Assert.Equal(actual, expected);
        }
    }
}
