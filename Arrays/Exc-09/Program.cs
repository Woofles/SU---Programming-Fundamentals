using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Extract Middle 1, 2 or 3 Elements
/// </summary>
namespace Exc_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = arr.Length;
            if (length == 1)
            {
                Console.WriteLine("{ " + arr[0] + " }");
            }
            else
            {
                Console.Write("{");
                for (int i = length/2 -1; i <=length/2 + length % 2; i++)
                {
                    Console.Write(" {0}", arr[i]);
                    if (i < length/2 + length%2) { Console.Write(","); }
                }
            }
            Console.WriteLine(" }");
        }
    }
}
