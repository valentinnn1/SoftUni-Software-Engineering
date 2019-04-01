using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double pp = tables * (length + 2 * 0.30) * (width + 2 * 0.30);
            double pk = tables * (length / 2) * (length / 2);
            double USD = pp * 7 + pk * 9;
            double BGN = USD * 1.85;
            Console.WriteLine($"{USD:f2} USD");
            Console.WriteLine($"{BGN:f2} BGN");
        }
    }
}
