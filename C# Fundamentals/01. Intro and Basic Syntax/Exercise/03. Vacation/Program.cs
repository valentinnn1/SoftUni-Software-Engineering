using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0.00;

            if (dayOfWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    price += 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    price += 10.90;
                }
                else if (typeOfGroup == "Regular")
                {
                    price += 15.00;
                }
            }
            if (dayOfWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    price += 9.80;
                }
                else if (typeOfGroup == "Business")
                {
                    price += 15.60;
                }
                else if (typeOfGroup == "Regular")
                {
                    price += 20.00;
                }
            }
            if (dayOfWeek == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    price += 10.46;
                }
                else if (typeOfGroup == "Business")
                {
                    price += 16.00;
                }
                else if (typeOfGroup == "Regular")
                {
                    price += 22.50;
                }
            }
            double totalPrice = 0.00;
            totalPrice = price * people;

            if (people >= 30 && typeOfGroup == "Students")
            {
                totalPrice = people * (price - (price * 0.15));
            }
            else if (people >= 100 && typeOfGroup == "Business")
            {
                totalPrice = price * (people - 10);
            }
            else if (people >= 10 && people <= 20 && typeOfGroup == "Regular")
            {
                totalPrice = people * (price - (price * 0.5));
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
