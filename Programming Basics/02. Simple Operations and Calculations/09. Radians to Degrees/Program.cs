using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитаме ъгъл в радиани от потребителя.
            double a = double.Parse(Console.ReadLine());
            //2. Превръщаме от Радиани във Градуси по формулата.
            double b = a * 180 / Math.PI;
            //3. Принтираме на конзолата.
            Console.WriteLine(Math.Round(b));
        }
    }
}
