using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Prime Checker
/// </summary>
namespace Exc_06
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(input));
        }

        private static bool IsPrime(long input)
        {
            if (input == 0 || input == 1)
            {
                return false;
            }
            bool num_isPrime = true;
            for (int factor = 2; factor <= Math.Sqrt(input); factor++)
            {
                if (input % factor == 0)
                {
                    num_isPrime = false;
                    break;
                }
            }
            return num_isPrime;
        }
    }
}
