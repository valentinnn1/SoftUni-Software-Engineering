using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Method(product, quantity);
        }

        static void Method(string product, int quantity)
        {
            double sum = 0.00;
            if (product == "coffee")
            {
                sum = 1.50 * quantity;
            }
            else if (product == "water")
            {
                sum = 1.00 * quantity;
            }
            else if (product == "coke")
            {
                sum = 1.40 * quantity;
            }
            else if (product == "snacks")
            {
                sum = 2.00 * quantity;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
