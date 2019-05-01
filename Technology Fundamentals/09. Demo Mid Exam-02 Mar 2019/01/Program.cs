using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPriceForPackage = double.Parse(Console.ReadLine());
            double eggPriceForSingleEgg = double.Parse(Console.ReadLine());
            double apronPriceForSingleApron = double.Parse(Console.ReadLine());
            int freePackages = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freePackages++;
                }
            }

            double price = apronPriceForSingleApron * (students + (Math.Ceiling(students * 0.2)))
                + eggPriceForSingleEgg * 10 * students + flourPriceForPackage * (students - freePackages);

            if (price <= budget)
            {
                Console.WriteLine($"Items purchased for {price:F2}$.");
            }
            else
            {
                Console.WriteLine($"{price - budget:F2}$ more needed.");
            }
        }
    }
}
