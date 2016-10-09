using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Cube Properties
/// </summary>
namespace Exc_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string choice = Console.ReadLine();
            double result = 0;
            switch (choice)
            {
                case "face":
                {
                    result = cube_diagonalFace(side);
                }break;
                case "space":
                {
                    result = cube_diagonalSpace(side);
                }break;
                case "volume":
                {
                    result = cube_volume(side);
                }break;
                case "area":
                {
                    result = cube_area(side);
                }break;
            }
            Console.WriteLine("{0:F2}",result);
        }
        static double cube_diagonalFace(double side)
        {
            return Math.Sqrt(2 * side * side);
        }
        static double cube_diagonalSpace(double side)
        {
            return Math.Sqrt(Math.Pow(cube_diagonalFace(side),2) + side * side);
        }
        static double cube_volume(double side)
        {
            return Math.Pow(side, 3);
        }
        static double cube_area(double side)
        {
            return side * side * 6;
        }
    }
}
