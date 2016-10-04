using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Greater of Two Values
/// </summary>
namespace Exc_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputType = Console.ReadLine();
            if (inputType == "int")
            {
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                var max = GetMax(input1, input2);
                Console.WriteLine(max);
            }
            else if (inputType == "char")
            {
                char input1 = char.Parse(Console.ReadLine());
                char input2 = char.Parse(Console.ReadLine());
                var max = GetMax(input1, input2);
                Console.WriteLine(max);
            }
            else if (inputType == "string")
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                var max = GetMax(input1, input2);
                Console.WriteLine(max);
            }

        }

        static int GetMax(int input1, int input2)
        {
            if (input1 >= input2) { return input1; }
            else return input2;
        }
        static char GetMax(char input1, char input2)
        {
            if (input1 >= input2) { return input1; }
            else return input2;
        }
        static string GetMax(string input1, string input2)
        {
            if (input1.CompareTo(input2) >= 1) { return input1; }
            else return input2;
        }
    }
}
