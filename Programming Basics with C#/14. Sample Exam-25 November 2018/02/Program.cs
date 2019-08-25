using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double avgHeight = double.Parse(Console.ReadLine());

            double volumeRacket = w * l * h;
            double volumeRoom = (avgHeight + 0.40) * 2 * 2;
            double humans = Math.Floor(volumeRacket / volumeRoom);

            if (humans < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            if (humans >= 3 && humans <= 10)
            {
                Console.WriteLine($"The spacecraft holds {humans} astronauts.");
            }
            if (humans > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
