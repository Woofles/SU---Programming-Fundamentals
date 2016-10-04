using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Numbers in Reverse Order
/// </summary>
namespace Exc_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversed = ReverseString(input);
            Console.WriteLine(reversed);
        }

        private static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
