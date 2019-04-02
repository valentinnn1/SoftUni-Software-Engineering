using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double results = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double scholarshipSocial = minSalary * 35 / 100;
            double scholarshipExcellent = results * 25;
            if (results >= 5.5)
            {
                if (scholarshipExcellent >= scholarshipSocial || income > minSalary)
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(scholarshipExcellent));
                else Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarshipSocial));
            }
            else if (income < minSalary && results > 4.5)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarshipSocial));
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");     
            }      
        }
    }
}