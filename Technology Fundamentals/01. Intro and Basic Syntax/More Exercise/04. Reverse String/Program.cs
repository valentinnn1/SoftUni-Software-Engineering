using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            Array.Reverse(text);
            text.ToString();
            Console.WriteLine(text);
        }
    }
}
