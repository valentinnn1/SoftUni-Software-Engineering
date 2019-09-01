using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int daysForStudy = int.Parse(Console.ReadLine());

            double percentStepsForADay = Math.Ceiling(((double)steps / daysForStudy) / steps * 100);


            double percentStepsForDancer = (percentStepsForADay / dancers);


            if (percentStepsForADay <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0}%.", Math.Round(percentStepsForDancer));
            }
            else if (percentStepsForADay > 13)
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0}% steps to be learned per day.", Math.Round(percentStepsForDancer));
            }
        }
    }
}
