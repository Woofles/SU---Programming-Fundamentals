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
            int input = int.Parse(Console.ReadLine());
            string name = LastDigitName(input);
            Console.WriteLine(name);
        }

        static string LastDigitName(int input)
        {
            int digit = input % 10;
            switch (digit)
            {
                case 1: return "one"; break;
                case 2: return "two"; break;
                case 3: return "three"; break;
                case 4: return "four"; break;
                case 5: return "five"; break;
                case 6: return "six"; break;
                case 7: return "seven"; break;
                case 8: return "eight"; break;
                case 9: return "nine"; break;
                default: return "zero"; break;
            }
        }
    }
}
