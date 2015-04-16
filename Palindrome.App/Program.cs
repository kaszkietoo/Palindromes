using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IPalindromeFinder finder = 
                new ProductPalindromeFinder(new ProductPalindromeChecker(new PalindromeChecker(), new ProductChecker()));

            string numbersCount, digitsCount;
            int numbers, digits;

            Console.WriteLine("Please type numbers count and press Enter");
            numbersCount = Console.ReadLine();            
            if (!int.TryParse(numbersCount, out numbers))
            {
                throw new ArgumentException("number count should be an integer number!");
            }

            Console.WriteLine("Please type digits count and press Enter");
            digitsCount = Console.ReadLine();            
            if (!int.TryParse(numbersCount, out digits))
            {
                throw new ArgumentException("digits count should be an integer number!");
            }

            Console.WriteLine("I'm looking for greatest palindrome...");

            Console.WriteLine("Greatest palindrome is {0}.", finder.Find(numbers, digits));
        }
    }
}
