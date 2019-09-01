using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
            int count = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 1; i <= number; i++)
                    {

                        if (number % i == 0)
                        {
                            count++;
                        }
                    }
                    if (number == 1)
                    {
                        nonPrimeSum ++;
                    }
                    if (count > 2)
                    {
                        nonPrimeSum += number;
                    }
                    else
                    {
                        primeSum += number;
                    }
                    count = 0;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
