using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> housesMembers = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            int currentPosition = 0;
            while (command.Contains("Jump"))
            {
                int jump = int.Parse(command[1]);
                if (currentPosition + jump < housesMembers.Count)
                {
                    currentPosition += jump;
                    GivePresents(housesMembers, currentPosition);
                }
                else
                {
                    currentPosition = (currentPosition + jump) % housesMembers.Count;
                    GivePresents(housesMembers, currentPosition);
                }
                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine($"Santa's last position was {currentPosition}.");
            if (housesMembers.Exists(x => x != 0))
            {
                List<int> failedHouses = housesMembers.FindAll(x => x != 0);
                Console.WriteLine($"Santa has failed {failedHouses.Count} houses.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
        static void GivePresents(List<int> housesMembers, int currentPosition)
        {
            if (housesMembers[currentPosition] <= 0)
            {
                housesMembers[currentPosition] = 0;
                Console.WriteLine($"House {currentPosition} will have a Merry Christmas.");
            }
            else
            {
                housesMembers[currentPosition] -= 2;
            }
        }
    }
}
