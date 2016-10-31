using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Reverse and Array of Integers
/// </summary>
namespace Exc_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i<size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
