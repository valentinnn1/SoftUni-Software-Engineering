using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sums_Left_Right_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                int current = i;
                int rightSum = 0;
                int mid = 0;
                int leftSum = 0;
                for (int j = 1; j <= 5; j++)
                {
                    if (j < 3)
                    {
                        rightSum += current % 10;
                    }
                    else if (j == 3)
                    {
                        mid += current % 10;
                    }
                    else
                    {
                        leftSum += current % 10;
                    }
                    current /= 10;
                }
                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }
                else if (leftSum < rightSum)
                {
                    if (leftSum + mid == rightSum)
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    if (rightSum + mid == leftSum)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
