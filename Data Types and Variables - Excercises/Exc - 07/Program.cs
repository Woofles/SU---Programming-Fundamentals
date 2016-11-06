using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___07
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = int.Parse(Console.ReadLine());
            int var2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine("a = " + var1);
            Console.WriteLine("b = " + var2);
            var1 = var1 + var2;
            var2 = var1 - var2;
            var1 = var1 - var2;
            Console.WriteLine("After:");
            Console.WriteLine("a = " + var1);
            Console.WriteLine("b = " + var2);
        }
    }
}
