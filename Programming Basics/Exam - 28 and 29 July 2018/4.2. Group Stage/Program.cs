using System;

namespace _4._2.Group_Stage
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            int counter = 0;
            int diff = 0;
            int points = 0;

            while (counter < games)
            {
                int scoredGoals = int.Parse(Console.ReadLine());
                int receivedGoals = int.Parse(Console.ReadLine());
                if (scoredGoals > receivedGoals)
                {
                    points += 3;
                }
                else if (scoredGoals == receivedGoals)
                {
                    points += 1;
                }
                
                diff += scoredGoals - receivedGoals;
                counter++;
            }
            if (diff >= 0)
            {
                Console.WriteLine($"{team} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {diff}.");
            }
            else
            {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {diff}.");
            }
        }
    }
}
