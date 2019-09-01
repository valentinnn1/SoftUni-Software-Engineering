using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();

            decimal USD = 1.79549m;
            decimal EUR = 1.95583m;
            decimal GBP = 2.53405m;

            decimal currentCurrency = 0;

            decimal totalSum = 0;

            if (firstCurrency == "BGN")
            {
                currentCurrency = money;

                if (secondCurrency == "USD")
                {
                    totalSum = currentCurrency / USD;
                }
                else if (secondCurrency == "GBP")
                {
                    totalSum = currentCurrency / GBP;
                }
                else if (secondCurrency == "EUR")
                {
                    totalSum = currentCurrency / EUR;
                }
            }
            else if (firstCurrency == "USD")
            {
                currentCurrency = money * USD;

                if (secondCurrency == "BGN")
                {
                    totalSum = money * USD;
                }
                else if (secondCurrency == "EUR")
                {
                    totalSum = currentCurrency / EUR;
                }
                else if (secondCurrency == "GBP")
                {
                    totalSum = currentCurrency / GBP;
                }
            }
            else if (firstCurrency == "EUR")
            {
                currentCurrency = money * EUR;

                if (secondCurrency == "BGN")
                {
                    totalSum = money * EUR;
                }
                else if (secondCurrency == "USD")
                {
                    totalSum = currentCurrency / USD;
                }
                else if (secondCurrency == "GBP")
                {
                    totalSum = currentCurrency / GBP;
                }
            }
            else if (firstCurrency == "GBP")
            {
                currentCurrency = money * GBP;

                if (secondCurrency == "BGN")
                {
                    totalSum = money * GBP;
                }
                else if (secondCurrency == "USD")
                {
                    totalSum = currentCurrency / USD;
                }
                else if (secondCurrency == "EUR")
                {
                    totalSum = currentCurrency / EUR;
                }
            }

            Console.WriteLine($"{totalSum:F2} {secondCurrency}");

        }
    }
}
