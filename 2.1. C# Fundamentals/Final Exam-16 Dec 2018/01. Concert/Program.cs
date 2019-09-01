using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            var dict = new Dictionary<string, List<string>>();
            var dict2 = new Dictionary<string, int>();
            int totalTime = 0;
            string finalInput = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "start of concert")
                {
                    finalInput = Console.ReadLine();
                    break;
                }

                var tokens = command.Split("; ");
                string bandName = tokens[1];


                if (tokens[0] == "Add")
                {
                    var members = new List<string>(tokens[2].Split(", "));

                    if (dict.ContainsKey(bandName) == false)
                    {
                        dict.Add(bandName, new List<string>());

                        foreach (var member in members)
                        {
                            dict[bandName].Add(member);
                        }
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if (dict[bandName].Contains(member) == false)
                            {
                                dict[bandName].Add(member);
                            }
                        }
                    }
                }
                if (tokens[0] == "Play")
                {
                    var times = new List<int>();
                    int currTime = int.Parse(tokens[2]);

                    if (dict2.ContainsKey(bandName) == false)
                    {
                        dict2.Add(bandName, 0);
                        dict2[bandName] = currTime; //+= ili =
                        totalTime += currTime;
                    }
                    else
                    {
                        dict2[bandName] += currTime;
                        totalTime += currTime;
                    }
                }
            }
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var kvp in dict2.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            Console.WriteLine(finalInput);
            foreach (var item in dict[finalInput])
            {
                Console.WriteLine($"=> {item}");
            }
        }
    }
}
