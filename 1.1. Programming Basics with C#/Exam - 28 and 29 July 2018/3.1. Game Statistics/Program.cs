using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1.Game_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            if (minutes == 0)
            {
                Console.WriteLine("Match has just began!");
            }
            if (minutes > 0 && minutes < 45)
            {
                Console.WriteLine("First half time.");
            }
            if (minutes >= 45 )
            {
                Console.WriteLine("Second half time.");
            }

            if (minutes > 0 && minutes <= 10)
            {
                Console.WriteLine($"{name} missed a penalty.");
                if (minutes % 2 == 0)
                {
                    Console.WriteLine($"{name} was injured after the penalty.");
                }
            }
            if (minutes > 10 && minutes <= 35)
            {
                Console.WriteLine($"{name} received yellow card.");
                if (minutes % 2 != 0)
                {
                    Console.WriteLine($"{name} got another yellow card.");
                }
            }
            if (minutes > 35 && minutes < 45)
            {
                Console.WriteLine($"{name} SCORED A GOAL !!!");
            }
            if (minutes > 45 && minutes <= 55)
            {
                Console.WriteLine($"{name} got a freekick.");
                if (minutes % 2 == 0)
                {
                    Console.WriteLine($"{name} missed the freekick.");
                }
            }
            if (minutes > 55 && minutes <= 80)
            {
                Console.WriteLine($"{name} missed a shot from corner.");
                if (minutes % 2 != 0)
                {
                    Console.WriteLine($"{name} has been changed with another player.");
                }
            }
            if (minutes > 80 && minutes <= 90)
            {
                Console.WriteLine($"{name} SCORED A GOAL FROM PENALTY !!!");
            }
        }
    }
}
