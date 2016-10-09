using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Longer Line
/// </summary>
namespace Exc_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] line1 = newLine();
            double[] line2 = newLine();
            if (lineLenght(line1)>= lineLenght(line2))
            {
                lineCoords(line1);
            }
            else
            {
                lineCoords(line2);
            }
        }

        /// <summary>
        /// input (x1, y1)(x2, y2)
        /// </summary>
        /// <returns></returns>
        static double[] newLine()
        {
            double[] line = new double[4];
            for (int i = 0; i < 4; i++)
            {
                line[i] = double.Parse(Console.ReadLine());
            }
            return line;
        }

        /// <summary>
        /// uses (x1, y1)(x2, y2)
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        static double lineLenght(double[] line)
        {
            double lenght;
            lenght = Math.Sqrt(Math.Pow(line[0] - line[2], 2) + Math.Pow(line[1] - line[3], 2));
            return lenght;
        }

        /// <summary>
        /// outputs (x1, y1)(x2, y2) closest one (to origin) first.
        /// </summary>
        /// <param name="line"></param>
        static void lineCoords(double[] line)
        {
            if (radius(line[0], line[1]) <= radius(line[2], line[3]))
            {
                Console.WriteLine("({0}, {1})({2}, {3})", line[0], line[1], line[2], line[3]);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", line[2], line[3], line[0], line[1]);
            }
        }

        /// <summary>
        /// returns the radius of a point (x,y) to origin
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static double radius(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
