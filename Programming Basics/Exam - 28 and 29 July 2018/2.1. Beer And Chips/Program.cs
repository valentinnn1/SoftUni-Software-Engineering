using System;

namespace _2._1.Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerBottles = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            double totalBeerPrice = 1.20 * beerBottles;
            double chipsPackets = totalBeerPrice * 0.45;
            double totalChipsPrice = chipsPackets * chipsCount;
            double totalSum = totalBeerPrice + Math.Ceiling(totalChipsPrice);

            if (budget >= totalSum)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget - totalSum):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {(totalSum - budget):F2} more leva!");
            }
        }
    }
}