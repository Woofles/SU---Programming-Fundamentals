using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Draw a Filled Square
/// </summary>
namespace Exc_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintBase(input);
            PrintFill(input);
            PrintBase(input);

        }
        static void PrintBase(int input)
        {
            Console.WriteLine(new string('-', input * 2));
        }
        static void PrintFill(int input)
        {
            //Starting from the second roll and printing up to last-1
            for (int roll=2; roll<input; roll++)
            {
                Console.Write("-");
                //Prints one-less-than-input times "\\/"
                for (int j = 0; j < input - 1; j++) { Console.Write("\\/"); }
                Console.WriteLine("-");
            }
        }
    }
}
