using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            string firstWord = tokens[0];
            string secondWord = tokens[1];

            string longerWord = string.Empty;
            string shorterWord = string.Empty;

            int totalSum = 0;

            if (firstWord.Length >= secondWord.Length)
            {
                longerWord = firstWord;
                shorterWord = secondWord;
            }
            else
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }

            for (int i = 0; i < shorterWord.Length; i++)
            {
                totalSum += longerWord[i] * shorterWord[i];
            }
            for (int j = shorterWord.Length; j < longerWord.Length; j++)
            {
                totalSum += longerWord[j];
            }
            Console.WriteLine(totalSum);
        }
    }
}
