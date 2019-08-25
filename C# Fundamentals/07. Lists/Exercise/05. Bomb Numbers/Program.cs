using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];
            int bombIndex = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    bombIndex = i;
                    int startIndex = Math.Max(0, bombIndex - power); //началния индекс на взрива
                    int count = Math.Min(numbers.Count - startIndex, power * 2 + 1); //броя на взривени елементи

                    numbers.RemoveRange(startIndex, count); //взривяваме (трием елементите)
                    i = Math.Max(0, i - (power + 1)); //преизчисляваме новия индекс i след взрива
                }
            }
            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
