using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string patter = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";
            Regex regex = new Regex(patter);

            string input = Console.ReadLine();
            double total = 0;

            while (input != "end of shift")
            {
                Match name = regex.Match(input);
                if (name.Success)
                {
                    string costomer = name.Groups[1].Value;
                    string product = name.Groups[2].Value;
                    int count = int.Parse(name.Groups[3].Value);
                    double price = double.Parse(name.Groups[4].Value);
                    double sum = count * price;

                    total += sum;
                    Console.WriteLine($"{costomer}: {product} - {sum:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");



        }
    }
}