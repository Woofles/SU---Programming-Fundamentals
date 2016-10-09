using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Master Numbers
/// </summary>
namespace Exc_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 1; i < range + 1; i++) 
            {
                if (isPalindrome(i) && sumDigitDiv7(i) && evenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool evenDigit(int input)
        {
            for (int i = 0; i < input.ToString().Length; i++)
            {
                if (input.ToString()[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool sumDigitDiv7(int input)
        {
            int sumDigits = 0;
            while (input>0)
            {
                sumDigits += input % 10;
                input /= 10;
            }
            return (sumDigits % 7 == 0);
        }

        private static bool isPalindrome(int input)
        {
            int inputC = input;
            int inputR = 0;
            while (inputC > 0)
            {
                inputR *= 10;
                inputR += inputC % 10;
                inputC /= 10;
            }
            return (input == inputR);
        }
    }
}
