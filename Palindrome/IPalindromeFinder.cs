using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public interface IPalindromeFinder
    {
        ulong Find(int numbers, int digits);
    }
}
