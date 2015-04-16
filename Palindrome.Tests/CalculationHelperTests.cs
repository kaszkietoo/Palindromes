using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Tests
{
    [TestFixture]
    public class CalculationHelperTests
    {
        [TestCase(3, 999UL)]
        [TestCase(2, 99UL)]        
        [TestCase(1, 9UL)]
        public void ShouldReturnProperMaximumNumberWithSpecificDigitsCount(int digits, ulong maxNumber)
        {
            ulong actualMaxResult = CalculationHelper.GetMaximumNumber(digits);
            Assert.AreEqual(maxNumber, actualMaxResult);            
        }

        [TestCase(3, 100UL)]
        [TestCase(2, 10UL)]
        [TestCase(1, 1UL)]
        public void ShouldReturnProperMinimumNumberWithSpecificDigitsCount(int digits, ulong minNumber)
        {
            ulong actualMinResult = CalculationHelper.GetMinimumNumber(digits);
            Assert.AreEqual(actualMinResult, minNumber);
        }
        
        [TestCase(3, 3, 999UL * 999UL * 999UL)]
        [TestCase(3, 2, 99UL * 99UL * 99UL)]
        [TestCase(2, 3, 999UL * 999UL)]
        [TestCase(2, 2, 99UL * 99UL)]
        [TestCase(1, 2, 99UL)]
        [TestCase(2, 1, 9UL * 9UL)]
        public void ShouldReturnProperMaximumProductForSpecificNumbersAndDigits(int numbers, int digits, ulong maxProduct)
        {
            ulong actualMaxProduct = CalculationHelper.GetMaximumProduct(numbers, digits);
            Assert.AreEqual(maxProduct, actualMaxProduct);
        }

        [TestCase(3, 3, 100UL * 100UL * 100UL)]
        [TestCase(3, 2, 10UL * 10UL * 10UL)]
        [TestCase(2, 3, 100UL * 100UL)]
        [TestCase(2, 2, 10UL * 10UL)]
        [TestCase(1, 2, 10UL)]
        [TestCase(2, 1, 1UL * 1UL)]
        public void ShouldReturnProperMinimumProductForSpecificNumbersAndDigits(int numbers, int digits, ulong minProduct)
        {
            ulong actualMinProduct = CalculationHelper.GetMinimumProduct(numbers, digits);
            Assert.AreEqual(minProduct, actualMinProduct);
        }

    }
}
