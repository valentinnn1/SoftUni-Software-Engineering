using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитаме b1, b2 и h от потребителя
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //2. Изчисляваме лицето на трапеца
            double area = (b1 + b2) * h / 2;

            //3. Принтираме на конзолата
            Console.WriteLine(area);
        }
    }
}
