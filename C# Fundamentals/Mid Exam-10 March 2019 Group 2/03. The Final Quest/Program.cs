using System;
using System.Collections.Generic;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCommand = new List<string>();
            string input = Console.ReadLine();
            var inputTokens = input.Split(" ");

            foreach (var item in inputTokens)
            {
                newCommand.Add(item);
            }

            while (true)
            {
                string newInputs = Console.ReadLine();

                if (newInputs == "Stop")
                {
                    break;
                }

                var commandsList = newInputs.Split(" ");

                string command = commandsList[0];

                if (command == "Delete")
                {
                    int index = int.Parse(commandsList[1]);
                    index += 1;

                    if (index >= 0 && index < newCommand.Count) //до counta, защото не можем да изтрием несъщестуващ елемент;индексите са от 0 до count-1
                    {
                        newCommand.RemoveAt(index);
                    }
                }
                else if (command == "Replace")
                {
                    string secondWord = commandsList[2];
                    string firstWord = commandsList[1];

                    if (newCommand.Contains(secondWord))
                    {
                        int index = newCommand.IndexOf(secondWord);
                        newCommand.RemoveAt(index);
                        newCommand.Insert(index, firstWord);           
                    }
                }
                else if (command == "Swap")
                {
                    string firstWord = commandsList[1];
                    string secondWord = commandsList[2];

                    if (newCommand.Contains(firstWord) && newCommand.Contains(secondWord))
                    {
                        int firstIndex = newCommand.IndexOf(firstWord);
                        int secondIndex = newCommand.IndexOf(secondWord);
                        newCommand.RemoveAt(firstIndex);
                        newCommand.Insert(firstIndex, secondWord);
                        newCommand.RemoveAt(secondIndex);
                        newCommand.Insert(secondIndex, firstWord);
                    }
                }
                else if (command == "Put")
                {
                    int index = int.Parse(commandsList[2]);
                    string wordToPut = commandsList[1];
                    index -= 1;

                    if (index >= 0 && index <= newCommand.Count) //въртим до counta вкл., защото може да добавим на този индекс нов елемент(Add)
                    {                                            //Пр. 1 2 3 -> count 3, index 2, можем да добавим на index 3 -> 1 2 3 4 (counta вече е 4)
                        newCommand.Insert(index, wordToPut);
                    }
                }
                else if (command == "Sort")
                {
                    newCommand.Sort(); //първо сортираме
                    newCommand.Reverse(); // после обръщаме сортирания вече списък :)
                }
            }
            Console.WriteLine(string.Join(" ", newCommand));
        }
    }
}