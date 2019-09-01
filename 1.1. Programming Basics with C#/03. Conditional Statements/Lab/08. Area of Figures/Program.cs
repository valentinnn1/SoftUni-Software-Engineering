using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(side * side);
            }
            else if (type == "triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = (side1 * h) / 2;
                Console.WriteLine(area);
            }
            else if (type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine(sideA * sideB);
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double areaOfACircle = Math.PI * radius * radius;
                Console.WriteLine($"{areaOfACircle:F3}");
            }
        }
    }
}
