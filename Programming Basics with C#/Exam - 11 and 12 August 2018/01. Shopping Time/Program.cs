using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shopping_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForRelax = int.Parse(Console.ReadLine());
            double moneyForOneItem = double.Parse(Console.ReadLine());
            double moneyForOneProgram = double.Parse(Console.ReadLine());
            double moneyForFrape = double.Parse(Console.ReadLine());

            int totalTimeForRelax = timeForRelax - 15;
            double totalItemsPrice = 3 * moneyForOneItem;
            double totalProgramsPrice = 2 * moneyForOneProgram;
            double totalPrice = totalItemsPrice + totalProgramsPrice + moneyForFrape;
            Console.WriteLine($"{totalPrice:F2}");
            Console.WriteLine(totalTimeForRelax);
        }
    }
}
