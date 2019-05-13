using System;
using System.Text.RegularExpressions;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<name>[A-Za-z0-9!@#$?]+)=(?<length>[0-9]+)<<(?<geohashcode>[\d\S\\W]+)$";
            Regex regex = new Regex(pattern);

            int length = 0;
            int geohashcodeLength = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Last note")
                {
                    break;
                }

                if (regex.IsMatch(input))
                {
                    length = int.Parse(regex.Match(input).Groups["length"].Value);
                    string geohashcode = regex.Match(input).Groups["geohashcode"].Value;
                    string name = regex.Match(input).Groups["name"].Value;
                    geohashcodeLength = geohashcode.Length;

                    if (length == geohashcodeLength)
                    {
                        string currentName = string.Empty;
                        string newName = string.Empty;
                        for (int i = 0; i < name.Length; i++)
                        {
                            var charArr = name[i];
                            
                            if (char.IsLetterOrDigit(charArr))
                            {
                                newName += charArr; 
                            }
                        }

                        Console.WriteLine($"Coordinates found! {newName} -> {geohashcode}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
