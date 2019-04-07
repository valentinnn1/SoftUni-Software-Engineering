using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int homeWeekends = int.Parse(Console.ReadLine());

            double weekendsInSofia = (48 - homeWeekends) * 3.0 / 4;
            double gamesInSofiaInHolidays = holidays * 2.0 / 3;
            double fullWeekendPlusHolidays = weekendsInSofia + homeWeekends + gamesInSofiaInHolidays;

            if (typeOfYear == "normal")
            {
                double result = Math.Truncate(fullWeekendPlusHolidays);
                Console.WriteLine(result);
            }
            else if (typeOfYear == "leap")
            {
                double leap_Result = fullWeekendPlusHolidays * 0.15;
                leap_Result = leap_Result + fullWeekendPlusHolidays;
                double result = Math.Truncate(leap_Result);
                Console.WriteLine(result);
            }
        }
    }
}
