using System;

namespace _04.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int prevSum = 0;
            int currSum = 0;
            int maxDiff = 0;
            int currDiff = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    currSum = firstNum + secondNum;
                    continue;
                }
                prevSum = currSum;

                currSum = firstNum + secondNum;

                currDiff = Math.Abs(currSum - prevSum);

                if (currDiff > maxDiff)
                {
                    maxDiff = currDiff;
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={currSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
