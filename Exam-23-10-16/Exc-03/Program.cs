using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exc_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string patternDMG = @"(\d.\d|\d)";
            Regex regDMG = new Regex(patternDMG);
            string patternMUL = @"\*";
            Regex regMUL = new Regex(patternMUL);
            Match matchDMG = regDMG.Match(input[0]);
            Console.WriteLine(matchDMG.Groups);
            foreach (Match item in matchDMG.Groups)
            {
                Console.WriteLine(item);
            }
        }
    }
}
