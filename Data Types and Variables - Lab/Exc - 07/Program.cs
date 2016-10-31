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
            var nameFirst = Console.ReadLine();
            var nameLast = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {nameFirst} {nameLast}. You are {age} years old.");
        }
    }
}
