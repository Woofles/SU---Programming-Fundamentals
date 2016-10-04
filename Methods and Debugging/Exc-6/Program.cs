using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Math Power
/// </summary>
namespace Exc_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = GetPower(input, power);
            Console.WriteLine(result);
        }

        private static double GetPower(double input, double power)
        {
            return Math.Pow(input, power);
        }
    }
}
