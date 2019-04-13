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
            int passengersOnDeparture = int.Parse(Console.ReadLine());
            int stopsCount = int.Parse(Console.ReadLine());
            int passengersNow = passengersOnDeparture;

            for (int i = 1; i <= stopsCount; i++)
            {
                int passengersGoDown = int.Parse(Console.ReadLine());
                int passengersGoIn = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    passengersNow = (passengersNow - passengersGoDown + passengersGoIn) + 2;
                }
                if (i % 2 == 0)
                {
                    passengersNow = (passengersNow - passengersGoDown - 2) + passengersGoIn;
                }
            }
            Console.WriteLine($"The final number of passengers is : {passengersNow}");
        }
    }
}
