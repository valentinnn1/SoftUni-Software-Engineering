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
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int orderedSets = int.Parse(Console.ReadLine());
            double price = 0.00;

            if (fruit == "Watermelon" && size == "small")
            {
                price += 2 * 56.00;
            }
            else if (fruit == "Watermelon" && size == "big")
            {
                price += 5 * 28.70;
            }
            else if (fruit == "Mango" && size == "small")
            {
                price += 2 * 36.66;
            }
            else if (fruit == "Mango" && size == "big")
            {
                price += 5 * 19.60;
            }
            else if (fruit == "Pineapple" && size == "small")
            {
                price += 2 * 42.10;
            }
            else if (fruit == "Pineapple" && size == "big")
            {
                price += 5 * 24.80;
            }
            else if (fruit == "Raspberry" && size == "small")
            {
                price += 2 * 20.00;
            }
            else if (fruit == "Pineapple" && size == "big")
            {
                price += 5 * 15.20;
            }

            double priceForSets = price * orderedSets;
            double totalPrice = 0.00;
            double discount = 0.00;

            if (priceForSets < 400)
            {
                totalPrice = priceForSets;
                Console.WriteLine($"{totalPrice:F2} lv.");
            }
            if (priceForSets >= 400 && priceForSets <= 1000)
            {
                discount = priceForSets * 0.15;
                totalPrice = priceForSets - discount;
                Console.WriteLine($"{totalPrice:F2} lv.");
            }
            if (priceForSets > 1000)
            {
                discount = priceForSets * 0.5;
                totalPrice = priceForSets - discount;
                Console.WriteLine($"{totalPrice:F2} lv.");
            }
        }
    }
}
