using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1.Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            //  90/100 в judge
            string name = string.Empty;
            int greaterScore = 0;
            int goals = 0;
            string theBestPlayer = string.Empty;

            while (true)
            {
                name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                goals = int.Parse(Console.ReadLine());
                if (goals >= 10)
                {
                    theBestPlayer = name;
                    break;
                }
                if (goals > greaterScore)
                {
                    theBestPlayer = name;
                    greaterScore = goals;
                }
                
            }
            Console.WriteLine($"{theBestPlayer} is the best player!");
            if (goals >= 3)
            {
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goals} goals.");
            }
        }
    }
}
