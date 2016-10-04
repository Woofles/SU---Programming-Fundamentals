using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Multiply Evens by Odds
/// </summary>
namespace Exc_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 0) { input *= -1; }
            int sumOdd = 0, sumEven = 0;
            while (input > 0)
            {
                if ((input % 10) % 2 == 1) { sumOdd += input % 10; }
                else sumEven += input % 10;
                input /= 10;
            }
            int result = sumOdd * sumEven;
            Console.WriteLine(result);
        }
    }
}
