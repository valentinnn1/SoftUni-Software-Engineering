using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("&").ToList();
            List<string> final = new List<string>();

            Regex digits16 = new Regex(@"(?<valid16>([A-Za-z0-9]{16}))");
            Regex digits25 = new Regex(@"(?<valid25>([A-Za-z0-9]{25}))");

            string result = string.Empty;

            for (int i = 0; i < input.Count; i++)
            {
                string word = input[i].ToUpper();

                if (digits25.IsMatch(word))
                {

                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] == '0' || word[j] == '1' || word[j] == '2' || word[j] == '3' || word[j] == '4'
                            || word[j] == '5' || word[j] == '6' || word[j] == '7' || word[j] == '8' || word[j] == '9')
                        {
                            string letter = word[j].ToString();
                            letter = (9 - int.Parse(letter)).ToString();
                            result += letter;
                        }

                        else
                        {
                            result += word[j];
                        }

                        if (j == 4 || j == 9 || j == 14 || j == 19)
                        {
                            result += '-';
                        }
                    }

                    final.Add(result);
                    result = string.Empty;
                }

                else if (digits16.IsMatch(input[i]))
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] == '0' || word[j] == '1' || word[j] == '2' || word[j] == '3' || word[j] == '4'
                            || word[j] == '5' || word[j] == '6' || word[j] == '7' || word[j] == '8' || word[j] == '9')
                        {
                            string letter = word[j].ToString();
                            letter = (9 - int.Parse(letter)).ToString();
                            result += letter;
                        }

                        else
                        {
                            result += word[j];
                        }

                        if (j == 3 || j == 7 || j == 11)
                        {
                            result += '-';
                        }

                    }

                    final.Add(result);
                    result = string.Empty;
                }
            }

            Console.WriteLine(String.Join(", ", final));
        }
    }
}
