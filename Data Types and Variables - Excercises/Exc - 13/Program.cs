using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___13
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine().ToLower());

            if (input == 'a' || input == 'o' || input == 'i' || input == 'e' || input == 'u') 
            {
                Console.WriteLine("vowel");
            }
            else if (input >= '0' && input <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
