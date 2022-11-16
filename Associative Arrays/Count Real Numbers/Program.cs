using System;
using System.Collections.Generic;
using System.Linq;

namespace assaray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> dic = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (dic.ContainsKey(number))
                {
                    dic[number]++;
                }
                else
                {
                    dic.Add(number, 1);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
