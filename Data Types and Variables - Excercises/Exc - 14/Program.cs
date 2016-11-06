using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___14
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(input, 16).ToUpper();
            string bin = Convert.ToString(input, 2).ToUpper();
            Console.WriteLine(hex);
            Console.WriteLine(bin);
        }
    }
}
