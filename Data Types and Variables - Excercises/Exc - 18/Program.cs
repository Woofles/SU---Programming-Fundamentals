using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___18
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            sbyte SByte;
            byte Byte;
            short Short;
            ushort UShort;
            int Int;
            uint UInt;
            long Long;

            if (long.TryParse(input, out Long))
            {
                Console.WriteLine("{0} can fit in:", input);
                if (sbyte.TryParse(input, out SByte)) { Console.WriteLine("* sbyte"); }
                if (byte.TryParse(input, out Byte)) { Console.WriteLine("* byte"); }
                if (short.TryParse(input, out Short)) { Console.WriteLine("* short"); }
                if (ushort.TryParse(input, out UShort)) { Console.WriteLine("* ushort"); }
                if (int.TryParse(input, out Int)) { Console.WriteLine("* int"); }
                if (uint.TryParse(input, out UInt)) { Console.WriteLine("* uint"); }
                Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}
