using System;
using Dsal.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace DsalTest.String
{
    [TestClass]
    public class IsPalindromeTest
    {
        [TestMethod]
        public void IsPalindromeOnOddNumberOfCharsForPalindromeShouldWork()
        {
            "civic"
                .IsPalindrome()
                .Should()
                .BeTrue();
        }

        [TestMethod]
        public void IsPalindromeOnOddNumberOfCharsForNonPalindromeShouldWork()
        {
            "Perls"
                .IsPalindrome()
                .Should()
                .BeFalse();
        }

        [TestMethod]
        public void IsPalindromeOnEvenNumberOfCharsForPalindromeShouldWork()
        {
            "Hannah"
                .IsPalindrome()
                .Should()
                .BeTrue();
        }

        [TestMethod]
        public void IsPalindromeOnEvenNumberOfCharsForNonPalindromeShouldWork()
        {
            "Handenah"
                .IsPalindrome()
                .Should()
                .BeFalse();
        }

        [TestMethod]
        public void IsPalindromeOnSingleCharacterShouldWork()
        {
            "A"
                .IsPalindrome()
                .Should()
                .BeTrue();
        }

        [TestMethod]
        public void IsPalindromeOnEmptyStringShouldWork()
        {
            ""
                .IsPalindrome()
                .Should()
                .BeTrue();
        }
    }
}
