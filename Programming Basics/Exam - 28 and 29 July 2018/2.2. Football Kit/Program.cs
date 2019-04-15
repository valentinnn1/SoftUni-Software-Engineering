using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2.Football_Kit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double moneyForBall = double.Parse(Console.ReadLine());

            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.2;
            double shoesPrice = (tshirtPrice + shortsPrice) * 2;
            double sum = tshirtPrice + shortsPrice + socksPrice + shoesPrice;
            double sumAfterDiscount = sum - (sum * 0.15);

            if (sumAfterDiscount >= moneyForBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {sumAfterDiscount:F2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {Math.Abs(sumAfterDiscount - moneyForBall):F2} lv. more.");
            }
        }
    }
}
