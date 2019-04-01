using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int teddy = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double pricePuzzle = puzzle * 2.6;
            double priceDoll = doll * 3;
            double priceTeddy = teddy * 4.1;
            double priceMinion = minion * 8.2;
            double priceTruck = truck * 2;


            double toys = puzzle + doll + teddy + minion + truck;
            double grossMoney = pricePuzzle + priceDoll + priceTeddy + priceMinion + priceTruck;
            double discount = 0;

            if (toys >= 50)
            {
                discount = 0.25;
            }

            double discountMoney = grossMoney * (1 - discount);
            double nettMoney = discountMoney * 0.9;

            if (nettMoney >= priceTrip)
            {
                Console.WriteLine($"Yes! {nettMoney - priceTrip:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceTrip - nettMoney:f2} lv needed.");
            }
        }
    }
}
