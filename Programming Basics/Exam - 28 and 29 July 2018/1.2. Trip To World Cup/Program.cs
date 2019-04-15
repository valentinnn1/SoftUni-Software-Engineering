using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2.Trip_To_World_Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForGo = double.Parse(Console.ReadLine());
            double priceForReturn = double.Parse(Console.ReadLine());
            double priceForOneMatch = double.Parse(Console.ReadLine());
            int matchCount = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double priceForSixFriends = 6 * (priceForGo + priceForReturn);
            double priceAfterDiscount = priceForSixFriends - (priceForSixFriends * discount / 100);
            double totalTicketPrice = 6 * matchCount * priceForOneMatch;
            double totalPrice = priceAfterDiscount + totalTicketPrice;
            double priceForOne = totalPrice / 6;

            Console.WriteLine($"Total sum: {totalPrice:F2} lv.");
            Console.WriteLine($"Each friend has to pay {priceForOne:F2} lv.");
        }
    }
}
