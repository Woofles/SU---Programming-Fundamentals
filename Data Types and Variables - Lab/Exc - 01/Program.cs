using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___01
{
    class Program
    {
        static void Main(string[] args)
        {
            int input_centuries = int.Parse(Console.ReadLine());
            int input_toYears = input_centuries * 100;
            int input_toDays = (int)(input_toYears * 365.2422);
            int input_toHours = input_toDays * 24;
            int input_toMinutes = input_toHours * 60;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", input_centuries, input_toYears, input_toDays, input_toHours, input_toMinutes);
        }
    }
}
