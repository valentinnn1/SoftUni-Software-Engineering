using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Да прочетем дължина, широчина и височината и процентите.
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;

            //2. Трябва да намерим обема на аквариума.
            int volume = length * width * height;
            double liters = volume * 0.001;

            //3. Трябва да изчислим колко литра събира аквариума.
            double litersNeeded = liters - (liters * percentage);

            //4. Да изпринтираме литрите вода, които ще  събира аквариума, форматирани до третия знак след десетичната запетая
            Console.WriteLine($"{litersNeeded:F3}");
        }
    }
}
