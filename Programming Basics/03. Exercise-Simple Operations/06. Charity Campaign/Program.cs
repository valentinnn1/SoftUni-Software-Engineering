using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int sweets = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePrice = cakes * 45;
            double wafflesPrice = waffles * 5.80;
            double pancakesPrice = pancakes * 3.20;

            double moneyFor1day = (cakePrice + wafflesPrice + pancakesPrice) * sweets;
            double allMoney = moneyFor1day * days;
            double result = allMoney - 0.125 * allMoney;

            Console.WriteLine($"{result:f2}");
        }
    }
}
