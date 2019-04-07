﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int schoolClass = 1;
            double yearlyGradesSum = 0;
            int notPassed = 0;

            while (schoolClass <= 12 && notPassed < 2)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    yearlyGradesSum += grade;
                    schoolClass++;
                }
                else
                {
                    notPassed += 1;
                }
            }

            if (notPassed < 2)
            {
                double average = yearlyGradesSum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {schoolClass} grade");
            }
        }
    }
}
