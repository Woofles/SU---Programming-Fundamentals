using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Select(int.Parse).OrderBy(n => n).Reverse().Take(3).ToArray()));
        }
    }
}
