using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(VowelsCount(str));
        }

        static int VowelsCount(string str)
        {
            int vowelsCount = 0;
            string strToLower = str.ToLower();
            for (int i = 0; i < strToLower.Length; i++)
            {
                if (strToLower[i] == 'a' ||
                    strToLower[i] == 'e' ||
                    strToLower[i] == 'u' ||
                    strToLower[i] == 'o' ||
                    strToLower[i] == 'i' ||
                    strToLower[i] == 'y')
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
