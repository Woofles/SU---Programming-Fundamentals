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
            var input = Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();
            SortedDictionary<double, int> dic = new SortedDictionary<double, int>();
            foreach (var num in input)
            {
                if (dic.Keys.Contains(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
