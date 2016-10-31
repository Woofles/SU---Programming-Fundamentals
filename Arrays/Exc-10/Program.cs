using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Remove Negatives and Reverse
/// </summary>
namespace Exc_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> list = new List<int>();
            foreach (var i in arr)
            {
                if (i>0)
                {
                    list.Add(i);
                }
            }
            for (int k = list.Count - 1; k >= 0; k--)
            {
                Console.Write(list[k] + " ");
            }
            if (list.Count == 0) { Console.WriteLine("empty"); }
            else { Console.WriteLine(); }
        }
    }
}
