using System;

namespace Exc___16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(double.Parse(Console.ReadLine()) - double.Parse(Console.ReadLine())) < 0.000001);
        }
    }
}
