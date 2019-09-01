using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int greatestNum = GetMaxInt(firstNum, secondNum);
                Console.WriteLine(greatestNum);
            }

            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char greatestChar = GetMaxChar(firstChar, secondChar);
                Console.WriteLine(greatestChar);
            }

            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string greatestString = GetMaxString(firstString, secondString);
                Console.WriteLine(greatestString);
            }
        }
        static int GetMaxInt(int firstNum, int secondNum)
        {
            int maxInt = 0;

            if (firstNum > secondNum)
            {
                maxInt = firstNum;
            }
            else
            {
                maxInt = secondNum;
            }
            return maxInt;
        }
        static char GetMaxChar(char firstChar, char secondChar)
        {
            char maxChar = 'a';

            if (firstChar > secondChar)
            {
                maxChar = firstChar;
            }
            else
            {
                maxChar = secondChar;
            }
            return maxChar;
        }
        static string GetMaxString(string firstString, string secondString)
        {
            string maxString = String.Empty;

            if (firstString.CompareTo(secondString) >= 0)
            {
                maxString = firstString;
            }
            else
            {
                maxString = secondString;
            }
            return maxString;
        }
    }
}
