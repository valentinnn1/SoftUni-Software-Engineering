using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string num = i.ToString();
                int length = num.Length;

                int evenSum = 0;
                int oddSum = 0;
                int process = i;

                for (int j = 0; j < length; j++)
                {
                    int modul = process % 10;

                    if (j % 2 != 0)
                    {
                        evenSum += modul;
                    }
                    else
                    {
                        oddSum += modul;
                    }

                    process /= 10;
                }

                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
