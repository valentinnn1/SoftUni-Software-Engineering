using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] leftElements = new int[n];
            int[] rightElements = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentArr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    leftElements[i] = currentArr[0];
                    rightElements[i] = currentArr[1];
                }
                else
                {
                    leftElements[i] = currentArr[1];
                    rightElements[i] = currentArr[0];
                }
            }

            Console.WriteLine(String.Join(" ", leftElements));
            Console.WriteLine(String.Join(" ", rightElements));
        }
    }
}
