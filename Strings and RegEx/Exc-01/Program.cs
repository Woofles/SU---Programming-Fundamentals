using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exc_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"<a.*?href\s*=("".*?"").*?>(.*?)<\/a>";
            string replace = @"[URL href=$1]$2[/URL]";

            Regex regex = new Regex(pattern);

            string result = Regex.Replace(text,pattern,replace);

            Console.WriteLine(result);
        }
    }
}
