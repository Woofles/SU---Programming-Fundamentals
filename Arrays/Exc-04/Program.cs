using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Triple Sum
/// </summary>
namespace Exc_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[input.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            bool hasTripple = false;
            for (int i = 0; i < arr.Length - 1; i++) 
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //for (int k = 0; k < arr.Length; k++)
                    //{
                        if (arr.Contains(arr[i]+arr[j]))
                        {
                            hasTripple = true;
                            //Console.WriteLine("{0} + {1} == {2}", arr[i], arr[j], arr[k]);
                            Console.WriteLine("{0} + {1} == {2}", arr[i], arr[j], arr[i]+arr[j]);
                        }
                    //}
                }
            }
            if (!hasTripple) { Console.WriteLine("No"); }
        }
    }
}
