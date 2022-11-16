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
            Dictionary<string, List<double>> stud = new Dictionary<string, List<double>>();
            int ask = int.Parse(Console.ReadLine());
            for (int i = 0; i < ask; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (stud.ContainsKey(name))
                {
                    stud[name].Add(grade);
                }
                else
                {
                    stud.Add(name, new List<double>() { grade });
                }

            }
            foreach (var item in stud.OrderByDescending(x => x.Value.Average()))
            {
                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }
    }
}
