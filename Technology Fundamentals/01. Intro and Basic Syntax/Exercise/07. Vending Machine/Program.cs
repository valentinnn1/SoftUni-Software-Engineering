using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;
            while (input != "Start")
            {
                double coin = double.Parse(input);

                if (coin == 0.1 ||
                    coin == 0.2 ||
                    coin == 0.5 ||
                    coin == 1 ||
                    coin == 2)
                {
                    balance += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                double productPrice = 0.00;

                switch (input)
                {
                    case "Nuts": productPrice = 2; break;
                    case "Water": productPrice = 0.7; break;
                    case "Crisps": productPrice = 1.5; break;
                    case "Soda": productPrice = 0.8; break;
                    case "Coke": productPrice = 1; break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (balance >= productPrice && productPrice > 0)
                {
                    string productTorLower = input.ToLower();
                    Console.WriteLine($"Purchased {productTorLower}");
                    balance -= productPrice;
                }
                else if (productPrice > 0)
                {
                    Console.WriteLine();
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {balance:F2}");
        }
    }
}
