using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ordered_by_Age_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Information> newList = new List<Information>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                List<string> input = command.Split().ToList();

                string firstName = input[0];
                string ID = input[1];
                int age = int.Parse(input[2]);

                var Information = new Information(firstName, ID, age);
                newList.Add(Information);
            }
            newList = newList.OrderBy(x => x.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, newList));
        }
    }

    class Information
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Information(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
