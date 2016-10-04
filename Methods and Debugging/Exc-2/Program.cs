using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Sign of Integer Number
/// </summary>
namespace Exc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintSign(input);
        }
        static void PrintSign(int input)
        {
            if (input < 0) { Console.WriteLine("The number {0} is negative.", input); }
            if (input > 0) { Console.WriteLine("The number {0} is positive.", input); }
            if (input == 0) { Console.WriteLine("The number {0} is zero.", input); }
        }
    }
}
