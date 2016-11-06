using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc___12
{
    class Program
    {
        static void Main(string[] args)
        {
            double input_width = double.Parse(Console.ReadLine());
            double input_height = double.Parse(Console.ReadLine());

            double output_perimeter = input_width * 2 + input_height * 2;
            double output_area = input_width * input_height;
            double output_diagonal = Math.Sqrt(input_width * input_width + input_height * input_height);

            Console.WriteLine(output_perimeter);
            Console.WriteLine(output_area);
            Console.WriteLine(output_diagonal);

        }
    }
}
