using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class CalculationHelper
    {
        public static ulong GetMaximumNumber(int digits)
        {            
            return (ulong)Math.Pow(10, digits) - 1;
        }

        public static ulong GetMinimumNumber(int digits)
        {
            return (ulong)Math.Pow(10, digits - 1);
        }

        public static ulong GetMaximumProduct(int numbers, int digits)
        {
            return (ulong)Math.Pow(((int)Math.Pow(10, digits) - 1), numbers);
        }

        public static ulong GetMinimumProduct(int numbers, int digits)
        {
            return (ulong)Math.Pow(((int)Math.Pow(10, digits - 1)), numbers);
        }
    }
}
