using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___05
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int dummy = i;
                while (dummy != 0)
                {
                    sum += dummy % 10;
                    dummy /= 10;
                }
                Console.WriteLine("{0} -> {1}", i, (sum == 5 || sum == 7 || sum == 11));
            }
        }
    }
}
