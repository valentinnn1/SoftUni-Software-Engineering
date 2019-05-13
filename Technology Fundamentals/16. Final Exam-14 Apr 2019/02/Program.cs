using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            var dict = new Dictionary<string, List<string>>();
            

            while (true)
            {
                command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                var tokens = command.Split("->");
                string store = tokens[1];
                
                if (tokens[0] == "Add")
                {
                    var items = new List<string>(tokens[2].Split(","));
                    string theLastToken = tokens[2];

                    if (dict.ContainsKey(store) == false)
                    {
                        dict.Add(store, new List<string>());

                        foreach (var item in items)
                        {
                            dict[store].Add(item);
                        }
                    }
                    else
                    {
                        foreach (var item in items)
                        {

                            dict[store].Add(item);

                        }
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    if (dict.ContainsKey(store) == true)
                    {
                        dict.Remove(store);
                    }
                }
            }
            Console.WriteLine("Stores list:");

            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count)
                .ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var item in dict[kvp.Key])
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
