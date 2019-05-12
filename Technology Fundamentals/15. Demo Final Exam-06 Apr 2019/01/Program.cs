using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            var tokens = firstInput.Split(" | ");
            var dict = new SortedDictionary<string, List<string>>();
            string left = string.Empty;
            string right = string.Empty;

            for (int i = 0; i < tokens.Length; i++)
            {
                var smallTokens = tokens[i].Split(": ");
                left = smallTokens[0];
                right = smallTokens[1];

                if (!dict.ContainsKey(left))
                {
                    dict.Add(left, new List<string>());
                    dict[left].Add(right);
                }
                else
                {
                    dict[left].Add(right);
                }
            }
            string secondInput = Console.ReadLine();
            var secondTokens = secondInput.Split(" | ");

            string thirdInput = Console.ReadLine();

            if (thirdInput == "End")
            {
                foreach (var kvp in dict)
                {
                    Console.WriteLine(kvp.Key);
                    
                    foreach (var neshto in kvp.Value.OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($" -{neshto}");
                    }
                    
                }
            }
            else if (thirdInput == "List")
            {
                foreach (var kvp in dict.OrderBy(x => x.Key))
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }
    }
}
