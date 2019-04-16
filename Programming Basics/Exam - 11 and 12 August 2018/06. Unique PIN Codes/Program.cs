using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstNum; i++)
            {
                for (int j = 2; j <= secondNum; j++)
                {
                    for (int k = 1; k <= thirdNum; k++)
                    {
                        if (i % 2 != 0)
                        {
                            continue;
                        }
                        if (k % 2 != 0)
                        {
                            continue;
                        }
                        if (j == 4 || j == 6 || j == 8 || j == 9)
                        {
                            continue;
                        }
                        Console.WriteLine($"{i} {j} {k}");
                    }
                }
            }
        }
    }
}
