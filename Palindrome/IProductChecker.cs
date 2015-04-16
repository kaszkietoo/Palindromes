using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public interface IProductChecker
    {
        bool IsProduct(ulong number, int numbers, int digits);
    }
}
