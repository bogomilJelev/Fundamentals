using System;
using System.Collections.Generic;
using System.Linq;

namespace assaray
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> spisuk = new Dictionary<string, int>();
            while (input != "stop")
            {
                int kolichestvo = int.Parse(Console.ReadLine());
                if (spisuk.ContainsKey(input))
                {
                    spisuk[input] += (kolichestvo);
                }
                else
                {
                    spisuk.Add(input, kolichestvo);
                }

                input = Console.ReadLine();
            }
            foreach (var item in spisuk)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
