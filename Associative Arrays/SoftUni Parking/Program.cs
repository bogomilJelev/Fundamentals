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
            int ask = int.Parse(Console.ReadLine());
            Dictionary<string, string> dics = new Dictionary<string, string>();
            for (int i = 0; i < ask; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string com1 = input[0];
                if (com1 == "register")
                {
                    string name = input[1];
                    string carplate = input[2];
                    if (dics.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carplate}");
                    }
                    else
                    {
                        dics.Add(name, carplate);
                        Console.WriteLine($"{name} registered {carplate} successfully");
                    }
                }
                else if (com1 == "unregister")
                {
                    string name = input[1];
                    if (dics.ContainsKey(name))
                    {
                        dics.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var item in dics)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
