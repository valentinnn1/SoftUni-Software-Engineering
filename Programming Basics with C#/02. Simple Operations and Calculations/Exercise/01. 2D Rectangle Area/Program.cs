using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 1
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Max(x1, x2) - Math.Min(x1, x2);
            double height = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine("Area = {0}", (width * height));
            Console.WriteLine("Perimeter = {0}", 2 * (width + height));

            //Вариант 2
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);

            double area = a * b;
            double perimeter = 2 * (a + b);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
