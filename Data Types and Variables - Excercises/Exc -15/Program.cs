using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc__15
{
    class Program
    {
        static void Main(string[] args)
        {
            int input_range = int.Parse(Console.ReadLine());
            for (int numberTested = 2; numberTested <= input_range; numberTested++)
            {
                bool primeFlag = true;
                for (int divisor = 2; divisor <= Math.Sqrt(numberTested); divisor++)
                {
                    if (numberTested % divisor == 0)
                    {
                        primeFlag = false;
                        break;
                    }
                }
                Console.WriteLine($"{numberTested} -> {primeFlag}");
            }

        }
    }
}
