using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            double timeWithoutDelay = (meters * timePerMeter);
            double delay = Math.Floor(meters / 15) * 12.5;
            double ivansTime = timeWithoutDelay + delay;
            double notEnoughTime = Math.Abs(worldRecord - ivansTime);
            if (worldRecord > ivansTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {notEnoughTime:f2} seconds slower.");
            }
        }
    }
}
