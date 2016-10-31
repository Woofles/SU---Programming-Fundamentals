using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Last K Numbers Sums Sequence
/// </summary>
namespace Exc_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] array = new long[n];
            array[0] = 1;
            int sum = 0;
            //
            Console.Write(array[0]);
            //
            for (int i = 1; i < n; i++)
            {
                for (int j = i-1; j>=0; j--)
                {
                    array[i] += array[j];
                    if (j == i - k) { break; }
                }
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }
    }
}
