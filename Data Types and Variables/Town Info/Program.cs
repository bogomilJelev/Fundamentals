using System;
using System.IO;

namespace da_da
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pop = Console.ReadLine();
            string squer = Console.ReadLine();
            Console.WriteLine($"Town {name} has population of {pop} and area {squer} square km.");
        }
    }
}
