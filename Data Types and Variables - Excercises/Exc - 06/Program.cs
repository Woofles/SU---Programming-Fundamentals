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
            string var1 = Console.ReadLine();
            string var2 = Console.ReadLine();
            object var3 = var1 + " " + var2;
            string var4 = (string)var3;
            Console.WriteLine(var4);
        }
    }
}
