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
            int alpinists = int.Parse(Console.ReadLine());
            int carabiners = int.Parse(Console.ReadLine());
            int ropes = int.Parse(Console.ReadLine());
            int pickels = int.Parse(Console.ReadLine());

            double carabinersPrice = carabiners * 36;
            double ropesPrice = ropes * 3.60;
            double pickelsPrice = pickels * 19.80;
            double totalSumForOneAlpinist = carabinersPrice + ropesPrice + pickelsPrice;
            double totalSumForAllAlpinists = totalSumForOneAlpinist * alpinists;
            double sumWithDDS = totalSumForAllAlpinists + (totalSumForAllAlpinists * 0.2);

            Console.WriteLine($"{sumWithDDS:F2}");
        }
    }
}
