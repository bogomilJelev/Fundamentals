using System;
using System.IO;

namespace da_da
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastname = Console.ReadLine();
            string comand = Console.ReadLine();
            Console.WriteLine($"{name}{comand}{lastname}");
        }
    }
}
