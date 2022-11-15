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
            string[] people = Console.ReadLine().Split(", ");

            Dictionary<string, int> dicofpeople = new Dictionary<string, int>();

            foreach (var name in people)
            {
                dicofpeople.Add(name, 0);
            }

            string pattername = @"[\W\d]";
            string patternum = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, pattername, "");
                string number = Regex.Replace(input, patternum, "");

                int sum = 0;

                foreach (var item in number)
                {
                    int curdig = int.Parse(item.ToString());
                    sum += curdig;
                }
                if (dicofpeople.ContainsKey(name))
                {
                    dicofpeople[name] += sum;
                }

                input = Console.ReadLine();

            }

            int ask = 1;
            foreach (var kvp in dicofpeople.OrderByDescending(x => x.Value))
            {
                string text = ask == 1 ? "st" : ask == 2 ? "nd" : "rd";
                Console.WriteLine($"{ask++}{text} place: {kvp.Key}");
                if (ask == 4)
                {
                    break;

                }

            }


        }
    }
}
