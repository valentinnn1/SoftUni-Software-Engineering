using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int result = Smallest(firstNum, secondNum, thirdNum);
            Console.WriteLine(result);
        }

        static int Smallest(int firstNum, int secondNum, int thirdNum)
        {
            int smallest = 0;

            if (firstNum < secondNum && firstNum < thirdNum)
            {
                smallest = firstNum;
            }
            else if (secondNum < firstNum && secondNum < thirdNum)
            {
                smallest = secondNum;
            }
            else
            {
                smallest = thirdNum;
            }
            return smallest;
        }
    }
}
