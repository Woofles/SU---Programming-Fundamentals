using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Fibbonaci Numbers
/// </summary>
namespace Exc_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = FibbonaciGet_linear(input);
            Console.WriteLine(result);
        }
        /// <summary>
        /// Returns the N'th Fibbonaci number F(N), starting from F(0)=1 and F(1)=1;
        /// Calculation is recursive.
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        private static int FibbonaciGet_recursive(int N)
        {
            switch (N)
            {
                case 0: return 1;
                case 1: return 1;
                default: return FibbonaciGet_recursive(N - 2) + FibbonaciGet_recursive(N - 1);
            }
        }
        /// <summary>
        /// Returns the N'th Fibbonaci number F(N), starting from F(0)=1 and F(1)=1;
        /// Calculation is linear.
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        private static int FibbonaciGet_linear(int N)
        {
            int a = 1, b = 1;
            int result = 0;
            for (int i = 0; i <= N; i++)
            {
                result = a;
                b = a + b;
                a = b - a;
            }
            return result;
        }
    }
}
