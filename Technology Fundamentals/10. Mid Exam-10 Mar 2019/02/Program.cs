using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split("|");
            double budget = double.Parse(Console.ReadLine());

            // set the initial max prices of all products (consts)
            double clothesMaxPrice = 50;
            double shoesMaxPrice = 35;
            double accessoriesMaxPrice = 20.50;

            List<double> totalPrices = new List<double>();
            double oldPrices = default(double);   // create this variable to store the old prices of products

            for (int i = 0; i < items.Length; i++)  // loop all the items
            {
                string[] tokens = items[i].Split("->");  // make an inner array to split the items by ->
                string product = tokens[0];              // set the product                      
                double price = double.Parse(tokens[1]);  // set the price ot this product

                // check what command is recieved from the tokens array
                if (product == "Clothes")
                {
                    if (price > clothesMaxPrice)         // check the price of product with the max price
                    {
                        continue; // do nothing
                    }
                    else
                    {
                        if (price > budget)  // check whether the price is bigger than the given budget
                        {
                            continue; // do nothing
                        }
                        budget -= price;  // remove that price from the budget
                        oldPrices += price; // add the price to the old prices variable
                        price += price * 0.4; // add the additional 40% to the price, because the product is already bought
                        totalPrices.Add(price); // add the price to the list total prices
                    }
                }
                else if (product == "Shoes") // the same steps as above
                {
                    if (price > shoesMaxPrice) // check whether the price is bigger than the given budget
                    {
                        continue;  // do nothing
                    }
                    else
                    {
                        if (price > budget)
                        {
                            continue; // do nothing
                        }
                        budget -= price;
                        oldPrices += price;
                        price += price * 0.4;
                        totalPrices.Add(price);
                    }
                }
                else if (product == "Accessories") // the same steps as above
                {
                    if (price > accessoriesMaxPrice)
                    {
                        continue;
                    }
                    else
                    {
                        if (price > budget)
                        {
                            continue;
                        }
                        budget -= price;
                        oldPrices += price;
                        price += price * 0.4;
                        totalPrices.Add(price);
                    }
                }
            }

            double sumOfNewPrices = totalPrices.Sum();     // make a new variable to store the sum of total prices list (this step can be skipped)
            double profit = sumOfNewPrices - oldPrices;    // calculate the profit

            double finalBudget = budget + sumOfNewPrices;  // calculate the final budget, which is the current budget + the sum of new prices

            foreach (var item in totalPrices)              // make all the elements formatted to second decimal point
            {
                Console.Write($"{item:F2} ");
            }
            Console.WriteLine();                           // print new line in order to print the next line on new line

            Console.WriteLine($"Profit: {profit:F2}");
            Console.WriteLine(finalBudget >= 150 ? "Hello, France!" : "Time to go.");
        }
    }
}
