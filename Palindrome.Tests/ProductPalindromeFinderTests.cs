using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Tests
{
    [TestFixture]
    public class ProductPalindromeFinderTests
    {       
        [TestCase(3, 2, "828828")]
        [TestCase(3, 1, "343")]
        [TestCase(2, 3, "906609")]
        [TestCase(2, 4, "99000099")]
        [TestCase(2, 2, "9009")]
        [TestCase(1, 3, "999")]
        [TestCase(3, 1, "343")]
        public void ShouldReturnGreatestPalindromeForGivenNumbersAndDigits(int numbers, int digits, string result)
        {
            var palindromeChecker = new Mock<IProductPalindromeChecker>();
            palindromeChecker.Setup(e => e.IsPalindrome(result)).Returns(true);
            palindromeChecker.Setup(e => e.IsProduct(ulong.Parse(result), numbers, digits)).Returns(true);
            var palindromeFinder = new ProductPalindromeFinder(palindromeChecker.Object);

            ulong palindrome = palindromeFinder.Find(numbers, digits);

            Assert.AreEqual(result, palindrome.ToString());
        }
    }
}
