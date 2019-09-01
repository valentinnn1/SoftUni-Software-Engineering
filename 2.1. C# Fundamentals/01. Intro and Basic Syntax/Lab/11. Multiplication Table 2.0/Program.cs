using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int product = 0;

            if (secondNumber >= 1 && secondNumber <= 10)
            {
                for (int i = secondNumber; i <= 10; i++)
                {
                    product = firstNumber * i;
                    Console.WriteLine($"{firstNumber} X {i} = {product}");
                }
            }
            else
            {
                product = firstNumber * secondNumber;
                Console.WriteLine($"{firstNumber} X {secondNumber} = {product}");
            }
        }
    }
}
