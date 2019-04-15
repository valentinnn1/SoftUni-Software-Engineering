using System;

namespace _5._2.Game_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int gamesCount = int.Parse(Console.ReadLine());
            double minutesSum = 0.00;
            int gamesWithPenalties = 0;
            int gamesWithAdditionalTime = 0;

            for (int i = 0; i < gamesCount; i++)
            {
                int minutes = int.Parse(Console.ReadLine());
                minutesSum += minutes;

                if (minutes > 120)
                {
                    gamesWithPenalties++;
                }
                if (minutes > 90 && minutes <= 120)
                {
                    gamesWithAdditionalTime++;
                }
            }
            Console.WriteLine($"{name} has played {minutesSum} minutes. Average minutes per game: {(minutesSum/gamesCount):F2}");
            Console.WriteLine($"Games with penalties: {gamesWithPenalties}");
            Console.WriteLine($"Games with additional time: {gamesWithAdditionalTime}");
        }
    }
}
