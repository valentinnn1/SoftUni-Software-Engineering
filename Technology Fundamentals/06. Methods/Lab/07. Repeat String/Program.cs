using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string newStr = RepeatString(str, n);
            Console.WriteLine(newStr);
        }

        private static string RepeatString(string str, int count)
        {
            string result = "";

            for (int i = 1; i <= count; i++)
            {
                result = result + str;
            }
            return result;
        }
    }
}
