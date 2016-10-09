using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Geometry Calculator
/// </summary>
namespace Exc_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "triangle":
                {
                    area_triangle();
                }break;
                case "rectangle":
                {
                    area_rectangle();
                }break;
                case "square":
                {
                    area_square();
                }break;
                case "circle":
                {
                    area_circle();
                }break;
            }
        }

        private static void area_circle()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("{0:f2}", area);
        }

        private static void area_square()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine("{0:f2}", area);
        }

        private static void area_rectangle()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double area = sideA * sideB;
            Console.WriteLine("{0:f2}", area);
        }

        private static void area_triangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height / 2;
            Console.WriteLine("{0:f2}", area);
        }
    }
}
