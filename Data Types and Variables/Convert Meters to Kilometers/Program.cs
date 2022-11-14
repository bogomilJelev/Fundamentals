using System;
using System.IO;

namespace da_da
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            float zzzz = number / 1000F;
            Console.WriteLine($"{zzzz:f2}");
        }
    }
}
