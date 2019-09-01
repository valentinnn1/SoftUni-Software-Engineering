using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            int factoriel = 1;

            for (int i = number; i >= 1; i /= 10)
            {
                int digit = i % 10;
                if (digit == 0)
                {
                    factoriel = 1;
                    sum += factoriel;
                    continue;
                }
                for (int j = 1; j <= digit; j++)
                {
                    factoriel *= j;
                }
                sum += factoriel;
                factoriel = 1;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
