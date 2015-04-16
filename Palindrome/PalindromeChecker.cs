using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class PalindromeChecker : IPalindromeChecker
    {
        public bool IsPalindrome(string candidate)
        {
            if (string.IsNullOrEmpty(candidate))
                return false;
            
            string fromStart = null;
            string fromEnd = null;
            StringBuilder builder = new StringBuilder();
            for (int j = 0; j < candidate.Length; j++)
            {
                builder.Append(candidate[j]);
            }

            fromStart = builder.ToString();
            builder.Clear();

            for (int j = candidate.Length - 1; j >= 0; j--)
            {
                builder.Append(candidate[j]);
            }

            fromEnd = builder.ToString();

            return fromStart.Equals(fromEnd, StringComparison.OrdinalIgnoreCase);
        }
    }
}
