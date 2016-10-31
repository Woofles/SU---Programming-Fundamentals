using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var item in input)
            {
                if (dict.Keys.Contains(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            List<string> result = new List<string>();
            foreach (var item in dict)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key.ToString());
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
