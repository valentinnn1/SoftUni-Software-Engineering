using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int balloonCounter = 0;
            int flowersCounter = 0;
            int candlesCounter = 0;
            int ribbonCounter = 0;
            double spendMoney = 0.00;
            string stock = string.Empty;

            while (true)
            {
                stock = Console.ReadLine();
                if (stock == "stop")
                {
                    Console.WriteLine($"Spend money: {spendMoney:F2}");
                    Console.WriteLine($"Money left: {budget - spendMoney:F2}");
                    Console.WriteLine($"Purchased decoration is {balloonCounter} balloons, {ribbonCounter} m ribbon, {flowersCounter} flowers and {candlesCounter} candles.");
                    break;
                }
                int count = int.Parse(Console.ReadLine());

                if (stock == "balloons")
                {
                    spendMoney += count * 0.10;
                    balloonCounter += count;
                }
                if (stock == "flowers")
                {
                    spendMoney += count * 1.50;
                    flowersCounter += count;
                }
                if (stock == "candles")
                {
                    spendMoney += count * 0.50;
                    candlesCounter += count;
                }
                if (stock == "ribbon")
                {
                    spendMoney += count * 2;
                    ribbonCounter += count;
                }
                if (budget <= spendMoney)
                {
                    Console.WriteLine("All money is spent!");
                    Console.WriteLine($"Purchased decoration is {balloonCounter} balloons, {ribbonCounter} m ribbon, {flowersCounter} flowers and {candlesCounter} candles.");
                    return;
                }
            }
        }
    }
}
