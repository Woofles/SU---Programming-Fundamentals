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
            int fieldSize = int.Parse(Console.ReadLine());
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
            //
            string action = Console.ReadLine().ToLower();
            //
            while (!action.Equals("end"))
            {
                var command = action.Split().ToArray();
                long start = long.Parse(command[0]);
                string dir = command[1].ToString();
                long shift = long.Parse(command[2]);
                //
                if (dir.Equals("left")) { shift *= -1; }
                long end = start + shift;
                //
                if (start >= 0 && start < field.Length)
                {
                    if (end >= 0 && end < field.Length)
                    {
                        if (field[end] == 0) { field[end] = 1; }
                        else
                        {
                            while (field[end]==1)
                            {
                                if (end + shift >=0 && end + shift < field.Length)
                                {
                                    if (field[end+shift] == 0)
                                    {
                                        field[end+shift] = 1;
                                        break;
                                    }
                                    else { end += shift; }
                                }
                                else { break; }
                            }
                            field[end] = 1;
                        }
                    }
                    field[start] = 0;
                }
                //
                action = Console.ReadLine().ToLower();
            }
            //
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
