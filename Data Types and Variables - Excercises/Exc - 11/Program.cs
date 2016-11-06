using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___11
{
    class Program
    {
        static void Main(string[] args)
        {
            int input_distance = int.Parse(Console.ReadLine());
            int input_hours = int.Parse(Console.ReadLine());
            int input_minutes = int.Parse(Console.ReadLine());
            int input_seconds = int.Parse(Console.ReadLine());

            TimeSpan time = new TimeSpan(input_hours, input_minutes, input_seconds);

            double speed_mps = input_distance / time.TotalSeconds;
            double speed_kmph = (input_distance / 1000d) / time.TotalHours;
            double speed_Mph = (input_distance / 1609d) / time.TotalHours;

            Console.WriteLine("{0:f6}", speed_mps);
            Console.WriteLine("{0:f6}", speed_kmph);
            Console.WriteLine("{0:f6}", speed_Mph);
        }
    }
}
