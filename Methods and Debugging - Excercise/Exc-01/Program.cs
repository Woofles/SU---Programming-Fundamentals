using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Hello User
/// </summary>
namespace Exc_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            HelloUser(input);
        }

        static void HelloUser(string user)
        {
            Console.WriteLine("Hello, {0}!", user);
        }
    }
}
