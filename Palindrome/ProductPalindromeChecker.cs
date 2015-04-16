using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class ProductPalindromeChecker : IProductPalindromeChecker
    {
        private IPalindromeChecker _palindromeChecker;
        private IProductChecker _productChecker;

        public ProductPalindromeChecker(IPalindromeChecker palindromeChecker, IProductChecker productChecker)
        {
            _palindromeChecker = palindromeChecker;
            _productChecker = productChecker;
        }
        public bool IsPalindrome(string candidate)
        {
            return _palindromeChecker.IsPalindrome(candidate);
        }

        public bool IsProduct(ulong number, int numbers, int digits)
        {
            return _productChecker.IsProduct(number, numbers, digits);
        }        
    }
}
