using System;
using System.Collections.Generic;
using System.Linq;

namespace assaray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> save = new Dictionary<string, int>();
            foreach (var item in input)
            {
                string inteInLowerCase = item.ToLower();
                if (save.ContainsKey(inteInLowerCase))
                {
                    save[inteInLowerCase]++;
                }
                else
                {
                    save.Add(inteInLowerCase, 1);
                }

            }
            foreach (var count in save)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }

            }
        }
    }
}
