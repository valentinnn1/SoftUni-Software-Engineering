using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < number; i++)
            {
                double singleNumber = double.Parse(Console.ReadLine());
                sum += singleNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
