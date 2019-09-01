using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Santa_s_New_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> children = new Dictionary<string, int>(); //key = children, value-total toys;
            Dictionary<string, int> toys = new Dictionary<string, int>(); //key = toy, value = amount;
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] information = input.Split("->");
                string actionOrName = information[0];

                if (actionOrName == "Remove")
                {
                    string childName = information[1];

                    if (children.ContainsKey(childName))
                    {
                        children.Remove(childName);
                    }
                }
                else
                {
                    string childName = actionOrName;
                    string typeOfToy = information[1];
                    int amount = int.Parse(information[2]);

                    if (children.ContainsKey(childName) == false)
                    {
                        children.Add(childName, 0);
                    }

                    children[childName] += amount;

                    if (toys.ContainsKey(typeOfToy) == false)
                    {
                        toys.Add(typeOfToy, 0);
                    }

                    toys[typeOfToy] += amount;

                }
            }

            Console.WriteLine("Children:");
            foreach (var child in children.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }

            Console.WriteLine("Presents:");
            foreach (var kvp in toys)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
