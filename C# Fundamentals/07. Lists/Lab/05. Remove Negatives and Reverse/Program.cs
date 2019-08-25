using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var positiveNumbers = Console.ReadLine().Split(' ').Select(int.Parse)
                .Where(number => number >= 0).ToList();

            positiveNumbers.Reverse();

            if (positiveNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", positiveNumbers));
            }
        }
    }
}
