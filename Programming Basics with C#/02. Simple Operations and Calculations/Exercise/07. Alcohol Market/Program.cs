using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);
            double rakiaSum = rakia * rakiaPrice;
            double wineSum = wine * winePrice;
            double beerSum = beer * beerPrice;
            double whiskeySum = whiskeyPrice * whiskey;

            double result = rakiaSum + wineSum + beerSum + whiskeySum;
            Console.WriteLine($"{result:f2}");
        }
    }
}
