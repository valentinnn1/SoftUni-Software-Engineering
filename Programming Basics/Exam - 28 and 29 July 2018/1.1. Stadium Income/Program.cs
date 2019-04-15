using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1.Stadium_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectors = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double moneyForOneSector = (capacity * ticketPrice) / sectors;
            double totalMoney = moneyForOneSector * sectors;
            double moneyForCharity = (totalMoney - (moneyForOneSector * 0.75)) / 8;

            Console.WriteLine($"Total income - {totalMoney:F2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:F2} BGN");
        }
    }
}
