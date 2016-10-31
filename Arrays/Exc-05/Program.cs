using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Rounding Numbers Away From Zero
/// </summary>
namespace Exc_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            double[] nums = array.Select(double.Parse).ToArray();
            for (int i = 0; i<nums.Length; i++)
            {
                nums[i] = Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0} => {1}", array[i], nums[i]);
            }
        }
    }
}
