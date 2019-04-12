using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string nToString = Console.ReadLine();
            int num = int.Parse(nToString);
            //int length = n.ToString().Length();

            for (int i = 0; i < nToString.Length; i++)
            {
                int n = num % 10;
                num /= 10;

                if (n == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write((char)(n+33));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
