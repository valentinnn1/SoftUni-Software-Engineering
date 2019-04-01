using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double hall = (L * 100) * (W * 100);
            double wardrobe = (A * 100) * (A * 100);
            double bench = hall / 10;
            double space = hall - wardrobe - bench;
            double dancers = space / (40 + 7000);

            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
