using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point() { X = 5, Y = 7 };
            Console.WriteLine("Point({0}, {1})", p.X, p.Y);
            
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

    }
}
