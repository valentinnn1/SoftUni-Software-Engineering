using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int countOfPlayers = int.Parse(Console.ReadLine());
            double groupsEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForOne = double.Parse(Console.ReadLine());
            double foodPerDayForOne = double.Parse(Console.ReadLine());
            bool enoughEnergy = true;
            double totalWater = days * countOfPlayers * waterPerDayForOne;
            double totalFood = days * countOfPlayers * foodPerDayForOne;
            double currentEnergy = groupsEnergy;
            double currentFood = totalFood;
            double currentWater = totalWater;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                currentEnergy -= energyLoss;

                if (currentEnergy <= 0)
                {
                    enoughEnergy = false;
                    break;
                }

                if (i % 2 == 0)
                {
                    
                    currentEnergy += currentEnergy * 0.05;
                    currentWater -= currentWater * 0.3;
                }
                if (i % 3 == 0)
                {
                    
                    currentFood -= currentFood / countOfPlayers;
                    currentEnergy += currentEnergy * 0.1;
                }
                
            }

            if (enoughEnergy == false)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {currentFood:F2} food and {currentWater:F2} water.");
            }
            else
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {currentEnergy:F2} energy!");
            }
        }
    }
}
