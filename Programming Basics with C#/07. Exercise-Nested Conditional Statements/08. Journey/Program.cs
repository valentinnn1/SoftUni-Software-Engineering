using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    double moneySpend = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {moneySpend:f2}");
                }
                else if (season == "winter")
                {
                    double moneySpend = budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {moneySpend:f2}");
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    double moneySpend = budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {moneySpend:f2}");
                }
                else if (season == "winter")
                {
                    double moneySpend = budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {moneySpend:f2}");
                }
            }
            else if (budget > 1000 && season == "summer" || season == "winter")
            {
                double moneySpend = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {moneySpend:f2}");
            }
        }
    }
}
