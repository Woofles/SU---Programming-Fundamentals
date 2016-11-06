using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Printing Triangle
/// </summary>
namespace Exc_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
        }
        static void PrintLine(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int input)
        {
            for (int roll = (-input) + 1; roll < input; roll++)
            {
                // it goes like 3-|-2|; 3-|-1|; 3-|0|; 3-|1|; 3-|2|;
                // where 3 is the input and the N in |N| the correction number
                // ... +1 for roll declaration can also be moved to PrintLine's input
                PrintLine(input - Math.Abs(roll));
            }
        }
    }
}
