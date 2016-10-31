using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___04
{
    class Program
    {
        static void Main(string[] args)
        {
            int personCount = int.Parse(Console.ReadLine());
            decimal elevatorCap = int.Parse(Console.ReadLine());
            decimal courseCount = Math.Ceiling(personCount / elevatorCap);
            Console.WriteLine(courseCount);
        }
    }
}
