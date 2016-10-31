using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Enter Name of the Last Digit
/// </summary>
namespace Exc_03
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string name = LastDigitName(input);
            Console.WriteLine(name);
        }

        static string LastDigitName(long input)
        {
            long digit = Math.Abs(input) % 10;
            if (digit == 1) { return "one"; }
            else if (digit == 2) { return "two"; }
            else if (digit == 3) { return "three"; }
            else if (digit == 4) { return "four"; }
            else if (digit == 5) { return "five"; }
            else if (digit == 6) { return "six"; }
            else if (digit == 7) { return "seven"; }
            else if (digit == 8) { return "eigth"; }
            else if (digit == 9) { return "nine"; }
            else if (digit ==0) { return "zero"; }
            return "";
        }
    }
}
