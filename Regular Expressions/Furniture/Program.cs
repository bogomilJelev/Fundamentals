using System;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string patter = @">>([A-za-z]+)<<(\d+.?\d+)!(\d+)";
            string input = Console.ReadLine();
            Regex regex = new Regex(patter);
            Console.WriteLine("Bought furniture:");
            double sum = 0;
            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    double number = double.Parse(match.Groups[2].Value);
                    int quan = int.Parse(match.Groups[3].Value);

                    Console.WriteLine(name);
                    sum += number * quan;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
