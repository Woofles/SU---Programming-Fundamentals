using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___09
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool isPrime = false;
            for (int counter = 1; counter <= input; counter++)
            {
                int sum = 0;
                int current = counter;
                while (current > 0)
                {
                    sum += current % 10;
                    current = current / 10;
                }
                isPrime = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{counter} -> {isPrime}");
            }
        }
    }
}
