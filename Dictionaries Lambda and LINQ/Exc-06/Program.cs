using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] roll1 = input.Take(input.Length/4).Reverse().ToArray().Concat(input.Reverse().Take(input.Length / 4).ToArray()).ToArray();
            int[] roll2 = input.Skip(input.Length / 4).Reverse().Skip(input.Length / 4).Reverse().ToArray();
            int[] output = new int[input.Length / 2];
            for (int i = 0; i < input.Length/2; i++)
            {
                output[i] = roll1[i] + roll2[i];
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
