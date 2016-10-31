using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___06
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (char C1 = 'a'; C1 < 'a' + input; C1++)
            {
                for (char C2 = 'a'; C2 < 'a' + input; C2++)
                {
                    for (char C3 = 'a'; C3 < 'a' + input; C3++)
                    {
                        Console.WriteLine(C1 + "" + C2 + "" + C3);
                    }
                }
            }
        }
    }
}
