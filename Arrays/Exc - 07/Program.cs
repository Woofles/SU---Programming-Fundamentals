using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Sum Arrays
/// </summary>
namespace Exc___07
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = Math.Max(arr1.Length, arr2.Length);
            int[] arrSum = new int[max];
            for (int i = 0; i<max; i++)
            {
                arrSum[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }
            foreach (int num in arrSum) { Console.Write(num + " "); }
        }
    }
}
