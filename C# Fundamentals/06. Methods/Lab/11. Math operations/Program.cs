using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            double result = Calculate(firstNum, oper, secondNum);
            Console.WriteLine(result);
        }

        static double Calculate(int firstNum, string oper, int secondNum)
        {
            double result = 0.0;

            if (oper == "+")
            {
                result = firstNum + secondNum;
            }
            else if (oper == "-")
            {
                result = firstNum - secondNum;
            }
            else if (oper == "*")
            {
                result = firstNum * secondNum;
            }
            else if (oper == "/")
            {
                result = firstNum / secondNum;
            }
            return result;
        }
    }
}
