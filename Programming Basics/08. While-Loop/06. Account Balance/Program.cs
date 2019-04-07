using System;

namespace _06.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiVnoski = int.Parse(Console.ReadLine());
            decimal balance = 0.0m;

            int counter = 1;
            decimal vnoska;

            while (counter <= broiVnoski)
            {
                vnoska = decimal.Parse(Console.ReadLine());
                if (vnoska < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {vnoska:F2}");
                counter++;
                balance += vnoska;
            }
            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}
