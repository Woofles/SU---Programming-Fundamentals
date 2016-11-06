using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirst = Console.ReadLine();
            string nameLast = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long ID = long.Parse(Console.ReadLine());
            uint UEN = uint.Parse(Console.ReadLine());
            Console.WriteLine("First name: " + nameFirst);
            Console.WriteLine("Last name: " + nameLast);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + ID);
            Console.WriteLine("Unique Employee number: " + UEN);
        }
    }
}
