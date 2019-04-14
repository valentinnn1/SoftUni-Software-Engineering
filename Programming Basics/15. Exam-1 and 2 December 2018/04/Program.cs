using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodBought = int.Parse(Console.ReadLine());
            int foodBoughtInGrams = foodBought * 1000;
            int foodSum = 0;

            while (true)
            {
                string foodEatenToString = Console.ReadLine();

                if (foodEatenToString == "Adopted")
                {
                    break;
                }
                int foodEaten = int.Parse(foodEatenToString);
                foodSum += foodEaten;
            }
            if (foodSum <= foodBoughtInGrams)
            {
                int foodLeft = foodBoughtInGrams - foodSum;
                Console.WriteLine($"Food is enough! Leftovers: {foodLeft} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodSum - foodBoughtInGrams} grams more.");
            }
        }
    }
}
