using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Day of Week
/// </summary>
namespace Exc_01
{
    class Program
    {
        static int var = 2;

        static void Main(string[] args)
        {
            int dayNum = int.Parse(Console.ReadLine());
            if (dayNum > 7 || dayNum < 0) { dayNum = 0; }
            Console.WriteLine(new string[] { "Invalid Day!", "Monday" , "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}[dayNum]);
        }
    }
}
