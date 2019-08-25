using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int currentIndex = 0;

            for (int i = 1; i <= numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Forward":
                        int stepsForward = int.Parse(command[1]);
                        if (stepsForward < 0 || stepsForward + currentIndex >= houses.Count)
                        {
                            continue;
                        }
                        currentIndex += stepsForward;
                        houses.RemoveAt(currentIndex);
                        break;

                    case "Back":
                        int backStep = int.Parse(command[1]);
                        if (currentIndex - backStep < 0)
                        {
                            continue;
                        }
                        currentIndex -= backStep;
                        houses.RemoveAt(currentIndex);
                        break;

                    case "Gift":
                        int indexToInsertNewHouse = int.Parse(command[1]);
                        int houseNumber = int.Parse(command[2]);
                        if (indexToInsertNewHouse > houses.Count - 1)
                        {
                            if (indexToInsertNewHouse == houses.Count)
                            {
                                houses.Add(houseNumber);
                                currentIndex = indexToInsertNewHouse;
                            }
                        }

                        else
                        {
                            houses.Insert(indexToInsertNewHouse, houseNumber);
                            currentIndex = indexToInsertNewHouse;
                        }
                        break;

                    case "Swap":
                        int firstHouse = int.Parse(command[1]);
                        int secondHouse = int.Parse(command[2]);
                        if (houses.Contains(firstHouse) && houses.Contains(secondHouse))
                        {
                            houses.Insert(houses.IndexOf(secondHouse), firstHouse);
                            houses.Remove(secondHouse);
                            houses.Insert(houses.IndexOf(firstHouse), secondHouse);
                            houses.Remove(firstHouse);
                        }
                        break;
                }
            }
            Console.WriteLine($"Position: {currentIndex}");
            Console.WriteLine(string.Join(", ", houses));
        }
    }
}
