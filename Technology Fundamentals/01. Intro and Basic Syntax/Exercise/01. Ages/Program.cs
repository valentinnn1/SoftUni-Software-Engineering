using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            if (age == 0 || age > 0 && age < 3)
            {
                Console.WriteLine("baby");
            }
            if (age > 2 && age <= 13)
            {
                Console.WriteLine("child");
            }
            if (age >= 14 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            if (age >= 20 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            if (age >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
