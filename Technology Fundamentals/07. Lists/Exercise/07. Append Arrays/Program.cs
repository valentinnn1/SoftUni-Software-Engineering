using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine()
                .Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < inputData.Count; i++)
            {
                string currentItem = inputData[i];
                List<string> numbersStack = currentItem
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                inputData[i] = string.Join(" ", numbersStack);
            }

            for (int i = 0, j = inputData.Count - 1; i < j; i++, j--)
            {
                var temp = inputData[i];
                inputData[i] = inputData[j];
                inputData[j] = temp;

            }
            foreach (var item in inputData)
            {
                if (item != "")
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
