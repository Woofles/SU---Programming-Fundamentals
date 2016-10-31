using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Reverse an Array of Strings
/// </summary>
namespace Exc_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length/2; i++)
            {
                string temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
            foreach (string el in input) { Console.Write(el + " "); }
        }
    }
}
