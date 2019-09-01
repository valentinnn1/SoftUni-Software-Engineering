﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthCake = int.Parse(Console.ReadLine());
            int lengthCake = int.Parse(Console.ReadLine());
            var wholeCake = widthCake * lengthCake;
            while (wholeCake >= 0)
            {
                string taken = Console.ReadLine();
                if (taken == "STOP")
                {
                    Console.WriteLine($"{wholeCake} pieces are left.");
                    return;
                }
                wholeCake = wholeCake - int.Parse(taken);
            }
            Console.WriteLine($"No more cake left! You need {Math.Abs(wholeCake)} pieces more.");
        }
    }
}
