using System;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>\d{2})([-.\/])(?<mouth>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            var text = Console.ReadLine();

            var regmach = Regex.Matches(text, pattern);

            foreach (Match item in regmach)
            {
                var day = item.Groups["day"].Value;
                var mouth = item.Groups["mouth"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {mouth}, Year: {year}");
            }
        }
    }
}
