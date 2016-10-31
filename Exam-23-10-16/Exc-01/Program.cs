using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_01
{
    class Program
    {
        static void Main(string[] args)
        {
            long daysCount = long.Parse(Console.ReadLine());
            long runnersCount = long.Parse(Console.ReadLine());
            long avrgLapsRunner = long.Parse(Console.ReadLine());
            long lapLength = long.Parse(Console.ReadLine());
            long lapCapacity = long.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());
            //
            long runnersFinal = 0;
            for (int i = 1; i <= daysCount; i++)
            {
                if (runnersCount > lapCapacity)
                {
                    runnersFinal += lapCapacity;
                    runnersCount -= lapCapacity;
                }
                else
                {
                    runnersFinal += runnersCount;
                    break;
                }
            }
            {

            }
            //
            long totalMeters = runnersFinal * avrgLapsRunner * lapLength;
            long totalKm = totalMeters / 1000;
            double moneyRaised = totalKm * moneyPerKm;

            Console.WriteLine("Money raised: {0:F2}", moneyRaised);
        }
    }
}
