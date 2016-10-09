using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Factorial Trailing Zeroes
/// </summary>
namespace Exc_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }
            TrailingZeroes(factorial);
        }
        static void TrailingZeroes(BigInteger input)
        {
            int result = 0;
            while (true)
            {
                if (input % 10 == 0)
                {
                    result++;
                    input /= 10;
                }
                else break;
            }
            Console.WriteLine(result);
        }
    }
}
