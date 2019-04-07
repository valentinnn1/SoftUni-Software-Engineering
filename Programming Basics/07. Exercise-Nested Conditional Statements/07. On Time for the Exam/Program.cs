using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int examTimeInMin = hourExam * 60 + minutesExam;
            int studentsTimeInMin = hourArrival * 60 + minutesArrival;
            int minutesDifference = studentsTimeInMin - examTimeInMin;

            if (minutesDifference < -30)
            {
                Console.WriteLine("Early");
            }
            else if (minutesDifference <= 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }

            int hours = Math.Abs(minutesDifference / 60);
            int minutes = Math.Abs(minutesDifference % 60);

            if (hours > 0)
            {
                if (minutes < 10)
                {
                    Console.WriteLine(hours + ":0" + minutes + "hours");
                }
                else
                {
                    Console.WriteLine(hours + ":" + minutes + "hours");
                }
            }
            else
            {
                Console.WriteLine(minutes + "minutes");
            }

            if (minutesDifference < 0)
            {
                Console.WriteLine(" before the start");
            }
            else
            {
                Console.WriteLine(" after the start");
            }
        }
    }
}
