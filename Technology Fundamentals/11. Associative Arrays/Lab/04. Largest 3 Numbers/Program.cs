using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var top3 = Console.ReadLine().Split()
                .Select(int.Parse).OrderByDescending(x => x).Take(3);

            foreach (var item in top3)
            {
                Console.Write(item + " ");
            }
        }
    }
}
