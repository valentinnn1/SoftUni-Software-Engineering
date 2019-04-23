using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += arrayOfIntegers[j];
                }
                for (int k = i + 1; k < arrayOfIntegers.Length; k++)
                {
                    sumRight += arrayOfIntegers[k];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine($"{i}");
                    if (arrayOfIntegers[i] == 0 && arrayOfIntegers[i + 1] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            Console.WriteLine("no");
        }
    }
}
