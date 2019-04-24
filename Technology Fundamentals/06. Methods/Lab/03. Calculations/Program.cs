using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                AddNums(firstNum, secondNum);
            }
            else if (command == "multiply")
            {
                MultiplyNums(firstNum, secondNum);
            }
            else if (command == "subtract")
            {
                SubtractNums(firstNum, secondNum);
            }
            else if (command == "divide")
            {
                DivideNums(firstNum, secondNum);
            }
        }

        private static void DivideNums(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }

        private static void SubtractNums(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

        private static void MultiplyNums(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }

        private static void AddNums(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
    }
}
