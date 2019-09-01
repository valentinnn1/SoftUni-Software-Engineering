using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Students> Students = new List<Students>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                string firstName = input.Split()[0];
                string secondName = input.Split()[1];
                string grade = input.Split()[2];

                Students student = new Students(firstName, secondName, grade);

                Students.Add(student);
            }

            List<Students> sortedStudents = new List<Students>();
            sortedStudents = Students.OrderByDescending(art => art.Grade).ToList();

            foreach (var list in sortedStudents)
            {
                Console.WriteLine(list);
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Grade { get; set; }

        public Students(string f, string s, string g)
        {
            this.FirstName = f;
            this.SecondName = s;
            this.Grade = g;
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade}";
        }
    }
}
