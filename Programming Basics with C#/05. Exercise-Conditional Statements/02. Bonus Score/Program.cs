using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonusScore = 0.0;
            if (num <= 100)
            {
                bonusScore += 5;
            }
            else if (num > 100 && num <= 1000)
            {
                bonusScore += 0.20 * num;
            }
            else if (num > 1000)
            {
                bonusScore += 0.10 * num;
            }

            if (num % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (num % 10 == 5)
            {
                bonusScore += 2;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(num + bonusScore);
        }
    }
}
