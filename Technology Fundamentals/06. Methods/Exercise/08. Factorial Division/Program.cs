using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long firstFactorial = GetFactorial(firstNumber);
            long secondFactorial = GetFactorial(secondNumber);

            double result = (double)firstFactorial / secondFactorial;
            Console.WriteLine($"{result:F2}");
        }

        private static long GetFactorial(long firstNumber)
        {
            long factorial = 1;

            for (int i = 1; i <= firstNumber; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
