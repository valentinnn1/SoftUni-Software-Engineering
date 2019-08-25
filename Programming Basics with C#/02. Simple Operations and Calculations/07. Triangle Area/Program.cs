using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитаме a и ha от потребителя.
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            //2. Изчисляваме лицето на триъгълника.
            double area = a * ha / 2;
            //3. Принтираме на конзолата.
            Console.WriteLine($"Triangle area = {area:F2}.");
        }
    }
}
