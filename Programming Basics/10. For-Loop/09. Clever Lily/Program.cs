using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toysCounter = 0;
            int moneyFromGifts = 0;
            int badBrotherCounter = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    badBrotherCounter++;
                    moneyFromGifts += 10 * badBrotherCounter;
                }
                else
                {
                    toysCounter++;
                }
            }
            int moneyForToys = toysCounter * toyPrice;
            int totalMoney = (moneyForToys + moneyFromGifts) - badBrotherCounter;

            if (totalMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(totalMoney - washingMachinePrice):F2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachinePrice-totalMoney):F2}");
            }
        }
    }
}
