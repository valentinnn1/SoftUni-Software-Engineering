using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2.Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string typeOfSouvenir = Console.ReadLine();
            int purchasedSouvenirs = int.Parse(Console.ReadLine());

            double sum = 0.00;

            if (country != "Argentina" && country != "Brazil" && country != "Croatia" && country != "Denmark" )
            {
                Console.WriteLine("Invalid country!");
            }
            if (typeOfSouvenir != "flags" && typeOfSouvenir != "caps" && typeOfSouvenir != "posters" && typeOfSouvenir != "stickers")
            {
                Console.WriteLine("Invalid stock!");
            }

            if (country == "Argentina" && typeOfSouvenir == "flags")
            {
                sum = purchasedSouvenirs * 3.25;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} flags of Argentina for {sum:F2} lv.");
            }
            if (country == "Argentina" && typeOfSouvenir == "caps")
            {
                sum = purchasedSouvenirs * 7.20;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} caps of Argentina for {sum:F2} lv.");
            }
            if (country == "Argentina" && typeOfSouvenir == "posters")
            {
                sum = purchasedSouvenirs * 5.10;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} posters of Argentina for {sum:F2} lv.");
            }
            if (country == "Argentina" && typeOfSouvenir == "stickers")
            {
                sum = purchasedSouvenirs * 1.25;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} stickers of Argentina for {sum:F2} lv.");
            }
            if (country == "Brazil" && typeOfSouvenir == "flags")
            {
                sum = purchasedSouvenirs * 4.20;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} flags of Brazil for {sum:F2} lv.");
            }
            if (country == "Brazil" && typeOfSouvenir == "caps")
            {
                sum = purchasedSouvenirs * 8.50;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} caps of Brazil for {sum:F2} lv.");
            }
            if (country == "Brazil" && typeOfSouvenir == "posters")
            {
                sum = purchasedSouvenirs * 5.35;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} posters of Brazil for {sum:F2} lv.");
            }
            if (country == "Brazil" && typeOfSouvenir == "stickers")
            {
                sum = purchasedSouvenirs * 1.20;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} stickers of Brazil for {sum:F2} lv.");
            }
            if (country == "Croatia" && typeOfSouvenir == "flags")
            {
                sum = purchasedSouvenirs * 2.75;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} flags of Croatia for {sum:F2} lv.");
            }
            if (country == "Croatia" && typeOfSouvenir == "caps")
            {
                sum = purchasedSouvenirs * 6.90;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} caps of Croatia for {sum:F2} lv.");
            }
            if (country == "Croatia" && typeOfSouvenir == "posters")
            {
                sum = purchasedSouvenirs * 4.95;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} posters of Croatia for {sum:F2} lv.");
            }
            if (country == "Croatia" && typeOfSouvenir == "stickers")
            {
                sum = purchasedSouvenirs * 1.10;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} stickers of Croatia for {sum:F2} lv.");
            }
            if (country == "Denmark" && typeOfSouvenir == "flags")
            {
                sum = purchasedSouvenirs * 3.10;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} flags of Denmark for {sum:F2} lv.");
            }
            if (country == "Denmark" && typeOfSouvenir == "caps")
            {
                sum = purchasedSouvenirs * 6.50;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} caps of Denmark for {sum:F2} lv.");
            }
            if (country == "Denmark" && typeOfSouvenir == "posters")
            {
                sum = purchasedSouvenirs * 4.80;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} posters of Denmark for {sum:F2} lv.");
            }
            if (country == "Denmark" && typeOfSouvenir == "stickers")
            {
                sum = purchasedSouvenirs * 0.90;
                Console.WriteLine($"Pepi bought {purchasedSouvenirs} stickers of Denmark for {sum:F2} lv.");
            }
        }
    }
}
