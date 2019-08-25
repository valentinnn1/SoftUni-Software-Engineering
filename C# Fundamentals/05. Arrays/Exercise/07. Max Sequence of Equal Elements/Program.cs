using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int count = 0;
            int position = 0;
            int maxCount = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;
                    if (maxCount < count)
                    {
                        position = i - count;
                        maxCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int i = position + 1; i <= position + maxCount + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
