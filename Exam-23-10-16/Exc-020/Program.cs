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
            long fieldSize = long.Parse(Console.ReadLine());
            long[] field = new long[fieldSize];
            var indexesInput = Console.ReadLine().Split().Select(long
                .Parse).ToArray();
            for (int i = 0; i < field.Length; i++)
            {
                if (indexesInput.Contains(i))
                {
                    field[i] = 1;
                }
            }
            var action = Console.ReadLine().ToLower().Split();
            while (!action.Contains("end"))
            {
                var start = long.Parse(action[0]);
                if (start>=0 && start < field.Length)
                {
                    if (field[start] == 0)
                    {}
                    else
                    {
                        var shift = long.Parse(action[2]);
                        var dir = action[1];
                        if (dir == "left") { shift *= -1; }
                        var end = start + shift;
                        if ((start != end) && (end >= 0) && (end < field.Length))
                        {
                            if (field[end] == 0) { field[start] = 0; field[end] = 1; }
                            else
                            {
                                for(var i = end; i<field.Length && i>=0; i += shift)
                                {
                                    if (field[i] == 0) { field[i] = 1; break; }
                                }
                            }
                        }
                        field[start] = 0;
                    }
                }
                action = Console.ReadLine().ToLower().Split();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
