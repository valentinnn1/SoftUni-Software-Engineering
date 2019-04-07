using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double rentBoat = 0;
            double even = 1;

            if (fisherman % 2 == 0)
            {
                even *= 0.95;
            }

            switch (season)
            {
                case "Spring":
                    rentBoat = 3000 * even;
                    break;
                case "Summer":
                    rentBoat = 4200 * even;
                    break;
                case "Autumn":
                    rentBoat = 4200;
                    break;
                case "Winter":
                    rentBoat = 2600 * even;
                    break;
            }

            if (fisherman >= 12)
            {
                rentBoat *= 0.75;
            }
            else if (fisherman >= 7)
            {
                rentBoat *= 0.85;
            }
            else
            {
                rentBoat *= 0.90;
            }

            double moneyLeft = Math.Abs(budget - rentBoat);

            if (budget >= rentBoat)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", moneyLeft);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", moneyLeft);
            }
        }
    }
}
