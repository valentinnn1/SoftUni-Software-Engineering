using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int sum = SumMethod(firstNum, secondNum);
            Console.WriteLine(SubtractMethod(sum, thirdNum));
        }

        private static int SubtractMethod(int sum, int thirdNum)
        {
            return sum - thirdNum;
        }

        private static int SumMethod(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }
    }
}
