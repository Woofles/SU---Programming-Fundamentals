using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Max Method
/// </summary>
namespace Exc_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(input1, GetMax(input2, input3)));
        }

        static int GetMax(int a, int b)
        {
            if (a >= b) { return a; }
            else return b;
        }
    }
}
