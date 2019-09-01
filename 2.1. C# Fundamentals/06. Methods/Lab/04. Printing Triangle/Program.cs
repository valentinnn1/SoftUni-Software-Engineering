using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
            PrintReversedTriangle(n);
        }
        static void PrintTriangle(int maxNum)
        {
            for (int row = 1; row <= maxNum; row++)
            {
                PrintRowWithNumbers(1, row);
            }
        }
        static void PrintReversedTriangle(int maxNum)
        {
            for (int j = maxNum - 1; j >= 1; j--)
            {
                PrintRowWithNumbers(1, j);
            }
        }
        static void PrintRowWithNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
