using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double time1 = double.Parse(Console.ReadLine());
            double time2 = double.Parse(Console.ReadLine());
            double time3 = double.Parse(Console.ReadLine());
            double time4 = double.Parse(Console.ReadLine());

            double time = 1 / (1/time1 + 1/time2 + 1/time3);
            double timeWithRest = time * 0.15;
            time += timeWithRest;
            double totalTime = time4 - time;

            Console.WriteLine($"Cleaning time: {time:F2}");

            if (totalTime > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(totalTime)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Abs(Math.Floor(totalTime))} hours.");
            }
        }
    }
}
