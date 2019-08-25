using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            int sum = firstNum + secondNum;
            int afterDivide = sum / thirdNum;
            int result = afterDivide * fourthNum;

            Console.WriteLine(result);
        }
    }
}
