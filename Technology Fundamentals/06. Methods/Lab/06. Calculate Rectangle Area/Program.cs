using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double area = RectangleArea(a, b);
            Console.WriteLine(area);
        }

        static double RectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
