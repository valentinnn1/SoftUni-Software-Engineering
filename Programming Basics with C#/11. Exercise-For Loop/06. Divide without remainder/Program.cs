using System;

namespace _06.Divide_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int divideBy2 = 0;
            int divideBy3 = 0;
            int divideBy4 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    divideBy2++;
                }
                if (number % 3 == 0)
                {
                    divideBy3++;
                }
                if (number % 4 == 0)
                {
                    divideBy4++;
                }
            }

            Console.WriteLine($"{(divideBy2 * 100.0 / n):F2}%");
            Console.WriteLine($"{(divideBy3 * 100.0 / n):F2}%");
            Console.WriteLine($"{(divideBy4 * 100.0 / n):F2}%");
        }
    }
}
