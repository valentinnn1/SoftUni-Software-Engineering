using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> namesOfGuests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens.Length == 3)
                {
                    if (!namesOfGuests.Contains(tokens[0]))
                    {
                        namesOfGuests.Add(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                }
                else if (tokens.Length == 4)
                {
                    if (namesOfGuests.Contains(tokens[0]))
                    {
                        namesOfGuests.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                }
            }
            foreach (var person in namesOfGuests)
            {
                Console.WriteLine(person);
            }
        }
    }
}
