using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            while (true)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
                if (num > n)
                {
                    break;
                }
            }
        }
    }
}
