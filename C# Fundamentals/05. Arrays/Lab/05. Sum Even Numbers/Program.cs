using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;

            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] % 2 == 0)
                {
                    evenSum += arr[index];
                }
            }
            Console.WriteLine(evenSum);
        }
    }
}
