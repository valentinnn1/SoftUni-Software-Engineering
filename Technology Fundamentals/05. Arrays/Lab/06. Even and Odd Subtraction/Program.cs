using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] % 2 == 0)
                {
                    evenSum += arr[index];
                }
                else
                {
                    oddSum += arr[index];
                }
            }

            int diff = evenSum - oddSum;
            Console.WriteLine(diff);
        }
    }
}
