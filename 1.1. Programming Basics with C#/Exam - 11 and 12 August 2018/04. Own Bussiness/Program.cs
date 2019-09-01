using System;

namespace _04.Own_Bussiness
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomWidth = int.Parse(Console.ReadLine());
            int roomLength = int.Parse(Console.ReadLine());
            int roomHeight = int.Parse(Console.ReadLine());
            int roomVolume = roomWidth * roomLength * roomHeight;
            int usedSpace = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    break;
                }
                usedSpace += int.Parse(command);
                if (usedSpace >= roomVolume)
                {
                    break;
                }
            }
            if (usedSpace <= roomVolume)
            {
                Console.WriteLine($"{roomVolume - usedSpace} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {usedSpace - roomVolume} Cubic meters more.");
            }
        }
    }
}
