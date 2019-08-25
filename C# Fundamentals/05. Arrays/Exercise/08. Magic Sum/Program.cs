using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.
            int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            //result=0;
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == num)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }
                }
            }
        }
    }
}
