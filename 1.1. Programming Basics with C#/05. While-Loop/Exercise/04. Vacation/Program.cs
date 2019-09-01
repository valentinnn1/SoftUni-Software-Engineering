using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needed = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int spendcount = 0;
            int days = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                days++;
                switch (action)
                {
                    case "spend":
                        money -= amount; spendcount++;
                        if (money < 0)
                        {
                            money = 0;
                        }
                        break;
                    case "save":
                        money += amount; spendcount = 0;
                        break;
                }
                if (spendcount == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{days}");
                    break;
                }
                else if (money >= needed)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }
        }
    }
}
