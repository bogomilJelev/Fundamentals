using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            string text = Console.ReadLine();
            var names = regex.Matches(text);
            var ask = names.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", ask));

        }
    }
}
