using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Multiply Evens by Odds
/// </summary>
namespace Exc_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 0) { input *= -1; }
            int sumEven = getDigitsSumEven(input);
            int sumOdd = getDigitsSumOdd(input);
            int result = getDigitsSumEven(input) * getDigitsSumOdd(input);
            Console.WriteLine(result);
        }

        private static int getDigitsSumOdd(int input)
        {
            int result = 0;
            while (input > 0)
            {
                if ((input%10)%2 == 1)
                {
                    result += input % 10;
                }
                input /= 10;
            }
            return result;
        }

        private static int getDigitsSumEven(int input)
        {
            int result = 0;
            while (input > 0)
            {
                if ((input % 10) % 2 == 0)
                {
                    result += input % 10;
                }
                input /= 10;
            }
            return result;
        }
    }
}
