﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
