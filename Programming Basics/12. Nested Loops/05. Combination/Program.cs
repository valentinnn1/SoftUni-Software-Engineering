using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            
            for (int x1 = 0; x1 <= 25; x1++)
            {
                for (int x2 = 0; x2 <= 25; x2++)
                {
                    for (int x3 = 0; x3 <= 25; x3++)
                    {
                        for (int x4 = 0; x4 <= 25; x4++)
                        {
                            for (int x5 = 0; x5 <= 25; x5++)
                            {
                                if (x1 + x2 + x3 + x4 + x5 == n)
                                {
                                    counter++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
