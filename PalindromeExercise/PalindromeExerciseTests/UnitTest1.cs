using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("panama", false)]
        [InlineData("A man, a plan, a canal - Panama!", true)]
        public void PalindromeTest(string word, bool expected)
        {
            //Arrange, Act, Assert

            bool actual = Program.IsPalindrome(word);
            
            Assert.Equal(actual, expected);
        }
    }
}
