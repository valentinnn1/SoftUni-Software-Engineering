using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeInteger();
        }

        static void PalindromeInteger()
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                return;
            }

            while (input != "END")
            {
                char[] reverse = input.ToArray();
                Array.Reverse(reverse);

                for (int i = 0; i < reverse.Length; i++)
                {
                    if (reverse[i] == input[i])
                    {
                        Console.WriteLine("true"); break;
                    }
                    else if (reverse[i] != input[i])
                    {
                        Console.WriteLine("false"); break;
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
