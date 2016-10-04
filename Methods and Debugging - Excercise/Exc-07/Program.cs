using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Primes in Given Range
/// </summary>
namespace Exc_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int range_lower = int.Parse(Console.ReadLine());
            int range_upper = int.Parse(Console.ReadLine());
            List<int> primes = FindPrimesInRange(range_lower, range_upper);
            for (int i = 0; i<primes.Count - 1; i++)
            {
                Console.Write(primes[i] + ", ");
            }
            Console.WriteLine(primes[primes.Count - 1]);
            //foreach (var item in primes)
            //{
            //    Console.Write(item + ", ");
            //}
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primesList = new List<int>();
            while (startNum <= endNum)
            {
                if (IsPrime(startNum))
                {
                    primesList.Add(startNum);
                }
                startNum ++;
            }
            return primesList;
        }

        private static bool IsPrime(long input)
        {
            if (input == 0 || input == 1)
            {
                return false;
            }
            bool num_isPrime = true;
            for (int factor = 2; factor <= Math.Sqrt(input); factor++)
            {
                if (input % factor == 0)
                {
                    num_isPrime = false;
                    break;
                }
            }
            return num_isPrime;
        }
    }
}
