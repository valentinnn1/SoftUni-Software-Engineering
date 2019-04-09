using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 1; i <= number; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                if (firstNum < min)
                {
                    min = firstNum;
                }
            }
            Console.WriteLine(min);
        }
    }
}
