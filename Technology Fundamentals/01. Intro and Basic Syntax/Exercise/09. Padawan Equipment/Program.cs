using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            double freeBelts = 0.00;

            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }
            }

            double totalMoney = priceOfLightsabers * (Math.Ceiling(students + (students * 0.1))) + priceOfRobes * students + priceOfBelts * (students - freeBelts);
            if (totalMoney <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalMoney - money):F2}lv more.");
            }
        }
    }
}
