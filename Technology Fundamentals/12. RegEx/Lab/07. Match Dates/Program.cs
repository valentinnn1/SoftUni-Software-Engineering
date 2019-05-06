using System;
using System.Text.RegularExpressions;

namespace _07._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\d{2})([-.\/])([A-Z][a-z]{2})(\2)(\d{4})";
            Regex regex = new Regex(pattern);
            MatchCollection matchDates = regex.Matches(input);

            foreach (Match match in matchDates)
            {
                Console.WriteLine($"Day: {match.Groups[1].Value}, Month: {match.Groups[3].Value}, Year: {match.Groups[5].Value}");
            }
        }
    }
}
