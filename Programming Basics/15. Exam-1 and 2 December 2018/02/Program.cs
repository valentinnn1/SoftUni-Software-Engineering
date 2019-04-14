using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodForOneDayForFirstDog = double.Parse(Console.ReadLine());
            double foodForOneDayForSecondDog = double.Parse(Console.ReadLine());
            double foodForOneDayForThirdDog = double.Parse(Console.ReadLine());

            double foodForFirstDog = days * foodForOneDayForFirstDog;
            double foodForSecondDog = days * foodForOneDayForSecondDog;
            double foodForThirdDog = days * foodForOneDayForThirdDog;
            double totalFood = foodForFirstDog + foodForSecondDog + foodForThirdDog;

            if (totalFood <= foodLeft)
            {
                Console.WriteLine($"{Math.Floor(foodLeft - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
