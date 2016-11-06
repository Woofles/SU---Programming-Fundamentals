using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte var1_Centuries = byte.Parse(Console.ReadLine());
            int var2_Years = var1_Centuries * 100;
            int var3_Days = (int)(var2_Years * 365.2422);
            int var4_Hours = var3_Days * 24;
            long var5_Minutes = var4_Hours * 60;
            long var6_Seconds = var5_Minutes * 60;
            long var7_Milliseconds = var6_Seconds * 1000;
            long var8_Microseconds = var7_Milliseconds * 1000;
            decimal var9_Nanoseconds = var8_Microseconds * 1000m;

            Console.Write("{0} centuries = ", var1_Centuries);
            Console.Write("{0} years = ", var2_Years);
            Console.Write("{0} days = ", var3_Days);
            Console.Write("{0} hours = ", var4_Hours);
            Console.Write("{0} minutes = ", var5_Minutes);
            Console.Write("{0} seconds = ", var6_Seconds);
            Console.Write("{0} milliseconds = ", var7_Milliseconds);
            Console.Write("{0} microseconds = ", var8_Microseconds);
            Console.WriteLine("{0} nanoseconds", var9_Nanoseconds);

        }
    }
}
