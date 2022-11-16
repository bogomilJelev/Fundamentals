using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> prod = new Dictionary<string, List<string>>();
            string[] comand = Console.ReadLine().Split(" -> ").ToArray();
            while (comand[0] != "End")
            {
                string namecomp = comand[0];
                string id = comand[1];
                if (prod.ContainsKey(namecomp))
                {
                    if (!prod[namecomp].Contains(id))
                    {
                        prod[namecomp].Add(id);
                    }
                }
                else
                {
                    prod.Add(namecomp, new List<string>() { id });
                }
                comand = Console.ReadLine().Split(" -> ").ToArray();
            }
            foreach (var item in prod.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-- {item2}");
                }
            }
        }
    }
}
