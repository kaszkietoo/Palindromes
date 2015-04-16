using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class ProductChecker : IProductChecker
    {
        public bool IsProduct(ulong number, int numbers, int digits)
        {
            ulong temp = number;
            ulong maxNumber = CalculationHelper.GetMaximumNumber(digits);
            ulong minNumber = CalculationHelper.GetMinimumNumber(digits);

            for (int k = 0; k < numbers - 1; k++)
            {
                for (ulong m = maxNumber; m >= minNumber; m--)
                {
                    if (temp % m == 0)
                    {
                        temp /= m;
                        break;
                    }
                }
            }

            return temp.ToString().Length == digits;
        }
    }
}
