using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитаме Целзий от потребителя.
            double celsius = double.Parse(Console.ReadLine());
            //2. Превръщаме от Целзий във Фаренхайт по формулата.
            double fahrenheit = celsius * 1.8 + 32 ;
            //3. Принтираме на конзолата.
            
            Console.WriteLine(Math.Round(fahrenheit, 2));
        }
    }
}
