using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Tests
{
    [TestFixture]
    public class PalindromeCheckerTests
    {
        private IPalindromeChecker _palindromeChecker;

        public PalindromeCheckerTests()
        {
            _palindromeChecker = new PalindromeChecker();
        }

        [TestCase("1234", false)]
        [TestCase("1111", true)]
        [TestCase("9889", true)]
        [TestCase("ala", true)]
        [TestCase("erttre", true)]
        public void ShouldCheckIfStringIsPalindrome(string candidate, bool result)
        {
            bool actualCheck = _palindromeChecker.IsPalindrome(candidate);
            Assert.AreEqual(result, actualCheck);
        }        
    }
}
