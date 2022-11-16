using System;
using System.Collections.Generic;
using System.Linq;

namespace assaray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> test = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if (item != ' ')
                {
                    if (!test.ContainsKey(item))
                    {
                        test.Add(item, 0);
                    }
                    test[item]++;
                }
            }
            foreach (var item1 in test)
            {
                Console.WriteLine($"{item1.Key} -> {item1.Value}");
            }
        }
    }
}
