using System;
using System.Collections.Generic;
using System.Linq;

namespace assaray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> corsesnames = new Dictionary<string, List<string>>();
            string comand = Console.ReadLine();
            while (comand != "end")
            {
                string[] comand2 = comand.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string coursename = comand2[0];
                string name = comand2[1];
                if (!corsesnames.ContainsKey(coursename))
                {
                    corsesnames.Add(coursename, new List<string>());
                }
                corsesnames[coursename].Add(name);


                comand = Console.ReadLine();
            }
            foreach (var item in corsesnames.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var item1 in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item1}");
                }
            }
        }
    }
}
