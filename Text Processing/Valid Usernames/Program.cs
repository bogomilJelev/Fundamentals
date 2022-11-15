using System;
using System.Collections.Generic;
using System.Linq;

namespace assaray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < text.Length; i++)
            {
                var cur = text[i];

                if (IsValid(cur))
                {
                    Console.WriteLine(cur);
                }
            }


        }
        public static bool IsValid(string cur)
        {
            return cur.Length >= 3
                && cur.Length <= 16
                && cur.All(c => char.IsLetterOrDigit(c))
                || cur.Contains("_") || cur.Contains("-");

        }
    }
}
