using System;

namespace _01._Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int spirit = 0;
            int cost = 0;
            int ornamentSet = 2;
            int treeSkirt = 5;
            int treeGarlands = 3;
            int treeLights = 15;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 2 == 0)
                {
                    cost += ornamentSet * quantity;
                    spirit += 5;
                }
                if (i % 3 == 0)
                {
                    cost += treeSkirt * quantity + treeGarlands * quantity;
                    spirit += 13;
                }
                if (i % 5 == 0)
                {
                    cost += treeLights * quantity;
                    spirit += 17;
                }
                if (i % 15 == 0)
                {
                    spirit += 30;
                }
                if (i % 10 == 0)
                {
                    spirit -= 20;
                    cost += treeSkirt + treeGarlands + treeLights;
                }
            }
            if (days % 10 == 0)
            {
                spirit -= 30;
            }
            Console.WriteLine($"Total cost: {cost}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
