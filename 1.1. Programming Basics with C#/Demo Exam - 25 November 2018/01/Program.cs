using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSouvenirs = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());

            double fuelLiters = 4.20 * 7;
            double moneyForFuel = fuelLiters * 1.85;
            double moneyForFoodAndSouvenirs = (3 * moneyForFood) + (3 * moneyForSouvenirs);
            double discountFirstDay = moneyForHotel * 0.9;
            double discountSecondDay = moneyForHotel * 0.85;
            double discountThirdDay = moneyForHotel * 0.8;

            double totalSum = moneyForFuel + moneyForFoodAndSouvenirs + discountFirstDay + discountSecondDay + discountThirdDay;
            Console.WriteLine($"Money needed: {totalSum:F2}");
        }
    }
}
