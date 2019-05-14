using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int water = int.Parse(Console.ReadLine());
            int totalFire = 0;
            double totalEffort = 0.0;
            var tokens = input.Split("#");
            var validCells = new List<int>();

            foreach (var item in tokens)
            {
                var smallTokens = item.Split(" = ");
                string type = smallTokens[0];
                int value = int.Parse(smallTokens[1]);

                if (type == "Low")
                {
                    if (value >= 1 && value <= 50)
                    {
                        if (water - value >= 0)
                        {
                            validCells.Add(value);
                            totalFire += value;
                            water -= value;
                            totalEffort += value * 0.25;
                        }
                    }
                }
                else if (type == "Medium")
                {
                    if (value >= 51 && value <= 80)
                    {
                        if (water - value >= 0)
                        {
                            validCells.Add(value);
                            totalFire += value;
                            water -= value;
                            totalEffort += value * 0.25;
                        }
                    }
                }
                else if (type == "High")
                {
                    if (value >= 81 && value <= 125)
                    {
                        if (water - value >= 0)
                        {
                            validCells.Add(value);
                            totalFire += value;
                            water -= value;
                            totalEffort += value * 0.25;
                        }
                    }
                }
            }
            Console.WriteLine("Cells:");
            foreach (var item in validCells)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine($"Effort: {totalEffort:F2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
