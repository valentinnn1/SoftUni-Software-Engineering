using System;

namespace _02.Going_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int fuelCostFor100km = int.Parse(Console.ReadLine());
            double priceForOneLiterFuel = double.Parse(Console.ReadLine());
            double moneyWin = double.Parse(Console.ReadLine());

            double moneyNeeded = priceForOneLiterFuel * fuelCostFor100km * distance / 100;

            if (moneyWin >= moneyNeeded)
            {
                Console.WriteLine($"You can go home. {moneyWin - moneyNeeded:F2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {(moneyWin / 5):F2} money.");
            }
        }
    }
}
