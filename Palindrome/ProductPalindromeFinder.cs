using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class ProductPalindromeFinder : IPalindromeFinder
    {
        private IProductPalindromeChecker _palindromeChecker;

        public ProductPalindromeFinder(IProductPalindromeChecker palindromeChecker)
        {
            _palindromeChecker = palindromeChecker;
        }

        public ulong Find(int numbers, int digits)
        {
            ulong maxProduct = CalculationHelper.GetMaximumProduct(numbers, digits);
            ulong minProduct = CalculationHelper.GetMinimumProduct(numbers, digits);

            for (ulong i = maxProduct; i >= minProduct; i--)
            {
                if (_palindromeChecker.IsPalindrome(i.ToString()) && _palindromeChecker.IsProduct(i, numbers, digits))
                    return i;               
            }            
            
            throw new ArithmeticException("palindrome doesn't exist");
        }
    }
}
