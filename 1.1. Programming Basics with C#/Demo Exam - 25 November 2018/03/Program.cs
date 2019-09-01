using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double price = 0.00;

            if (restaurant != "Sushi Zone" && restaurant != "Sushi Time" && restaurant != "Sushi Bar" && restaurant != "Asian Pub")
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!"); return;
            }

            if (sushi == "sashimi" && restaurant == "Sushi Zone")
            {
                price += 4.99;
            }
            if (sushi == "sashimi" && restaurant == "Sushi Time")
            {
                price += 5.49;
            }
            if (sushi == "sashimi" && restaurant == "Sushi Bar")
            {
                price += 5.25;
            }
            if (sushi == "sashimi" && restaurant == "Asian Pub")
            {
                price += 4.50;
            }

            if (sushi == "maki" && restaurant == "Sushi Zone")
            {
                price += 5.29;
            }
            if (sushi == "maki" && restaurant == "Sushi Time")
            {
                price += 4.69;
            }
            if (sushi == "maki" && restaurant == "Sushi Bar")
            {
                price += 5.55;
            }
            if (sushi == "maki" && restaurant == "Asian Pub")
            {
                price += 4.80;
            }

            if (sushi == "uramaki" && restaurant == "Sushi Zone")
            {
                price += 5.99;
            }
            if (sushi == "uramaki" && restaurant == "Sushi Time")
            {
                price += 4.49;
            }
            if (sushi == "uramaki" && restaurant == "Sushi Bar")
            {
                price += 6.25;
            }
            if (sushi == "uramaki" && restaurant == "Asian Pub")
            {
                price += 5.50;
            }

            if (sushi == "temaki" && restaurant == "Sushi Zone")
            {
                price += 4.29;
            }
            if (sushi == "temaki" && restaurant == "Sushi Time")
            {
                price += 5.19;
            }
            if (sushi == "temaki" && restaurant == "Sushi Bar")
            {
                price += 4.75;
            }
            if (sushi == "temaki" && restaurant == "Asian Pub")
            {
                price += 5.50;
            }

            double priceForPortions = portions * price;
            if (symbol == 'Y')
            {
                double moneyForDelivery = priceForPortions * 0.2;
                priceForPortions += moneyForDelivery;
            }
            double totalPrice = Math.Ceiling(priceForPortions);
            Console.WriteLine($"Total price: {totalPrice} lv.");
        }
    }
}
