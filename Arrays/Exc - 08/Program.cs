using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Condense Array of Numbers
/// </summary>
namespace Exc___08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int size = arr.Length;
            for (int i = size; i > 1; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    arr[j] += arr[j + 1];
                }
                arr[i-1] = 0;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
