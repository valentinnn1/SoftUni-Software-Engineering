using System;

namespace _03.Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            decimal price = 0.00m;
            decimal totalSum = 0.00m;

            switch (month)
            {
                case "march":
                case "april":
                case "may":

                    price = dayTime == "day" ? 10.50m : 8.40m;
                    break;

                case "june":
                case "july":
                case "august":

                    price = dayTime == "day" ? 12.60m : 10.20m;

                    break;
            }

            if (people >= 4)
            {
                price *= 0.9m;
            }

            if (hours >= 5)
            {
                price *= 0.5m;
            }

            totalSum = price * people * hours;

            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {totalSum:f2}");
        }
    }
}
