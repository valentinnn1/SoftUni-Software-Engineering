using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split().ToArray();
            bool changedList = false;

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "Add": numbers.Add(int.Parse(commands[1])); changedList = true; break;
                    case "Remove": numbers.Remove(int.Parse(commands[1])); changedList = true; break;
                    case "RemoveAt": numbers.RemoveAt(int.Parse(commands[1])); changedList = true; break;
                    case "Insert": numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1])); changedList = true; break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(commands[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> evenNumbers = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evenNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", evenNumbers));
                        break;
                    case "PrintOdd":
                        List<int> oddNumbers = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                oddNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", oddNumbers));
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = commands[1];
                        int numberToCheck = int.Parse(commands[2]);

                        switch (condition)
                        {
                            case "<":
                                var x = numbers.Where(num => num < numberToCheck);
                                Console.WriteLine(string.Join(" ", x)); break;
                            case ">":
                                var y = numbers.Where(num => num > numberToCheck);
                                Console.WriteLine(string.Join(" ", y)); break;
                            case ">=":
                                var BiggerOrEqualNmbers = numbers.Where(num => num >= numberToCheck);
                                Console.WriteLine(string.Join(" ", BiggerOrEqualNmbers)); break;
                            case "<=":
                                var SmallerOrEqualNmbers = numbers.Where(num => num <= numberToCheck);
                                Console.WriteLine(string.Join(" ", SmallerOrEqualNmbers)); break;
                        }
                        break;
                }
                commands = Console.ReadLine().Split().ToArray();
            }
            if (changedList)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
