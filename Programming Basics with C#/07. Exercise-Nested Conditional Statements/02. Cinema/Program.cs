using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double ticketPrice = 0.00;
            int chairs = rows * columns;

            if (projection == "Premiere")
            {
                ticketPrice = 12.00;
            }
            else if (projection == "Normal")
            {
                ticketPrice = 7.50;
            }
            else if (projection == "Discount")
            {
                ticketPrice = 5.00;
            }

            double totalPrice = ticketPrice * chairs;
            Console.WriteLine($"{totalPrice:F2} leva");
        }
    }
}
