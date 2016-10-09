using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Factorial
/// </summary>
namespace Exc_13
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
            Console.WriteLine(factorial);
        }
    }
}
