using System;
using System.Collections.Generic;
using System.Linq;

namespace assaray
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var word = new Dictionary<string, List<string>>();
            for (int i = 0; i < number; i++)
            {
                string word1 = Console.ReadLine();
                string word2 = Console.ReadLine();
                if (word.ContainsKey(word1) == false)
                {
                    word.Add(word1, new List<string>() { word2 });
                }
                else
                {
                    word[word1].Add(word2);
                }

            }
            foreach (var item in word)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
