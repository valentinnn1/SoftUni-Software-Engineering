using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rate = 0;
            int sales = 0;
            double totalSales = 0.00;
            double totalRate = 0.00;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                rate = number % 10;
                totalRate += rate;
                sales = number / 10;

                if (rate == 2)
                {
                    totalSales += 0;
                }
                if (rate == 3)
                {
                    totalSales += 0.5 * sales;
                }
                if (rate == 4)
                {
                    totalSales += 0.7 * sales;
                }
                if (rate == 5)
                {
                    totalSales += 0.85 * sales;
                }
                if (rate == 6)
                {
                    totalSales += sales;
                }
            }

            Console.WriteLine($"{(totalSales):F2}");
            Console.WriteLine($"{(totalRate / n):F2}");
        }
    }
}
