using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            int peopleInTheGroup = 0;
            int peopleSum = 0;
            int peopleTo5 = 0;
            int peopleFrom6To12 = 0;
            int peopleFrom13To25 = 0;
            int peopleFrom26To40 = 0;
            int peopleFrom41AndMore = 0;

            for (int i = 0; i < groupsCount; i++)
            {
                peopleInTheGroup = int.Parse(Console.ReadLine());
                peopleSum += peopleInTheGroup;

                if (peopleInTheGroup <= 5)
                {
                    peopleTo5 += peopleInTheGroup;
                }
                else if (peopleInTheGroup > 5 && peopleInTheGroup <= 12)
                {
                    peopleFrom6To12 += peopleInTheGroup;
                }
                else if (peopleInTheGroup > 12 && peopleInTheGroup <= 25)
                {
                    peopleFrom13To25 += peopleInTheGroup;
                }
                else if (peopleInTheGroup > 25 && peopleInTheGroup <= 40)
                {
                    peopleFrom26To40 += peopleInTheGroup;
                }
                else if (peopleInTheGroup >= 41)
                {
                    peopleFrom41AndMore += peopleInTheGroup;
                }
            }
            double peopleToMusala = peopleTo5  * 100;
            double peopleToMonblan = peopleFrom6To12  * 100;
            double peopleToKilimandzharo = peopleFrom13To25  * 100;
            double peopleToK2 = peopleFrom26To40  * 100;
            double peopleToEverest = peopleFrom41AndMore * 100;

            Console.WriteLine($"{peopleToMusala / peopleSum:F2}%");
            Console.WriteLine($"{peopleToMonblan / peopleSum:F2}%");
            Console.WriteLine($"{peopleToKilimandzharo / peopleSum:F2}%");
            Console.WriteLine($"{peopleToK2 / peopleSum:F2}%");
            Console.WriteLine($"{peopleToEverest / peopleSum:F2}%");
        }
    }
}
