using System;
using System.Linq;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            while (text.Contains(word))
            {
                int index = text.IndexOf(word);
                text = text.Remove(index, word.Length);
            }
            Console.WriteLine(text);
        }
    }
}
