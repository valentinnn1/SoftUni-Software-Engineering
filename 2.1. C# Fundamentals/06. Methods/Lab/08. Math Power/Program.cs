using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int stepen = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, stepen);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, int stepen)
        {
            ;
            double finalNum = Math.Pow(number, stepen);
            return finalNum;
        }
    }
}
