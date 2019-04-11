using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            while ((line = Console.ReadLine()) != "End")
            {
                string destination = line;
                double neededMoney = double.Parse(Console.ReadLine());

                double money = 0;
                string savings = string.Empty;
                while (true)
                {
                    savings = Console.ReadLine();
                    if (savings == "End")
                    {
                        return;
                    }

                    money += double.Parse(savings);

                    if (money >= neededMoney)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
        }
    }
}
