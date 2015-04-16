using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Tests
{
    [TestFixture]
    public class ProductCheckerTests
    {
        private IProductChecker _productChecker;
        public ProductCheckerTests()
        {
            _productChecker = new ProductChecker();
        }

        [TestCase(9889UL, 2, 2, false)]
        [TestCase(9009UL, 2, 2, true)]
        public void ShouldCheckIfNumberIsProductOfDigitsNumbers(ulong number, int numbers, int digits, bool result)
        {
            bool actualCheck = _productChecker.IsProduct(number, numbers, digits);
            Assert.AreEqual(result, actualCheck);
        }
    }
}
