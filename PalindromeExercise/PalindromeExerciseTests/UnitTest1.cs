using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("tacocat", true)]
        [InlineData("coder", false)]
        public void Test1(string word, bool expected)
        {
            var str = new WordSmith();
            var actual = str.IsPalindrome(word);
            Assert.Equal(expected, actual);






            
            
        }
        
    }
}
