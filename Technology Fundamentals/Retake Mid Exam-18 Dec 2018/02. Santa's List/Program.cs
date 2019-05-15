using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = Console.ReadLine().Split('&').ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Finished!")
                {
                    break;
                }

                var commandParts = command.Split(' ').ToArray();

                if (commandParts[0] == "Bad")
                {
                    var kidName = commandParts[1];

                    if (!kids.Contains(kidName))
                    {
                        kids.Insert(0, kidName);
                    }

                }

                if (commandParts[0] == "Rename")
                {
                    var kidName = commandParts[1];
                    var newKidName = commandParts[2];

                    if (kids.Contains(kidName))
                    {
                        var indexOfKidName = kids.IndexOf(kidName);
                        kids[indexOfKidName] = newKidName;
                    }
                }

                if (commandParts[0] == "Good")
                {
                    var kidName = commandParts[1];

                    if (kids.Contains(kidName))
                    {
                        kids.Remove(kidName);
                    }
                }

                if (commandParts[0] == "Rearrange")
                {
                    var kidName = commandParts[1];
                    if (kids.Contains(kidName))
                    {
                        kids.Remove(kidName);
                        kids.Add(kidName);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", kids));
        }
    }
}
